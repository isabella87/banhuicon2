using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Banhuitong.Console.Crm;
using System.Collections;

namespace Banhuitong.Console {
    using MyLib.UI;
    //绩效考核-销售一部
    public partial class CrmPerformanceStatisticByMonthFrm : Form, IHasGridDataTable {
        /// <summary>
        /// key：客户经理
        /// value:部门
        /// </summary>
        private Hashtable m_Managers;
        /// <summary>
        /// 树的所有节点
        /// </summary>
        private IList<TreeNode> m_AllNodes;
        /// <summary>
        /// 是否按下了shift键
        /// </summary>
        bool shift = false;
        /// <summary>
        /// 是否按下了鼠标左键
        /// </summary>
        bool lButton = false;

        public CrmPerformanceStatisticByMonthFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private async void UpdateTable() {
            btnSearchMonth.Enabled = false;
            var checkedManagers = GetCheckedManagers();
            if (checkedManagers.Count == 0) {
                Commons.ShowInfoBox(this, "至少选择一个客户经理");
                btnSearchMonth.Enabled = true;
                return;
            }
            var p = new Dictionary<string, object>();
            p["datepoint"] = searchDate.Value;
            p["u-names"] = string.Join(",", checkedManagers).Replace("+", Properties.Settings.Default.LastUser);
            var r = await CrmPerformance.GetPerformanceByMonth(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r, Commons.BindFlag.Replace, "", () => {
                    var sumInvestAmt = 0M;
                    var sumTenderAmt = 0M;
                    var sumRepaidCapitalAmt = 0M;
                    var sumFirstInvestCount = 0M;
                    var sumInvesterCount = 0U;
                    var sumInvestCount = 0U;
                    var sumCreditAmt = 0U;
                    var sumBindCount = 0U;
                    var sumIncomeAmt = 0M;

                    for (var i = 0; i < myGridViewBinding1.DataTable.Count; ++i) {
                        sumInvestAmt += Convert.ToDecimal(myGridViewBinding1.DataTable[i, "sumInvestAmt"]);
                        sumTenderAmt += Convert.ToDecimal(myGridViewBinding1.DataTable[i, "sumTenderAmt"]);
                        sumRepaidCapitalAmt += Convert.ToDecimal(myGridViewBinding1.DataTable[i, "sumRepaidCapitalAmt"]);
                        sumFirstInvestCount += Convert.ToDecimal(myGridViewBinding1.DataTable[i, "sumFirstInvestCount"]);
                        sumInvesterCount += Convert.ToUInt32(myGridViewBinding1.DataTable[i, "sumInvesterCount"]);
                        sumInvestCount += Convert.ToUInt32(myGridViewBinding1.DataTable[i, "sumInvestCount"]);
                        sumCreditAmt += Convert.ToUInt32(myGridViewBinding1.DataTable[i, "sumCreditAmt"]);
                        sumBindCount += Convert.ToUInt32(myGridViewBinding1.DataTable[i, "sumBindCount"]);
                        sumIncomeAmt += Convert.ToDecimal(myGridViewBinding1.DataTable[i, "sumIncomeAmt"]);
                    }

                    var sumRow = new List<object>();
                    //客户经理
                    sumRow.Add("<总计>");
                    //客户经理编码
                    sumRow.Add(null);
                    //客户经理上级
                    sumRow.Add(null);
                    //客户经理职务
                    sumRow.Add(null);
                    //投资余额
                    sumRow.Add(sumInvestAmt);
                    //投标总额
                    sumRow.Add(sumTenderAmt);
                    //已还本金总额
                    sumRow.Add(sumRepaidCapitalAmt);
                    //首次投标人数
                    sumRow.Add(sumFirstInvestCount);
                    //投标人数
                    sumRow.Add(sumInvesterCount);
                    //投标次数
                    sumRow.Add(sumInvestCount);
                    //买入债权本金总额
                    sumRow.Add(sumCreditAmt);
                    //绑卡人数
                    sumRow.Add(sumBindCount);
                    //平台收入
                    sumRow.Add(sumIncomeAmt);
                    myGridViewBinding1.DataTable.Add(sumRow);
                    myGridViewBinding1.InvalidateView();
                });
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearchMonth.Enabled = true;
        }

        private IList<string> GetCheckedManagers() {
            var managers = new List<string>();
            foreach (TreeNode node in m_AllNodes) {
                if (node.Checked) {
                    managers.Add(node.Tag.ToString());
                }
            }
            return managers;
        }

        private void CrmPerformanceStatisticByMonthFrm_Load(object sender, EventArgs e) {
            m_Managers = new Hashtable();
            m_AllNodes = new List<TreeNode>();
            toolStrip1.AddControlAfter(searchDate, toolStripLabel1);
            UpdateManagersTree();
        }

        private void btnCustomers_Click(object sender, EventArgs e) {
            var dlg = new CrmCstmOfMgrByMonthDlg(myGridViewBinding1.GetSelectedValues<string>("uName").FirstOrDefault(), searchDate.Value);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            btnCustomers.Enabled = e.SelectedRowIndex.Length == 1;
        }

        private async void UpdateManagersTree() {
            btnUpdate.Enabled = false;
            treeView1.Nodes.Clear();
            cbbDepartments.Items.Clear();
            var r = new Dictionary<string, object>();
            r["if-self"] = false;
            var p = await CrmInvestor.GetAllRelations(r);
            if (p.IsOk) {
                var dl = JArray.Parse(p.AsString).ToList();
                var treeList = new List<Tuple<string, string>>();
                foreach (var d in dl) {
                    var uName = d["uName"].ToStdString();
                    var pName = d["pName"].ToStdString();
                    var department = d["department"].ToStdString();
                    treeList.Add(Tuple.Create(uName, pName));
                    m_Managers[uName] = department == "" ? "无" : department;
                }
                CrmCommons.GetTreeView(treeView1, treeList, "", (int)CrmCommons.ExtraItem.AddSelf);
                GetAllNodes();
                SetCbbDepartments();
                SetDepartment();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnUpdate.Enabled = true;
        }

        private void GetAllNodes(TreeNodeCollection nodes = null) {
            if (nodes == null) {
                m_AllNodes.Clear();
                nodes = treeView1.Nodes;
            }
            foreach (TreeNode node in nodes) {
                m_AllNodes.Add(node);
                if (node.Nodes.Count > 0) {
                    GetAllNodes(node.Nodes);
                }
            }
        }

        private void SetCbbDepartments() {
            if (m_Managers.Values.Count > 0) {
                var allDepartments = new SortedSet<string>();
                foreach (string d in m_Managers.Values) {
                    allDepartments.Add(d);
                }
                cbbDepartments.Items.AddRange(allDepartments.ToArray());
                cbbDepartments.ComboBox.SelectedIndex = 0;
            }
        }

        private void SetDepartment() {
            foreach (TreeNode node in m_AllNodes) {
                if (m_Managers.ContainsKey(node.Tag))
                    node.Text = Convert.ToString(node.Tag) + "(" + m_Managers[node.Tag] + ")";
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e) {
            if (lButton && shift && e.Node.Nodes.Count > 0) {
                lButton = false;
                SelectSameLevel(e.Node.Nodes, e.Node.Checked);
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e) {
            SetCheckedDepartment(cbbDepartments.ComboBox.Text);
        }

        private void SetCheckedDepartment(string department) {
            foreach (TreeNode node in m_AllNodes) {
                if (m_Managers.ContainsKey(node.Tag)) {
                    if (m_Managers[node.Tag].ToString() == department) {
                        node.Checked = true;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateManagersTree();
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ShiftKey) {
                shift = true;
            }
        }

        private void treeView1_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.ShiftKey) {
                shift = false;
            }
        }

        private void SelectSameLevel(TreeNodeCollection nodes, bool b) {
            foreach (TreeNode node in nodes) {
                node.Checked = b;
                if (node.Nodes.Count > 0)
                    SelectSameLevel(node.Nodes, b);
            }
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                lButton = true;
            }
        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                lButton = false;
            }

        }

        private void btnSearchMonth_Click(object sender, EventArgs e) {
            UpdateTable();
        }
    }
}
