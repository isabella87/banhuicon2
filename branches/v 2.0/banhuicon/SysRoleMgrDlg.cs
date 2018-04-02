using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Security;
    using Rpc;
    public partial class SysRoleMgrDlg : Form {

        public IResult DlgResult { get; private set; }
        private string m_roleName;
        private bool m_isNew;
        public SysRoleMgrDlg(string roleName) {
            InitializeComponent();
            m_roleName = roleName;
            DlgResult = new JsonResult("{}"); 
        }

        private void SysRoleMgrDlg_Load(object sender, EventArgs e) {
            if (m_roleName.Length == 0) {
                this.Text = "创建帐号";
                m_isNew = true;
            } else {
                this.Text = "修改帐号-" + m_roleName;
                m_isNew = false;
            }

            UpdateTable();
        }

        private async void UpdateTable() {
            var p = await Roles.Role(m_roleName);
            if (p.IsOk) {
                var d = p.AsDictionary;
                tbRoleName.Text = d.GetOrDefault<string>("name");
                tbRoleName.ReadOnly = !d.GetOrDefault<bool>("nameIsWritable");
                tbTitle.Text = d.GetOrDefault<string>("title");
                tbDescription.Text = d.GetOrDefault<string>("description");
                ckbEnable.Checked = d.GetOrDefault<bool>("enabled");
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private async void SaveData() {
            var r = new Dictionary<string, object>();
            r["role-name"] = tbRoleName.Text.Trim().ToLower();
            r["title"] = tbTitle.Text.Trim();
            r["description"] = tbDescription.Text.Trim().LeftStr(2000);
            r["enabled"] = ckbEnable.Checked;

            var p = m_isNew ? await Roles.AddRole(r) : await Roles.UpdateRole(r);
            if (p.IsOk) {
                DlgResult = p;
                this.DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, p);
            }

        }

        private void btnOK_Click(object sender, EventArgs e) {
            SaveData();
        }
    }
}
