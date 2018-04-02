using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    using Excel;
    public partial class AccHistoryRunningsDlg : Form {
        private long m_auId;
        private static readonly TextValues HISTORY_RUNNING_TYPES;

        static AccHistoryRunningsDlg() {
            HISTORY_RUNNING_TYPES = new TextValues()
            .AddNew("转入", 1)
            .AddNew("转出", 2);
        }

        public AccHistoryRunningsDlg(long auId) {
            InitializeComponent();
            m_auId = auId;
        }

        private void AccHistoryRunningsDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

            cbbTypes.ComboBox.BindTo(HISTORY_RUNNING_TYPES, ExtraItems.AddAll);
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private async void UpdateTable() {
            btnSearch.Enabled = false;
            var type = cbbTypes.ComboBox.GetSelectedValue();
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["start-date"] = startDate.Value.TruncToStart();
            d["end-date"] = endDate.Value.TruncToEnd();
            if (type != Commons.AllValue)
                d["tran-type-flag"] = type;

            var p = await InvestBase.HistoryRunnings(d);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "creditAmt") {
                e.Value = Convert.ToDecimal(e.Value) - Convert.ToDecimal(e.GetValue("debitAmt")) - Convert.ToDecimal(e.GetValue("frzAmt"))
                    + Convert.ToDecimal(e.GetValue("unfrzAmt"));
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            ExcelHelper.ExportExcel(myGridViewBinding1);
        }

        private void btnQuickDate1Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today, 1 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDate3Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today, 3 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDate5Year_Click(object sender, EventArgs e) {

            var dateRange = Commons.MakeDateRange(DateTime.Today, 5 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDateThisYear_Click(object sender, EventArgs e) {
            startDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            endDate.Value = new DateTime(DateTime.Now.Year + 1, 1, 1);
        }
    }
}
