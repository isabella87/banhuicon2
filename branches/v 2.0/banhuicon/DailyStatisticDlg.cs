using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Account;
    public partial class DailyStatisticDlg : Form {
        public DailyStatisticDlg() {
            InitializeComponent();
        }

        private void DailyStatisticDlg_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(dtpSearchDate, toolStripLabel1);
            dtpSearchDate.Value = DateTime.Now;

            UpdateTable1();
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            wbInvestorsInfo.DocumentText = "";
            var r = new Dictionary<string, object>();
            r["datepoint"] = dtpSearchDate.Value.TruncToEnd();
            var p = await DataStatistic.DailyStatistic(r);
            if (p.IsOk) {
                var d = p.AsDictionary;

                string info;
                info = string.Format(@"<table border=1 cellspacing=0 align=center>
                    <tr>
                    <td {0} {1}><b>新增注册人数</b></td><td {0} {2}>&nbsp;{3}</td> <td {0} {1}><b>总注册人数</b></td><td {0} {2}>&nbsp;{4}</td>
                    </tr><tr>
                    <td {0} {1}><b>新增投资人数</b></td><td {0} {2}>&nbsp;{5}</td> <td {0} {1}><b>总投资人数</b></td><td {0} {2}>&nbsp;{6}</td>
                    </tr><tr>
                    <td {0} {1}><b>充值人数(仅投资人)</b></td><td {0} {2}>&nbsp;{7}</td> <td {0} {1}><b>总充值人数(仅投资人)</b></td><td {0} {2}>&nbsp;{8}</td>
                    </tr><tr>
                    <td {0} {1}><b>充值人数(其他)</b></td><td {0} {2}>&nbsp;{9}</td> <td {0} {1}><b>总充值人数(其他)</b></td><td {0} {2}>&nbsp;{10}</td>
                    </tr><tr>
                    <td {0} {1}><b>提现人数(仅投资人)</b></td><td {0} {2}>&nbsp;{11}</td> <td {0} {1}><b>总提现人数(仅投资人)</b></td><td {0} {2}>&nbsp;{12}</td>
                    </tr><tr>
                    <td {0} {1}><b>提现人数(其他)</b></td><td {0} {2}>&nbsp;{13}</td> <td {0} {1}><b>总提现人数(其他)</b></td><td {0} {2}>&nbsp;{14}</td>
                    </tr><tr>
                    <td {0} {1}><b>投资人数</b></td><td {0} {2}>&nbsp;{15}</td> <td {0} {1}><b>&nbsp;</b></td><td {0} {2}>&nbsp;</td>
                    </tr><tr>
                    <td {0} {1}><b>投资人充值金额(元)</b></td><td {0} {2}>&nbsp;{16}</td> <td {0} {1}><b>投资人总充值金额(元)</b></td><td {0} {2}>&nbsp;{17}</td>
                    </tr><tr>
                    <td {0} {1}><b>其他充值金额(元)</b></td><td {0} {2}>&nbsp;{18}</td> <td {0} {1}><b>其他总充值金额(元)</b></td><td {0} {2}>&nbsp;{19}</td>
                    </tr><tr>
                    <td {0} {1}><b>投资人提现金额(元)</b></td><td {0} {2}>&nbsp;{20}</td> <td {0} {1}><b>投资人总提现金额(元)</b></td><td {0} {2}>&nbsp;{21}</td>
                    </tr><tr>
                    <td {0} {1}><b>其他提现金额(元)</b></td><td {0} {2}>&nbsp;{22}</td> <td {0} {1}><b>其他总提现金额(元)</b></td><td {0} {2}>&nbsp;{23}</td>
                    </tr><tr>
                    <td {0} {1}><b>投资金额(元)</b></td><td {0} {2}>&nbsp;{24}</td> <td {0} {1}><b>总投资金额(元)</b></td><td {0} {2}>&nbsp;{25}</td>
                    </tr><tr>
                    <td {0} {1}><b>债权转让成交金额(元)</b></td><td {0} {2}>&nbsp;{26}</td> <td {0} {1}><b>总债权转让成交金额(元)</b></td><td {0} {2}>&nbsp;{27}</td>
                    </tr><tr>
                    <td {0} {1}><b>借款余额(元)</b></td><td {0} {2}>&nbsp;{28}</td> <td {0} {1}><b>&nbsp;</b></td><td {0} {2}>&nbsp;</td>
                    </tr><tr>
                    <td {0} {1}><b>还款服务费(元)</b></td><td {0} {2}>&nbsp;{29}</td> <td {0} {1}><b>债权转让服务费(元)</b></td><td {0} {2}>&nbsp;{30}</td>
                    </tr>
                    </table>", "align=center valign=middle", "width=200", "width=110"
                    , d.GetOrDefault<string>("newRegCount"), d.GetOrDefault<string>("totalRegCount")
                    , d.GetOrDefault<string>("newInvestCount"), d.GetOrDefault<string>("totalInvestCount")
                    , d.GetOrDefault<string>("rechargeCountInvestor"), d.GetOrDefault<string>("totalRechargeCountInvestor")
                    , d.GetOrDefault<string>("rechargeCountOther"), d.GetOrDefault<string>("totalRechargeCountOther")
                    , d.GetOrDefault<string>("withdrawCountInvestor"), d.GetOrDefault<string>("totalWithdrawCountInvestor")
                    , d.GetOrDefault<string>("withdrawCountOther"), d.GetOrDefault<string>("totalWithdrawCountOther")
                    , d.GetOrDefault<string>("investCount")
                    , d.GetOrDefault<string>("rechargeAmtInvestor"), d.GetOrDefault<string>("totalRechargeAmtInvestor")
                    , d.GetOrDefault<string>("rechargeAmtOther"), d.GetOrDefault<string>("totalRechargeAmtOther")
                    , d.GetOrDefault<string>("withdrawAmtInvestor"), d.GetOrDefault<string>("totalWithdrawAmtInvestor")
                    , d.GetOrDefault<string>("withdrawAmtOther"), d.GetOrDefault<string>("totalWithdrawAmtOther")
                    , d.GetOrDefault<string>("investAmt"), d.GetOrDefault<string>("totalInvestAmt")
                    , d.GetOrDefault<string>("creditAmt"), d.GetOrDefault<string>("totalCreditAmt")
                    , d.GetOrDefault<string>("loanBalanceAmt")
                    , d.GetOrDefault<string>("repayFeeAmt"), d.GetOrDefault<string>("creditFeeAmt"));

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

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }
    }
}
