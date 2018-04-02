using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Account;
    using Rpc;
    using Excel;
    public partial class BusinessTransferDlg : Form {

        private long m_tbdId;
        private string m_remark;
        private static TextValues STATUS;
        static BusinessTransferDlg() {
            STATUS = new TextValues()
            .AddNew("待执行", -1)
            .AddNew("正在执行", 0)
            .AddNew("失败", 1)
            .AddNew("成功", 2);
        }
        public BusinessTransferDlg(long tbdId, string remark) {
            InitializeComponent();

            m_tbdId = tbdId;
            m_remark = remark;
        }

        private void BusinessTransferDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_tbdId);

            UpdateTable1();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private async void UpdateTable1() {
            toolStrip1.Enabled = false;
            var r = await BusinessTransfers.InvestBonus(m_tbdId);
            if (r.IsOk) {
                myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            toolStrip1.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "done") {
                switch (Convert.ToString(e.Value)) {
                    case "0":
                        myGridViewBinding1.View.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case "1":
                        myGridViewBinding1.View.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        break;
                    case "2":
                        myGridViewBinding1.View.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    default:
                        myGridViewBinding1.View.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        break;
                }
                e.Value = STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void btnCreateOne_Click(object sender, EventArgs e) {
            var dlg = new BusinessTransferAddOneDlg(m_tbdId, m_remark);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK)
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "jvpId");
        }

        private void btnStart_Click(object sender, EventArgs e) {
            var ids = new List<long>();

            for (int i = 0; i < myGridViewBinding1.View.RowCount; ++i) {
                if (Convert.ToInt32(STATUS.FindByText(Convert.ToString(myGridViewBinding1.GetCellValue(i, "done")))) != -1)
                    continue;
                ids.Add(Convert.ToInt64(myGridViewBinding1.GetCellValue(i, "jvpId")));
            }

            if (ids.Count == 0) {
                Commons.ShowInfoBox(this, "无可操作记录");
                return;
            }

            var dlg = new BatchProcessDlg(ids);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (id) => {
                var p = BusinessTransfers.ExecuteInvestBonus(m_tbdId, id).Result;
                myGridViewBinding1.BindTo(p, Commons.BindFlag.Update, "jvpId");
                return p;
            };
            dlg.ShowDialog();
            //UpdateTable1();
        }


        private void btnCreateBatch_Click(object sender, EventArgs e) {
            var dlg = new ImportWizardDlg(new List<Tuple<string, CellType, bool>>() { 
                ImportWizardDlg.MakeColumn("登录名",CellType.Text,true),
                ImportWizardDlg.MakeColumn("姓名", CellType.Text,true),
                ImportWizardDlg.MakeColumn("金额",CellType.Text,true)});
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (index, gridView) => {
                var d = new Dictionary<string, object>();
                d["tbd-id"] = m_tbdId;
                d["login-name"] = gridView.Rows[index].Cells[0].Value.TrimStr();
                d["real-name"] = gridView.Rows[index].Cells[1].Value.TrimStr();
                d["amt"] = gridView.Rows[index].Cells[2].Value.TrimStr();
                var p = BusinessTransfers.SaveInvestBonus(d).Result;
                if (p.IsOk) {
                    myGridViewBinding1.BindTo(p, Commons.BindFlag.Update, "jvpId");
                }

                return p;
            };
            dlg.ShowDialog(this);
        }


    }
}
