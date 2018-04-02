using System;
using System.Windows.Forms;

using log4net;

namespace Banhuitong.Console {
    public partial class SignInDlg : Form {
        private ILog m_log = LogManager.GetLogger(typeof(SignInDlg));

        private bool m_capthcaImageIsLoading;

        public SignInDlg() {
            InitializeComponent();

            m_capthcaImageIsLoading = false;
        }

        private async void UpdateCaptchaImage() {
            if (!m_capthcaImageIsLoading) {
                m_capthcaImageIsLoading = true;
                picCaptchaCode.Image = null;
                var captchaImage = await Security.SignIn.GetCaptchaImage();
                picCaptchaCode.Image = captchaImage;
                m_capthcaImageIsLoading = false;
            }
        }

        private void DlgSignIn_Load(object sender, EventArgs e) {
            var lastUser = Properties.Settings.Default.LastUser;
            if (lastUser != "") {
                txtUserName.Text = lastUser;
                txtPassword.Select();
            } else {
                txtUserName.Select();
            }

            UpdateCaptchaImage();
        }

        private void picCaptchaCode_Click(object sender, EventArgs e) {
            UpdateCaptchaImage();
        }

        private async void btnOk_Click(object sender, EventArgs e) {
            var ret = await Security.SignIn.Validate(
                txtUserName.Text,
                txtPassword.Text,
                txtCaptchaCode.Text
                );

            if (ret) {
                var userName = txtUserName.Text.Trim();
                m_log.InfoFormat("logged as {0}", userName);
                Properties.Settings.Default.LastUser = userName;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            } else {
                Commons.ShowErrorBox(this, Properties.Resources.SignIn_Failed);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void txtCaptchaCode_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtCaptchaCode.Text))
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
        }
    }
}
