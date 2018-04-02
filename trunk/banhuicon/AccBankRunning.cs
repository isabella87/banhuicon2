using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    using Excel;
    public partial class AccBankRunning : Form {
        private long m_auId;
        private static readonly TextValues m_type;

        static AccBankRunning() {
            m_type = new TextValues()
            .AddNew("支出", "C")
            .AddNew("收入", "D");
        }

        public AccBankRunning(long auId) {
            InitializeComponent();
            m_auId = auId;
        }

        private void AccBankRunning_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private async void UpdateTable() {
            btnSearch.Enabled = false;
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["start-date"] = startDate.Value.TruncToStart();
            d["end-date"] = endDate.Value.TruncToEnd();

            var p = await InvestBase.BankRunnings(d);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "crflag") {
                e.Value = m_type.FindByValue(Convert.ToString(e.Value).ToUpper());
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            ExcelHelper.ExportExcel(myGridViewBinding1);
        }
    }
}
