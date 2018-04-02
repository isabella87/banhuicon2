using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Banhuitong.Console.Account;

namespace Banhuitong.Console {
    using MyLib.UI;

    /// <summary>
    /// 帐户管理-发送消息
    /// </summary>
    public partial class AccMessageFrm : Form, IHasGridDataTable {

        public AccMessageFrm() {
            InitializeComponent();
        }

        private void FrmAccMessage_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);
            startDate.Value = startDate.Value.AddYears(-2);
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return this.myGridViewBinding1;
            }
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var p = new Dictionary<string, object>();
            p["start-time"] = startDate.Value.TruncToStart();
            p["end-time"] = endDate.Value.TruncToEnd();
            p["search-key"] = tbKey.Text.Trim();

            var r = await Messages.GetMessages(p);
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
            btnCheck.Enabled = e.SelectedRowIndex.Length == 1;
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            var dlg = new AccMessageDlg(0);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "amId");
            }
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            var dlg = new AccMessageDlg(myGridViewBinding1.GetSelectedValues<long>("amId").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.SetReadOnly(true);
            dlg.ShowDialog(this);
        }
    }
}
