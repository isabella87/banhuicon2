using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    using Excel;
    using StatisticsCell = Tuple<string, Excel.CellStyleCustom>;
    using StatisticsRow = List<Tuple<string, Excel.CellStyleCustom>>;

    public partial class MonthStatisticDlg : Form {
        private static readonly IList<StatisticsRow> m_model;

        static MonthStatisticDlg() {
            m_model = new List<StatisticsRow>()
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("新增投资人数", CellStyleCustom.Text)).Add2(Tuple.Create("newInvestCount", CellStyleCustom.Integer))
                                                     .Add2(Tuple.Create("", CellStyleCustom.Text)).Add2(Tuple.Create("", CellStyleCustom.Text)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月注册人数", CellStyleCustom.Text)).Add2(Tuple.Create("newRegCount", CellStyleCustom.Integer))
                                                     .Add2(Tuple.Create("总注册人数", CellStyleCustom.Text)).Add2(Tuple.Create("totalRegCount", CellStyleCustom.Integer)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月充值人数(仅投资人)", CellStyleCustom.Text)).Add2(Tuple.Create("rechargeCountInvestor", CellStyleCustom.Integer))
                                                     .Add2(Tuple.Create("总充值人数(仅投资人)", CellStyleCustom.Text)).Add2(Tuple.Create("totalRechargeCountInvestor", CellStyleCustom.Integer)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月充值人数(其它)", CellStyleCustom.Text)).Add2(Tuple.Create("rechargeCountOther", CellStyleCustom.Integer))
                                                     .Add2(Tuple.Create("总充值人数(其它)", CellStyleCustom.Text)).Add2(Tuple.Create("totalRechargeCountOther", CellStyleCustom.Integer)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月提现人数(仅投资人)", CellStyleCustom.Text)).Add2(Tuple.Create("withdrawCountInvestor", CellStyleCustom.Integer))
                                                     .Add2(Tuple.Create("总提现人数(仅投资人)", CellStyleCustom.Text)).Add2(Tuple.Create("totalWithdrawCountInvestor", CellStyleCustom.Integer)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月提现人数(其它)", CellStyleCustom.Text)).Add2(Tuple.Create("withdrawCountOther", CellStyleCustom.Integer))
                                                     .Add2(Tuple.Create("总提现人数(其它)", CellStyleCustom.Text)).Add2(Tuple.Create("totalWithdrawCountOther", CellStyleCustom.Integer)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月投资人数", CellStyleCustom.Text)).Add2(Tuple.Create("investCount", CellStyleCustom.Integer))
                                                     .Add2(Tuple.Create("总投资人数", CellStyleCustom.Text)).Add2(Tuple.Create("totalInvestCount", CellStyleCustom.Integer)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月借款人数", CellStyleCustom.Text)).Add2(Tuple.Create("borrowerCount", CellStyleCustom.Integer))
                                                     .Add2(Tuple.Create("总借款人数", CellStyleCustom.Text)).Add2(Tuple.Create("totalBorrowerCount", CellStyleCustom.Integer)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月充值金额(仅投资人)", CellStyleCustom.Text)).Add2(Tuple.Create("rechargeAmtInvestor", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("总充值金额(仅投资人)", CellStyleCustom.Text)).Add2(Tuple.Create("totalRechargeAmtInvestor", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月充值金额(其它)", CellStyleCustom.Text)).Add2(Tuple.Create("rechargeAmtOther", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("总充值金额(其它)", CellStyleCustom.Text)).Add2(Tuple.Create("totalRechargeAmtOther", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月提现金额(仅投资人)", CellStyleCustom.Text)).Add2(Tuple.Create("withdrawAmtInvestor", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("总提现金额(仅投资人)", CellStyleCustom.Text)).Add2(Tuple.Create("totalWithdrawAmtInvestor", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月提现金额(其它)", CellStyleCustom.Text)).Add2(Tuple.Create("withdrawAmtOther", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("总提现金额(其它)", CellStyleCustom.Text)).Add2(Tuple.Create("totalWithdrawAmtOther", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月投资金额", CellStyleCustom.Text)).Add2(Tuple.Create("investAmt", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("总投资金额", CellStyleCustom.Text)).Add2(Tuple.Create("totalInvestAmt", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月债权转让成交金额", CellStyleCustom.Text)).Add2(Tuple.Create("creditAmt", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("总债权转让成交金额", CellStyleCustom.Text)).Add2(Tuple.Create("totalCreditAmt", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("", CellStyleCustom.Text)).Add2(Tuple.Create("", CellStyleCustom.Text))
                                                     .Add2(Tuple.Create("借款余额", CellStyleCustom.Text)).Add2(Tuple.Create("loanBalanceAmt", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月还款服务费", CellStyleCustom.Text)).Add2(Tuple.Create("repayFeeAmt", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("总还款服务费", CellStyleCustom.Text)).Add2(Tuple.Create("totalRepayFeeAmt", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月债权转让服务费", CellStyleCustom.Text)).Add2(Tuple.Create("creditFeeAmt", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("总债权转让服务费", CellStyleCustom.Text)).Add2(Tuple.Create("totalCreditFeeAmt", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月个人平均借款额度", CellStyleCustom.Text)).Add2(Tuple.Create("personAverageBorrowAmt", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("历史个人平均借款总额", CellStyleCustom.Text)).Add2(Tuple.Create("totalPersonAverageBorrowAmt", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月机构平均借款额度", CellStyleCustom.Text)).Add2(Tuple.Create("orgAverageBorrowAmt", CellStyleCustom.DecimalMoney))
                                                     .Add2(Tuple.Create("历史机构平均借款总额", CellStyleCustom.Text)).Add2(Tuple.Create("totalOrgAverageBorrowAmt", CellStyleCustom.DecimalMoney)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月上线项目平均借款天数", CellStyleCustom.Text)).Add2(Tuple.Create("averageBorrowDays", CellStyleCustom.Integer))
                                                     .Add2(Tuple.Create("上线项目平均借款天数", CellStyleCustom.Text)).Add2(Tuple.Create("totalAverageBorrowDays", CellStyleCustom.Integer)))
            .Add2(new List<StatisticsCell>().Add2(Tuple.Create("当月上线项目平均借款利率", CellStyleCustom.Text)).Add2(Tuple.Create("averageBorrowRate", CellStyleCustom.Percent))
                                                     .Add2(Tuple.Create("上线项目平均借款利率", CellStyleCustom.Text)).Add2(Tuple.Create("totalAverageBorrowRate", CellStyleCustom.Percent)));
            //m_model.Add(new List("新增投资人数", "newInvestCount", "", ""));
            //m_model.Add(new List("当月注册人数", "newRegCount", "总注册人数", "totalRegCount"));
            //m_model.Add(new List("当月充值人数(仅投资人)", "rechargeCountInvestor", "总充值人数(仅投资人)", "totalRechargeCountInvestor"));
            //m_model.Add(new List("当月充值人数(其它)", "rechargeCountOther", "总充值人数(其它)", "totalRechargeCountOther"));
            //m_model.Add(new List("当月提现人数(仅投资人)", "withdrawCountInvestor", "总提现人数(仅投资人)", "totalWithdrawCountInvestor"));
            //m_model.Add(new List("当月提现人数(其它)", "withdrawCountOther", "总提现人数(其它)", "totalWithdrawCountOther"));
            //m_model.Add(new List("当月投资人数", "investCount", "总投资人数", "totalInvestCount"));
            //m_model.Add(new List("当月借款人数", "borrowerCount", "总借款人数", "totalBorrowerCount"));
            //m_model.Add(new List("当月充值金额(仅投资人)", "rechargeAmtInvestor", "总充值金额(仅投资人)", "totalRechargeAmtInvestor"));
            //m_model.Add(new List("当月充值金额(其它)", "rechargeAmtOther", "总充值金额(其它)", "totalRechargeAmtOther"));
            //m_model.Add(new List("当月提现金额(仅投资人)", "withdrawAmtInvestor", "总提现金额(仅投资人)", "totalWithdrawAmtInvestor"));
            //m_model.Add(new List("当月提现金额(其它)", "withdrawAmtOther", "总提现金额(其它)", "totalWithdrawAmtOther"));
            //m_model.Add(new List("当月投资金额", "investAmt", "总投资金额", "totalInvestAmt"));
            //m_model.Add(new List("当月债权转让成交金额", "creditAmt", "总债权转让成交金额", "totalCreditAmt"));
            //m_model.Add(new List("", "", "借款余额", "loanBalanceAmt"));
            //m_model.Add(new List("当月还款服务费", "repayFeeAmt", "总还款服务费", "totalRepayFeeAmt"));
            //m_model.Add(new List("当月债权转让服务费", "creditFeeAmt", "总债权转让服务费", "totalCreditFeeAmt"));
            //m_model.Add(new List("当月个人平均借款额度", "personAverageBorrowAmt", "个人平均借款总额", "totalPersonAverageBorrowAmt"));
            //m_model.Add(new List("当月机构平均借款额度", "orgAverageBorrowAmt", "机构平均借款总额", "totalOrgAverageBorrowAmt"));
            //m_model.Add(new List("当月上线项目平均借款天数", "averageBorrowDays", "上线项目平均借款天数", "totalAverageBorrowDays"));
            //m_model.Add(new List("当月上线项目平均借款利率", "averageBorrowRate", "上线项目平均借款利率", "totalAverageBorrowRate"));
        }

        public MonthStatisticDlg() {
            InitializeComponent();
        }

        private void MonthStatisticDlg_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(dtpSearchDate, toolStripLabel1);
            dtpSearchDate.Value = DateTime.Now.AddMonths(-1);

            exportStatistics.DropDownItems[0].Text = DateTime.Now.Year + "年";
            exportStatistics.DropDownItems[1].Text = DateTime.Now.Year - 1 + "年";
            exportStatistics.DropDownItems[2].Text = DateTime.Now.Year - 2 + "年";

            UpdateTable(true);
        }

        private void UpdateTable(bool initial) {
            var allData = new Dictionary<string, object>();

            if (!initial) {
                btnSearch.Enabled = false;
                wbDataStatistic.DocumentText = "";

                var r = new Dictionary<string, object>();
                var now = dtpSearchDate.Value;
                r["datepoint1"] = new DateTime(now.Year, now.Month, 1).AddDays(-1).TruncToEnd();
                r["datepoint2"] = new DateTime(now.Year, now.Month, 1).AddMonths(1).TruncToStart();
                var dlg = new BatchProcessMultipleServers();
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.MonthStatistic1(r); });
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.MonthStatistic2(r); });
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.MonthStatistic3(r); });
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.MonthStatistic4(r); });
                dlg.ALL_SEVERS.Add(async () => { return await DataStatistic.MonthStatistic5(r); });
                dlg.ShowDialog();

                foreach (var d in dlg.AllResult) {
                    if (d.IsOk) {
                        Commons.DictionaryAddResult(allData, d);
                    }
                }

            }

            string info = "<p>人数单位：个，金额单位：元</p>";
            info += "<table border=1 cellspacing=0 align=center>";
            for (int row = 0; row < m_model.Count; ++row) {
                info += string.Format("<tr><td {0} {1}><b>&nbsp;{3}</b></td><td {0} {2}>&nbsp;{4}</td> <td {0} {1}><b>&nbsp;{5}</b></td><td {0} {2}>&nbsp;{6}</td></tr>",
                    "align=center valign=middle", "width=220", "width=110",
                    GetCellStr(m_model[row][0], allData), GetCellStr(m_model[row][1], allData),
                    GetCellStr(m_model[row][2], allData), GetCellStr(m_model[row][3], allData));
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
                                   <dd>新系统截止到统计月结束的总放款-总还本</dd></dl>", "指定月");

            wbDataStatistic.DocumentText = info;


            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable(false);
        }

        private void statisticsOfYear1_Click(object sender, EventArgs e) {
            ExportDate(DateTime.Now.Year);
        }

        private void statisticsOfYear2_Click(object sender, EventArgs e) {
            ExportDate(DateTime.Now.Year - 1);
        }

        private void statisticsOfYear3_Click(object sender, EventArgs e) {
            ExportDate(DateTime.Now.Year - 2);
        }

        private void ExportDate(int year) {
            var label = new List<string>();
            var times = new List<DateTime>();
            if (year == DateTime.Now.Year) {
                for (int i = 1; i <= DateTime.Now.Month; ++i) {
                    label.Add(string.Format("{0}年{1}月", year, i));
                    times.Add(new DateTime(year, i, 1));
                }
            } else {
                for (int i = 1; i <= 12; ++i) {
                    label.Add(string.Format("{0}年{1}月", year, i));
                    times.Add(new DateTime(year, i, 1));
                }
            }

            var dlg = new ExportExcel2Dlg(label, m_model);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.GetCellStr += GetCellStr;

            for (int i = 0; i < times.Count; ++i) {
                var r = new Dictionary<string, object>();
                r["datepoint"] = times[i];
                dlg.ALL_SERVERS.Add((all) => {
                    var dic = new Dictionary<string, object>();
                    var d1 = DataStatistic.MonthStatistic1(r).Result;
                    var d2 = DataStatistic.MonthStatistic2(r).Result;
                    var d3 = DataStatistic.MonthStatistic3(r).Result;
                    var d4 = DataStatistic.MonthStatistic4(r).Result;
                    var d5 = DataStatistic.MonthStatistic5(r).Result;
                    Commons.DictionaryAddResult(dic, d1);
                    Commons.DictionaryAddResult(dic, d2);
                    Commons.DictionaryAddResult(dic, d3);
                    Commons.DictionaryAddResult(dic, d4);
                    Commons.DictionaryAddResult(dic, d5);
                    all.Add(dic);
                });
            }
            dlg.ShowDialog();
        }

        private string GetCellStr(StatisticsCell c, IDictionary<string, object> d, NPOI.SS.UserModel.ICell cell = null) {
            string s = "";
            object o;
            switch (c.Item2) {
                case CellStyleCustom.Text:
                    if (cell != null)
                        cell.SetCellValue(c.Item1);
                    else
                        s = c.Item1;
                    break;
                case CellStyleCustom.Integer:
                    if (cell != null)
                        cell.SetCellValue(Convert.ToInt64(d.GetOrDefault<int>(c.Item1)));
                    else {
                        if ((o = d.GetOrDefault<string>(c.Item1)) != null) {
                            s = string.Format("{0:#,##0}", Convert.ToInt32(o));
                        }
                    }
                    break;
                case CellStyleCustom.DecimalMoney:
                    if (cell != null)
                        cell.SetCellValue(Convert.ToDouble(d.GetOrDefault<decimal>(c.Item1)));
                    else {
                        if ((o = d.GetOrDefault<string>(c.Item1)) != null) {
                            s = string.Format("{0:#,##0.00}", Convert.ToDecimal(o));
                        }
                    }
                    break;
                case CellStyleCustom.Percent:
                    if (cell != null)
                        cell.SetCellValue(Convert.ToDouble(d.GetOrDefault<decimal>(c.Item1) / 100));
                    else {
                        if ((o = d.GetOrDefault<string>(c.Item1)) != null) {
                            s = string.Format("{0:0.00}%", Convert.ToDecimal(o));
                        }
                    }
                    break;
                default:
                    if (cell != null)
                        cell.SetCellValue(s);
                    break;
            }
            return s;
        }
    }
}
