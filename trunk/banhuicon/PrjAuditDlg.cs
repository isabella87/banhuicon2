using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Rpc;
    using Projs;
    using Security;
    public partial class PrjAuditDlg : Form {
        private long m_pId;
        private int m_status;
        private int m_statusSign;
        private bool m_locked;
        private static readonly Dictionary<int, string> createOpMap = new Dictionary<int, string>();
        private static readonly Dictionary<int, string> createTitleMap = new Dictionary<int, string>();

        static PrjAuditDlg() {
            createOpMap.Add(1, "提交");
            createOpMap.Add(10, "项目经理审批");
            createOpMap.Add(20, "风控审批");
            createOpMap.Add(30, "评委会审批");
            createOpMap.Add(40, "业务副总批准上线");
            createOpMap.Add(50, "业务副总中途流标");
            createOpMap.Add(60, "业务副总确认满标");
            createOpMap.Add(70, "财务核收服务费");
            createOpMap.Add(80, "业务副总批准放款");
            createOpMap.Add(999, "结清");

            createTitleMap.Add(0, "提交项目经理审批");
            createTitleMap.Add(1, "项目经理审批");
            createTitleMap.Add(10, "风控经理审批");
            createTitleMap.Add(20, "评委会秘书审批");
            createTitleMap.Add(30, "业务副总审批");
            createTitleMap.Add(50, "业务副总确认满标");
            createTitleMap.Add(60, "财务核收服务费");
            createTitleMap.Add(70, "业务副总批准放款");

        }


        public PrjAuditDlg(long pid, int prjStatus, int signStatus, bool locked) {
            InitializeComponent();
            m_pId = pid;
            m_status = prjStatus;
            m_statusSign = signStatus;
            m_locked = locked;
        }

        private void PrjAuditDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_pId);
            btnLock.Text = m_locked ? "解锁" : "锁定";

            UpdateTable1();

            UpdateButtonsStatus();
        }

        private async void UpdateMoneyCompare() {
            if (m_status < 40 || m_status > 70) {
                return;
            }

            var r = await Projects.Prj(m_pId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                var expectMoney = d.GetOrDefault<decimal>("amt");
                var actualMoney = d.GetOrDefault<decimal>("investedAmt");
                if (expectMoney != actualMoney)
                    labMoneyCompare.Text = string.Format("预期募集金额:{0}  实际募集金额:{1}", expectMoney, actualMoney);
                else
                    labMoneyCompare.Text = "";
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "aOrder") {
                e.Value = createOpMap[Convert.ToInt32(e.Value)];
            }
        }

        private async void UpdateTable1() {
            var r = await Projects.Actions(m_pId);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void UpdateTable2() {
            var text = tbComments.Text.LeftStr(500);
            if (rbNo.Checked) {
                if (text.Trim() == "") {
                    Commons.ShowInfoBox(this, "审批不通过时必须输入备注");
                    tbComments.Focus();
                    return;
                }
                if (m_status == 50 || m_status == 70) {
                    if (!Commons.ShowConfirmBox(this, "此时审批不通过会导致\"流标\"!确认吗？"))
                        return;
                }
            }

            if (rbYes.Checked && m_status == 50) {
                var p = await Projects.IsExistsUncheckedTender(m_pId);
                if (p.IsOk) {
                    if (p.AsInt > 0) {
                        Commons.ShowWarnBox(this, string.Format("存在{0}个状态未知的投标，请检查投标", p.AsInt));
                        return;
                    }
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }

            }

            if (m_status == 60) {
                var reservedAmt = Commons.ShowDecimalInputDialog(this, 0, "金额(&A)", "输入财务核收服务费", 200);
                if (reservedAmt == -1)
                    return;
                var p = new Dictionary<string, object>();
                p["pid"] = m_pId;
                p["amt"] = reservedAmt;

                var r = await Projects.SaveReservedAmt(p);
                if (!r.IsOk)
                    Commons.ShowResultErrorBox(this, r);
            }

            if (m_status == 70) {
                if (m_statusSign == 0) {
                    if (!Commons.ShowConfirmBox(this, "签章未完成，确认放款嘛？", "确认")) {
                        return;
                    }
                }
                var password = Commons.ShowInputDialog(this, "密码(&P)", "操作人员身份验证", 200, null, true).Trim();
                if (password == "")
                    return;
                else if (!(await SignIn.ValidateUser(password))) {
                    Commons.ShowInfoBox(this, "密码错误，禁止操作!");
                    return;
                }
            }

            var isOk = rbYes.Visible ? rbYes.Checked : true;
            string vf = "";
            var p2 = new Dictionary<string, object>();
            p2.AddVF("pid", m_pId, ref vf)
            .AddVF("flag", isOk, ref vf)
            .AddVF("comments", text, ref vf);
            p2["signature"] = Verification.GetSha1(vf);
            Rpc.IResult r2;
            switch (m_status) {
                case 0:
                    r2 = await Projects.PrjSubmit(p2);
                    break;
                case 1:
                    r2 = await Projects.PrjMgrAudit(p2);
                    break;
                case 10:
                    r2 = await Projects.PrjRiskCtrlAudit(p2);
                    break;
                case 20:
                    r2 = await Projects.PrjBusSecAudit(p2);
                    break;
                case 30:
                    r2 = await Projects.PrjBusVpAprOnline(p2);
                    break;
                case 50:
                    r2 = await Projects.PrjBusVpConfirmFull(p2);
                    break;
                case 60:
                    r2 = await Projects.PrjCheckFee(p2);
                    break;
                case 70:
                    r2 = await Projects.PrjBusVpConfirmLoan(p2);
                    break;
                default:
                    return;
            }

            if (r2.IsOk) {
                if (!Convert.ToBoolean(r2.AsBoolean)) {
                    Commons.ShowInfoBox(this, "业务操作失败!");
                }
            } else {
                Commons.ShowResultErrorBox(this, r2);
            }

            DialogResult = DialogResult.OK;

        }

        private void btnInvestors_Click(object sender, EventArgs e) {
            var dlg = new PrjInvestorsTableDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnOk_Click(object sender, EventArgs e) {
            UpdateTable2();
        }

        private void btnTenders_Click(object sender, EventArgs e) {
            var dlg = new PrjTendersDlg(m_pId, m_status, m_locked);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }


        private void btnLoans_Click(object sender, EventArgs e) {
            var dlg = new PrjLoansDlg(m_pId, m_status);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnInvests_Click(object sender, EventArgs e) {
            var dlg = new PrjInvestDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnCancelTenders_Click(object sender, EventArgs e) {
            var dlg = new PrjCancelTenderDlg(m_pId, m_status);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnPrjClose_Click(object sender, EventArgs e) {
            ClosePrj();
        }

        private async void ClosePrj() {
            btnPrjClose.Enabled = false;
            var temp = await Projects.Bonus(m_pId);
            string tips = "";
            if (temp.IsOk) {
                var dl = JArray.Parse(temp.AsString).ToList();
                if (dl.Count > 0) {
                    decimal unpaidAmt = 0;
                    foreach (var d in dl) {
                        unpaidAmt += d["amt"].ToDecimal() - d["paidAmt"].ToDecimal();
                    }
                    if (unpaidAmt != 0)
                        tips = string.Format("尚有 {0:N} 元未还款，", unpaidAmt);
                }
            } else {
                Commons.ShowResultErrorBox(this, temp);
                btnPrjClose.Enabled = true;
                return;
            }

            if (Commons.ShowConfirmBox(this, tips + "确定结清此企业贷吗？", "结清")) {
                var p = await Projects.Complete(m_pId);
                if (p.IsOk) {
                    UpdateTable1();
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            }

            btnPrjClose.Enabled = true;
        }

        private async void UpdateLockStatus() {
            btnLock.Enabled = false;
            var p = await Projects.IsLocked(m_pId);
            if (p.IsOk) {
                m_locked = p.AsBoolean;
                btnLock.Text = m_locked ? "解锁" : "锁定";
                UpdateButtonsStatus();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnLock.Enabled = true;
        }

        private async void Lock() {
            if (m_locked) {
                var p = await Projects.UnLock(m_pId);
                if (p.IsOk) {
                    UpdateLockStatus();
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            } else {
                var p = await Projects.Lock(m_pId);
                if (p.IsOk) {
                    UpdateLockStatus();
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            }
        }

        private void btnLock_Click(object sender, EventArgs e) {
            Lock();
        }

        private void UpdateButtonsStatus() {
            if (m_locked) {
                groupBox1.Visible = false;
                btnOk.Visible = false;
                btnCancelTenders.Visible = false;
                btnPrjClose.Visible = false;
            } else {
                btnOk.Visible = true;

                string title = "";
                var isGet = createTitleMap.TryGetValue(m_status, out title);
                if (isGet) {
                    groupBox1.Visible = true;
                    groupBox1.Text = title + "(&A)";
                } else
                    groupBox1.Visible = false;

                if (m_status == 0 || m_status == 60) {
                    rbYes.Checked = true;
                    rbYes.Hide();
                    rbNo.Hide();
                }

                UpdateMoneyCompare();

                if (m_status >= 40 || m_status == -1) {
                    btnCancelTenders.Visible = true;
                } else {
                    btnCancelTenders.Visible = false;
                }

                btnPrjClose.Visible = m_status == 90;
            }

            if (m_status >= 90 && m_status != -1)
                btnInvests.Visible = true;
            else
                btnInvests.Visible = false;

            if (m_status >= 40 || m_status == -1) {
                btnTenders.Visible = true;
            } else {
                btnTenders.Visible = false;
            }

            if (m_status >= 80) {
                btnInvestors.Visible = true;
                btnLoans.Visible = true;
            } else {
                btnInvestors.Visible = false;
                btnLoans.Visible = false;
            }
        }
    }
}
