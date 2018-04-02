using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using MyLib.UI;
    using Crm;
    using Excel;
    public partial class CrmRegUserFrm : Form, IHasGridDataTable {
        private string m_selUName;

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        public CrmRegUserFrm() {
            InitializeComponent();
        }

        private void RegUserFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel6);
            toolStrip1.AddControlAfter(endDate, toolStripLabel3);
            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

            cbbDepartment.ComboBox.Items.AddRange(new object[] { "全部", "无" });
            cbbDepartment.ComboBox.Items.AddRange(CrmCommons.Department);
            cbbDepartment.SelectedIndex = 0;
            cbbJxStatus.ComboBox.BindTo(CrmCommons.JxUserStatus, ExtraItems.AddAll);

            m_selUName = "";
            tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.NONE_TEXT);
        }

        private async void UpdateTable() {
            btnSearch.Enabled = false;
            var department = cbbDepartment.ComboBox.Text;

            if (department == "全部") {
                department = "*";
            } else if (department == "无") {
                department = "";
            }

            if (m_selUName == CrmCommons.ALL_VALUE && department == "*") {
                if (string.IsNullOrWhiteSpace(tbKey.Text)) {
                    Commons.ShowInfoBox(this, "请输入关键字！");
                    btnSearch.Enabled = true;
                    return;
                }
            }

            var status = cbbJxStatus.ComboBox.GetSelectedValue();

            var d = new Dictionary<string, object>();
            d["u-name"] = m_selUName;
            d["department"] = department;
            d["start-date1"] = startDate.Value.TruncToStart();
            d["end-date1"] = endDate.Value.TruncToEnd();
            d["search-key"] = tbKey.Text.Trim();
            if (status != Commons.AllValue)
                d["jx-status"] = status;

            var p = await CrmInvestor.RegUsers(d);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "jxStatus") {
                e.Value = CrmCommons.JxUserStatus.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "userType") {
                e.Value = CrmCommons.CustomerTypes.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void btnAccInfo_Click(object sender, EventArgs e) {
            if (myGridViewBinding1.GetSelectedValues<long>("userType").FirstOrDefault() == 1) {
                var dlg = new AccPersonDlg(myGridViewBinding1.GetSelectedValues<long>("auId").FirstOrDefault());
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ShowDialog();
            } else {
                var dlg = new AccOrgDlg(myGridViewBinding1.GetSelectedValues<long>("auId").FirstOrDefault());
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ShowDialog();
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            btnAccInfo.Enabled = e.SelectedRowIndex.Length == 1;
            btnAssign.Enabled = e.SelectedRowIndex.Length == 1;
        }

        private void btnCreateAssign_Click(object sender, EventArgs e) {
            var dlg = new CrmAssignRegUserDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                Commons.ShowInfoBox(this, "分配成功!");
                UpdateTable();
            }
        }

        private void btnBatchBind_Click(object sender, EventArgs e) {
            var dlg = new ImportWizardDlg(new List<Tuple<string, CellType, bool>>() { 
                ImportWizardDlg.MakeColumn("姓名",CellType.Text,true),
                ImportWizardDlg.MakeColumn("手机",CellType.Text,true),
                ImportWizardDlg.MakeColumn("客户经理",CellType.Text,true)});
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (index, gridView) => {
                var d = new Dictionary<string, object>();
                d["real-name"] = gridView.Rows[index].Cells[0].Value.TrimStr();
                d["mobile"] = gridView.Rows[index].Cells[1].Value.TrimStr();
                d["u-name"] = gridView.Rows[index].Cells[2].Value.TrimStr();

                return CrmInvestor.CreateAssignOfRegUser(d).Result;
            };

            if (dlg.ShowDialog(this) == DialogResult.Cancel) {
                UpdateTable();
            }
        }

        private void btnSelMgr_Click(object sender, EventArgs e) {
            var dlg = new CrmSelMgrDlg((int)CrmCommons.ExtraItem.AddNone |
                (int)CrmCommons.ExtraItem.AddAll | (int)CrmCommons.ExtraItem.AddSelf);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.SelManager = m_selUName;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_selUName = dlg.SelManager;
                if (CrmCommons.IsAll(m_selUName)) {
                    tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.ALL_TEXT);
                } else if (CrmCommons.IsNone(m_selUName)) {
                    tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.NONE_TEXT);
                } else if (CrmCommons.IsSelf(m_selUName)) {
                    tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.SELF_TEXT);
                } else {
                    tbOpUser.Text = dlg.SelManager;
                }
            }
        }

        private void btnReassignCustomers_Click(object sender, EventArgs e) {
            if (myGridViewBinding1.View.RowCount == 0) {
                Commons.ShowInfoBox(this, "无待分配客户");
                return;
            }
            var ids = new List<long>();
            for (int i = 0; i < myGridViewBinding1.View.RowCount; ++i) {
                ids.Add(Convert.ToInt64(myGridViewBinding1.DataTable[i, "auId"]));
            }
            var dlg = new CrmBindMgrAndCrmInvestor2Dlg(ids, true, m_selUName);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                UpdateTable();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e) {
            var dlg = new CrmBindMgrAndCrmInvestorDlg(myGridViewBinding1.GetSelectedValues<long>("auId").FirstOrDefault(),
                myGridViewBinding1.GetSelectedValues<string>("realName").FirstOrDefault(), true);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                UpdateTable();
            }
        }


    }
}
