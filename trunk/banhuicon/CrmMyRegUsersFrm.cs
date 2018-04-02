using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Crm;
    using MyLib.UI;
    public partial class CrmMyRegUsersFrm : Form, IHasGridDataTable {
        private string m_selUName;

        public CrmMyRegUsersFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void CrmMyRegUsersFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(dtpSearchDate, toolStripLabel2);

            cbbAge.ComboBox.BindTo(CrmCommons.Ages, ExtraItems.AddAll);
            cbbGender.ComboBox.BindTo(Commons.Genders, ExtraItems.AddAll);
            cbbAccType.ComboBox.BindTo(CrmCommons.CustomerTypes, ExtraItems.AddAll);
            cbbAccStatus.ComboBox.BindTo(CrmCommons.JxUserStatus, ExtraItems.AddAll);

            m_selUName = "+";
            tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.SELF_TEXT);
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private async void UpdateTable() {
            if (CrmCommons.IsAll(m_selUName) && string.IsNullOrWhiteSpace(tbKeys.Text)) {
                Commons.ShowInfoBox(this, "请输入关键字");
                return;
            }
            btnSearch.Enabled = false;
            var age = cbbAge.ComboBox.GetSelectedValue();
            var gender = cbbGender.ComboBox.GetSelectedValue();
            var userType = cbbAccType.ComboBox.GetSelectedValue();
            var status = cbbAccStatus.ComboBox.GetSelectedValue();

            var d = new Dictionary<string, object>();
            d["u-name"] = m_selUName;
            d["search-key"] = tbKeys.Text.Trim();
            if (age != Commons.AllValue)
                d["age"] = age;
            if (gender != Commons.AllValue)
                d["gender"] = gender;
            if (userType != Commons.AllValue)
                d["user-type"] = userType;
            if (status != Commons.AllValue)
                d["jx-status"] = status;

            var p = await CrmInvestor.MyRegUsers(d);
            if (p.IsOk) {
                myGridViewBinding1.DataTable.Clear();
                var ids = p.AsList;
                if (ids.Count == 0) {
                    myGridViewBinding1.DataTable = null;
                    btnSearch.Enabled = true;
                    return;
                }
                var dlg = new BatchProcessDlg(ids.Select<object, long>(o => Convert.ToInt64(o)).ToList());
                dlg.StartPosition = FormStartPosition.CenterParent;
                var d2 = new Dictionary<string, object>();
                d2["datepoint"] = dtpSearchDate.Value;

                var todayInvestAmt = 0M;
                var todayRepayCapitalAmt = 0M;
                var todayRechargeAmt = 0M;
                var todayWithdrawAmt = 0M;
                var investRemainAmt = 0M;
                var investCount = 0L;
                var sumInvestAmt = 0M;

                dlg.RunSingle += (id) => {
                    var m = CrmInvestor.MyRegUserDetail(id, d2).Result;
                    myGridViewBinding1.BindTo(m, Commons.BindFlag.Update, "auId");

                    var dic = m.AsDictionary;
                    todayInvestAmt += Convert.ToDecimal(dic["todayInvestAmt"]);
                    todayRepayCapitalAmt += Convert.ToDecimal(dic["todayRepayCapitalAmt"]);
                    todayRechargeAmt += Convert.ToDecimal(dic["todayRechargeAmt"]);
                    todayWithdrawAmt += Convert.ToDecimal(dic["todayWithdrawAmt"]);
                    investRemainAmt += Convert.ToDecimal(dic["investRemainAmt"]);
                    investCount += Convert.ToInt64(dic["investCount"]);
                    sumInvestAmt += Convert.ToDecimal(dic["sumInvestAmt"]);

                    return m;
                };
                dlg.ShowDialog();

                var sumRow = new List<object>();
                //ID
                sumRow.Add("");
                //用户名
                sumRow.Add("<总计>");
                //姓名
                sumRow.Add("");
                //性别
                sumRow.Add(0L);
                //年龄
                sumRow.Add(null);
                //手机
                sumRow.Add("");
                //注册时间
                sumRow.Add(null);
                //类型
                sumRow.Add(null);
                //状态
                sumRow.Add(null);
                //分配时间
                sumRow.Add(null);
                //投资
                sumRow.Add(todayInvestAmt);
                //还本
                sumRow.Add(todayRepayCapitalAmt);
                //充值
                sumRow.Add(todayRechargeAmt);
                //提现
                sumRow.Add(todayWithdrawAmt);
                //投资余额
                sumRow.Add(investRemainAmt);
                //当月投资次数
                sumRow.Add(investCount);
                //累计投资额
                sumRow.Add(sumInvestAmt);
                //绑卡时间
                sumRow.Add(null);

                myGridViewBinding1.DataTable.Add(sumRow);
                myGridViewBinding1.InvalidateView();
                //var dl = new JArray();
                //var temp = new List<string>();
                //foreach (var result in dlg.AllResult) {
                //    dl.Add(JObject.Parse(result.AsString));
                //}
                //var sum = new JObject();
                //sum["auId"] = "统计";
                //sum["gender"] = 0;
                //sum["todayInvestAmt"] = 0;
                //sum["todayRepayCapitalAmt"] = 0;
                //sum["todayRechargeAmt"] = 0;
                //sum["todayWithdrawAmt"] = 0;
                //sum["investCount"] = 0;
                //sum["investRemainAmt"] = 0;
                //sum["sumInvestAmt"] = 0;
                //foreach (var l in dl) {
                //    foreach (var j in sum) {
                //        sum[j.Key] = j.Value.ToDecimal() + l[j.Key].ToDecimal();
                //    }
                //}

                // dl.Add(sum);

                //myGridViewBinding1.BindTo(new JsonResult(dl.ToString()));

            } else {
                Commons.ShowResultErrorBox(this, p);
            }

            btnSearch.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            btnAccInfo.Enabled = e.SelectedRowIndex.Length == 1;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "userType") {
                e.Value = CrmCommons.CustomerTypes.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "jxStatus") {
                e.Value = CrmCommons.JxUserStatus.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "gender") {
                e.Value = Commons.Genders.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "age") {
                e.Value = Convert.ToInt32(e.Value) == 0 ? "" : e.Value;
            }
        }

        private void btnAccInfo_Click(object sender, EventArgs e) {
            if (myGridViewBinding1.GetSelectedValues<long>("userType").FirstOrDefault() == 1) {
                var dlg = new AccPersonDlg(myGridViewBinding1.GetSelectedValues<long>("auId").FirstOrDefault());
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ShowDialog();
            } else {
                var dlg = new AccOrgDlg(myGridViewBinding1.GetSelectedValues<long>("auId").FirstOrDefault());
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ShowDialog();
            }
        }

        private void btnSelMgr_Click(object sender, EventArgs e) {
            var dlg = new CrmSelMgrDlg((int)CrmCommons.ExtraItem.AddAll | (int)CrmCommons.ExtraItem.AddSelf);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.SelManager = m_selUName;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_selUName = dlg.SelManager;
                if (CrmCommons.IsAll(m_selUName)) {
                    tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.ALL_TEXT);
                } else if (CrmCommons.IsNone(m_selUName)) {
                    tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.NONE_TEXT);
                } else if (CrmCommons.IsSelf(m_selUName)) {
                    tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.SELF_TEXT);
                } else {
                    tbOpUser.Text = dlg.SelManager;
                }
            }
        }


    }
}
