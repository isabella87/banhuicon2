using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace Banhuitong.Console {
    using Crm;
    public partial class CrmSelMgrDlg : Form {

        public string SelManager { set; get; }
        private int m_extraItems;

        public CrmSelMgrDlg(int extraItems) {
            InitializeComponent();
            m_extraItems = extraItems;
        }

        private void CrmSelMgrDlg_Load(object sender, EventArgs e) {
            UpdateTable();
        }

        private async void UpdateTable() {
            var r = new Dictionary<string, object>();
            r["if-self"] = false;
            var p = await CrmInvestor.GetAllRelations(r);
            if (p.IsOk) {
                var dl = JArray.Parse(p.AsString).ToList();
                var treeList = new List<Tuple<string, string>>();
                foreach (var d in dl) {
                    treeList.Add(Tuple.Create(d["uName"].ToStdString(), d["pName"].ToStdString()));
                }
                CrmCommons.GetTreeView(treeView1, treeList, "", m_extraItems);
                var f = treeView1.Nodes.Find(CrmCommons.TextFromValue(SelManager), true);
                if (f.Length != 0)
                    treeView1.SelectedNode = f[0];
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            SelManager = Convert.ToString(treeView1.SelectedNode.Tag);
            DialogResult = DialogResult.OK;
        }

    }
}
