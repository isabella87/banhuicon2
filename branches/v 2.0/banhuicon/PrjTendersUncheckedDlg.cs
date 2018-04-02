using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Projs;
    using Excel;
    public partial class PrjTendersUncheckedDlg : Form {
        private long m_pId;
        public PrjTendersUncheckedDlg(long pId) {
            InitializeComponent();
            m_pId = pId;
        }

        private void PrjTendersUnknownDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_pId);

            UpdateTable();
        }

        private async void UpdateTable() {
            var p = await Projects.UncheckedTenders(m_pId);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (myGridViewBinding1.View.RowCount == 0)
                return;
            btnStart.Enabled = false;
            var ids = new List<long>();

            for (int i = 0; i < myGridViewBinding1.View.RowCount; ++i) {
                ids.Add(Convert.ToInt64(myGridViewBinding1.GetCellValue(i,"jbId")));
            }

            var dlg = new BatchProcessDlg(ids);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (id) => Projects.UpdateUncheckedTenders(m_pId, id).Result;
            dlg.ShowDialog(this);

            UpdateTable();
            btnStart.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e) {

            ExcelHelper.ExportExcel(myGridViewBinding1);
        }

    }
}
