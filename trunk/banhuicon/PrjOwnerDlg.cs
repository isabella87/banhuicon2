using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using BaseData;
    using Rpc;
    public partial class PrjOwnerDlg : Form {
        private long m_boId = 0;
        public IResult DlgResult { get; private set; }
        public PrjOwnerDlg(long boId) {
            InitializeComponent();
            m_boId = boId;
            DlgResult = new JsonResult("{}");
        }

        private void PrjOwnerDlg_Load(object sender, EventArgs e) {
            if (m_boId != 0)
                this.Text = "修改项目业主-" + m_boId;

            UpdateData();
        }

        private async void UpdateData() {
            var r = await PrjOwners.GetOwner(m_boId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                tbName.Text = d.GetOrDefault<string>("ownerName");
                tbShowName.Text = d.GetOrDefault<string>("ownerShowName");
                dtpRegisterDate.Value = Commons.FromTimestamp(d.GetOrDefault<long>("registeredDate"));
                tbRegYear.Text = d.GetOrDefault<string>("regYears");
                tbRegFunds.Text = d.GetOrDefault<string>("regFunds");
                tbShowRegFunds.Text = d.GetOrDefault<string>("showRegFunds");
                cbbEntIndustry.Text = d.GetOrDefault<string>("entIndustry");
                cbbOwnerNature.Text = d.GetOrDefault<string>("ownerNature");
                cbbOwnerStrength.Text = d.GetOrDefault<string>("ownerStrength");
                cbbOwnerQuality.Text = d.GetOrDefault<string>("ownerQuality");
                tbIntro.Text = d.GetOrDefault<string>("intro");

            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }

        private async void SaveData() {
            btnOk.Enabled = false;
            try {
                var r = new Dictionary<string, object>();
                r["bo-id"] = m_boId;
                r["owner-name"] = tbName.Text.Trim();
                r["owner-show-name"] = tbShowName.Text.Trim();
                r["registered-date"] = dtpRegisterDate.Value;
                r["reg-years"] = tbRegYear.Text.Trim();
                r["reg-funds"] = tbRegFunds.Text.Trim();
                r["show-reg-funds"] = tbShowRegFunds.Text.Trim();
                r["ent-industry"] = cbbEntIndustry.Text.Trim();
                r["owner-nature"] = cbbOwnerNature.Text.Trim();
                r["owner-strength"] = cbbOwnerStrength.Text.Trim();
                r["owner-quality"] = cbbOwnerQuality.Text.Trim();
                r["intro"] = tbIntro.Text.LeftStr(2000);
                IResult p;
                if (m_boId == 0) {
                    p = await PrjOwners.Create(r);
                } else {
                    p = await PrjOwners.Update(r);
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
