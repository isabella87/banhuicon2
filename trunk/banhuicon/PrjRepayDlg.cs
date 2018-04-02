using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Projs;
    using Rpc;
    using Excel;
    public partial class PrjRepayDlg : Form {
        private long m_pId;
        public static readonly TextValues UPDATE_STATES;
        public static readonly TextValues TRAN_TYPES;
        public static readonly TextValues PAY_TYPES;

        static PrjRepayDlg() {
            UPDATE_STATES = new TextValues()
            .AddNew("已禁用", -1)
            .AddNew("未上传", 0)
            .AddNew("已上传", 1);

            TRAN_TYPES = new TextValues()
            .AddNew("利息", 0)
            .AddNew("本金", 1);

            PAY_TYPES = new TextValues()
            .AddNew("正常", 1)
            .AddNew("保证金", 2)
            .AddNew("名义借款人", 3);
        }


        public PrjRepayDlg(long pId) {
            InitializeComponent();
            m_pId = pId;
        }

        private void PrjRepayDlg_Load(object sender, EventArgs e) {
            this.Text += m_pId;

            UpdateTable1();
            UpdateTable2();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateTable1();
            UpdateTable2();
        }

        private void btnCreateRepay_Click(object sender, EventArgs e) {
            panel1.Visible = true;
            rbNormal.Checked = true;
            ckbDatepointIsNow.Checked = true;
            tbExpectedAmt.Text = myGridViewBinding1.GetSelectedValues<decimal>("unpaidAmt").FirstOrDefault().ToString();
            dtpExpectedDate.Value = myGridViewBinding1.GetSelectedValues<DateTime>("dueTime").FirstOrDefault().Date;
            dtpDatePoint.Value = dtpExpectedDate.Value;
            nudAmt.Value = 0;
            tbDiffAmt.Text = tbExpectedAmt.Text;
            tbComments.Text = TRAN_TYPES.FindByValue(myGridViewBinding1.GetSelectedValues<string>("tranType").FirstOrDefault());
        }

        private async void SaveData() {
            var amt = nudAmt.Value;
            var eAmt = Convert.ToDecimal(tbExpectedAmt.Text);
            if (amt <= 0) {
                Commons.ShowInfoBox(this, "还款金额必须大于零");
                nudAmt.Focus();
                return;
            }
            var dAmt = eAmt - amt;
            if (dAmt < 0) {
                Commons.ShowInfoBox(this, "差额不能小于零");
                nudAmt.Focus();
                return;
            }
            var tranNo = myGridViewBinding1.GetSelectedValues<int>("tranNo").FirstOrDefault();
            var tranType = myGridViewBinding1.GetSelectedValues<string>("tranType").FirstOrDefault();
            var payType = rbNormal.Checked ? 1 : rbNominal.Checked ? 3 : rbReverse.Checked ? 2 : 0;
            var sPayType = payType == 1 ? "正常还款" : payType == 3 ? "名义借款人还款" : payType == 2 ? "保证金还款" : "";
            if (Commons.ShowConfirmBox(this, string.Format(
                "来源:{0:N}\r\n" +
                "金额:{1:N}\r\n" +
                "差额:{2:N}\r\n" +
                "还款时间:{3:G}\r\n" +
                "期数:{4}\r\n" +
                "类型:{5}\r\n" +
                "\n发起还款么?", sPayType, nudAmt.Value, tbDiffAmt.Text, dtpDatePoint.Value,
                tranNo, TRAN_TYPES.FindByValue(tranType)))) {
                string vf = "";
                var r = new Dictionary<string, object>();
                r.AddVF("pid", m_pId, ref vf)
                .AddVF("tran-no", tranNo, ref vf)
                .AddVF("tran-type", tranType, ref vf)
                .AddVF("pay-type", payType, ref vf)
                .AddVF("amt", amt, ref vf)
                .AddVF("paid-time", dtpDatePoint.Value, ref vf)
                .AddVF("remark", tbComments.Text.LeftStr(2000), ref vf);
                r["signature"] = Verification.GetSha1(vf);

                var p = await Projects.SaveBonusDetail(r);
                if (p.IsOk) {
                    panel1.Visible = false;
                    UpdateTable1();
                    UpdateTable2();

                    if (dAmt > 0 && tranType == "0") {
                        Commons.ShowWarnBox(this, "刚才发起的还息不是足额还款。如果是提前还款，请执行还息后立刻足额还本");
                    }
                    var p2 = await Projects.RepayFileUploadTime();
                    if (!p2.IsOk) {
                        Commons.ShowResultErrorBox(this, p2);
                    }

                } else {
                    Commons.ShowResultErrorBox(this, p);
                }

            }

        }

        private void btnOK_Click(object sender, EventArgs e) {
            SaveData();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            panel1.Visible = false;
        }

        private async void UpdateTable1() {
            btnUpdate.Enabled = false;
            var r = await Projects.Bonus(m_pId);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnUpdate.Enabled = true;
        }

        private async void UpdateTable2() {
            btnUpdate.Enabled = false;
            var r = await Projects.BonusDetails(m_pId);
            if (r.IsOk) {
                this.myGridViewBinding2.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnUpdate.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "unknown1")
                e.Value = 0;
            else if (e.Key == "unknown2")
                e.Value = 0;
            else if (e.Key == "unknown3")
                e.Value = 0;
            else if (e.Key == "tranType")
                e.Value = TRAN_TYPES.FindByValue(Convert.ToString(e.Value));
            else if (e.Key == "unpaidAmt")
                e.Value = Convert.ToDecimal(e.Value) < 0 ? 0 : e.Value;
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 1) {
                var rowIndex = e.SelectedRowIndex[0];
                var unpaidAmt = Convert.ToDecimal(e.GetValue(rowIndex, "unpaidAmt"));
                if (unpaidAmt > 0)
                    btnCreateRepay.Enabled = true;
                else
                    btnCreateRepay.Enabled = false;
            } else {
                btnCreateRepay.Enabled = false;
            }
        }

        private void myGridViewBinding2_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "tranType")
                e.Value = TRAN_TYPES.FindByValue(Convert.ToString(e.Value));
            else if (e.Key == "payType")
                e.Value = PAY_TYPES.FindByValue(Convert.ToString(e.Value));
            else if (e.Key == "uploadStatus")
                e.Value = UPDATE_STATES.FindByValue(Convert.ToString(e.Value));
        }

        private void myGridViewBinding2_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 1) {
                var rowIndex = e.SelectedRowIndex[0];
                var uploadStatus = Convert.ToInt32(e.GetValue(rowIndex, "uploadStatus"));
                btnForbidRepay.Enabled = uploadStatus != -1;
                btnSearchRecord.Enabled = true;
            } else {
                btnForbidRepay.Enabled = false;
                btnSearchRecord.Enabled = false;
            }
        }

        private void nudAmt_ValueChanged(object sender, EventArgs e) {
            var eAmt = Convert.ToDecimal(tbExpectedAmt.Text);
            var dAmt = eAmt - nudAmt.Value;
            if (dAmt > 0) {
                tbDiffAmt.BackColor = Color.Yellow;
            } else if (dAmt < 0) {
                tbDiffAmt.BackColor = Color.Red;
            } else {
                tbDiffAmt.BackColor = Color.LightGreen;
            }
            tbDiffAmt.Text = dAmt.ToString();
        }

        private void ckbDatepointIsNow_CheckedChanged(object sender, EventArgs e) {
            if (ckbDatepointIsNow.Checked) {
                dtpDatePoint.Value = dtpExpectedDate.Value;
                dtpDatePoint.Enabled = false;
            } else
                dtpDatePoint.Enabled = true;
        }

        private void dtpExpectedDate_ValueChanged(object sender, EventArgs e) {
            if (ckbDatepointIsNow.Checked)
                dtpDatePoint.Value = dtpExpectedDate.Value;
        }

        private async void ForbidRepay() {
            var pbdId = myGridViewBinding2.GetSelectedValues<long>("pbdId").FirstOrDefault();
            if (!Commons.ShowConfirmBox(this, string.Format("禁用还款明细 {0} 吗？禁用的还款明细不能再执行还款。", pbdId))) {
                return;
            }
            btnCancel.Enabled = false;
            var r = await Projects.DeleteBonusDetail(m_pId, pbdId);
            if (r.IsOk) {
                UpdateTable1();
                UpdateTable2();
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnCancel.Enabled = true;
        }

        private void btnForbidRepay_Click(object sender, EventArgs e) {
            ForbidRepay();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            var dlg = new PrjRepayRecordDlg(m_pId, myGridViewBinding2.GetSelectedValues<long>("pbdId").FirstOrDefault(),
                myGridViewBinding2.GetSelectedValues<int>("tranType").FirstOrDefault(),
                myGridViewBinding2.GetSelectedValues<int>("uploadStatus").FirstOrDefault() != -1);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnExportXml_Click(object sender, EventArgs e) {
            ExcelHelper.ExportExcel(myGridViewBinding1);
        }

    }
}
