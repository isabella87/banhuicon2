using System;
using System.Windows.Forms;
using Banhuitong.Console.Crm;

namespace Banhuitong.Console {
    using MyLib.UI;
    //客户管理-三部超时
    public partial class CrmInvestor3TimeOutFrm : Form, IHasGridDataTable {

        public CrmInvestor3TimeOutFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var r = await CrmInvestor.GetInvestors3TimeOut();
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

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "jxStatus") {
                e.Value = CrmCommons.JxUserStatus.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "prLevel") {
                e.Value = CrmCommons.PrLevels.FindByValue(Convert.ToString(e.Value));
            }
        }

    }
}
