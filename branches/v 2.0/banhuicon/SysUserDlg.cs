using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Banhuitong.Console {
    using Security;
    using Rpc;
    public partial class SysUserDlg : Form {
        private bool m_isNew;
        private string m_userName;
        public IResult DlgResult { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        public SysUserDlg(string userName = "") {
            InitializeComponent();

            m_userName = userName.TrimStr();
            m_isNew = m_userName == "";
            DlgResult = new JsonResult("{}");
        }

        private async void UpdateData() {
            var allRoles = await Roles.GetAll(null).ToTextValues("title", "name");
            lvRoles.BindTo(allRoles);

            var r = await Users.GetUser(m_userName);
            if (r.IsOk) {
                var data = r.AsDictionary;
                txtUserName.Text = data.GetOrDefault<string>("userName");
                txtMobile.Text = data.GetOrDefault<string>("mobile");
                txtEMail.Text = data.GetOrDefault<string>("email");
                cbEnabled.Checked = data.GetOrDefault<bool>("enabled");
                r = await Users.Roles(m_userName);
                if (r.IsOk) {
                    lvRoles.SetCheckedValues(r.AsList.OfType<string>());
                } else {
                    Commons.ShowResultErrorBox(this, r);
                }
                ValidateChildren();
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void SaveData() {
            btnOk.Enabled = false;
            try {
                var data = new Dictionary<string, object>();
                data["user-name"] = txtUserName.Text.Trim();
                data["mobile"] = txtMobile.Text.Trim();
                data["email"] = txtEMail.Text.Trim();
                data["enabled"] = cbEnabled.Checked;
                data["roles"] = string.Join(",", lvRoles.GetCheckedValues());
                Rpc.IResult r;
                if (m_isNew) {
                    r = await Security.Users.AddUser(data);
                } else {
                    r = await Security.Users.UpdateUser(data);
                }
                if (r.IsOk) {
                    DlgResult = r;
                    DialogResult = DialogResult.OK;
                } else {
                    Commons.ShowResultErrorBox(this, r);
                }
            } finally {
                btnOk.Enabled = true;
            }
        }

        private void SysUserDlg_Load(object sender, EventArgs e) {
            UpdateData();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }
    }
}
