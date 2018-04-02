using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Projs;
    using Excel;
    using Rpc;
    public partial class AllowInvestorsDlg : Form {

        private long m_pId;
        public bool ReadOnly { get; set; }
        public AllowInvestorsDlg(long id) {
            InitializeComponent();
            m_pId = id;
            ReadOnly = false;
        }

        private void AllowInvestorsDlg_Load(object sender, EventArgs e) {
            this.Text = this.Text + "-" + m_pId;
            if (ReadOnly) {
                toolStripDropDownButton1.Enabled = false;
                btnDel.Enabled = false;
            }
        }

        private async void Delete(IList<long> idArray) {
            btnDel.Enabled = true;
            var ss = idArray.JoinSome();
            foreach (var id in idArray) {
                var r = await Projects.DelAllowInvest(m_pId, id);
                if (r.IsOk) {
                    myGridViewBinding1.BindTo(r, Commons.BindFlag.Delete, "auId");
                } else {
                    Commons.ShowResultErrorBox(this, r);
                }
            }
            btnDel.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<long>("auId").ToList();
            if (idArray.Count > 0) {
                Delete(idArray);
            }
        }

        private void btnManualImport_Click(object sender, EventArgs e) {
            var dlg = new AllowInvestorsAddDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "auId");
            }
        }

        private void btnBatchImport_Click(object sender, EventArgs e) {
            var dlg = new ImportWizardDlg(new List<Tuple<string, CellType, bool>>() { 
                ImportWizardDlg.MakeColumn("登录名",CellType.Text,true), 
                ImportWizardDlg.MakeColumn("手机号码",CellType.Mobile,true) });
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (index, gridView) => {
                var d = new Dictionary<string, object>();
                d["pid"] = m_pId;
                d["login-name"] = gridView.Rows[index].Cells[0].Value.TrimStr();
                d["mobile"] = gridView.Rows[index].Cells[1].Value.TrimStr();
                var p = Projects.AddAllowInvest(d).Result;
                if (p.IsOk)
                    myGridViewBinding1.BindTo(p, Commons.BindFlag.Update, "auId");
                return p;
            };
            dlg.ShowDialog(this);
        }

        private async void UpdateData() {
            btnSearch.Enabled = false;
            var p = new Dictionary<string, object>();
            p["pid"] = m_pId;
            p["search-key"] = tbKeys.Text.Trim();
            var r = await Projects.GetAllowInvest(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateData();
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnDel.Enabled = false;
            } else {
                btnDel.Enabled = true;
            }
        }
    }
}
