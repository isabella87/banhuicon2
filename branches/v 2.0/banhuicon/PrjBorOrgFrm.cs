using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banhuitong.Console.BaseData;
using System.Linq;

namespace Banhuitong.Console {
    using MyLib.UI;
    //基础数据-借款机构
    public partial class PrjBorOrgFrm : Form, IHasGridDataTable {

        public PrjBorOrgFrm() {
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

            var r = await PrjBorOrgs.GetOrgs(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void Edit(long boId) {
            var dlg = new PrjBorOrgDlg(boId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "bpmoId");
            }
        }

        private async void Delete(IList<long> idArray) {
            btnDelete.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下借款机构：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await PrjBorOrgs.Delete(id);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "bpmoId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                Commons.ShowInfoBox(this, "借款机构：" + ss + " 已被删除。");
            }
            btnDelete.Enabled = true;
        }

        private void PrjBorOrg_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);
            startDate.Value = startDate.Value.AddYears(-2);
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Edit(0);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var boId = myGridViewBinding1.GetSelectedValues<long>("bpmoId").FirstOrDefault();
            if (boId != 0) {
                Edit(boId);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<long>("bpmoId").ToList();
            if (idArray.Count > 0) {
                Delete(idArray);
            }
        }

        private void btnCerts_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(myGridViewBinding1.GetSelectedValues<long>("bpmoId").FirstOrDefault(), 23, AcceptFilter.Image);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnCerts.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnCerts.Enabled = true;
            } else {
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
                btnCerts.Enabled = false;
            }
        }
    }
}
