using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Banhuitong.Console.Account;

namespace Banhuitong.Console {
    using MyLib.UI;
    //帐户管理-个人
    public partial class AccPersonsFrm : Form, IHasGridDataTable {

        public static readonly TextValues USER_STATUS;
        public static readonly TextValues USER_LOCKED;
        public static readonly TextValues ALLOW_STATUS;

        static AccPersonsFrm() {
            USER_STATUS = new TextValues()
                .AddNew("已注册", 1)
                .AddNew("已开户", 2);
            USER_LOCKED = new TextValues()
                .AddNew("正常", 0)
                .AddNew("自动锁定", 98)
                .AddNew("停用", 99);
            ALLOW_STATUS = new TextValues()
                .AddNew("不允许", 0)
                .AddNew("允许", 1);
        }

        public AccPersonsFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void AccPersonsFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

            cbStatus.ComboBox.BindTo(USER_STATUS, ExtraItems.AddAll);
            cbbLocked.ComboBox.BindTo(USER_LOCKED, ExtraItems.AddAll);
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var status = cbStatus.ComboBox.GetSelectedValue();
            var locked = cbbLocked.ComboBox.GetSelectedValue();

            var p = new Dictionary<string, object>();
            p["start-time"] = startDate.Value.TruncToStart();
            p["end-time"] = endDate.Value.TruncToEnd();
            if (status != Commons.AllValue)
                p["status"] = status;
            if (locked != Commons.AllValue)
                p["locked-status"] = locked;
            p["search-key"] = tbKey.Text.Trim();
            var r = await InvestPersons.GetAllPersons(p);
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

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 1) {
                var rowIndex = e.SelectedRowIndex[0];
                var status = Convert.ToInt32(e.GetValue(rowIndex, "status"));

                btnAccInfo.Enabled = true;
            } else {
                btnAccInfo.Enabled = false;
            }
        }

        private void btnAccInfo_Click(object sender, EventArgs e) {
            var dlg = new AccPersonDlg(myGridViewBinding1.GetSelectedValues<long>("auId").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "status") {
                e.Value = USER_STATUS.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "locked") {
                e.Value = USER_LOCKED.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "allowInvest") {
                e.Value = ALLOW_STATUS.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "allowBorrow") {
                e.Value = ALLOW_STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void btnQuickDate1Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today, 1 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDate3Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today, 3 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDate5Year_Click(object sender, EventArgs e) {
            var dateRange = Commons.MakeDateRange(DateTime.Today, 5 * 365);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;
        }

        private void btnQuickDateThisYear_Click(object sender, EventArgs e) {
            startDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            endDate.Value = new DateTime(DateTime.Now.Year + 1, 1, 1);
        }

    }
}
