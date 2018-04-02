using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Banhuitong.Console.BaseData;


namespace Banhuitong.Console {
    using MyLib.UI;
    //基础数据-担保公司
    public partial class PrjGuaranteeOrgFrm : Form, IHasGridDataTable {

        public PrjGuaranteeOrgFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void PrjGuaranteeFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);
            startDate.Value = startDate.Value.AddYears(-2);
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var p = new Dictionary<string, object>();
            p["start-time"] = startDate.Value.TruncToStart();
            p["end-time"] = endDate.Value.TruncToEnd();
            p["key"] = tbKey.Text.Trim();

            var r = await PrjGuaranteeOrgs.GetGuarantees(p);
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

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "regYearLimit") {
                object year = e.GetValue("regYearLimit");
                if (year == null || Convert.ToString(year) == "0")
                    e.Value = "";
                else
                    e.Value = e.Value + "年";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Edit(0);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var pId = myGridViewBinding1.GetSelectedValues<long>("bgoId").FirstOrDefault();
            if (pId != 0) {
                Edit(pId);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<long>("bgoId").ToList();
            if (idArray.Count > 0) {
                Delete(idArray);
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            } else {
                btnDelete.Enabled = true;
                btnEdit.Enabled = false;
            }
        }

        private void Edit(long bgoId) {
            var dlg = new PrjGuaranteeOrgDlg(bgoId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "bgoId");
            }
        }

        private async void Delete(IList<long> idArray) {
            btnDelete.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下担保公司：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await PrjGuaranteeOrgs.Delete(id);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "bgoId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                Commons.ShowInfoBox(this, "担保公司：" + ss + " 已被删除。");
            }
            btnDelete.Enabled = true;
        }

        private void btnCerts_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(myGridViewBinding1.GetSelectedValues<long>("bgoId").FirstOrDefault(), 25, AcceptFilter.Image);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }
    }
}
