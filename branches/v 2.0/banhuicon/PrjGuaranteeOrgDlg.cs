using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using BaseData;
    using Rpc;
    public partial class PrjGuaranteeOrgDlg : Form {
        private long m_bgoId = 0;
        public IResult DlgResult { get; private set; }

        public PrjGuaranteeOrgDlg(long bgoId) {
            InitializeComponent();
            m_bgoId = bgoId;
            DlgResult = new JsonResult("{}");
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }

        private void PrjGuaranteeDlg_Load(object sender, EventArgs e) {
            if (m_bgoId != 0)
                this.Text = "修改担保公司-" + m_bgoId;

            UpdateData();
        }

        private async void UpdateData() {
            var r = await PrjGuaranteeOrgs.GetGuarantee(m_bgoId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                tbName.Text = d.GetOrDefault<string>("name");
                tbShowName.Text = d.GetOrDefault<string>("showName");
                dtpRegisterDate.Value = Commons.FromTimestamp(d.GetOrDefault<long>("registeredDate"));
                tbRegYear.Text = d.GetOrDefault<string>("regYears");
                tbRegFunds.Text = d.GetOrDefault<string>("regFunds");
                tbRegAddress.Text = d.GetOrDefault<string>("regAddress");
                tbPostCode.Text = d.GetOrDefault<string>("postcode");
                tbLinkMan.Text = d.GetOrDefault<string>("linkman");
                tbMobile.Text = d.GetOrDefault<string>("mobile");
                tbRanking.Text = d.GetOrDefault<string>("ranking");
                tbGetPrize.Text = d.GetOrDefault<string>("getPrize");
                tbOrgWebSite.Text = d.GetOrDefault<string>("orgWebSite");

                tbQualification.Text = d.GetOrDefault<string>("qualification");
                tbShowRegAddress.Text = d.GetOrDefault<string>("showRegAddress");
                tbLegalIdCard.Text = d.GetOrDefault<string>("legalIdCard");
                tbLegalPersonName.Text = d.GetOrDefault<string>("legalPersonName");
                tbLegalPersonShowName.Text = d.GetOrDefault<string>("legalPersonShowName");

                tbSocialCreditCode.Text = d.GetOrDefault<string>("socialCreditCode");
                tbShowSocialCreditCode.Text = d.GetOrDefault<string>("showSocialCreditCode");

                tbIntro.Text = d.GetOrDefault<string>("intro");

            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void SaveData() {
            btnOk.Enabled = false;
            try {
                var r = new Dictionary<string, object>();
                r["bgo-id"] = m_bgoId;
                r["name"] = tbName.Text.Trim();
                r["show-name"] = tbShowName.Text.Trim();
                r["registered-date"] = dtpRegisterDate.Value;
                r["reg-years"] = tbRegYear.Text.Trim();
                r["reg-funds"] = tbRegFunds.Text.Trim();
                r["reg-address"] = tbRegAddress.Text.Trim();
                r["show-reg-address"] = tbShowRegAddress.Text.Trim();
                r["postcode"] = tbPostCode.Text.Trim();
                r["legal-id-card"] = tbLegalIdCard.Text.Trim();
                r["legal-person-name"] = tbLegalPersonName.Text.Trim();
                r["legal-person-show-name"] = tbLegalPersonShowName.Text.Trim();
                r["linkman"] = tbLinkMan.Text.Trim();
                r["mobile"] = tbMobile.Text.Trim();
                r["ranking"] = tbRanking.Text.Trim();
                r["qualification"] = tbQualification.Text.Trim();
                r["social-credit-code"] = tbSocialCreditCode.Text.Trim();
                r["show-social-credit-code"] = tbShowSocialCreditCode.Text.Trim();
                r["get-prize"] = tbGetPrize.Text.Trim();
                r["org-web-site"] = tbOrgWebSite.Text.Trim();
                r["intro"] = tbIntro.Text.Trim();
                IResult p;
                if (m_bgoId == 0) {
                    p = await PrjGuaranteeOrgs.Create(r);
                } else {
                    p = await PrjGuaranteeOrgs.Update(r);
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
