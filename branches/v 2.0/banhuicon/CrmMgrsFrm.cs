using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace Banhuitong.Console {
    using Crm;
    //客户经理管理
    public partial class CrmMgrsFrm : Form {

        IDictionary<string, Tuple<string, string, string, string>> m_viewData;
        public CrmMgrsFrm() {
            InitializeComponent();
        }

        private void CrmMgrsFrm_Load(object sender, EventArgs e) {
            m_viewData = new Dictionary<string, Tuple<string, string, string, string>>();
            UpdateTable1();
        }

        private async void UpdateTable1() {
            treeView1.Nodes.Clear();
            listView1.Items.Clear();
            setButton(false);
            btnUpdateInfo.Enabled = false;
            var r = new Dictionary<string, object>();
            r["if-self"] = false;
            var p = await CrmInvestor.GetAllRelations(r);
            if (p.IsOk) {
                var dl = JArray.Parse(p.AsString).ToList();
                var treeList = new List<Tuple<string, string>>();
                foreach (var d in dl) {
                    treeList.Add(Tuple.Create(d["uName"].ToStdString(), d["pName"].ToStdString()));
                    m_viewData[d["uName"].ToStdString()] = Tuple.Create(d["department"].ToStdString(), d["position"].ToStdString(),
                        d["enabled"].ToBoolean() ? "已启用" : "未启用", d["rCode"].ToStdString());
                }
                CrmCommons.GetTreeView(treeView1, treeList, "", (int)CrmCommons.ExtraItem.NoExtra);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnUpdateInfo.Enabled = true;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private void btnAddManager_Click(object sender, EventArgs e) {
            var dlg = new CrmAddMgrDlg(treeView1.SelectedNode == null ? "" : treeView1.SelectedNode.Text);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                UpdateTable1();
            }
        }

        private void btnAssUpper_Click(object sender, EventArgs e) {
            AssUpper();
        }

        private async void AssUpper() {
            var uname = treeView1.SelectedNode.Text;
            var newUName = Commons.ShowInputDialog(this, string.Format("为客户经理 {0} 指定新的上级:", uname), "指定上级", 300).Trim();
            if (newUName == "")
                return;
            var d = new Dictionary<string, object>();
            d["p-name"] = newUName;
            d["u-name"] = uname;

            var p = await CrmInvestor.MoveManager(d);
            if (p.IsOk) {
                UpdateTable1();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnEditInfo_Click(object sender, EventArgs e) {
            var dlg = new CrmMgrDlg(treeView1.SelectedNode.Text);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                UpdateTable1();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbKey.Text)) {
                Commons.ShowInfoBox(this, "快速定位时必须填写登录名");
                return;
            }

            var f = treeView1.Nodes.Find(tbKey.Text.Trim(), true);
            if (f.Length == 0) {
                Commons.ShowInfoBox(this, "查无此人！");
            } else {
                treeView1.SelectedNode = f[0];
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            listView1.Items.Clear();
            Tuple<string, string, string, string> content;
            if (m_viewData.TryGetValue(e.Node.Text, out content)) {
                setButton(true);
            } else {
                setButton(false);
                return;
            }

            ListViewItem lvi = new ListViewItem();

            lvi.Text = content.Item1;
            lvi.SubItems.Add(content.Item2);
            lvi.SubItems.Add(content.Item3);
            lvi.SubItems.Add(content.Item4);
            listView1.Items.Add(lvi);


        }

        private void btnDeleteManager_Click(object sender, EventArgs e) {
            Del();
        }

        private async void Del() {
            var delMgr = treeView1.SelectedNode.Text;
            if (Commons.ShowConfirmBox(this, string.Format("确认删除{0}吗？此操作无法被撤销。", delMgr))) {
                var p = await CrmInvestor.DeleteManager(delMgr);
                if (p.IsOk) {
                    UpdateTable1();
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            }
        }

        private void setButton(bool b) {
            btnDeleteManager.Enabled = b;
            btnAssUpper.Enabled = b;
            btnEditInfo.Enabled = b;
            btnEditRcode.Enabled = b;
        }

        private async void EditRcode() {
            string newRcode = "";
            if (Commons.ShowConfirmBox(this, "确认修改编号嘛？", "编号")) {
                newRcode = Commons.ShowInputDialog(this, "请输入新编号(只能输入大写字母和数字):", "修改编号", 300, new Regex("^[A-Z\\d]{0,11}$"));
            }
            if (newRcode == "")
                return;

            var d = new Dictionary<string, object>();
            d["u-name"] = treeView1.SelectedNode.Text;
            d["r-code"] = newRcode;

            var p = await CrmInvestor.EditRCode(d);
            if (p.IsOk) {
                if (Convert.ToBoolean(p.AsString)) {
                    UpdateTable1();
                    Commons.ShowInfoBox(this, "修改成功");
                } else {
                    Commons.ShowInfoBox(this, "修改失败");
                }
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnEditRcode_Click(object sender, EventArgs e) {
            EditRcode();
        }

    }
}
