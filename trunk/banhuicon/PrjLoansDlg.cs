using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Projs;
    using Rpc;
    using Excel;
    public partial class PrjLoansDlg : Form {
        private long m_pId;
        private int m_status;
        private static readonly TextValues VIEW1STATUS;
        private static readonly TextValues VIEW2STATUS;

        static PrjLoansDlg() {
            VIEW1STATUS = new TextValues()
            .AddNew("未完成", 0)
            .AddNew("已完成", 1);
            VIEW2STATUS = new TextValues()
            .AddNew("待执行", -1)
            .AddNew("正在执行", 0)
            .AddNew("失败", 1)
            .AddNew("成功", 2);
        }

        public PrjLoansDlg(long pId, int status) {
            InitializeComponent();
            m_pId = pId;
            m_status = status;
        }

        private void PrjLoansDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_pId);
            UpdateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateData();
        }

        private async void UpdateData() {
            toolStrip1.Enabled = false;
            labelInfo.Text = "";
            var r = await Projects.Loans(m_pId);
            if (r.IsOk) {
                var all = r.AsDictListDict;

                myGridViewBinding1.BindTo(all["items"], Commons.BindFlag.Replace, "", SetGridView1RowColor, UpdateMoney);
                myGridViewBinding2.BindTo(all["children"], Commons.BindFlag.Replace, "", SetGridView2RowColor, HideView2);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            toolStrip1.Enabled = true;
        }

        private void HideView2() {
            for (int i = 0; i < myGridViewBinding2.View.Rows.Count; ++i) {
                myGridViewBinding2.View.Rows[i].Visible = false;
            }
        }

        private void myGridViewBinding2_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "done") {
                e.Value = VIEW2STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void SetGridView1RowColor() {
            for (int i = 0; i < myGridViewBinding1.View.Rows.Count; ++i) {
                var status = VIEW1STATUS.FindByText(Convert.ToString(myGridViewBinding1.GetCellValue(i, "status")));
                myGridViewBinding1.View.Rows[i].Tag = status == "1" ? true : false;
            }
        }

        private void SetGridView2RowColor() {
            for (int i = 0; i < myGridViewBinding2.View.Rows.Count; ++i) {
                var done = VIEW2STATUS.FindByText(Convert.ToString(myGridViewBinding2.GetCellValue(i, "done")));
                if (done == "2") {
                    myGridViewBinding2.View.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                } else if (done == "1") {
                    myGridViewBinding2.View.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                } else {
                    myGridViewBinding2.View.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            HideView2();
            if (e.SelectedRowIndex.Length != 1)
                return;

            var rowIndex = e.SelectedRowIndex[0];
            var chosen = Convert.ToInt32(e.GetValue(rowIndex, "tlId"));
            ShowDetails(chosen);
        }

        private void ShowDetails(int tlId) {
            for (int i = 0; i < myGridViewBinding2.View.Rows.Count; ++i) {
                if (Convert.ToInt32(myGridViewBinding2.GetCellValue(i, "tsId")) == tlId) {
                    myGridViewBinding2.View.Rows[i].Visible = true;
                }
            }
        }

        private void UpdateMoney() {
            decimal m_completeMoney = 0;
            decimal m_totalMoney = 0;

            for (int i = 0; i < myGridViewBinding1.View.Rows.Count; ++i) {
                var amt = Convert.ToDecimal(myGridViewBinding1.GetCellValue(i, "amt"));
                var status = (bool)myGridViewBinding1.View.Rows[i].Tag;
                if (status) {
                    m_completeMoney += amt;
                }
                m_totalMoney += amt;
            }

            if (m_completeMoney == m_totalMoney) {
                labelInfo.ForeColor = Color.Blue;
            } else {
                labelInfo.ForeColor = Color.Red;
            }
            labelInfo.Text = string.Format("已执行金额: {0:N}元 总共金额: {1:N}元", m_completeMoney, m_totalMoney);
        }

        private void btnExportXml_Click(object sender, EventArgs e) {
            ExcelHelper.ExportExcel(myGridViewBinding1);
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "status") {
                e.Value = VIEW1STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private async void ExecuteLoan() {
            if (!Commons.ShowConfirmBox(this, "确认执行吗？", "执行")) {
                return;
            }

            toolStrip1.Enabled = false;

            var r = await Projects.ExecuteLoan(m_pId);
            if (r.IsOk) {
                UpdateData();
            } else {
                Commons.ShowResultErrorBox(this, r);
            }

            toolStrip1.Enabled = true;
        }

        private void btnExecuteLoan_Click(object sender, EventArgs e) {
            ExecuteLoan();
        }

    }
}
