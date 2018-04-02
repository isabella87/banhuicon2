using System;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    public partial class AccMonthReportsDlg : Form {

        private long m_auId;
        public AccMonthReportsDlg(long auid) {
            InitializeComponent();
            m_auId = auid;
        }

        private void AccMonthReportsDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            UpdateTable();
        }

        private async void UpdateTable() {
            var r = await InvestBase.MonthReports(m_auId);
            if (r.IsOk) {
                myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "url") {
#if DEBUG
                e.Value = Properties.Settings.Default.Rpc_BaseUrlDebug + Commons.AddUrlTail(URLTYPES.VISIT) + e.Value;
#else
                e.Value = Properties.Settings.Default.Rpc_BaseUrl + Commons.AddUrlTail(URLTYPES.VISIT) + e.Value;
#endif
            }
        }
    }
}
