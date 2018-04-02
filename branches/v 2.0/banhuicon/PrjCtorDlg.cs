using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using BaseData;
    using Rpc;
    public partial class PrjCtorDlg : Form {
        private long m_bcoId;
        public IResult DlgResult { get; private set; }

        public PrjCtorDlg(long bcoId) {
            InitializeComponent();
            m_bcoId = bcoId;
            DlgResult = new JsonResult("{}");
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }

        private async void SaveData() {
            if (string.IsNullOrWhiteSpace(tbIntro.Text)) {
                Commons.ShowInfoBox(this, "介绍不能为空！");
                return;
            }
            btnOK.Enabled = false;
            try {
                var r = new Dictionary<string, object>();
                r["bco-id"] = m_bcoId;
                r["name"] = tbName.Text.Trim();
                r["show-name"] = tbShowName.Text.Trim();
                r["ent-nature"] = cbbEntNature.Text.Trim();
                r["ent-quality"] = cbbEntQuality.Text.Trim();
                r["ent-strength"] = cbbEntStrength.Text.Trim();
                r["registered-date"] = dtpRegisterDate.Value;
                r["reg-years"] = tbRegYear.Text.Trim();
                r["show-reg-years"] = tbShowRegYear.Text.Trim();
                r["reg-funds"] = tbRegFunds.Text.Trim();
                r["show-reg-funds"] = tbShowRegFunds.Text.Trim();
                r["lasted-area"] = tbLastedArea.Text.Trim();
                r["lasted-output"] = tbLastedOutput.Text.Trim();
                r["qualification"] = cbbQualification.Text.Trim();
                r["nation-prize-count"] = tbNationPrizeCount.Text.Trim();
                r["provin-prize-count"] = tbProvinPrizeCount.Text.Trim();
                r["intro"] = tbIntro.Text.LeftStr(2000);
                IResult p;
                if (m_bcoId == 0) {
                    p = await PrjCtors.Create(r);
                } else {
                    p = await PrjCtors.Update(r);
                }
                if (p.IsOk) {
                    DlgResult = p;
                    DialogResult = DialogResult.OK;
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            } finally {
                btnOK.Enabled = true;
            }
        }

        private void PrjCtorDlg_Load(object sender, EventArgs e) {
            if (m_bcoId != 0)
                this.Text = "修改施工单位-" + m_bcoId;

            UpdateData();
        }

        private async void UpdateData() {
            var r = await PrjCtors.GetCtor(m_bcoId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                tbName.Text = d.GetOrDefault<string>("name");
                tbShowName.Text = d.GetOrDefault<string>("showName");
                cbbEntNature.SetSelectedValue(d.GetOrDefault<string>("entNature"));
                cbbEntQuality.SetSelectedValue(d.GetOrDefault<string>("entQuality"));
                cbbEntStrength.SetSelectedValue(d.GetOrDefault<string>("entStrength"));
                dtpRegisterDate.Value = Commons.FromTimestamp(d.GetOrDefault<long>("registeredDate"));
                tbRegYear.Text = d.GetOrDefault<string>("regYears");
                tbShowRegYear.Text = d.GetOrDefault<string>("showRegYears");
                tbRegFunds.Text = d.GetOrDefault<string>("regFunds");
                tbShowRegFunds.Text = d.GetOrDefault<string>("showRegFunds");
                tbLastedArea.Text = d.GetOrDefault<string>("lastedArea");
                tbLastedOutput.Text = d.GetOrDefault<string>("lastedOutput");
                cbbQualification.SetSelectedValue(d.GetOrDefault<string>("qualification"));
                tbNationPrizeCount.Text = d.GetOrDefault<string>("nationPrizeCount");
                tbProvinPrizeCount.Text = d.GetOrDefault<string>("provinPrizeCount");
                tbIntro.Text = d.GetOrDefault<string>("intro");

            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }
    }
}
