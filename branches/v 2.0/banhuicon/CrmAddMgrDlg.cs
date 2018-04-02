using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Crm;
    public partial class CrmAddMgrDlg : Form {
        public CrmAddMgrDlg(string pname) {
            InitializeComponent();

            tbPName.Text = pname;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                SaveData();
            }
        }

        private async void SaveData() {
            var d = new Dictionary<string, object>();
            d["u-name"] = tbManager.Text;
            d["position"] = cbbPositionType.Text;
            d["p-name"] = tbPName.Text;
            d["r-code"] = tbRCode.Text;

            var p = await CrmInvestor.CreateManager(d);
            if (p.IsOk) {
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void CrmAddMgrDlg_Load(object sender, EventArgs e) {
            cbbPositionType.Items.AddRange(CrmCommons.Positions);
        }
    }
}
