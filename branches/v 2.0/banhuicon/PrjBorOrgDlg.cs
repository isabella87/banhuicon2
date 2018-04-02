using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using BaseData;
    using Rpc;
    public partial class PrjBorOrgDlg : Form {
        private long m_bboId;
        public IResult DlgResult { get; private set; }

        public PrjBorOrgDlg(long bboId) {
            InitializeComponent();

            m_bboId = bboId;
            DlgResult = new JsonResult("{}");

            UpdateData();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }

        private void PrjBorOrgDlg_Load(object sender, EventArgs e) {
            if (m_bboId != 0)
                this.Text = "修改借款机构-" + m_bboId;
        }

        private async void UpdateData() {
            var r = await PrjBorOrgs.GetOrg(m_bboId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                //机构信息
                tbName.Text = d.GetOrDefault<string>("orgName");
                tbShowName.Text = d.GetOrDefault<string>("showOrgName");
                dtpRegisterDate.Value = Commons.FromTimestamp(d.GetOrDefault<long>("registeredDate"));
                tbRegFunds.Text = d.GetOrDefault<string>("registeredFund");
                tbShowRegFunds.Text = d.GetOrDefault<string>("registeredShowFund");
                tbAddress.Text = d.GetOrDefault<string>("address");
                tbShowAddress.Text = d.GetOrDefault<string>("showAddress");
                tbSocialCreditCode.Text = d.GetOrDefault<string>("socialCreditCode");
                tbShowSocialCreditCode.Text = d.GetOrDefault<string>("showSocialCreditCode");
                //法人信息
                tbLawName.Text = d.GetOrDefault<string>("legalPersonName");
                tbShowLawName.Text = d.GetOrDefault<string>("legalPersonShowName");
                tbLawIdCard.Text = d.GetOrDefault<string>("legalIdCard");
                tbLawMobile.Text = d.GetOrDefault<string>("mobile");
                tbLawEmail.Text = d.GetOrDefault<string>("email");
                tbLawFax.Text = d.GetOrDefault<string>("fax");
                tbLawWechat.Text = d.GetOrDefault<string>("wchat");
                //联系人信息
                tbLinkManName.Text = d.GetOrDefault<string>("linkmanName");
                tbShowLinkManName.Text = d.GetOrDefault<string>("linkmanShowName");
                tbLinkManIdCard.Text = d.GetOrDefault<string>("linkmanIdCard");
                tbLinkManMobile.Text = d.GetOrDefault<string>("linkmanMobile");
                tbLinkManEmail.Text = d.GetOrDefault<string>("linkmanEmail");
                tbLinkManWeChat.Text = d.GetOrDefault<string>("linkmanWchat");
                tbLinkManAddress.Text = d.GetOrDefault<string>("linkmanAddress");
                tbShowLinkManAddress.Text = d.GetOrDefault<string>("linkmanShowAddress");
                tbLinkManFax.Text = d.GetOrDefault<string>("linkmanFax");

                //介绍
                tbIntro.Text = d.GetOrDefault<string>("intro");

            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void SaveData() {
            btnOk.Enabled = false;
            try {
                var r = new Dictionary<string, object>();
                r["bbo-id"] = m_bboId;
                //机构信息
                r["org-name"] = tbName.Text.Trim();
                r["show-org-name"] = tbShowName.Text.Trim();
                r["registered-fund"] = tbRegFunds.Text.Trim();
                r["registered-show-fund"] = tbShowRegFunds.Text.Trim();
                r["registered-date"] = dtpRegisterDate.Value;
                r["address"] = tbAddress.Text.Trim();
                r["show-address"] = tbShowAddress.Text.Trim();
                r["social-credit-code"] = tbSocialCreditCode.Text.Trim();
                r["show-social-credit-code"] = tbShowSocialCreditCode.Text.Trim();
                //法人信息
                r["legal-person-name"] = tbLawName.Text.Trim();
                r["legal-person-show-name"] = tbShowLawName.Text.Trim();
                r["legal-id-card"] = tbLawIdCard.Text.Trim();
                r["mobile"] = tbLawMobile.Text.Trim();
                r["email"] = tbLawEmail.Text.Trim();
                r["fax"] = tbLawFax.Text.Trim();
                r["wchat"] = tbLawWechat.Text.Trim();
                //联系人信息
                r["linkman-name"] = tbLinkManName.Text.Trim();
                r["linkman-show-name"] = tbShowLinkManName.Text.Trim();
                r["linkman-id-card"] = tbLinkManIdCard.Text.Trim();
                r["linkman-mobile"] = tbLinkManMobile.Text.Trim();
                r["linkman-email"] = tbLinkManEmail.Text.Trim();
                r["linkman-wchat"] = tbLinkManWeChat.Text.Trim();
                r["linkman-address"] = tbLinkManAddress.Text.Trim();
                r["linkman-show-address"] = tbShowLinkManAddress.Text.Trim();
                r["linkman-fax"] = tbLinkManFax.Text.Trim();
                //介绍
                r["intro"] = tbIntro.Text.Trim();
                IResult p;
                if (m_bboId == 0) {
                    p = await PrjBorOrgs.Create(r);
                } else {
                    p = await PrjBorOrgs.Update(r);
                }
                if (p.IsOk) {
                    DlgResult = p;
                    DialogResult = DialogResult.OK;
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            } finally {
                btnOk.Enabled = true;
            }
        }
    }
}
