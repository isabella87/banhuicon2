using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Banhuitong.Console {
    using BaseData;
    using MyLib.UI;

    //基础数据-借款人
    public partial class PrjBorPersonsFrm : Form, IHasGridDataTable {

        private static readonly TextValues DATE_TYPES;
        private static readonly TextValues KEY_TYPES;

        static PrjBorPersonsFrm() {
            DATE_TYPES = new TextValues()
                .AddNew("创建时间", 1)
                .AddNew("修改时间", 2);
            KEY_TYPES = new TextValues()
                .AddNew("姓名", 1)
                .AddNew("手机", 2)
                .AddNew("工作单位", 3)
                .AddNew("创建人", 4)
                .AddNew("修改人", 5);
        }

        public PrjBorPersonsFrm() {
            InitializeComponent();
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
            var dateType = cbDateType.ComboBox.GetSelectedValue();
            var keyType = cbKeyType.ComboBox.GetSelectedValue();

            var p = new Dictionary<string, object>();

            switch (dateType) {
                case "1":
                    p["start-create-time"] = startDate.Value.TruncToStart();
                    p["end-create-time"] = endDate.Value.TruncToEnd();
                    break;
                case "2":
                    p["start-update-time"] = startDate.Value.TruncToStart();
                    p["end-update-time"] = endDate.Value.TruncToEnd();
                    break;
            }

            switch (keyType) {
                case "1":
                    p["real-name"] = tbKey.Text.Trim();
                    break;
                case "2":
                    p["mobile"] = tbKey.Text.Trim();
                    break;
                case "3":
                    p["company"] = tbKey.Text.Trim();
                    break;
                case "4":
                    p["creator"] = tbKey.Text.Trim();
                    break;
                case "5":
                    p["updater"] = tbKey.Text.Trim();
                    break;
            }


            var r = await PrjBorPersons.GetAll(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void Edit(long bpmpId) {
            var dlg = new PrjBorPersonDlg(bpmpId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "bpmpId");
            }
        }

        private async void Delete(IList<long> idArray) {
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下借款人：" + ss + " 此操作不可恢复！确认吗？")) {
                string suc = "";
                foreach (var id in idArray) {
                    var p = await PrjBorPersons.Delete(id);
                    if (p.IsOk) {
                        suc += id + ",";
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "bpmpId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                if (suc != "") {
                    Commons.ShowInfoBox(this, "借款人：" + suc.TrimEnd(',') + " 已被删除。");
                }

            }
            btnDelete.Enabled = true;
        }

        private void PrjBorPersonFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, cbDateType);
            toolStrip1.AddControlAfter(endDate, toolStripLabel1);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

            cbDateType.ComboBox.BindTo(DATE_TYPES);
            cbKeyType.ComboBox.BindTo(KEY_TYPES);
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Edit(0);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var bpmId = myGridViewBinding1.GetSelectedValues<long>("bpmpId").FirstOrDefault();
            if (bpmId != 0) {
                Edit(bpmId);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            btnDelete.Enabled = false;
            var idArray = myGridViewBinding1.GetSelectedValues<long>("bpmpId").ToList();
            if (idArray.Count > 0) {
                Delete(idArray);
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnCerts.Enabled = false;
                btnCreditFiles.Enabled = false;
                btnIncomeFiles.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnCerts.Enabled = true;
                btnCreditFiles.Enabled = true;
                btnIncomeFiles.Enabled = true;
            } else {
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
                btnCerts.Enabled = false;
                btnCreditFiles.Enabled = false;
                btnIncomeFiles.Enabled = false;
            }
        }

        private void btnCerts_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(myGridViewBinding1.GetSelectedValues<long>("bpmpId").FirstOrDefault(), 28, AcceptFilter.Image);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnQuickDate1Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today, 1 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDate3Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today, 3 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDate5Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today, 5 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDateThisYear_Click(object sender, EventArgs e) {
            startDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            endDate.Value = new DateTime(DateTime.Now.Year + 1, 1, 1);
        }

        private void btnCreditFiles_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(myGridViewBinding1.GetSelectedValues<long>("bpmpId").FirstOrDefault(), 58, AcceptFilter.Pdf);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnIncomeFiles_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(myGridViewBinding1.GetSelectedValues<long>("bpmpId").FirstOrDefault(), 60, AcceptFilter.Pdf);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }
    }
}
