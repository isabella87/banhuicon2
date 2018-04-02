using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Banhuitong.Console {
    using Account;
    public partial class AccPersonDlg : Form {
        private long m_auId;
        private int m_status;
        private static readonly TextValues INVESTOR_LEVEL;

        static AccPersonDlg() {
            INVESTOR_LEVEL = new TextValues()
            .AddNew("保守型", 1)
            .AddNew("稳健型", 2)
            .AddNew("平衡型", 3)
            .AddNew("成长型", 4)
            .AddNew("积极型", 5);
        }

        public AccPersonDlg(long auid) {
            InitializeComponent();
            m_auId = auid;
        }

        private void AccPersonDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            UpdateTable();
        }

        private async void UpdateTable() {
            var p = await InvestPersons.Account(m_auId);
            if (p.IsOk) {
                var r = p.AsDictionary;
                tbLoginName.Text = r.GetOrDefault<string>("loginName");
                tbRealName.Text = r.GetOrDefault<string>("realName");
                tbMobile.Text = r.GetOrDefault<string>("mobile");
                tbEmail.Text = r.GetOrDefault<string>("email");
                tbRegTime.Text = Commons.TimestampToDateTimeString(r.GetOrDefault<long>("regTime"));
                tbRMobile.Text = r.GetOrDefault<string>("recommendMobile");
                tbCompany.Text = r.GetOrDefault<string>("company");
                tbCompanyType.Text = r.GetOrDefault<string>("companyType");
                tbPosition.Text = r.GetOrDefault<string>("position");
                tbAddress.Text = r.GetOrDefault<string>("address");
                tbPostalCode.Text = r.GetOrDefault<string>("postalCode");
                tbIdCard.Text = r.GetOrDefault<string>("idCard");
                tbHomePhone.Text = r.GetOrDefault<string>("homePhone");
                tbQQ.Text = r.GetOrDefault<string>("qqNumber");
                tbOrgCode.Text = r.GetOrDefault<string>("orgCode");
                tbInvestorLevel.Text = INVESTOR_LEVEL.FindByValue(r.GetOrDefault<int>("lvl"));

                var m_jxStatus = r.GetOrDefault<bool>("jxStatus");
                if (m_jxStatus) {
                    UpdateAllowInvest(r.GetOrDefault<bool>("allowInvest"));
                    UpdateAllowBorrow(r.GetOrDefault<bool>("allowBorrow"));
                    btnBankInfo.Enabled = true;
                    btnFreezeMoney.Enabled = true;
                    btnInvestDetailsDepository.Enabled = true;
                    btnInvestDetailsPlatform.Enabled = true;
                    btnBorrowDetails.Enabled = true;
                    btnAllowInvest.Enabled = true;
                    btnAllowBorrow.Enabled = true;
                } else {
                    btnFreezeMoney.Enabled = false;
                    btnInvestDetailsDepository.Enabled = false;
                    btnInvestDetailsPlatform.Enabled = false;
                    btnBorrowDetails.Enabled = false;
                    btnAllowInvest.Enabled = false;
                    btnAllowBorrow.Enabled = false;
                }

                m_status = r.GetOrDefault<int>("status");
                var locked = r.GetOrDefault<int>("locked");
                UpdateBtnLock(locked == 98 || locked == 99);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }

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

        private void btnBankInfo_Click(object sender, EventArgs e) {
            var dlg = new BankInfoPersonDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();
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

        private void btnRecharge_Click(object sender, EventArgs e) {
            var dlg = new AccRechargesDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
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

        private async void CheckBank() {
            var idCard = tbIdCard.Text.Trim();
            idCard = Commons.ShowInputDialog(this, "请输入身份证号:", "检查银行开户", 300, new Regex("^\\d{18}$|^\\d{17}(X|x)$|^\\d{15}$"), false, idCard).Trim();
            if (idCard == "")
                return;
            btnCheckBank.Enabled = false;
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["id-card"] = idCard;
            var p = await InvestPersons.CheckBank(d);
            if (p.IsOk) {
                if (p.AsBoolean) {
                    UpdateTable();
                    Commons.ShowInfoBox(this, "已开户");
                } else
                    Commons.ShowInfoBox(this, "未开户");
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnCheckBank.Enabled = true;
        }

        private void btnCheckBank_Click(object sender, EventArgs e) {
            CheckBank();
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
