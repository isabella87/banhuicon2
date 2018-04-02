using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Projs;
    using Excel;
    public partial class PrjCancelTenderDlg : Form {

        private long m_pId;
        private int m_status;
        private static readonly TextValues VIEW1STATUS;
        private static readonly TextValues VIEW2STATUS;

        static PrjCancelTenderDlg() {
            VIEW1STATUS = new TextValues()
            .AddNew("未完成", 0)
            .AddNew("已完成", 1);
            VIEW2STATUS = new TextValues()
            .AddNew("待执行", -1)
            .AddNew("正在执行", 0)
            .AddNew("失败", 1)
            .AddNew("成功", 2);
        }

        public PrjCancelTenderDlg(long pId, int status) {
            InitializeComponent();
            m_pId = pId;
            m_status = status;
        }

        private void PrjCancelTender_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_pId);
            if (m_status == -1 || m_status >= 40) {
                btnExecute.Visible = true;
            }
        }

        private async void UpdateTable1() {
            btnUpdate.Enabled = false;
            var r = await Projects.GetCancelTenders(m_pId);
            if (r.IsOk) {
                var all = r.AsDictListDict;

                myGridViewBinding1.BindTo(all["items"], Commons.BindFlag.Replace, "", SetGridView1RowColor, UpdateMoney);
                myGridViewBinding2.BindTo(all["children"], Commons.BindFlag.Replace, "", SetGridView2RowColor, HideView2);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnUpdate.Enabled = true;
        }

        private void HideView2() {
            for (int i = 0; i < myGridViewBinding2.View.Rows.Count; ++i) {
                myGridViewBinding2.View.Rows[i].Visible = false;
            }
        }

        private void SetGridView1RowColor() {
            for (int i = 0; i < myGridViewBinding1.View.RowCount; ++i) {
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

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private void ShowDetails(int tsId) {
            for (int i = 0; i < myGridViewBinding2.View.Rows.Count; ++i) {
                if (Convert.ToInt32(myGridViewBinding2.GetCellValue(i, "tsId")) == tsId) {
                    myGridViewBinding2.View.Rows[i].Visible = true;
                }
            }
        }

        private void myGridViewBinding2_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "done") {
                e.Value = VIEW2STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void UpdateMoney() {
            decimal m_completeMoney = 0;
            decimal m_totalMoney = 0;

            for (int i = 0; i < myGridViewBinding1.View.RowCount; ++i) {
                var amt = Convert.ToDecimal(myGridViewBinding1.GetCellValue(i, "amt"));
                var status = Convert.ToBoolean(myGridViewBinding1.View.Rows[i].Tag);
                if (status) {
                    m_completeMoney += amt;
                }
                m_totalMoney += amt;
            }

            if (m_completeMoney == m_totalMoney) {
                labShow.ForeColor = Color.Blue;
            } else {
                labShow.ForeColor = Color.Red;
            }
            labShow.Text = string.Format("已执行金额:{0:N}元 总共金额:{1:N}元", m_completeMoney, m_totalMoney);
        }

        private void btnExecute_Click(object sender, EventArgs e) {
            var ids = new List<long>();
            for (int i = 0; i < myGridViewBinding1.View.SelectedRows.Count; ++i) {
                if (Convert.ToBoolean(myGridViewBinding1.View.SelectedRows[i].Tag))
                    continue;
                ids.Add(Convert.ToInt64(myGridViewBinding1.GetCellValue(myGridViewBinding1.View.SelectedRows[i].Index, "tctId")));
            }

            if (ids.Count == 0) {
                Commons.ShowInfoBox(this, "至少选中一项投标记录");
                return;
            }
            btnExecute.Enabled = false;
            var dlg = new BatchProcessDlg(ids);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (id) => Projects.CancelTenders(id).Result;
            dlg.ShowDialog();
            UpdateTable1();
            btnExecute.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            HideView2();
            if (e.SelectedRowIndex.Length == 0) {
                btnExecute.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnExecute.Enabled = true;
                ShowDetails(Convert.ToInt32(e.GetValue(e.SelectedRowIndex[0], "tctId")));
            } else {
                btnExecute.Enabled = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            ExcelHelper.ExportExcel(myGridViewBinding1);
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "status") {
                e.Value = VIEW1STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

    }
}
