using System;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Crm;
    public partial class CrmBindMgrAndCrmInvestorHistoryDlg : Form {

        private long m_id;
        private bool m_type;
        public CrmBindMgrAndCrmInvestorHistoryDlg(long id, bool type) {
            InitializeComponent();
            m_id = id;
            m_type = type;
        }

        private void CrmBindMgrAndCrmInvestorHistoryDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_id);

            UpdateTable();
        }

        private async void UpdateTable() {
            Rpc.IResult p;
            if (m_type) {
                p = await CrmInvestor.GetHistoryMgrsOfRegUser(m_id);
            } else {
                p = await CrmInvestor.GetHistoryMgrs(m_id);
            }

            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }
    }
}
