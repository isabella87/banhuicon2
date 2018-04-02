using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Banhuitong.Console {
    using Account;
    public partial class AccOrgDlg : Form {
        private long m_auId;
        private int m_status;
        private static readonly TextValues INVESTOR_LEVEL;

        static AccOrgDlg() {
            INVESTOR_LEVEL = new TextValues()
            .AddNew("保守型", 1)
            .AddNew("稳健型", 2)
            .AddNew("平衡型", 3)
            .AddNew("成长型", 4)
            .AddNew("积极型", 5);
        }
        public AccOrgDlg(long auId) {
            InitializeComponent();
            m_auId = auId;
        }

        private void AccOrgDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);

            UpdateTable();
        }

        private async void UpdateTable() {
            var p = await InvestOrgs.Account(m_auId);
            if (p.IsOk) {
                var d = p.AsDictionary;
                tbLoginName.Text = d.GetOrDefault<string>("loginName");
                tbRealName.Text = d.GetOrDefault<string>("realName");
                tbQQ.Text = d.GetOrDefault<string>("qqNumber");
                tbMobile.Text = d.GetOrDefault<string>("mobile");
                tbEmail.Text = d.GetOrDefault<string>("email");
                tbCompany.Text = d.GetOrDefault<string>("company");
                tbCompanyType.Text = d.GetOrDefault<string>("companyType");
                tbPostalCode.Text = d.GetOrDefault<string>("postalCode");
                tbCreateTime.Text = Commons.TimestampToDateString(d.GetOrDefault<long>("createTime"));
                tbUpdateTime.Text = Commons.TimestampToDateString(d.GetOrDefault<long>("updateTime"));
                tbIdCard.Text = d.GetOrDefault<string>("idCard");
                tbOrgName.Text = d.GetOrDefault<string>("orgName");
                tbPosition.Text = d.GetOrDefault<string>("position");
                tbAddress.Text = d.GetOrDefault<string>("address");
                tbBussLic.Text = d.GetOrDefault<string>("bussLic");
                tbOrgCodeNo.Text = d.GetOrDefault<string>("orgCodeNo");
                tbLawName.Text = d.GetOrDefault<string>("lawName");
                tbLawIdCard.Text = d.GetOrDefault<string>("lawIdCard");
                tbAccUserName.Text = d.GetOrDefault<string>("accUserName");
                tbAccount.Text = d.GetOrDefault<string>("account");
                tbAccBank.Text = d.GetOrDefault<string>("accBank");
                tbHomeNo.Text = d.GetOrDefault<string>("homePhone");
                tbInvestorLevel.Text = INVESTOR_LEVEL.FindByValue(d.GetOrDefault<int>("lvl"));

                m_status = d.GetOrDefault<int>("status");
                UpdateAllowInvest(d.GetOrDefault<bool>("allowInvest"));
                UpdateAllowBorrow(d.GetOrDefault<bool>("allowBorrow"));
                var locked = d.GetOrDefault<int>("locked");
                UpdateBtnLock(locked == 98 || locked == 99);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            SetReadOnly(m_status == 2 && !MainFrm.IsAdmin);
        }

        private void UpdateAllowInvest(bool b) {
            btnAllowInvest.Text = b ? "禁止投资" : "允许投资";
            btnAllowInvest.Tag = b;
            btnInvestDetailsDepository.Enabled = b;
            btnInvestDetailsPlatform.Enabled = b;
        }

        private void UpdateAllowBorrow(bool b) {
            btnAllowBorrow.Text = b ? "禁止借款" : "允许借款";
            btnAllowBorrow.Tag = b;
            btnBorrowDetails.Enabled = b;
        }

        private void SetReadOnly(bool b) {
            tbRealName.ReadOnly = b;
            tbQQ.ReadOnly = b;
            tbEmail.ReadOnly = b;
            tbOrgName.ReadOnly = b;
            tbPosition.ReadOnly = b;
            tbIdCard.ReadOnly = b;
            tbCompany.ReadOnly = b;
            tbCompanyType.ReadOnly = b;
            tbAddress.ReadOnly = b;
            tbPostalCode.ReadOnly = b;
            tbBussLic.ReadOnly = b;
            tbOrgCodeNo.ReadOnly = b;
            tbLawName.ReadOnly = b;
            tbLawIdCard.ReadOnly = b;
            tbAccUserName.ReadOnly = b;
            tbAccount.ReadOnly = b;
            tbAccBank.ReadOnly = b;
            tbHomeNo.ReadOnly = b;

            btnCancel.Visible = b;
            //btnAccConfirm.Visible = !b;
            btnCommitInfo.Visible = !b;

        }

        private async void CommitInfo() {
            btnCommitInfo.Enabled = false;
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["org-name"] = tbOrgName.Text.Trim();
            d["buss-lic"] = tbBussLic.Text.Trim();
            d["org-code-no"] = tbOrgCodeNo.Text.Trim();
            d["law-name"] = tbLawName.Text.Trim();
            d["law-id-card"] = tbLawIdCard.Text.Trim();
            d["acc-user-name"] = tbAccUserName.Text.Trim();
            d["account"] = tbAccount.Text.Trim();
            d["account-bank"] = tbAccBank.Text.Trim();
            d["real-name"] = tbRealName.Text.Trim();
            d["position"] = tbPosition.Text.Trim();
            d["id-card"] = tbIdCard.Text.Trim();
            d["company"] = tbCompany.Text.Trim();
            d["company-type"] = tbCompanyType.Text.Trim();
            d["address"] = tbAddress.Text.Trim();
            d["postal-code"] = tbPostalCode.Text.Trim();
            d["home-phone"] = tbHomeNo.Text.Trim();
            d["qq-number"] = tbQQ.Text.Trim();
            d["email"] = tbEmail.Text.Trim();

            var p = await InvestOrgs.UpdateInfo(d);
            if (p.IsOk) {
                if (p.AsBoolean) {
                    UpdateTable();
                    Commons.ShowInfoBox(this, "资料提交成功");
                } else {
                    Commons.ShowInfoBox(this, "资料提交失败");
                }
            } else {
                Commons.ShowResultErrorBox(this, p);
            }

            btnCommitInfo.Enabled = true;
        }

        private void btnCommitInfo_Click(object sender, EventArgs e) {
            CommitInfo();
        }

        private void btnWithdraws_Click(object sender, EventArgs e) {
            var dlg = new AccWithDrawsDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnTenders_Click(object sender, EventArgs e) {
            var dlg = new AccTendersDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnCreditIns_Click(object sender, EventArgs e) {
            var dlg = new AccCreditInsDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnInvestReport_Click(object sender, EventArgs e) {
            var dlg = new AccMonthReportsDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnFreezeMoney_Click(object sender, EventArgs e) {
            var dlg = new AccFreezeMoneyDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();
        }

        private void btnInvestDetailsDepository_Click(object sender, EventArgs e) {
            var dlg = new AccInvestDepositoryDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnInvestDetailsPlatform_Click(object sender, EventArgs e) {
            var dlg = new AccInvestPlatFormDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnBorrowDetails_Click(object sender, EventArgs e) {
            var dlg = new AccBorrowsDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private async void AllowInvest() {
            btnAllowInvest.Enabled = false;
            var allow = !(bool)btnAllowInvest.Tag;
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["invest-status"] = allow ? 1 : 0;
            var p = await InvestBase.AllowInvest(d);
            if (p.IsOk) {
                UpdateAllowInvest(allow);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnAllowInvest.Enabled = true;
        }

        private void btnAllowInvest_Click(object sender, EventArgs e) {
            AllowInvest();
        }

        private async void AllowBorrow() {
            btnAllowBorrow.Enabled = false;
            var allow = !(bool)btnAllowBorrow.Tag;
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["borrow-status"] = allow ? 1 : 0;
            var p = await InvestBase.AllowBorrow(d);
            if (p.IsOk) {
                UpdateAllowBorrow(allow);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnAllowBorrow.Enabled = true;
        }

        private void btnAllowBorrow_Click(object sender, EventArgs e) {
            AllowBorrow();
        }

        private async void AccConfirm() {
            btnAccConfirm.Enabled = false;
            var cardId = Commons.ShowInputDialog(this, "请输入电子帐户号:", "确认开户", 300, new Regex("^\\d*$")).Trim();
            if (cardId == "") {
                btnAccConfirm.Enabled = true;
                return;
            }
            if (!Commons.ShowConfirmBox(this, "确认开户吗？", "开户")) {
                btnAccConfirm.Enabled = true;
                return;
            }
            var r = new Dictionary<string, object>();
            r["au-id"] = m_auId;
            r["user-id"] = cardId;
            var p = await InvestOrgs.UpdateRegistry(r);
            if (p.IsOk) {
                UpdateTable();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnAccConfirm.Enabled = true;
        }

        private void btnAccConfirm_Click(object sender, EventArgs e) {
            AccConfirm();
        }

        private async void ChangeLevel() {
            var level = Commons.ShowComboboxInputDialog(this, INVESTOR_LEVEL, "请选择账户级别:",
                string.Format("修改级别-{0}", m_auId), INVESTOR_LEVEL.FindByText(tbInvestorLevel.Text), 300);
            if (level == "-1")
                return;

            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["lev"] = level;

            var p = await InvestPersons.UpdateLevel(d);
            if (p.IsOk) {
                UpdateTable();
                Commons.ShowInfoBox(this, "修改成功");
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnChangeLevel_Click(object sender, EventArgs e) {
            ChangeLevel();
        }

        private void btnBankInfo_Click(object sender, EventArgs e) {
            var dlg = new BankInfoOrgDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();
        }

        private void btnTradeDetails_Click(object sender, EventArgs e) {
            var dlg = new AccRunningsDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnHistoryTradeDetails_Click(object sender, EventArgs e) {
            var dlg = new AccHistoryRunningsDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnHistoryInvestDetails_Click(object sender, EventArgs e) {
            var dlg = new AccHistoryInvestDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnBankRunning_Click(object sender, EventArgs e) {
            var dlg = new AccBankRunning(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private async void UnLock() {
            btnUnLock.Enabled = false;
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["enable"] = !(bool)btnUnLock.Tag;
            var p = await InvestBase.Unlock(d);
            if (p.IsOk) {
                UpdateTable();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnUnLock.Enabled = true;
        }

        private void btnUnLock_Click(object sender, EventArgs e) {
            UnLock();
        }

        private void btnCheckTransfer_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(m_auId, 47, AcceptFilter.Pdf);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void UpdateBtnLock(bool b) {
            btnUnLock.Text = b ? "解锁帐户" : "锁定帐户";
            btnUnLock.Tag = b;
        }
    }
}
