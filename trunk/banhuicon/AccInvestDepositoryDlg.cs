using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Account;
    using Rpc;
    using Excel;
    public partial class AccInvestDepositoryDlg : Form {
        private static readonly TextValues INVEST_STATUS;
        private static readonly TextValues TYPES;
        private long m_auId;

        static AccInvestDepositoryDlg() {
            INVEST_STATUS = new TextValues()
            .AddNew("所有债权", 0)
            .AddNew("有效债权", 1);
            TYPES = new TextValues()
            .AddNew("投标中", 1)
            .AddNew("计息中", 2)
            .AddNew("本息已返回", 4)
            .AddNew("审核中", 8)
            .AddNew("已撤销", 9);
        }

        public AccInvestDepositoryDlg(long auId) {
            InitializeComponent();
            m_auId = auId;
        }

        private void AccInvestDepositoryDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            cbbTypes.ComboBox.BindTo(INVEST_STATUS);

            UpdateTable();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "state") {
                e.Value = TYPES.FindByValue(Convert.ToString(e.Value));
            }
        }

        private async void UpdateTable() {
            btnSearch.Enabled = false;
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            var status = cbbTypes.ComboBox.GetSelectedValue();
            d["status"] = status;
            d["key"] = tbKey.Text.Trim();

            var p = await InvestBase.InvestDepository(d);
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

        private void btnExportExcel_Click(object sender, EventArgs e) {

            ExcelHelper.ExportExcel(myGridViewBinding1);
        }
    }
}
