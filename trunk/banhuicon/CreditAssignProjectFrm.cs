using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Banhuitong.Console.Projs;

namespace Banhuitong.Console {
    using MyLib.UI;
    //项目管理-二级市场
    public partial class CreditAssignProjectFrm : Form, IHasGridDataTable {
        private static readonly TextValues DATE_TYPES;
        public static readonly TextValues TRANS_STATUS;
        public static readonly TextValues KEY_VALUE;

        static CreditAssignProjectFrm() {
            DATE_TYPES = new TextValues()
                .AddNew("发布时间", 1)
                .AddNew("截止时间", 2);
            TRANS_STATUS = new TextValues()
                .AddNew("正在转让", 0)
                .AddNew("转让成功", 1)
                .AddNew("转让失败", 2);
            KEY_VALUE = new TextValues()
                .AddNew("转让编号", 1)
                .AddNew("转让项目名称", 2)
                .AddNew("转让人", 3)
                .AddNew("ID", 4);
        }

        public CreditAssignProjectFrm() {
            InitializeComponent();
        }

        private void CreditAssignProjectFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, cbDateType);
            toolStrip1.AddControlAfter(endDate, toolStripLabel1);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

            cbDateType.ComboBox.BindTo(DATE_TYPES, ExtraItems.NoExtra);
            cbProjType.ComboBox.BindTo(Projects.PrjProperty, ExtraItems.AddAll);
            cbTransType.ComboBox.BindTo(TRANS_STATUS, ExtraItems.NoExtra);
            cbKeyValue.ComboBox.BindTo(KEY_VALUE, ExtraItems.NoExtra);
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var prjType = cbProjType.ComboBox.GetSelectedValue();

            var p = new Dictionary<string, object>();
            p["start-time"] = startDate.Value.TruncToStart();
            p["end-time"] = endDate.Value.TruncToEnd();
            p["date-type"] = cbDateType.ComboBox.GetSelectedValue();
            p["status"] = cbTransType.ComboBox.GetSelectedValue();
            if (prjType != Commons.AllValue) {
                p["prj-type"] = prjType;
            }
            p["key-type"] = cbKeyValue.ComboBox.GetSelectedValue();
            p["key"] = tbKey.Text.Trim();


            var r = await CreditAssignProjs.GetAllPrjs(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "gapAmt") {
                e.Value = Convert.ToDecimal(e.GetValue("creditAmount")) - Convert.ToDecimal(e.GetValue("assignAmt"));
            } else if (e.Key == "prjType") {
                e.Value = Projects.PrjProperty.FindByValue(Convert.ToInt32(e.Value));
            } else if (e.Key == "status") {
                e.Value = TRANS_STATUS.FindByValue(Convert.ToInt32(e.Value));
            } else if (e.Key == "oldRate") {
                e.Value = Convert.ToInt32(e.GetValue("status")) == 2 ? "" : e.Value;
            } else if (e.Key == "itemName") {
                e.Value = Convert.ToString(e.Value) + (Convert.ToBoolean(e.GetValue("topTime")) ? "(已置顶)" : "");
            }
        }

        private async void DelPrj() {
            btnDelete.Enabled = false;
            if (Commons.ShowConfirmBox(this, string.Format("提前撤销“{0}”,此操作不可恢复,是否继续"
                , myGridViewBinding1.GetSelectedValues<string>("itemName").FirstOrDefault()))) {
                var p = await CreditAssignProjs.CancelProj(myGridViewBinding1.GetSelectedValues<long>("pId").FirstOrDefault());
                if (p.IsOk) {
                    UpdateTable1();
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            }
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DelPrj();
        }

        private async void ToTop() {
            btnTop.Enabled = false;
            var topTime = Convert.ToBoolean(myGridViewBinding1.GetSelectedValues<long>("topTime").FirstOrDefault());
            Rpc.IResult p;
            if (topTime) {
                p = await Projects.PrjRevokeTop(myGridViewBinding1.GetSelectedValues<long>("pId").FirstOrDefault());
            } else {
                p = await Projects.PrjToTop(myGridViewBinding1.GetSelectedValues<long>("pId").FirstOrDefault());
            }
            if (p.IsOk)
                UpdateTable1();
            else
                Commons.ShowResultErrorBox(this, p);
            btnTop.Enabled = true;
        }

        private void btnTop_Click(object sender, EventArgs e) {
            ToTop();
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 1) {
                var r = e.SelectedRowIndex[0];
                var status = Convert.ToInt32(e.GetValue(r, "status"));
                var topTime = Convert.ToBoolean(e.GetValue(r, "topTime"));

                btnTop.Enabled = true;
                if (topTime)
                    btnTop.Text = "取消置顶";
                else
                    btnTop.Text = "置顶";
                btnDelete.Enabled = status == 0;
                btnCheckTransfer.Enabled = status == 1;
            } else {
                btnDelete.Enabled = false;
                btnTop.Enabled = false;
                btnCheckTransfer.Enabled = false;
            }
        }

        private void btnCheckTransfer_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(myGridViewBinding1.GetSelectedValues<long>("tiId").FirstOrDefault(), 48, AcceptFilter.Pdf);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnQuickDate1Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today, 1 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDate3Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today,3 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDate5Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today,5 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDateThisYear_Click(object sender, EventArgs e) {
            startDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            endDate.Value = new DateTime(DateTime.Now.Year + 1, 1, 1);
        }

        private void btnQuickDateNextYear_Click(object sender, EventArgs e) {
            startDate.Value = new DateTime(DateTime.Now.Year + 1, 1, 1);
            endDate.Value = new DateTime(DateTime.Now.Year + 2, 1, 1);
        }

    }
}
