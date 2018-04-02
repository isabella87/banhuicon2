using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using BaseData;
    public partial class PrjCreditorInfoDlg : Form {
        private long m_pId;

        public PrjCreditorInfoDlg(long id) {
            InitializeComponent();
            m_pId = id;
        }

        private void PrjCreditorInfoDlg_Load(object sender, EventArgs e) {
            this.Text += m_pId;

            UpdateTable();
        }

        private async void UpdateTable() {
            toolStrip1.Enabled = false;
            var r = new Dictionary<string, object>();
            var p = await PrjSignAgreements.GetCreditorInfo(m_pId);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            toolStrip1.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "signStatus") {
                e.Value = PrjSignAgreements.SIGN_STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }
    }
}
