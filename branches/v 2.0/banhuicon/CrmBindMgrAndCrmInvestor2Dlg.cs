using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Crm;
    public partial class CrmBindMgrAndCrmInvestor2Dlg : Form {
        private IList<long> m_ids;
        private bool m_type;
        private string m_choseManager;

        public CrmBindMgrAndCrmInvestor2Dlg(IList<long> ids, bool type, string choseManager) {
            InitializeComponent();
            m_ids = ids;
            m_type = type;
            m_choseManager = choseManager;
        }

        private void btnAssignManager_Click(object sender, EventArgs e) {
            if (treeView1.SelectedNode == null || string.IsNullOrWhiteSpace(treeView1.SelectedNode.Text)) {
                Commons.ShowInfoBox(this, "请选择一位新的客户经理");
                return;
            }

            var newMgr = treeView1.SelectedNode.Text;

            var dlg = new BatchProcessDlg(m_ids);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (id) => {
                if (m_type) {
                    var d = new Dictionary<string, object>();
                    d["au-id"] = id;
                    d["u-name"] = newMgr;
                    return CrmInvestor.BindMgrWithRegUser(d).Result;
                } else {
                    var d = new Dictionary<string, object>();
                    d["ci-id"] = id;
                    d["u-name"] = newMgr;
                    return CrmInvestor.BindMgr(d).Result;
                }
            };
            dlg.ShowDialog(this);

            DialogResult = DialogResult.OK;
        }

        private void CrmBindMgrAndCrmInvestor2Dlg_Load(object sender, EventArgs e) {
            UpdateTable();
        }

        private async void UpdateTable() {
            var r = new Dictionary<string, object>();
            r["if-self"] = true;
            var p = await CrmInvestor.GetAllRelations(r);
            if (p.IsOk) {
                var dl = JArray.Parse(p.AsString).ToList();
                var treeList = new List<Tuple<string, string>>();
                foreach (var d in dl) {
                    treeList.Add(Tuple.Create(d["uName"].ToStdString(), d["pName"].ToStdString()));
                }
                CrmCommons.GetTreeView(treeView1, treeList, "", (int)CrmCommons.ExtraItem.NoExtra);

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }
    }
}
