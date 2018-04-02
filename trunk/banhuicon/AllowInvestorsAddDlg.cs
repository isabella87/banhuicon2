using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Projs;
    using Rpc;
    public partial class AllowInvestorsAddDlg : Form {

        private long m_pId;
        public IResult DlgResult { get; private set; }
        public AllowInvestorsAddDlg(long id) {
            InitializeComponent();
            m_pId = id;
            DlgResult = new JsonResult("{}"); 
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }

        private async void SaveData() {
            btnOk.Enabled = false;

            var r = new Dictionary<string, object>();
            r["pid"] = m_pId;
            r["login-name"] = tbLoginName.Text.Trim();
            r["mobile"] = tbMobile.Text.Trim();

            var p = await Projects.AddAllowInvest(r);
            if (p.IsOk) {
                DlgResult = p;
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, p);
            }

            btnOk.Enabled = true;

        }
    }
}
