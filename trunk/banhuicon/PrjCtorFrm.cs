using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banhuitong.Console.BaseData;
using System.Linq;

namespace Banhuitong.Console {
    using MyLib.UI;
    //基础数据-施工单位
    public partial class PrjCtorFrm : Form, IHasGridDataTable {

        public PrjCtorFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var p = new Dictionary<string, object>();
            p["start-time"] = startDate.Value.TruncToStart();
            p["end-time"] = endDate.Value.TruncToEnd();
            p["key"] = tbKey.Text.Trim();

            var r = await PrjCtors.GetAll(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private void PrjCtorFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "regYears") {
                if (e.GetValue("regYears") == null || Convert.ToString(e.GetValue("regYears")) == "0")
                    e.Value = "";
                else
                    e.Value = e.Value + "年";
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnCerts.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnCerts.Enabled = true;
            } else {
                btnDelete.Enabled = true;
                btnEdit.Enabled = false;
                btnCerts.Enabled = false;
            }
        }

        private void Edit(long bcoId) {
            var dlg = new PrjCtorDlg(bcoId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "bcoId");
            }
        }

        private async void Delete(IList<long> idArray) {
            btnDelete.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下施工单位：" + ss + " 此操作不可恢复！确认吗？")) {
                string suc = "";
                foreach (var id in idArray) {
                    var p = await PrjCtors.Delete(id);
                    if (p.IsOk) {
                        suc += id + ",";
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "bcoId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                if (suc != "") {
                    Commons.ShowInfoBox(this, "施工单位：" + suc.TrimEnd(',') + " 已被删除。");
                }
            }
            btnDelete.Enabled = true;
        }

        private void btnCerts_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(myGridViewBinding1.GetSelectedValues<long>("bcoId").FirstOrDefault(), 29, AcceptFilter.Image);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Edit(0);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var pId = myGridViewBinding1.GetSelectedValues<long>("bcoId").FirstOrDefault();
            if (pId != 0) {
                Edit(pId);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<long>("bcoId").ToList();
            if (idArray.Count > 0) {
                Delete(idArray);
            }
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
    }
}
