using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using BaseData;
    using Rpc;
    public partial class PrjEngineerDlg : Form {

        private long m_bpeId = 0;
        public IResult DlgResult { get; private set; }

        public PrjEngineerDlg(long pid) {
            InitializeComponent();
            m_bpeId = pid;
            DlgResult = new JsonResult("{}");
        }

        private void PrjEngineerDlg_Load(object sender, EventArgs e) {
            cbbGenders.BindTo(Commons.Genders);

            if (m_bpeId != 0)
                this.Text = "修改工程项目" + " - " + m_bpeId;

            UpdateData();
        }

        private async void UpdateData() {
            var r = await PrjEngineers.GetEngineer(m_bpeId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                tbEngName.Text = d.GetOrDefault<string>("name");
                tbShowEngName.Text = d.GetOrDefault<string>("engShowName");
                tbAddress.Text = d.GetOrDefault<string>("address");
                tbShowAddress.Text = d.GetOrDefault<string>("engShowAddress");
                cbbMgrOrgLevel.SetSelectedValue(d.GetOrDefault<string>("mgrOrgLevel"));
                tbMgrOrg.Text = d.GetOrDefault<string>("mgrOrg");
                tbShowMgrOrg.Text = d.GetOrDefault<string>("showMgrOrg");
                cbbDesignOrgLevel.SetSelectedValue(d.GetOrDefault<string>("designOrgLevel"));
                tbDesignOrg.Text = d.GetOrDefault<string>("designOrg");
                tbShowDesignOrg.Text = d.GetOrDefault<string>("showDesignOrg");
                cbbEngType.SetSelectedValue(d.GetOrDefault<string>("engType"));
                tbAllOrg.Text = d.GetOrDefault<string>("allOrg");
                tbShowAllOrg.Text = d.GetOrDefault<string>("showAllOrg");
                tbArea.Text = d.GetOrDefault<string>("area");
                cbbShowArea.SetSelectedValue(d.GetOrDefault<string>("showArea"));
                dtpPrjStart.Value = Commons.FromTimestamp(d.GetOrDefault<long>("prjStartTime"));
                dtpPrjEnd.Value = Commons.FromTimestamp(d.GetOrDefault<long>("prjEndTime"));
                tbProIntro.Text = d.GetOrDefault<string>("proIntro");

                tbMgrRealName.Text = d.GetOrDefault<string>("mgrRealName");
                tbShowMgrName.Text = d.GetOrDefault<string>("mgrShowName");
                tbAge.Text = d.GetOrDefault<string>("mgrAge");
                tbShowAge.Text = d.GetOrDefault<string>("mgrShowAge");
                cbbGenders.SetSelectedValue(d.GetOrDefault<int>("mgrGender"));
                tbQualification.Text = d.GetOrDefault<string>("qualification");
                tbMgrIntro.Text = d.GetOrDefault<string>("mgrIntro");



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
                r["bpe-id"] = m_bpeId;
                r["name"] = tbEngName.Text.Trim();
                r["eng-show-name"] = tbShowEngName.Text.Trim();
                r["address"] = tbAddress.Text.Trim();
                r["eng-show-address"] = tbShowAddress.Text.Trim();
                r["mgr-org-level"] = cbbMgrOrgLevel.Text.Trim();
                r["mgr-org"] = tbMgrOrg.Text.Trim();
                r["show-mgr-org"] = tbShowMgrOrg.Text.Trim();
                r["design-org-level"] = cbbDesignOrgLevel.Text.Trim();
                r["design-org"] = tbDesignOrg.Text.Trim();
                r["show-design-org"] = tbShowDesignOrg.Text.Trim();
                r["eng-type"] = cbbEngType.Text.Trim();
                r["all-org"] = tbAllOrg.Text.Trim();
                r["show-all-org"] = tbShowAllOrg.Text.Trim();
                r["area"] = tbArea.Text;
                r["show-area"] = cbbShowArea.Text.Trim();
                r["prj-start-time"] = dtpPrjStart.Value.TruncToStart();
                r["prj-end-time"] = dtpPrjEnd.Value.TruncToEnd();
                r["pro-intro"] = tbProIntro.Text.LeftStr(2000);
                r["mgr-real-name"] = tbMgrRealName.Text.Trim();
                r["mgr-show-name"] = tbShowMgrName.Text.Trim();
                r["mgr-age"] = tbAge.Text;
                r["mgr-show-age"] = tbShowAge.Text;
                r["mgr-gender"] = cbbGenders.GetSelectedValue();
                r["qualification"] = tbQualification.Text.Trim();
                r["mgr-intro"] = tbMgrIntro.Text.LeftStr(2000);
                IResult p;
                if (m_bpeId == 0) {
                    p = await PrjEngineers.Create(r);
                } else {
                    p = await PrjEngineers.Update(r);
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
