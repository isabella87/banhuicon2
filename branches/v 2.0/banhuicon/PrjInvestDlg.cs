using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Projs;
    using Excel;
    public partial class PrjInvestDlg : Form {
        private long m_pId;
        public PrjInvestDlg(long pId) {
            InitializeComponent();
            m_pId = pId;
        }

        private void PrjInvestDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_pId);
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);

            UpdateTable1();
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var p = new Dictionary<string, object>();
            p["pid"] = m_pId;
            p["datepoint"] = startDate.Value.TruncToStart();


            var r = await Projects.Invests(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "sType") {
                var type = Convert.ToInt64(e.Value);
                e.Value = type == 1 ? "投标" : type == 2 ? "买入债权" : "";
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            ExcelHelper.ExportExcel(myGridViewBinding1);
        }

    }
}
