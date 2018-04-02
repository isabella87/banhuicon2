using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Banhuitong.Console.Projs;

namespace Banhuitong.Console {
    using MyLib.UI;
    //项目管理-借款申请
    public partial class WyjksFrm : Form, IHasGridDataTable {
        private static readonly TextValues WYJK_STATUS;

        static WyjksFrm() {
            WYJK_STATUS = new TextValues()
            .AddNew("申请中", 1)
            .AddNew("已分配", 2)
            .AddNew("已注册", 3)
            .AddNew("待审核", 4)
            .AddNew("已通过", 5)
            .AddNew("未通过", 6)
            .AddNew("已开户", 7);
        }

        public WyjksFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var p = new Dictionary<string, object>();
            p["start-date"] = startDate.Value.TruncToStart();
            p["end-date"] = endDate.Value.TruncToEnd();
            p["key"] = tbKey.Text.Trim();

            var r = await Wyjks.GetFinaciers(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void WyjksFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);
            startDate.Value = startDate.Value.AddYears(-2);
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "status") {
                e.Value = WYJK_STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 1)
                btnDetails.Enabled = true;
            else
                btnDetails.Enabled = false;
        }

        private void btnDetails_Click(object sender, EventArgs e) {
            var dlg = new WyjksDlg(myGridViewBinding1.GetSelectedValues<long>("fId").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }
    }
}
