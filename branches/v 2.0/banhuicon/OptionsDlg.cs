using System;
using System.Windows.Forms;

namespace Banhuitong.Console {
    public partial class OptionsDlg : Form {
        public OptionsDlg() {
            InitializeComponent();
        }

        private void OptionsDlg_Load(object sender, EventArgs e) {
#if DEBUG
            tbBaseUri.Text = Properties.Settings.Default.Rpc_BaseUrlDebug;
#else
            tbBaseUri.Text = Properties.Settings.Default.Rpc_BaseUrl;
#endif
            tbUpdateUrl.Text = Properties.Settings.Default.Update_BaseUrl.Trim();
        }

        private void btnOk_Click(object sender, EventArgs e) {
#if DEBUG
            Properties.Settings.Default.Rpc_BaseUrlDebug = tbBaseUri.Text.Trim();
#else
            Properties.Settings.Default.Rpc_BaseUrl = tbBaseUri.Text.Trim();
#endif
            Properties.Settings.Default.Update_BaseUrl = tbUpdateUrl.Text.Trim();
        }
    }
}
