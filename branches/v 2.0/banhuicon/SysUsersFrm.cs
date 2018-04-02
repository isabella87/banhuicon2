using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Security;
    using MyLib.UI;
    //运维管理-帐户管理
    public partial class SysUsersFrm : Form, IHasGridDataTable {

        public SysUsersFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void UpdateRoles() {
            cbRoles.ComboBox.BindTo(Roles.GetAll(null).ToTextValues("title", "name"), ExtraItems.AddAll);
        }
        private void UpdateEnabled() {
            cbEnabled.ComboBox.BindTo(Commons.YesOrNo, ExtraItems.AddAll);
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var roleName = cbRoles.ComboBox.GetSelectedValue();
            var enabled = cbEnabled.ComboBox.GetSelectedValue();
            var keyword = tbKey.Text.Trim();

            var p = new Dictionary<string, object>();
            if (roleName != Commons.AllValue) {
                p["role-name"] = roleName;
            }
            if (enabled != Commons.AllValue) {
                p["enabled"] = enabled;
            }
            p["keyword"] = keyword;

            var r = await Users.GetAll(p);
            if (r.IsOk) {
                myGridViewBinding1.BindTo(r.AsDictList);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void FrmSysUsers_Load(object sender, EventArgs e) {
            UpdateRoles();
            UpdateEnabled();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "userName") {
                var enabled = Convert.ToBoolean(e.GetValue("enabled"));
                if (!enabled) {
                    e.Value = e.Value + "(未启用)";
                }
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnResetPassword.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnResetPassword.Enabled = true;
            } else {
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
                btnResetPassword.Enabled = true;
            }
        }

        private void Edit(string userName = "") {
            var dlg = new SysUserDlg(userName);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "userName");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Edit();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var userName = myGridViewBinding1.GetSelectedValues<string>("userName").FirstOrDefault();
            if (userName != "") {
                Edit(userName);
            }
        }

        private async void ResetPwd(IList<string> userNames) {
            var ss = userNames.JoinSome();
            if (Commons.ShowConfirmBox(this, "重置以下用户的密码：" + ss + " 确认吗？")) {
                foreach (var userName in userNames) {
                    await Security.Users.ResetPwd(userName);
                }
                UpdateTable1();
                Commons.ShowInfoBox(this, "用户：" + ss + " 的密码已被重置。");
            }
        }

        private async void Delete(IList<string> userNames) {
            btnDelete.Enabled = false;
            var ss = userNames.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下用户：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var userName in userNames) {
                    var p = await Security.Users.DeleteUser(userName);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "userName");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                Commons.ShowInfoBox(this, "用户：" + ss + " 已被删除。");
            }
            btnDelete.Enabled = true;
        }

        private void btnResetPassword_Click(object sender, EventArgs e) {
            var userNames = myGridViewBinding1.GetSelectedValues<string>("userName").ToList();
            if (userNames.Count > 0) {
                ResetPwd(userNames);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var userNames = myGridViewBinding1.GetSelectedValues<string>("userName").ToList();
            if (userNames.Count > 0) {
                Delete(userNames);
            }
        }
    }
}
