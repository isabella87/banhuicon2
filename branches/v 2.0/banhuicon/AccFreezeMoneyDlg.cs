using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    public partial class AccFreezeMoneyDlg : Form {

        private long m_auId;
        public AccFreezeMoneyDlg(long auid) {
            InitializeComponent();
            m_auId = auid;
        }

        private void AccFreezeMoneyDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);

        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;

            var p = await FreezeMoney.FreezeDetails(d);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private async void UpdateTable2() {
            btnSearch.Enabled = false;
            labResult.Text = "";
            var p = await FreezeMoney.SearchBalance(m_auId);
            if (p.IsOk) {
                var d = p.AsDictionary;
                labResult.Text = string.Format("当前冻结总额为{0:N}元",
                    (d.GetOrDefault<decimal>("currBal") - d.GetOrDefault<decimal>("availBal")));
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
            UpdateTable2();
        }

        private async void AddFreeze() {
            var fMoney = Commons.ShowDecimalInputDialog(this, 0, "金额(&A)", "输入冻结金额", 200);
            if (fMoney < 0) {
                btnFreeze.Enabled = true;
                return;
            }
            var d = new Dictionary<string, object>();
            d["au-id"] = m_auId;
            d["amt"] = fMoney;
            var p = await FreezeMoney.AddFreeze(d);
            if (p.IsOk) {
                UpdateTable1();
                UpdateTable2();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnFreeze.Enabled = true;
        }

        private void btnFreeze_Click(object sender, EventArgs e) {
            btnFreeze.Enabled = false;
            AddFreeze();
        }

        private async void DelFreeze(IList<string> idArray) {
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "解除订单号为：" + ss + " 的冻结资金吗？")) {
                foreach (var id in idArray) {
                    var d = new Dictionary<string, object>();
                    d["old-order-id"] = id;
                    var p = await FreezeMoney.DelFreeze(d);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "buyDate");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                UpdateTable2();
                Commons.ShowInfoBox(this, "解除订单号为：" + ss + " 已被删除。");
            }
            btnDel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e) {
            btnDel.Enabled = false;
            var idArray = myGridViewBinding1.GetSelectedValues<string>("orderId").ToList();
            if (idArray.Count > 0) {
                DelFreeze(idArray);
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnDel.Enabled = false;
            } else {
                btnDel.Enabled = true;
            }
        }

    }
}
