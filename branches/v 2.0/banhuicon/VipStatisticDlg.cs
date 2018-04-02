using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Banhuitong.Console {
    using Account;
    public partial class VipStatisticDlg : Form {
        public VipStatisticDlg() {
            InitializeComponent();
        }

        private void VipStatisticDlg_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(dtpSearchDate, toolStripLabel1);
            toolStrip1.AddControlAfter(nudAmt, toolStripLabel2);
            dtpSearchDate.Value = DateTime.Now;

        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            wbDataStatistic.DocumentText = "";
            var r = new Dictionary<string, object>();
            r["datepoint"] = dtpSearchDate.Value;
            r["limit-amt"] = nudAmt.Value;

            var p = await DataStatistic.VipStatistic(r);
            if (p.IsOk) {
                var rows = JArray.Parse(p.AsString).ToList();
                string info;
                info = string.Format(@"<table border=1 cellspacing=0 align=center>
                        <tr><th width=80 {0}>ID</th>
                        <th width=100 {0}>帐户名</th>
                        <th width=100 {0}>真实姓名</th>
                        <th width=120 {0}>手机</th>
                        <th width=100 {0}>当月投资额</th>
                        <th width=100 {0}>投资余额</th>
                        <th width=150 {0}>当月买入债权额</th></tr>", "bgcolor=#A9A9A9");

                if (rows.Count == 0) {
                    info += "</table>";
                    wbDataStatistic.DocumentText = info;
                    btnSearch.Enabled = true;
                    Commons.ShowInfoBox(this, "未查询到数据!");
                    return;
                }

                foreach (var row in rows) {
                    info += string.Format(@"<tr><td {0}>&nbsp;{1}</td>
                    <td {0}>&nbsp;{2}</td>
                    <td {0}>&nbsp;{3}</td>
                    <td {0}>&nbsp;{4}</td>
                    <td align=right valign=middle>&nbsp;{5}</td>
                    <td align=right valign=middle>&nbsp;{6}</td>
                    <td align=right valign=middle>&nbsp;{7}</td></tr>"
                    , "align=center valign=middle", row["auId"].ToStdString(), row["loginName"].ToStdString()
                    , row["realName"].ToStdString(), row["mobile"].ToStdString(), row["monthSumAmt"].ToMoney()
                    , row["blanceAmt"].ToMoney(), row["monthSumCredit"].ToMoney());
                }

                info += "</table>";

                wbDataStatistic.DocumentText = info;
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
