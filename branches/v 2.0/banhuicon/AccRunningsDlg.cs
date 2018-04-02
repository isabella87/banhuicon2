using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Account;
    using Rpc;
    using Excel;
    public partial class AccRunningsDlg : Form {
        private long m_auId;
        private static readonly TextValues RUNNING_TYPES1;
        private static readonly TextValues RUNNING_TYPES2;

        static AccRunningsDlg() {
            RUNNING_TYPES1 = new TextValues()
            .AddNew("全部", 0)
            .AddNew("转入", 1)
            .AddNew("转出", 2);
            RUNNING_TYPES2 = new TextValues()
            .AddNew("转入", "+")
            .AddNew("转出", "-");
        }

        public AccRunningsDlg(long auid) {
            InitializeComponent();
            m_auId = auid;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private void AccRunningsDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            cbbTypes.ComboBox.BindTo(RUNNING_TYPES1);

        }

        private async void UpdateTable() {
            btnSearch.Enabled = false;
            var type = cbbTypes.ComboBox.GetSelectedValue();
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["tran-type-flag"] = type;
            var p = await InvestBase.Runnings(d);
            if (p.IsOk) {
                var r = new JsonResult(JObject.Parse(p.AsString)["items"].ToStdString());
                myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e) {
            ExcelHelper.ExportExcel(myGridViewBinding1);
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "txFlag") {
                e.Value = RUNNING_TYPES2.FindByValue(Convert.ToString(e.Value));
            }
        }

    }
}
