using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Banhuitong.Console.Crm;

namespace Banhuitong.Console {
    using MyLib.UI;
    //客户关系管理-我的客户
    public partial class CrmMyInvestorsFrm : Form, IHasGridDataTable {
        public static readonly TextValues MY_CUSTOMER_PR_LEVELS;
        private static readonly TextValues REG_STATUS;
        private string m_selUName;

        static CrmMyInvestorsFrm() {
            MY_CUSTOMER_PR_LEVELS = new TextValues()
                .AddNew("未指定", 1)
                .AddNew("A", 2)
                .AddNew("B", 4)
                .AddNew("C", 8)
                .AddNew("A和B", 6)
                .AddNew("A和C", 10)
                .AddNew("B和C", 12)
                .AddNew("A和B和C", 14)
                .AddNew("D", 16)
                .AddNew("E", 32);
            REG_STATUS = new TextValues()
            .AddNew("未注册", 0)
            .AddNew("已注册", 1);
        }
        public CrmMyInvestorsFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void FrmCrmMyInvestors_Load(object sender, EventArgs e) {
            toolStrip2.AddControlAfter(startDate, toolStripLabel8);
            toolStrip2.AddControlAfter(endDate, toolStripLabel9);
            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

            cbbPrLevels.ComboBox.BindTo(MY_CUSTOMER_PR_LEVELS, ExtraItems.AddAll);
            cbbAge.ComboBox.BindTo(CrmCommons.Ages, ExtraItems.AddAll);
            cbbGenders.ComboBox.BindTo(Commons.Genders, ExtraItems.AddAll);
            cbbCustomerSource.ComboBox.Items.AddRange(CrmCommons.SrTypes);
            cbbAccStatus.ComboBox.BindTo(REG_STATUS, ExtraItems.AddAll);

            m_selUName = "+";
            tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.SELF_TEXT);
        }

        private async void UpdateTable1() {
            if (m_selUName == CrmCommons.ALL_VALUE && string.IsNullOrWhiteSpace(tbKey.Text)) {
                Commons.ShowInfoBox(this, "请输入关键字");
                return;
            }
            btnSearch.Enabled = false;
            var prLevel = cbbPrLevels.ComboBox.GetSelectedValue();
            var age = cbbAge.ComboBox.GetSelectedValue();
            var gender = cbbGenders.ComboBox.GetSelectedValue();
            var status = cbbAccStatus.ComboBox.GetSelectedValue();

            var p = new Dictionary<string, object>();
            p["u-name"] = m_selUName;
            p["assign-time1"] = startDate.Value.TruncToStart();
            p["assign-time2"] = endDate.Value.TruncToEnd();
            p["search-key"] = tbKey.Text.Trim();
            p["origin-type"] = cbbCustomerSource.Text.Trim();
            if (prLevel != Commons.AllValue) {
                p["pr-level"] = prLevel;
            }
            if (age != Commons.AllValue) {
                p["age"] = age;
            }
            if (gender != Commons.AllValue) {
                p["gender"] = gender;
            }
            if (status != Commons.AllValue) {
                p["status"] = status;
            }

            var r = await CrmInvestor.MyInvestors(p);
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
            if (e.Key == "gender") {
                e.Value = Commons.Genders.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "prLevel") {
                e.Value = CrmCommons.PrLevels.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "regStatus") {
                e.Value = REG_STATUS.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "latestAction") {
                e.Value = CrmCommons.CustomerFollowStatus.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "age") {
                e.Value = Convert.ToString(e.Value) == "0" ? "" : Convert.ToString(e.Value);
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 1) {
                btnFollow.Enabled = true;
            } else {
                btnFollow.Enabled = false;
            }
        }

        private void btnWorkDetails_Click(object sender, EventArgs e) {
            if (CrmCommons.IsAll(m_selUName) || CrmCommons.IsNone(m_selUName)) {
                Commons.ShowInfoBox(this, "请选择一个客户经理");
                return;
            }
            var dlg = new CrmTodoDlg(m_selUName);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnFollow_Click(object sender, EventArgs e) {
            var dlg = new CrmInvestorRemarksDlg(myGridViewBinding1.GetSelectedValues<long>("ciId").FirstOrDefault(), false);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnSelectMgr_Click(object sender, EventArgs e) {
            var dlg = new CrmSelMgrDlg((int)CrmCommons.ExtraItem.AddAll | (int)CrmCommons.ExtraItem.AddSelf);
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
    }
}
