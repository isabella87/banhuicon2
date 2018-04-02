using System;
using System.Windows.Forms;
using Banhuitong.Console.Crm;

namespace Banhuitong.Console {
    using MyLib.UI;
    //客户管理-二部转一部
    public partial class CrmInvestor2To1Frm : Form, IHasGridDataTable {

        public CrmInvestor2To1Frm() {
            InitializeComponent();
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var r = await CrmInvestor.GetInvestors2To1();
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "jxStatus") {
                e.Value = CrmCommons.JxUserStatus.FindByValue(Convert.ToString(e.Value));
            }
        }

    }
}
