using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    using Rpc;
    public partial class BusinessTransferAddOneDlg : Form {

        private long m_tbdId;
        private string m_remark;
        public IResult DlgResult { get; private set; }
        public BusinessTransferAddOneDlg(long tbdId, string remark) {
            InitializeComponent();
            m_tbdId = tbdId;
            m_remark = remark;
        }

        private void BusinessTransferAddOneDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_tbdId);
        }

        private async void SaveData() {
            btnOK.Enabled = false;
            try {
                var amt = nudAmt.Value;
                if (amt <= 0) {
                    Commons.ShowInfoBox(this, "转帐金额必须大于0！");
                    return;
                }

                var r = new Dictionary<string, object>();
                r["tbd-id"] = m_tbdId;
                r["login-name"] = tbLoginName.Text.Trim();
                r["real-name"] = tbRealName.Text.Trim();
                r["amt"] = nudAmt.Value;
                r["remark"] = m_remark;

                var p = await BusinessTransfers.SaveInvestBonus(r);
                if (p.IsOk) {
                    DlgResult = p;
                    DialogResult = DialogResult.OK;
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            } finally {
                btnOK.Enabled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (this.ValidateChildren())
                SaveData();
        }
    }
}
