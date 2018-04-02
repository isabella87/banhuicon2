using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banhuitong.Console.BaseData;
using System.Linq;

namespace Banhuitong.Console {
    using MyLib.UI;
    //基础数据-工程项目
    public partial class PrjEngineerFrm : Form, IHasGridDataTable {
        public PrjEngineerFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void PrjEngineerFrm_Load(object sender, EventArgs e) {
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

            var r = await PrjEngineers.GetEngineers(p);
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
            if (e.Key == "prjTime") {
                e.Value = Convert.ToDateTime(e.GetValue("prjStartTime")).ToString("yyyy.MM.dd") +
                    " - " + Convert.ToDateTime(e.GetValue("prjEndTime")).ToString("yyyy.MM.dd");
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnPrjCerts.Enabled = false;
                btnMangCerts.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnPrjCerts.Enabled = true;
                btnMangCerts.Enabled = true;
            } else {
                btnDelete.Enabled = true;
                btnEdit.Enabled = false;
                btnPrjCerts.Enabled = false;
                btnMangCerts.Enabled = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Edit(0);
        }

        private void Edit(long pId) {
            var dlg = new PrjEngineerDlg(pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "bpeId");
            }
        }

        private async void Delete(IList<long> idArray) {
            btnDelete.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下工程项目：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await PrjEngineers.Delete(id);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "bpeId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                Commons.ShowInfoBox(this, "工程项目：" + ss + " 已被删除。");
            }
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var pId = myGridViewBinding1.GetSelectedValues<long>("bpeId").FirstOrDefault();
            if (pId != 0) {
                Edit(pId);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<long>("bpeId").ToList();
            if (idArray.Count > 0) {
                Delete(idArray);
            }
        }

        private void btnPrjCerts_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(myGridViewBinding1.GetSelectedValues<long>("bpeId").FirstOrDefault(), 24, AcceptFilter.Image);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnMangCerts_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(myGridViewBinding1.GetSelectedValues<long>("bpeId").FirstOrDefault(), 27, AcceptFilter.Image);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }
    }
}
