using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Projs;
    using Rpc;
    public partial class CreatePrjEntGuaranteeOrgDlg : Form {
        private static readonly TextValues VISIBLE;
        private long m_pId;
        private long m_bgoId = 0;
        public IResult DlgResult;

        static CreatePrjEntGuaranteeOrgDlg() {
            VISIBLE = new TextValues()
                .AddNew("不可见", 0)
                .AddNew("可见", 1);
        }

        public CreatePrjEntGuaranteeOrgDlg(long id) {
            InitializeComponent();
            m_pId = id;
            DlgResult = new JsonResult("{}");
        }

        private void CreatePrjEntGuaranteeDlg_Load(object sender, EventArgs e) {
            this.Text = this.Text + "-" + m_pId;

            cbbVisible.BindTo(VISIBLE);
        }

        private void btnSelGuarantee_Click(object sender, EventArgs e) {
            var dlg = new SelPrjGuaranteeOrgDlg(m_bgoId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_bgoId = dlg.SelGuaId;
                labRealName.Text = dlg.SelGuaName;
                tbShowName.Text = dlg.SelGuaShowName;
            }
        }

        private async void SaveData() {
            if (m_bgoId == 0 || m_bgoId == -1) {
                Commons.ShowInfoBox(this, "请选择一个担保机构!");
                btnSelGuarantee.Focus();
                return;
            }

            var p = new Dictionary<string, object>();
            p["pid"] = m_pId;
            p["bgo-id"] = m_bgoId;
            p["form"] = cbbTypes.Text.Trim();
            p["range"] = cbbRange.Text.Trim();
            p["limit"] = cbbLimit.Text.Trim();
            p["last-year-income"] = (int)nudLastYearIncome.Value;
            p["relation-ship"] = cbbRelationShip.Text.Trim();
            p["guarantee-right-man"] = tbGuaRightMan.Text.Trim();
            p["guarantee-right-man-no"] = tbGuaRightManNo.Text.Trim();
            p["order-no"] = (int)nudOrder.Value;
            p["visible"] = cbbVisible.GetSelectedValue();

            var r = await Projects.GuaranteeOrgPut(p);
            if (r.IsOk) {
                DlgResult = r;
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, r);
            }

        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren())
                SaveData();
        }

    }
}
