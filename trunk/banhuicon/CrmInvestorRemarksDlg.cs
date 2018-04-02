using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Crm;
    public partial class CrmInvestorRemarksDlg : Form {
        private long m_ciId;
        private bool m_readOnly;
        private long m_auId;

        public CrmInvestorRemarksDlg(long ciId, bool readOnly) {
            InitializeComponent();
            m_ciId = ciId;
            m_readOnly = readOnly;
            m_auId = 0;
        }

        private void CrmInvestorRemarksDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_ciId);
            cbbFollowRecord.BindTo(CrmCommons.CustomerFollowStatus, ExtraItems.AddNone);

            GetAuID();
            GetAccount();
            UpdateTable();
        }

        private async void GetAuID() {
            var p = await CrmInvestor.GetAuIdOfAccount(m_ciId);
            if (p.IsOk)
                m_auId = p.AsLong;
            else
                Commons.ShowResultErrorBox(this, p);
        }

        private async void GetAccount() {
            var p = await CrmInvestor.Account(m_ciId);
            if (p.IsOk) {
                var d = p.AsDictionary;
                tbName.Text = d.GetOrDefault<string>("realName");
                btnAdd.Enabled = !m_readOnly;
                cbbFollowRecord.Enabled = !m_readOnly;
                if (m_auId > 0) {
                    btnAccount.Enabled = true;
                    btnInvestsDepository.Enabled = true;
                    btnInvestsPlatform.Enabled = true;
                    btnRunnings.Enabled = true;
                }

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private async void UpdateTable() {
            var p = await CrmInvestor.Remarks(m_ciId);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "action")
                e.Value = CrmCommons.CustomerFollowStatus.FindByValue(Convert.ToString(e.Value));
        }

        private void btnAccount_Click(object sender, EventArgs e) {
            var dlg = new AccPersonDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnInvestsDepository_Click(object sender, EventArgs e) {
            var dlg = new AccInvestDepositoryDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnInvestsPlatform_Click(object sender, EventArgs e) {
            var dlg = new AccInvestPlatFormDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnRunnings_Click(object sender, EventArgs e) {
            var dlg = new AccRunningsDlg(m_auId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private async void SaveData() {
            var remark = tbRemark.Text.Trim().LeftStr(2000);
            var action = cbbFollowRecord.GetSelectedValue();
            if (action == "") {
                if (remark == "") {
                    Commons.ShowInfoBox(this, "备注不能为空");
                    return;
                }
            }

            var d = new Dictionary<string, object>();
            d["remark"] = remark;
            d["action"] = action == "" ? "-1" : action;

            var p = await CrmInvestor.SaveRemark(m_ciId, d);
            if (p.IsOk) {
                if (p.AsInt > 0) {
                    UpdateTable();
                    tbRemark.Clear();
                }
            } else {
                Commons.ShowResultErrorBox(this, p);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            SaveData();
        }
    }
}
