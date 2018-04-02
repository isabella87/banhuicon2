using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Banhuitong.Console.Account;

namespace Banhuitong.Console {
    using MyLib.UI;
    //帐户管理-商户转帐
    public partial class BusinessTransferFrm : Form, IHasGridDataTable {

        public BusinessTransferFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void FrmBusinessTransfer_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);
            startDate.Value = startDate.Value.AddYears(-2);
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var p = new Dictionary<string, object>();
            p["start-date"] = startDate.Value.TruncToStart();
            p["end-date"] = endDate.Value.TruncToEnd();
            p["key"] = tbKey.Text.Trim();

            var r = await BusinessTransfers.GetAll(p);
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
            if (e.SelectedRowIndex.Length == 0) {
                btnDel.Enabled = false;
                btnExecute.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnExecute.Enabled = true;
                btnDel.Enabled = true;
            } else {
                btnExecute.Enabled = false;
                btnDel.Enabled = true;
            }
        }

        private async void Create() {
            var remark = Commons.ShowInputDialog(this, "备注(&R):", "创建商户转帐", 300);
            if (remark == "")
                return;
            var d = new Dictionary<string, object>();
            d["remark"] = remark;

            var p = await BusinessTransfers.SaveB2cDetail(d);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p, Commons.BindFlag.Update, "tbdId");
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Create();
        }

        private void btnExecute_Click(object sender, EventArgs e) {
            var dlg = new BusinessTransferDlg(myGridViewBinding1.GetSelectedValues<long>("tbdId").FirstOrDefault(),
                myGridViewBinding1.GetSelectedValues<string>("remark").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private async void Del(IList<long> idArray) {
            btnDel.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下商户转帐：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await BusinessTransfers.Delete(id);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "tbdId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
            }
            btnDel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<long>("tbdId").ToList();
            if (idArray.Count > 0) {
                Del(idArray);
            }
        }
    }
}
