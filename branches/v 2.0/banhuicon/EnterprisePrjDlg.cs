using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;


namespace Banhuitong.Console {
    using Projs;
    using Rpc;
    public partial class EnterprisePrjDlg : Form {
        private static readonly TextValues BONUS_PERIODS;
        private static readonly TextValues VISIBLE;
        public bool PrjReadOnly { get; set; }
        public IResult DlgResult { get; private set; }

        private long m_pId;
        //选中的借款人帐户ID
        private long m_borId;
        //选中的名义借款人帐户ID
        private long m_nominalBorId;
        //担保人ID
        private long m_sponsorId;
        //项目是否可见
        private bool visible;


        static EnterprisePrjDlg() {
            BONUS_PERIODS = new TextValues()
            .AddNew("每月固定日还款(放款后30天作为首次还款日)", 1)
            .AddNew("每月固定日还款(首次还款日为指定日)", 2)
            .AddNew("固定周期还款", 3);

            VISIBLE = new TextValues()
            .AddNew("不可见", 0)
            .AddNew("可见", 1);

        }


        public EnterprisePrjDlg(long pid) {
            InitializeComponent();
            m_pId = pid;

            m_borId = 0;
            m_nominalBorId = 0;
            m_sponsorId = 0;
            DlgResult = new JsonResult("{}");
        }

        private void EnterprisePrjDlg_Load(object sender, EventArgs e) {
            cbbBonusPeriod.BindTo(BONUS_PERIODS);

            if (PrjReadOnly)
                this.Text = "查看-" + m_pId;
            else
                this.Text = "修改-" + m_pId;


            tbItemNo.ReadOnly = true;
            tbTotalInterest.ReadOnly = true;
            btnOk.Enabled = true;
            btnCancel.Enabled = true;
            btnDelayCollect.Enabled = true;
            btnBonusList.Enabled = true;
            btnAddAllowInvestors.Enabled = true;

            dataGridView2.Enabled = true;
            dataGridView3.Enabled = true;
            dataGridView4.Enabled = true;
            nudInvestMaxAmtRatio.Enabled = false;
            nudInvestMaxAmt.Enabled = false;
            nudPerInvestMaxAmt.Enabled = false;

            cbbPrjType.BindTo(Projects.PrjProperty);
            cbbPrjType.Enabled = false;
            UpdateData1();
            UpdateData3();
            UpdateData4();
            UpdateData5();
            UpdateData6();
            UpdateData7();
            UpdateData8();
            UpdateData9();
        }

        private async void UpdateData1() {
            var r = await Projects.Prj(m_pId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                tbItemName.Text = d.GetOrDefault<string>("itemName");
                tbItemShowName.Text = d.GetOrDefault<string>("itemShowName");
                tbItemNo.Text = d.GetOrDefault<string>("itemNo");
                tbDeputy.Text = d.GetOrDefault<string>("outProxy");
                tbFinanceManager.Text = d.GetOrDefault<string>("inProxy");
                tbFinancier.Text = d.GetOrDefault<string>("financier");
                tbPrjSource.Text = d.GetOrDefault<string>("src");
                nudAmt.SetValue(d.GetOrDefault<decimal>("amt"));
                nudPerInvestMaxAmt.Maximum = nudAmt.Value;
                nudRate.SetValue(d.GetOrDefault<decimal>("rate"));
                nudSellRate.SetValue(d.GetOrDefault<decimal>("soldFee"));
                nudExtensionRate.SetValue(d.GetOrDefault<decimal>("extensionRate"));
                nudTimeoutRate.SetValue(d.GetOrDefault<decimal>("timeOutRate"));
                nudPenaltyRatio.SetValue(d.GetOrDefault<decimal>("penaltyRation"));
                nudBorrowDays.SetValue(d.GetOrDefault<decimal>("borrowDays"));
                nudExtensionDay.SetValue(d.GetOrDefault<decimal>("extensionDays"));
                nudBuyRate.SetValue(d.GetOrDefault<decimal>("costFee"));
                ckbNormalEqualSell.Checked = nudRate.Value == nudSellRate.Value;
                dtpInTime.Value = Commons.FromTimestamp(d.GetOrDefault<long>("inTime"));
                dtpOutTime.Value = Commons.FromTimestamp(d.GetOrDefault<long>("outTime"));
                ckbInEqualOut.Checked = dtpInTime.Value.Date == dtpOutTime.Value.Date;
                nudFinanceDays.SetValue(d.GetOrDefault<decimal>("financingDays"));
                dtpExpecteBorTime.Value = Commons.FromTimestamp(d.GetOrDefault<long>("expectedBorrowTime"));
                nudPerInvestMinAmt.SetValue(d.GetOrDefault<decimal>("perInvestMinAmt"));
                nudPerInvestAmt.SetValue(d.GetOrDefault<decimal>("perInvestAmt"));
                nudFeeRate.SetValue(d.GetOrDefault<decimal>("feeRate"));
                cbbPrjType.SetSelectedValue(d.GetOrDefault<string>("type"));
                visible = d.GetOrDefault<bool>("visible");
                var investMaxAmtRatio = d.GetOrDefault<decimal>("investMaxAmtRatio");
                var investMaxAmt = d.GetOrDefault<decimal>("investMaxAmt");
                var perMaxMoney = d.GetOrDefault<decimal>("perInvestMaxAmt");
                if (investMaxAmtRatio > 0) {
                    ckbLimitMoneyRate.Checked = true;
                    nudInvestMaxAmtRatio.SetValue(investMaxAmtRatio);
                }
                if (investMaxAmt > 0) {
                    ckbLimitMoney.Checked = true;
                    nudInvestMaxAmt.SetValue(investMaxAmt);
                }
                if (perMaxMoney > 0) {
                    ckbPerMaxMoney.Checked = true;
                    nudPerInvestMaxAmt.SetValue(perMaxMoney);
                }

                UpdateTotalInterest();

                var contract = d.GetOrDefault<int>("contract");
                ckbContract1.Checked = Convert.ToBoolean(contract & 1);
                ckbContract2.Checked = Convert.ToBoolean(contract & 2);
                ckbContract4.Checked = Convert.ToBoolean(contract & 4);
                ckbContract8.Checked = Convert.ToBoolean(contract & 8);
                tbKeys.Text = d.GetOrDefault<string>("key");

                var flags = d.GetOrDefault<int>("flags");
                ckbFlagNewer.Checked = Convert.ToBoolean(flags & 0x0001);
                ckbFlagJcb.Checked = Convert.ToBoolean(flags & 0x0010);
                ckbFlagBx.Checked = Convert.ToBoolean(flags & 0x0040);

                cbbWaterMark.Text = d.GetOrDefault<string>("waterMark");

                btnDelayCollect.Enabled = d.GetOrDefault<int>("status") == 40;
                tbRemark.Text = d.GetOrDefault<string>("remark");
                if (m_pId == 0)
                    btnDelayCollect.Visible = false;
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void UpdateData3() {
            var r = await Projects.Financier(m_pId);
            if (r.IsOk) {
                var dl = JArray.Parse(r.AsString).ToList();
                foreach (var d in dl) {
                    var roleType = d["roleType"].ToStdString();
                    string userType = d["userType"].ToStdString();
                    string name = userType == "1" ? d["realName"].ToStdString() : d["orgName"].ToStdString();
                    switch (roleType) {
                        case "1":
                            m_borId = d["auId"].ToInt64();
                            tbBor.Text = mapBorName(userType, name);
                            break;
                        case "2":
                            m_nominalBorId = d["auId"].ToInt64();
                            tbNominalBor.Text = mapBorName(userType, name);
                            break;
                        case "3":
                            m_sponsorId = d["auId"].ToInt64();
                            tbSponsor.Text = mapBorName(userType, name);
                            break;
                    }
                }
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private string mapBorName(string type, string name) {
            switch (type) {
                case "1":
                    return "(个人)" + name;
                case "2":
                    return "(机构)" + name;
                default:
                    return name;
            }
        }

        private async void UpdateData4() {
            var r = await Projects.Rating(m_pId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                cbbPrjRating.SetSelectedValue(d.GetOrDefault<string>("prjRating"));
                nudSAll.SetValue(d.GetOrDefault<decimal>("sAll"));
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void UpdateData5() {
            var r = await Projects.BonusPeriod(m_pId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                cbbBonusPeriod.SetSelectedValue(d.GetOrDefault<string>("bonusPeriod"));
                var date = d.GetOrDefault<decimal>("bonusDay");
                nudBonusDay.Value = date == 0 ? 1 : date;
                UpdateBonusDay();
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void UpdateData6() {
            var r = await Projects.GuaranteeOrgGet(m_pId);
            if (r.IsOk) {
                myGridViewBinding2.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void UpdateData7() {
            var r = await Projects.BorrowPerGet(m_pId);
            if (r.IsOk) {
                myGridViewBinding3.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void UpdateData8() {
            var r = await Projects.BorrowOrgGet(m_pId);
            if (r.IsOk) {
                myGridViewBinding4.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void UpdateData9() {
            var r = await Projects.GuaranteePerGet(m_pId);
            if (r.IsOk) {
                myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private void UpdateTotalInterest() {
            tbTotalInterest.Text = string.Format("{0:F2}", nudAmt.Value / 100 * nudRate.Value / 365 * nudBorrowDays.Value);
        }

        private void UpdateBonusDay() {
            if (PrjReadOnly)
                return;
            var p = cbbBonusPeriod.GetSelectedValue();
            switch (p) {
                case "2":
                case "3":
                    btnBonusList.Enabled = true;
                    nudBonusDay.Enabled = true;
                    break;
                default:
                    btnBonusList.Enabled = true;
                    nudBonusDay.Enabled = false;
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }

        private async void SaveData() {
            if (PrjReadOnly)
                return;

            if (m_borId == 0 || m_borId == -1) {
                Commons.ShowInfoBox(this, "必须选择一个借款人帐户");
                return;
            }

            btnOk.Enabled = false;

            var r = new Dictionary<string, object>();
            r["pid"] = m_pId;
            r["item-name"] = tbItemName.Text.Trim();
            r["item-show-name"] = tbItemShowName.Text.Trim();
            r["item-no"] = tbItemNo.Text.Trim();
            r["out-proxy"] = tbDeputy.Text.Trim();
            r["in-proxy"] = tbFinanceManager.Text.Trim();
            r["financier"] = tbFinancier.Text.Trim();
            r["src"] = tbPrjSource.Text.Trim();
            r["amt"] = nudAmt.Value;
            r["rate"] = nudRate.Value;
            r["extension-rate"] = nudExtensionRate.Value;
            r["time-out-rate"] = nudTimeoutRate.Value;
            r["penalty-ratio"] = nudPenaltyRatio.Value;
            r["borrow-days"] = (int)nudBorrowDays.Value;
            r["extension-days"] = (int)nudExtensionDay.Value;
            r["cost-fee"] = nudBuyRate.Value;
            r["sold-fee"] = nudSellRate.Value;
            r["in-time"] = dtpInTime.Value;
            r["out-time"] = dtpOutTime.Value;
            r["financing-days"] = (int)nudFinanceDays.Value;
            r["expected-borrow-time"] = dtpExpecteBorTime.Value;
            r["per-invest-min-amt"] = nudPerInvestMinAmt.Value;
            r["per-invest-amt"] = nudPerInvestAmt.Value;
            r["fee-rate"] = nudFeeRate.Value;
            r["visible"] = visible;
            if (ckbLimitMoneyRate.Checked)
                r["invest-max-amt-ratio"] = nudInvestMaxAmtRatio.Value;
            if (ckbLimitMoney.Checked)
                r["invest-max-amt"] = nudInvestMaxAmt.Value;
            if (ckbPerMaxMoney.Checked)
                r["per-invest-max-amt"] = nudPerInvestMaxAmt.Value;
            r["contract"] = (ckbContract1.Checked ? 1 : 0) |
                (ckbContract2.Checked ? 2 : 0) |
                (ckbContract4.Checked ? 4 : 0) |
                (ckbContract8.Checked ? 8 : 0);


            r["key"] = tbKeys.Text.Trim();
            r["water-mark"] = cbbWaterMark.Text.Trim();
            r["type"] = cbbPrjType.GetSelectedValue();
            long flags = 0;
            if (ckbFlagNewer.Checked)
                flags |= 0x0001;
            if (ckbFlagJcb.Checked)
                flags |= 0x0010;
            if (ckbFlagBx.Checked)
                flags |= 0x0040;

            r["flags"] = flags;
            r["remark"] = tbRemark.Text.Trim();

            var p1 = await Projects.Update(r);
            if (!p1.IsOk) {
                Commons.ShowResultErrorBox(this, p1);
                btnOk.Enabled = true;
                return;
            } else {
                DlgResult = p1;
            }

            r.Clear();
            r["pid"] = m_pId;
            r["financier-cu-id"] = m_borId;
            var p3 = await Projects.SaveFinancier(r);
            if (!p3.IsOk) {
                Commons.ShowResultErrorBox(this, p3);
                btnOk.Enabled = true;
                return;
            }

            r.Clear();
            r["pid"] = m_pId;
            r["nominal-au-id"] = m_nominalBorId;
            r["bondsman-au-id"] = m_sponsorId;
            var p4 = await Projects.SaveNorminalBor(r);
            if (!p4.IsOk) {
                Commons.ShowResultErrorBox(this, p4);
                btnOk.Enabled = true;
                return;
            }

            r.Clear();
            r["pid"] = m_pId;
            r["prj-rating"] = cbbPrjRating.Text.Trim();
            r["s-all"] = (int)nudSAll.Value;
            var p5 = await Projects.SaveRating(r);
            if (!p5.IsOk) {
                Commons.ShowResultErrorBox(this, p5);
                btnOk.Enabled = true;
                return;
            }

            r.Clear();
            r["pid"] = m_pId;
            r["bonus-period"] = cbbBonusPeriod.GetSelectedValue();
            if (nudBonusDay.Enabled) {
                r["bonus-day"] = (int)nudBonusDay.Value;
            }
            var p6 = await Projects.SaveBonusPeriod(r);
            if (!p6.IsOk) {
                Commons.ShowResultErrorBox(this, p6);
                btnOk.Enabled = true;
                return;
            }
            btnOk.Enabled = true;
            DialogResult = DialogResult.OK;

        }

        private void cbbBonusPeriod_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateBonusDay();
        }

        private void btnSelBor_Click(object sender, EventArgs e) {
            var dlg = new SelPrjBorDlg(m_borId, SelPrjBorDlg.BorType.Borrow);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_borId = dlg.SelBorId;
                tbBor.Text = mapBorName(dlg.SelType, dlg.SelBorName);
            }
        }

        private void btnSelNominalBor_Click(object sender, EventArgs e) {
            var dlg = new SelPrjBorDlg(m_nominalBorId, SelPrjBorDlg.BorType.Borrow2);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_nominalBorId = dlg.SelBorId;
                tbNominalBor.Text = mapBorName(dlg.SelType, dlg.SelBorName);
            }
        }

        private void btnSelSponsor_Click(object sender, EventArgs e) {
            var dlg = new SelPrjBorDlg(m_sponsorId, SelPrjBorDlg.BorType.Guarantor);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_sponsorId = dlg.SelBorId;
                tbSponsor.Text = mapBorName(dlg.SelType, dlg.SelBorName);
            }
        }

        private void btnClrNominalBor_Click(object sender, EventArgs e) {
            m_nominalBorId = 0;
            tbNominalBor.Clear();
        }

        private void btnClrSponsor_Click(object sender, EventArgs e) {
            m_sponsorId = 0;
            tbSponsor.Clear();
        }

        private void btnBonusList_Click(object sender, EventArgs e) {
            var dlg = new PreviewBonusDlg(m_pId, Convert.ToInt32(cbbBonusPeriod.GetSelectedValue()),
                Convert.ToInt32(nudBonusDay.Value));
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnDelayCollect_Click(object sender, EventArgs e) {
            UpdateBorrowTime();
        }

        private async void UpdateBorrowTime() {
            var newBorrowTime = Commons.ShowDateTimeInputDialog(this, dtpExpecteBorTime.Value, "新的截止时间:", "延期募集", 200);

            var r = new Dictionary<string, object>();
            r["pid"] = m_pId;
            r["datepoint"] = newBorrowTime;
            var p = await Projects.UpdateDelayDate(r);
            if (p.IsOk) {
                UpdateData1();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void ckbNormalEqualSell_CheckedChanged(object sender, EventArgs e) {
            if (ckbNormalEqualSell.Checked) {
                nudSellRate.SetValue(nudRate.Value);
                nudSellRate.Enabled = false;
            } else {
                nudSellRate.Enabled = true;
            }
        }

        private void nudMoneyRate_ValueChanged(object sender, EventArgs e) {
            if (ckbNormalEqualSell.Checked)
                nudSellRate.SetValue(nudRate.Value);
            UpdateTotalInterest();
        }

        private void nudAmt_ValueChanged(object sender, EventArgs e) {
            nudPerInvestMaxAmt.Maximum = nudAmt.Value;
            UpdateTotalInterest();
        }

        private void nudBorrowDays_ValueChanged(object sender, EventArgs e) {
            UpdateTotalInterest();
        }

        private void ckbInEqualOut_CheckedChanged(object sender, EventArgs e) {
            if (ckbInEqualOut.Checked) {
                dtpOutTime.Value = dtpInTime.Value;
                dtpOutTime.Enabled = false;
            } else {
                dtpOutTime.Enabled = true;
            }
        }

        private void dtpInTime_ValueChanged(object sender, EventArgs e) {
            if (ckbInEqualOut.Checked)
                dtpOutTime.Value = dtpInTime.Value;
        }

        private void UpdateExpectedBorrowTime() {
            dtpExpecteBorTime.Value = dtpOutTime.Value.AddDays(Convert.ToDouble(nudFinanceDays.Value));
        }

        private void dtpOutTime_ValueChanged(object sender, EventArgs e) {
            UpdateExpectedBorrowTime();
        }

        private void nudFinanceDays_ValueChanged(object sender, EventArgs e) {
            UpdateExpectedBorrowTime();
        }

        private void ckbLimitMoneyRate_CheckedChanged(object sender, EventArgs e) {
            if (ckbLimitMoneyRate.Checked) {
                nudInvestMaxAmtRatio.Enabled = true;
            } else {
                nudInvestMaxAmtRatio.SetValue(nudInvestMaxAmtRatio.Minimum);
                nudInvestMaxAmtRatio.Enabled = false;
            }
        }

        private void ckbLimitMoney_CheckedChanged(object sender, EventArgs e) {
            if (ckbLimitMoney.Checked) {
                nudInvestMaxAmt.Enabled = true;
            } else {
                nudInvestMaxAmt.SetValue(nudInvestMaxAmt.Minimum);
                nudInvestMaxAmt.Enabled = false;
            }
        }

        private void btnGuaranteeOrgCrt_Click(object sender, EventArgs e) {
            var dlg = new CreatePrjEntGuaranteeOrgDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK)
                myGridViewBinding2.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "pgoId");
        }

        private void myGridViewBinding2_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (PrjReadOnly)
                return;
            btnGuaranteeOrgDel.Enabled = e.SelectedRowIndex.Length > 0;
        }

        private async void DeleteGuaranteeOrgs(IList<long> idArray) {
            btnGuaranteeOrgDel.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下担保机构：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await Projects.GuaranteeOrgDel(m_pId, id);
                    if (p.IsOk) {
                        myGridViewBinding2.BindTo(p, Commons.BindFlag.Delete, "pgoId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                Commons.ShowInfoBox(this, "担保机构：" + ss + " 已被删除。");
            }
            btnGuaranteeOrgDel.Enabled = true;
        }

        private void btnGuaranteeOrgDel_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding2.GetSelectedValues<long>("pgoId").ToList();
            if (idArray.Count > 0) {
                DeleteGuaranteeOrgs(idArray);
            }
        }

        private void btnBorPerCrt_Click(object sender, EventArgs e) {
            var dlg = new CreatePrjEntBorPerDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding3.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "bpmpId");
            }
        }

        private void myGridViewBinding3_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (PrjReadOnly)
                return;
            btnBorPerDel.Enabled = e.SelectedRowIndex.Length > 0;
        }

        private async void DeleteBorPer(IList<long> idArray) {
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下借款人：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await Projects.BorrowPerDel(m_pId, id);
                    if (p.IsOk) {
                        myGridViewBinding3.BindTo(p, Commons.BindFlag.Delete, "bpmpId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                Commons.ShowInfoBox(this, "借款人：" + ss + " 已被删除。");
            }
        }

        private void btnBorPerDel_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding3.GetSelectedValues<long>("bpmpId").ToList();
            if (idArray.Count > 0) {
                DeleteBorPer(idArray);
            }
        }

        private void btnBorOrgCrt_Click(object sender, EventArgs e) {
            var dlg = new CreatePrjEntBorOrgDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding4.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "bpmoId");
            }
        }

        private void myGridViewBinding4_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (PrjReadOnly)
                return;
            btnBorOrgDel.Enabled = e.SelectedRowIndex.Length > 0;
        }

        private async void DeleteBorOrg(IList<long> idArray) {
            btnBorOrgDel.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下借款机构：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await Projects.BorrowOrgDel(m_pId, id);
                    if (p.IsOk) {
                        myGridViewBinding4.BindTo(p, Commons.BindFlag.Delete, "bpmoId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                Commons.ShowInfoBox(this, "借款机构：" + ss + " 已被删除。");
            }
            btnBorOrgDel.Enabled = true;
        }

        private void btnBorOrgDel_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding4.GetSelectedValues<long>("bpmoId").ToList();
            if (idArray.Count > 0) {
                DeleteBorOrg(idArray);
            }
        }

        private void btnAddAllowInvestors_Click(object sender, EventArgs e) {
            var dlg = new AllowInvestorsDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            //dlg.ReadOnly = PrjReadOnly;
            dlg.ShowDialog(this);
        }

        private void ckbPerMaxMoney_CheckedChanged(object sender, EventArgs e) {
            if (ckbPerMaxMoney.Checked) {
                nudPerInvestMaxAmt.Enabled = true;
            } else {
                nudPerInvestMaxAmt.Enabled = false;
            }
        }

        private void btnGuaranteePerCrt_Click(object sender, EventArgs e) {
            var dlg = new CreatePrjEntGuaranteePerDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK)
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "pgpId");
        }

        private async void DeleteGuaranteePers(IList<long> idArray) {
            btnGuaranteePerDel.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下担保人：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await Projects.GuaranteePerDel(m_pId, id);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "pgpId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }
                Commons.ShowInfoBox(this, "担保人：" + ss + " 已被删除。");
            }
            btnGuaranteePerDel.Enabled = true;
        }

        private void btnGuaranteePerDel_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<long>("pgpId").ToList();
            if (idArray.Count > 0) {
                DeleteGuaranteePers(idArray);
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (PrjReadOnly)
                return;
            btnGuaranteePerDel.Enabled = e.SelectedRowIndex.Length > 0;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "visible") {
                e.Value = VISIBLE.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void myGridViewBinding2_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "visible") {
                e.Value = VISIBLE.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void myGridViewBinding3_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "visible") {
                e.Value = VISIBLE.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void myGridViewBinding4_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "visible") {
                e.Value = VISIBLE.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void btnBillFiles_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(m_pId, 31, AcceptFilter.Pdf);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

    }
}
