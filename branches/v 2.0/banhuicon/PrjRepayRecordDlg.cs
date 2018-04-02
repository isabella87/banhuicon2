using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Banhuitong.Console {
    using Projs;
    using Rpc;
    using Excel;
    public partial class PrjRepayRecordDlg : Form {
        private long m_pId;
        private long m_pbdId;
        private int m_tranType;
        private static readonly TextValues VIEW1STATUS;
        private static readonly TextValues VIEW2STATUS;

        static PrjRepayRecordDlg() {
            VIEW1STATUS = new TextValues()
            .AddNew("未完成", 0)
            .AddNew("已完成", 1);
            VIEW2STATUS = new TextValues()
            .AddNew("待执行", -1)
            .AddNew("正在执行", 0)
            .AddNew("失败", 1)
            .AddNew("成功", 2);
        }
        public PrjRepayRecordDlg(long pId, long pbdId, int tranType) {
            InitializeComponent();
            m_pId = pId;
            m_pbdId = pbdId;
            m_tranType = tranType;
        }

        private void PrjRepayRecordDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_pbdId);
        }

        private async void UpdateData() {
            btnUpdate.Enabled = false;
            var r = await Projects.Repays(m_pId, m_pbdId);
            if (r.IsOk) {
                var all = r.AsDictListDict;

                myGridViewBinding1.BindTo(all["items"], Commons.BindFlag.Replace, "", SetGridView1RowColor, UpdateMoney);
                myGridViewBinding2.BindTo(all["children"], Commons.BindFlag.Replace, "", SetGridView2RowColor, HideView2);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnUpdate.Enabled = true;
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

        private void HideView2() {
            for (int i = 0; i < myGridViewBinding2.View.Rows.Count; ++i) {
                myGridViewBinding2.View.Rows[i].Visible = false;
            }
        }

        private void UpdateMoney() {
            decimal m_completeMoney = 0;
            decimal m_totalMoney = 0;

            for (int i = 0; i < myGridViewBinding1.View.Rows.Count; ++i) {
                var amt = Convert.ToDecimal(myGridViewBinding1.View.Rows[i].Cells[5].Value);
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
            labelInfo.Text = string.Format("已执行金额:{0}元，总共金额:{1}元", m_completeMoney, m_totalMoney);
        }

        private void myGridViewBinding2_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "txamount") {
                if (Convert.ToDecimal(e.Value) == 0) {
                    e.Value = e.GetValue("intamount");
                }
            } else if (e.Key == "done") {
                e.Value = VIEW2STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateData();
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            HideView2();
            if (e.SelectedRowIndex.Length != 1)
                return;

            var rowIndex = e.SelectedRowIndex[0];
            var chosen = Convert.ToInt32(e.GetValue(rowIndex, "trId"));
            ShowDetails(chosen);
        }

        private void ShowDetails(int tsId) {
            for (int i = 0; i < myGridViewBinding2.View.Rows.Count; ++i) {
                if (Convert.ToInt32(myGridViewBinding2.View.Rows[i].Cells[0].Value) == tsId) {
                    myGridViewBinding2.View.Rows[i].Visible = true;
                }
            }
        }

        private void btnExportXml_Click(object sender, EventArgs e) {
            ExcelHelper.ExportExcel(myGridViewBinding1);
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "status") {
                e.Value = VIEW1STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private async void ExecuteRepay() {
            toolStrip1.Enabled = false;

            var d = new Dictionary<string, object>();
            d["p-id"] = m_pId;
            d["pbd-id"] = m_pbdId;
            d["tran-type"] = m_tranType;
            var r = await Projects.ExecuteRepays(d);
            if (r.IsOk) {
                UpdateData();
            } else {
                Commons.ShowResultErrorBox(this, r);
            }

            toolStrip1.Enabled = true;
        }

        private void btnExecuteRepay_Click(object sender, EventArgs e) {
            ExecuteRepay();
        }
    }
}
