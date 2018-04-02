using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Crm;
    public partial class CrmBindMgrAndCrmInvestorDlg : Form {
        private long m_id;
        private string m_name;
        private bool m_type;

        public CrmBindMgrAndCrmInvestorDlg(long id, string name, bool type) {
            InitializeComponent();
            m_id = id;
            m_name = name;
            m_type = type;
        }

        private void CrmBindMgrAndCrmInvestorDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_id);
            labName.Text = m_name;

            UpdateTable();
        }

        private async void UpdateTable() {
            treeView1.Nodes.Clear();
            var r = new Dictionary<string, object>();
            r["if-self"] = false;
            var p = await CrmInvestor.GetAllRelations(r);
            if (p.IsOk) {
                var dl = JArray.Parse(p.AsString).ToList();
                var treeList = new List<Tuple<string, string>>();
                foreach (var d in dl) {
                    treeList.Add(Tuple.Create(d["uName"].ToStdString(), d["pName"].ToStdString()));
                }
                CrmCommons.GetTreeView(treeView1, treeList, "", (int)CrmCommons.ExtraItem.AddSelf);

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private async void AssignManager() {
            if (treeView1.SelectedNode == null || string.IsNullOrWhiteSpace(treeView1.SelectedNode.Text)) {
                Commons.ShowInfoBox(this, "请选择一位新的客户经理");
                return;
            }
            btnAssignManager.Enabled = false;
            var newMgr = treeView1.SelectedNode.Text;

            if (newMgr == CrmCommons.SELF_TEXT)
                newMgr = CrmCommons.SELF_VALUE;

            var d = new Dictionary<string, object>();
            Rpc.IResult p;
            if (m_type) {
                d["au-id"] = m_id;
                d["u-name"] = newMgr;
                p = await CrmInvestor.BindMgrWithRegUser(d);
            } else {
                d["ci-id"] = m_id;
                d["u-name"] = newMgr;
                p = await CrmInvestor.BindMgr(d);
            }

            if (p.IsOk) {
                if (p.AsInt == 0) {
                    Commons.ShowInfoBox(this, "绑定客户经理失败！");
                } else {
                    DialogResult = DialogResult.OK;
                }
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnAssignManager.Enabled = true;
        }

        private void btnAssignManager_Click(object sender, EventArgs e) {
            AssignManager();
        }

        private void btnAssignHistory_Click(object sender, EventArgs e) {
            var dlg = new CrmBindMgrAndCrmInvestorHistoryDlg(m_id, m_type);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

    }
}
