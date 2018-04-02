using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Projs;
    using Rpc;
    public partial class CreatePrjEntBorOrgDlg : Form {

        private long m_pId;
        private long m_bpmoId = 0;
        private static readonly TextValues VISIBLE;
        public IResult DlgResult;

        static CreatePrjEntBorOrgDlg() {
            VISIBLE = new TextValues()
                .AddNew("不可见", 0)
                .AddNew("可见", 1);
        }

        public CreatePrjEntBorOrgDlg(long id) {
            InitializeComponent();
            m_pId = id;
            DlgResult = new JsonResult("{}"); 
        }

        private void CreatePrjEntBorOrg_Load(object sender, EventArgs e) {
            this.Text = this.Text + "-" + m_pId;
            tbBorName.ReadOnly = true;
            cbbVisible.BindTo(VISIBLE);
        }

        private async void SaveData() {
            if (m_bpmoId == 0 || m_bpmoId == -1) {
                Commons.ShowInfoBox(this, "请选择一个借款机构!");
                btnSelBorOrg.Focus();
                return;
            }
            var p = new Dictionary<string, object>();
            p["pid"] = m_pId;
            p["bpmo-id"] = m_bpmoId;
            p["loan-purposes"] = tbLoanPurpose.Text.Trim();
            p["loan-bal"] = (int)nudLoanBal.Value;
            p["other-loan-bal"] = (int)nudOtherLoanBal.Value;
            p["overdue-num"] = tbOverDueNum.Text.Trim();
            p["other-overdue-num"] = tbOtherOverDueNum.Text.Trim();
            p["overdue-amt"] = nudOverDueAmt.Value;
            p["other-overdue-amt"] = nudOtherOverDueAmt.Text.Trim();
            p["visible"] = cbbVisible.GetSelectedValue();
            p["order-no"] = (int)nudOrder.Value;
            p["loan-intro"] = tbSituation.Text.LeftStr(2000);

            var r = await Projects.BorrowOrgPut(p);
            if (r.IsOk) {
                DlgResult = r;
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, r);
            }

        }

        private void btnSelBorOrg_Click(object sender, EventArgs e) {
            var dlg = new SelPrjMgrOrgDlg(m_bpmoId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_bpmoId = dlg.SelMgrId;
                tbBorName.Text = dlg.SelBorName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                SaveData();
            }
        }

    }
}
