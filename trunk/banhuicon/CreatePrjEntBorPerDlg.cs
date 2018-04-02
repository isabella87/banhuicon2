using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Projs;
    using Rpc;
    public partial class CreatePrjEntBorPerDlg : Form {

        private long m_pId;
        private long m_bpmpId = 0;
        private static readonly TextValues VISIBLE;
        public IResult DlgResult;

        static CreatePrjEntBorPerDlg() {
            VISIBLE = new TextValues()
                .AddNew("可见", 1)
                .AddNew("不可见", 0);
        }

        public CreatePrjEntBorPerDlg(long id) {
            InitializeComponent();
            m_pId = id;
            DlgResult = new JsonResult("{}"); 
        }

        private void CreatePrjEntBorPer_Load(object sender, EventArgs e) {
            this.Text = this.Text + "-" + m_pId;
            tbBorName.ReadOnly = true;
            cbbVisible.BindTo(VISIBLE);
        }

        private async void SaveData() {
            if (m_bpmpId == 0 || m_bpmpId == -1) {
                Commons.ShowInfoBox(this, "请选择一个借款人!");
                btnSelBorPer.Focus();
                return;
            }


            var p = new Dictionary<string, object>();
            p["pid"] = m_pId;
            p["bpmp-id"] = m_bpmpId;
            p["loan-bal"] = (int)nudLoanBal.Value;
            p["other-loan-bal"] = (int)nudOtherLoanBal.Value;
            p["overdue-num"] = tbOverDueNum.Text.Trim();
            p["other-overdue-num"] = tbOtherOverDueNum.Text.Trim();
            p["overdue-amt"] = nudOverDueAmt.Value;
            p["other-overdue-amt"] = nudOtherOverDueAmt.Value;
            p["visible"] = cbbVisible.GetSelectedValue();
            p["order-no"] = (int)nudOrder.Value;

            var r = await Projects.BorrowPerPut(p);
            if (r.IsOk) {
                DlgResult = r;
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, r);
            }

        }

        private void btnSelBorPer_Click(object sender, EventArgs e) {
            var dlg = new SelPrjMgrPerDlg(m_bpmpId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_bpmpId = dlg.SelMgrId;
                tbBorName.Text = dlg.SelBorName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (ValidateChildren())
                SaveData();
        }

    }
}
