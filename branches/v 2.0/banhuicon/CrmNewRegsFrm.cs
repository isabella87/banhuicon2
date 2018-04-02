using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banhuitong.Console.Crm;

namespace Banhuitong.Console {
    using MyLib.UI;
    //客户管理-新增注册用户
    public partial class CrmNewRegsFrm : Form, IHasGridDataTable {
        public CrmNewRegsFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void FrmCrmNewRegs_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            startDate.Value = startDate.Value.AddMonths(-1);
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var p = new Dictionary<string, object>();
            p["datepoint"] = startDate.Value.TruncToStart();

            var r = await CrmInvestor.GetNewRegs(p);
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
            if (e.Key == "age") {
                e.Value = Convert.ToInt32(e.Value) == 0 ? "" : e.Value;
            }
        }
    }
}
