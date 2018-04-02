using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Crm;
    public partial class CrmAssignRegUserDlg : Form {
        public CrmAssignRegUserDlg() {
            InitializeComponent();
        }

        private void AssignRegUserDlg_Load(object sender, EventArgs e) {
            cbbDepartment.Items.AddRange(CrmCommons.Department);
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren())
                SaveData();
        }

        private async void SaveData() {
            var d = new Dictionary<string, object>();
            d["real-name"] = tbUserName.Text.Trim();
            d["mobile"] = tbMobile.Text.Trim();
            d["u-name"] = tbUName.Text.Trim();
            d["department"] = cbbDepartment.Text;

            var p = await CrmInvestor.CreateAssignOfRegUser(d);
            if (p.IsOk) {
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }
    }
}
