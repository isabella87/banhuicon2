using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    public partial class DailyStatisticDlg : Form {
        private static readonly IList<Tuple<string, string, string, string>> m_allData;

        static DailyStatisticDlg() {
            m_allData = new List<Tuple<string, string, string, string>>();
            m_allData.Add(Tuple.Create("新增投资人数", "newInvestCount", "", ""));
            m_allData.Add(Tuple.Create("当日注册人数", "newRegCount", "总注册人数", "totalRegCount"));
            m_allData.Add(Tuple.Create("当日充值人数(仅投资人)", "rechargeCountInvestor", "总充值人数(仅投资人)", "totalRechargeCountInvestor"));
            m_allData.Add(Tuple.Create("当日充值人数(其它)", "rechargeCountOther", "总充值人数(其它)", "totalRechargeCountOther"));
            m_allData.Add(Tuple.Create("当日提现人数(仅投资人)", "withdrawCountInvestor", "总提现人数(仅投资人)", "totalWithdrawCountInvestor"));
            m_allData.Add(Tuple.Create("当日提现人数(其它)", "withdrawCountOther", "总提现人数(其它)", "totalWithdrawCountOther"));
            m_allData.Add(Tuple.Create("当日投资人数", "investCount", "总投资人数", "totalInvestCount"));
            m_allData.Add(Tuple.Create("当日充值金额(仅投资人)", "rechargeAmtInvestor", "总充值金额(仅投资人)", "totalRechargeAmtInvestor"));
            m_allData.Add(Tuple.Create("当日充值金额(其它)", "rechargeAmtOther", "总充值金额(其它)", "totalRechargeAmtOther"));
            m_allData.Add(Tuple.Create("当日提现金额(仅投资人)", "withdrawAmtInvestor", "总提现金额(仅投资人)", "totalWithdrawAmtInvestor"));
            m_allData.Add(Tuple.Create("当日提现金额(其它)", "withdrawAmtOther", "总提现金额(其它)", "totalWithdrawAmtOther"));
            m_allData.Add(Tuple.Create("当日投资金额", "investAmt", "总投资金额", "totalInvestAmt"));
            m_allData.Add(Tuple.Create("当日债权转让成交金额", "creditAmt", "总债权转让成交金额", "totalCreditAmt"));
            m_allData.Add(Tuple.Create("", "", "借款余额", "loanBalanceAmt"));
            m_allData.Add(Tuple.Create("当日还款服务费", "repayFeeAmt", "总还款服务费", "totalRepayFeeAmt"));
            m_allData.Add(Tuple.Create("当日债权转让服务费", "creditFeeAmt", "总债权转让服务费", "totalCreditFeeAmt"));
            m_allData.Add(Tuple.Create("当日个人平均借款额度", "personAverageBorrowAmt", "历史个人平均借款总额", "totalPersonAverageBorrowAmt"));
            m_allData.Add(Tuple.Create("当日机构平均借款额度", "orgAverageBorrowAmt", "历史机构平均借款总额", "totalOrgAverageBorrowAmt"));
        }

        public DailyStatisticDlg() {
            InitializeComponent();
        }

        private void DailyStatisticDlg_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(dtpSearchDate, toolStripLabel1);
            dtpSearchDate.Value = DateTime.Now.AddDays(-1);

            UpdateTable1(true);
        }

        private void UpdateTable1(bool initial) {
            var allData = new Dictionary<string, object>();

            if (!initial) {
                btnSearch.Enabled = false;
                wbInvestorsInfo.DocumentText = "";
                var r = new Dictionary<string, object>();
                r["datepoint"] = dtpSearchDate.Value.AddDays(1).TruncToStart();
                var dlg = new BatchProcessMultipleServers();
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.DailyStatistic1(r); });
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.DailyStatistic2(r); });
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.DailyStatistic3(r); });
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.DailyStatistic4(r); });
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.DailyStatistic5(r); });
                dlg.ShowDialog();

                foreach (var d in dlg.AllResult) {
                    if (d.IsOk) {
                        Commons.DictionaryAddResult(allData, d);
                    }
                }
            }

            string info = "<p>人数单位：个，金额单位：元</p>";
            info += "<table border=1 cellspacing=0 align=center>";
            for (int row = 0; row < m_allData.Count; ++row) {
                info += string.Format("<tr><td {0} {1}><b>&nbsp;{3}</b></td><td {0} {2}>&nbsp;{4}</td> <td {0} {1}><b>&nbsp;{5}</b></td><td {0} {2}>&nbsp;{6}</td></tr>",
                    "align=center valign=middle", "width=210", "width=110",
                    m_allData[row].Item1, allData.GetOrDefault<string>(m_allData[row].Item2),
                    m_allData[row].Item3, allData.GetOrDefault<string>(m_allData[row].Item4));
            }
            info += "</table>";

            info += string.Format(@"<p> </p>
                    <dl><dt>投资注册人数:</dt>
                    <dd>第一次投资时间在{0}的人数</dd></dl>
                    <dl><dt>新增注册人数:</dt>
                    <dd>注册时间在{0}的人数</dd></dl>
                    <dl><dt>提现人数:</dt>
                    <dd>在{0}曾经成功提现的人数(分为投资人和其他两类)</dd></dl>
                    <dl><dt>充值人数:</dt>
                    <dd>在{0}曾经成功充值的人数(分为投资人和其他两类)</dd></dl>
                    <dl><dt>投资人数:</dt>
                    <dd>在{0}曾经成功投资的人数</dd></dl>
                    <dl><dt>提现金额:</dt>
                    <dd>在{0}曾经成功提现的总金额(分为投资人和其他两类)</dd></dl>
                    <dl><dt>充值金额:</dt>
                    <dd>在{0}曾经成功充值的总金额(分为投资人和其他两类)</dd></dl>
                    <dl><dt>投资金额:</dt>
                    <dd>在{0}曾经成功投资的总金额</dd></dl>
                    <dl><dt>债权转让成交金额:</dt>
                    <dd>在{0}曾经成功转让的标价总额</dd></dl>
                    <dl><dt>借款余额:</dt>
                    <dd>新系统截止到统计日期结束的总放款-总还本</dd></dl>"
                , "指定日的00:00:00到指定日的23:59:59之间");

            wbInvestorsInfo.DocumentText = info;

            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1(false);
        }
    }
}
