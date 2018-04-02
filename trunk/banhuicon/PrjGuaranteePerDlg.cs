using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using BaseData;
    using Rpc;
    public partial class PrjGuaranteePerDlg : Form {
        private long m_bgpId = 0;
        public IResult DlgResult { get; private set; }
        public PrjGuaranteePerDlg(long bgoId) {
            InitializeComponent();
            m_bgpId = bgoId;
            DlgResult = new JsonResult("{}");
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }

        private void PrjGuaranteeDlg_Load(object sender, EventArgs e) {
            if (m_bgpId != 0)
                this.Text = "修改担保人-" + m_bgpId;

            Commons.BindTo(cbbGenders, Commons.Genders);

            UpdateData();
        }

        private async void UpdateData() {
            var r = await PrjGuaranteePers.GetGuarantee(m_bgpId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                tbName.Text = d.GetOrDefault<string>("name");
                tbShowName.Text = d.GetOrDefault<string>("showName");
                cbbGenders.SetSelectedValue(d.GetOrDefault<int>("gender"));
                tbAddress.Text = d.GetOrDefault<string>("address");
                tbPostCode.Text = d.GetOrDefault<string>("postcode");
                tbMobile.Text = d.GetOrDefault<string>("mobile");
                tbShowAddress.Text = d.GetOrDefault<string>("showAddress");
                tbIdCard.Text = d.GetOrDefault<string>("idCard");
                tbAge.Text = d.GetOrDefault<string>("age");
                tbShowAge.Text = d.GetOrDefault<string>("showAge");

                tbIntro.Text = d.GetOrDefault<string>("intro");

            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void SaveData() {
            btnOk.Enabled = false;
            try {
                var r = new Dictionary<string, object>();
                r["bgp-id"] = m_bgpId;
                r["name"] = tbName.Text.Trim();
                r["show-name"] = tbShowName.Text.Trim();
                r["age"] = tbAge.Text.Trim();
                r["show-age"] = tbShowAge.Text.Trim();
                r["gender"] = cbbGenders.GetSelectedValue();
                r["address"] = tbAddress.Text.Trim();
                r["show-address"] = tbShowAddress.Text.Trim();
                r["postcode"] = tbPostCode.Text.Trim();
                r["id-card"] = tbIdCard.Text.Trim();
                r["mobile"] = tbMobile.Text.Trim();
                r["intro"] = tbIntro.Text.Trim();
                IResult p;
                if (m_bgpId == 0) {
                    p = await PrjGuaranteePers.Create(r);
                } else {
                    p = await PrjGuaranteePers.Update(r);
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
