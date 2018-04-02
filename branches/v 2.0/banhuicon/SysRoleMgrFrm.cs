using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Banhuitong.Console.Security;

namespace Banhuitong.Console {
    using MyLib.UI;
    //运维管理-角色管理
    public partial class SysRoleMgrFrm : Form, IHasGridDataTable {

        public SysRoleMgrFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;

            var enabled = cbUserEnable.ComboBox.GetSelectedValue();

            var p = new Dictionary<string, object>();
            p["keyword"] = tbKey.Text.Trim();
            if (enabled != Commons.AllValue) {
                p["enabled"] = enabled;
            }

            var r = await Roles.GetAll(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private void FrmSysRoleMgr_Load(object sender, EventArgs e) {
            cbUserEnable.ComboBox.BindTo(Commons.YesOrNo, ExtraItems.AddAll);
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            var dlg = new SysRoleMgrDlg("");
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "name");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var dlg = new SysRoleMgrDlg(myGridViewBinding1.GetSelectedValues<string>("name").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK)
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "name");
        }

        private void btnRight_Click(object sender, EventArgs e) {
            var name = myGridViewBinding1.GetSelectedValues<string>("name").FirstOrDefault();
            if (name == "administrators") {
                Commons.ShowInfoBox(this, "不能修改角色：administrators 的权限！");
                return;
            }

            var dlg = new SysRoleRightsDlg(name, myGridViewBinding1.GetSelectedValues<string>("title").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK)
                UpdateTable1();
        }

        private async void Del(IList<string> idArray) {
            btnDel.Enabled = false;
            var ss = idArray.JoinSome(" ");
            if (Commons.ShowConfirmBox(this, "删除以下角色：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    if (id == "administrators") {
                        Commons.ShowInfoBox(this, "不能删除角色：administrators ！");
                        continue;
                    }
                    var p = await Roles.Delete(id);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "name");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                var adminIndex = ss.IndexOf("administrators");
                if (adminIndex != -1)
                    ss = ss.Remove(adminIndex, "administrators".Length);
                Commons.ShowInfoBox(this, "角色：" + ss + " 已被删除。");
            }
            btnDel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<string>("name").ToList();
            if (idArray.Count > 0)
                Del(idArray);
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
                btnRight.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                btnRight.Enabled = true;
            } else {
                btnEdit.Enabled = false;
                btnDel.Enabled = true;
                btnRight.Enabled = false;
            }
        }
    }
}
