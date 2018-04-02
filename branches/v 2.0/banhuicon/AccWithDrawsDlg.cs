using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    using Excel;
    public partial class AccWithDrawsDlg : Form {
        private static readonly TextValues STATUS;
        private static readonly TextValues REPLY_STATUS;

        private long m_auId;

        static AccWithDrawsDlg() {
            STATUS = new TextValues()
            .AddNew("成功", 1)
            .AddNew("失败", 2)
            .AddNew("未知结果", 3);

            REPLY_STATUS = new TextValues()
            .AddNew("未知", -1)
            .AddNew("未知", 0)
            .AddNew("失败", 1)
            .AddNew("成功", 2);
        }

        public AccWithDrawsDlg(long auId) {
            InitializeComponent();
            m_auId = auId;
        }

        private void AccWithDrawsDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);
            cbbTypes.ComboBox.BindTo(STATUS, ExtraItems.AddAll);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

        }

        private async void UpdateTable() {
            btnSearch.Enabled = false;
            var types = cbbTypes.ComboBox.GetSelectedValue();
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["start-date"] = startDate.Value.TruncToStart();
            d["end-date"] = endDate.Value.TruncToEnd();
            if (types != Commons.AllValue)
                d["is-ok"] = cbbTypes.ComboBox.GetSelectedValue();

            var p = await InvestBase.WithDraws(d);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "done") {
                e.Value = REPLY_STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private void btnExportExcel_Click(object sender, EventArgs e) {

            ExcelHelper.ExportExcel(myGridViewBinding1);
        }
    }
}
