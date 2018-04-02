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
        public static readonly TextValues BANK_STATUS;
        public static readonly TextValues ALLOW_STATUS;

        static AccPersonsFrm() {
            USER_STATUS = new TextValues()
                .AddNew("已注册", -2)
                .AddNew("激活", 1)
                .AddNew("待审核", 0)
                .AddNew("审核未通过", -1)
                .AddNew("审核通过", 2)
                .AddNew("已锁定", 98)
                .AddNew("停用", 99);
            BANK_STATUS = new TextValues()
                .AddNew("未开户", 0)
                .AddNew("已开户", 1);
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
            cbBankStatus.ComboBox.BindTo(BANK_STATUS, ExtraItems.AddAll);
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var status = cbStatus.ComboBox.GetSelectedValue();
            var bankStatus = cbBankStatus.ComboBox.GetSelectedValue();

            var p = new Dictionary<string, object>();
            p["start-time"] = startDate.Value.TruncToStart();
            p["end-time"] = endDate.Value.TruncToEnd();
            if (status != Commons.AllValue)
                p["status"] = status;
            if (bankStatus != Commons.AllValue)
                p["jx-status"] = bankStatus;
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
            } else if (e.Key == "jxStatus") {
                e.Value = BANK_STATUS.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "allowInvest") {
                e.Value = ALLOW_STATUS.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "allowBorrow") {
                e.Value = ALLOW_STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

    }
}
