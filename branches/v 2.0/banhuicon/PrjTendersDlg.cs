using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Projs;
    using Rpc;
    using Excel;
    public partial class PrjTendersDlg : Form {

        private int m_status;
        private long m_pId;
        private bool m_locked;
        public PrjTendersDlg(long id, int status, bool locked) {
            InitializeComponent();
            m_pId = id;
            m_status = status;
            m_locked = locked;
        }

        private async void UpdateTable() {
            btnUpdate.Enabled = false;
            var r = await Projects.Tenders(m_pId);
            if (r.IsOk) {
                myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnUpdate.Enabled = true;
        }

        private void PrjTendersDlg_Load(object sender, EventArgs e) {
            this.Text = this.Text + "-" + m_pId;
            if (m_locked) {
                btnCancelTenders.Visible = false;
                btnCancelTenders2.Visible = false;
                btnCheckTenders.Visible = false;
            } else {
                if (m_status == 40 || m_status == 50) {
                    btnCancelTenders.Visible = true;
                }
                if (m_status >= 40) {
                    btnCheckTenders.Visible = true;
                }
            }

            UpdateTable();
        }

        private void btnExportXml_Click(object sender, EventArgs e) {

            ExcelHelper.ExportExcel(myGridViewBinding1);
        }

        private async void CancelTenders() {
            if (!Commons.ShowConfirmBox(this, "将“整个项目”中途流标，此操作无法撤销！确认吗？")) {
                return;
            }
            btnCancelTenders.Enabled = false;
            var p = new Dictionary<string, object>();
            p["pid"] = m_pId;
            p["remark"] = "流标";
            var r = await Projects.BusVpStopRaising(p);
            if (!r.IsOk) {
                Commons.ShowResultErrorBox(this, r);
            }
            UpdateTable();
            btnCancelTenders.Enabled = true;
        }


        private void btnCancelTenders_Click(object sender, EventArgs e) {
            CancelTenders();
        }

        private async void CancelTenders2() {
            btnCancelTenders2.Enabled = false;
            decimal totalAmt = 0;
            var ttIds = new List<long>();
            for (int i = 0; i < myGridViewBinding1.View.SelectedRows.Count; ++i) {
                totalAmt += Convert.ToDecimal(myGridViewBinding1.GetCellValue(myGridViewBinding1.View.SelectedRows[i].Index, "amt"));
                ttIds.Add(Convert.ToInt64(myGridViewBinding1.GetCellValue(myGridViewBinding1.View.SelectedRows[i].Index, "ttId")));
            }

            if (!Commons.ShowConfirmBox(this, string.Format("撤销选中的投标，共计{0:N}元，此操作无法撤销！确认吗？", totalAmt))) {
                btnCancelTenders2.Enabled = true;
                return;
            }

            foreach (var ttId in ttIds) {
                var p = new Dictionary<string, object>();
                p["tt-id"] = ttId;
                p["remark"] = "撤销订单";

                var r = await Projects.CreateCancelTender(p);
                if (r.IsOk) {
                    var d = JObject.Parse(r.AsString);
                    var c = new JsonResult(d["ttId"].ToString());
                    myGridViewBinding1.BindTo(c, Commons.BindFlag.Delete, "ttId");
                } else {
                    Commons.ShowResultErrorBox(this, r);
                }
            }

            btnCancelTenders2.Enabled = true;
        }

        private void btnCancelTenders2_Click(object sender, EventArgs e) {
            CancelTenders2();
        }

        private void btnCheckTenders_Click(object sender, EventArgs e) {
            var dlg = new PrjTendersUncheckedDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                UpdateTable();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length != 0) {
                btnCancelTenders2.Enabled = true;
            } else {
                btnCancelTenders2.Enabled = false;
            }
        }
    }
}
