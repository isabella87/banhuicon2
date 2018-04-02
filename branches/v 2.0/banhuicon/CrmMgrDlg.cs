using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Crm;
    public partial class CrmMgrDlg : Form {

        private string m_mgr;

        public CrmMgrDlg(string mgr) {
            InitializeComponent();
            m_mgr = mgr;
        }

        private void CrmMgrDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_mgr);

            cbbDepartmentType.Items.AddRange(CrmCommons.Department);
            cbbPositionType.Items.AddRange(CrmCommons.Positions);

            UpdateTable();
        }

        private async void UpdateTable() {
            var p = await CrmInvestor.GetManager(m_mgr);
            if (p.IsOk) {
                var d = p.AsDictionary;
                cbbDepartmentType.Text = d.GetOrDefault<string>("department");
                cbbPositionType.Text = d.GetOrDefault<string>("position");
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            SaveData();
        }

        private async void SaveData() {
            var d = new Dictionary<string, object>();
            d["u-name"] = m_mgr;
            d["position"] = cbbPositionType.Text;
            d["department"] = cbbDepartmentType.Text;
            d["recursive"] = ckbSubDepartment.Checked;

            var p = await CrmInvestor.UpdateManager(d);
            if (p.IsOk) {
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }
    }
}
