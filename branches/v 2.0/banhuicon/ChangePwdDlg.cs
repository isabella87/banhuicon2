using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Security;
    public partial class ChangePwdDlg : Form {
        public ChangePwdDlg() {
            InitializeComponent();
        }

        private async void SaveData() {
            if (tbNewPassword1.Text.Trim() != tbNewPassword2.Text.Trim()) {
                Commons.ShowInfoBox(this, "两次输入的密码必须一致!");
                tbNewPassword2.Focus();
                return;
            }

            var d = new Dictionary<string, object>();
            d["old-password"] = tbOldPassword.Text.Trim();
            d["new-password"] = tbNewPassword1.Text.Trim();

            var p = await Users.ChangePwd(d);
            if (p.IsOk) {
                if (p.AsBoolean) {
                    Commons.ShowInfoBox(this, "修改成功，请重新登录!");
                    DialogResult = DialogResult.OK;
                } else
                    Commons.ShowInfoBox(this, "修改密码失败!");
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (this.ValidateChildren())
                SaveData();
        }
    }
}
