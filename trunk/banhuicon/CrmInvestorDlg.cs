using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Banhuitong.Console {
    using Crm;
    using Rpc;
    public partial class CrmInvestorDlg : Form {

        private long m_ciId;
        public IResult DlgResult { get; private set; }

        public CrmInvestorDlg(long ciId) {
            InitializeComponent();
            m_ciId = ciId;
            DlgResult = new JsonResult("{}");
        }

        private void CrmInvestorDlg_Load(object sender, EventArgs e) {
            if (m_ciId > 0) {
                this.Text = "编辑跟进客户-" + m_ciId;
                tbMobile.ReadOnly = true;
            } else {
                btnCancelAssign.Visible = false;
                btnChangePhone.Visible = false;
                this.Text = "创建跟进客户";
            }

            cbbGender.BindTo(Commons.Genders, ExtraItems.NoExtra);
            cbbPrLevel.BindTo(CrmCommons.PrLevels, ExtraItems.NoExtra);

            UpdateTable();
        }

        private async void UpdateTable() {
            var p = await CrmInvestor.Account(m_ciId);
            if (p.IsOk) {
                var d = p.AsDictionary;
                tbRealName.Text = d.GetOrDefault<string>("realName");
                tbMobile.Text = d.GetOrDefault<string>("mobile");
                tbCompany.Text = d.GetOrDefault<string>("company");
                tbPosition.Text = d.GetOrDefault<string>("position");
                tbCity.Text = d.GetOrDefault<string>("city");
                if (m_ciId == 0)
                    nudAge.Value = nudAge.Minimum;
                else
                    nudAge.SetValue(DateTime.Now.Year - Commons.FromTimestamp(d.GetOrDefault<long>("birth")).Year);
                cbbGender.SetSelectedValue(d.GetOrDefault<string>("gender"));
                tbSourceType.Text = d.GetOrDefault<string>("originType");
                cbbPrLevel.SetSelectedValue(d.GetOrDefault<string>("prLevel"));
                tbRemark.Text = d.GetOrDefault<string>("remark");

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private async void SaveData() {
            var r = new Dictionary<string, object>();
            r["ci-id"] = m_ciId;
            r["real-name"] = tbRealName.Text.Trim();
            r["mobile"] = tbMobile.Text.Trim();
            r["company"] = tbCompany.Text.Trim();
            r["position"] = tbPosition.Text.Trim();
            r["city"] = tbCity.Text.Trim();
            r["birth"] = (DateTime.Now.AddYears(-Convert.ToInt32(nudAge.Value))).TruncToStart();
            r["gender"] = cbbGender.GetSelectedValue();
            r["origin-type"] = tbSourceType.Text.Trim();
            r["pr-level"] = cbbPrLevel.GetSelectedValue();
            r["remark"] = tbRemark.Text.Trim().LeftStr(2000);

            IResult p;
            if (m_ciId == 0) {
                p = await CrmInvestor.Create(r);
            } else {
                p = await CrmInvestor.Update(r);
            }
            if (p.IsOk) {
                DlgResult = p;
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }

        private async void CancelAssign() {
            btnCancelAssign.Enabled = false;
            if (Commons.ShowConfirmBox(this, "确定取消该客户经理?")) {
                var p = await CrmInvestor.UnBindMgr(m_ciId);
                if (p.IsOk) {
                    DialogResult = DialogResult.OK;
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            }
            btnCancelAssign.Enabled = true;
        }

        private void btnCancelAssign_Click(object sender, EventArgs e) {
            CancelAssign();
        }

        private void btnChangePhone_Click(object sender, EventArgs e) {
            ChangeMobile();
        }

        private async void ChangeMobile() {
            var phone = Commons.ShowInputDialog(this, "请输入新手机号:", "修改手机号", 300,
                new Regex("^((11)|(12)|(13)|(14)|(15)|(16)|(17)|(18)|(19))\\d{9}$")).Trim();
            if (phone == "")
                return;

            var d = new Dictionary<string, object>();
            d["ci-id"] = m_ciId;
            d["mobile"] = phone;

            var p = await CrmInvestor.ChangeMobile(d);
            if (p.IsOk) {
                UpdateTable();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }
    }
}
