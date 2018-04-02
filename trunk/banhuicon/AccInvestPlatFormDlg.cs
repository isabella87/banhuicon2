using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    using Excel;
    public partial class AccInvestPlatFormDlg : Form {
        private static readonly TextValues INVEST_STATUS;
        private long m_auId;

        static AccInvestPlatFormDlg() {
            INVEST_STATUS = new TextValues()
            .AddNew("失败", 0)
            .AddNew("成功", 1);
        }

        public AccInvestPlatFormDlg(long auId) {
            InitializeComponent();
            m_auId = auId;
        }

        private void AccInvestPlatFormDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

            cbbStatus.ComboBox.BindTo(INVEST_STATUS, ExtraItems.AddAll);

            UpdateTable();
        }

        private async void UpdateTable() {
            btnSearch.Enabled = false;
            var type = cbbStatus.ComboBox.GetSelectedValue();
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["start-date"] = startDate.Value.TruncToStart();
            d["end-date"] = endDate.Value.TruncToEnd();
            if (type != Commons.AllValue)
                d["type"] = type;

            var p = await InvestBase.InvestPlatform(d);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "status") {
                e.Value = INVEST_STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private void btnExportExcel_Click(object sender, EventArgs e) {

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
