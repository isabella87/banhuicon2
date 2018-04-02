using System;
using System.Windows.Forms;

namespace Banhuitong.Console {
    public partial class ErrorDlg : Form {
        public ErrorDlg() {
            InitializeComponent();
        }

        public Exception Exception {
            set {
                if (value != null) {
                    txtMessage.Text = value.Message;
                    txtStackTrace.Text = value.ToString() + "\r\n" + value.StackTrace;
                }
            }
        }

        /// <summary>
        /// 扩展对话框的高度，并且显示调用堆栈。
        /// </summary>
        private void ShowMore() {
            txtStackTrace.Show();
            txtStackTrace.SelectAll();
            txtStackTrace.Focus();

            this.Height += txtStackTrace.Height + 12;
        }

        private void CopyStackTrace() {
            try {
                Clipboard.SetText(txtStackTrace.Text);
            } catch {
            }
        }

        private void DlgError_Load(object sender, EventArgs e) {
            //
        }

        private void btnShowMore_Click(object sender, EventArgs e) {
            ((Button)sender).Enabled = false;
            ShowMore();
            btnCopyStackTrace.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCopyStackTrace_Click(object sender, EventArgs e) {
            CopyStackTrace();
        }
    }
}
