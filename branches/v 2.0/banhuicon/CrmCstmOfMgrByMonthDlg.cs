using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Crm;
    using Excel;
    public partial class CrmCstmOfMgrByMonthDlg : Form {

        private string m_uname;
        public CrmCstmOfMgrByMonthDlg(string uname, DateTime time) {
            InitializeComponent();
            dtpDate.Value = time;
            m_uname = uname;
        }

        private void CrmCstmOfMgrByMonthDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_uname);
            toolStrip1.AddControlAfter(dtpDate, toolStripLabel1);
        }

        private void btnInvestRecord_Click(object sender, EventArgs e) {
            var dlg = new AccHistoryInvestDlg(myGridViewBinding1.GetSelectedValues<long>("auId").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();
        }

        private async void UpdateTable() {
            btnSearchMonth.Enabled = false;
            var d = new Dictionary<string, object>();
            d["u-name"] = m_uname;
            d["datepoint"] = dtpDate.Value;

            var p = await CrmPerformance.GetCstmofMgrByMonth(d);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearchMonth.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            btnInvestRecord.Enabled = e.SelectedRowIndex.Length == 1;
        }

        private void btnSearchMonth_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private void btnExportExcel_Click(object sender, EventArgs e) {
            ExcelHelper.ExportExcel(myGridViewBinding1);
        }
    }
}
