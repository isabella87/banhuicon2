using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Banhuitong.Console {
    using Account;
    public partial class NewInvestorsStatisticDlg : Form {
        public NewInvestorsStatisticDlg() {
            InitializeComponent();
        }

        private void NewInvestorsStatisticDlg_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(dtpSearchDate, toolStripLabel1);
            dtpSearchDate.Value = DateTime.Now;
        }

        private async void UpdateTable() {
            btnSearch.Enabled = false;
            wbDataStatistic.DocumentText = "";
            var r = new Dictionary<string, object>();
            r["datepoint"] = dtpSearchDate.Value;
            var p = await DataStatistic.NewInvestorsStatistic(r);
            if (p.IsOk) {
                var rows = JArray.Parse(p.AsString).ToList();
                string info;
                info = string.Format(@"<table border=1 cellspacing=0 align=center>
                            <tr><th width=80 {0}>ID</th>
                            <th width=100 {0}>帐户名</th>
                            <th width=100 {0}>真实姓名</th>
                            <th width=100 {0}>手机</th>
                            <th width=200 {0}>第一笔投资时间</th>
                            <th width=120 {0}>第一笔投资额</th>
                            <th width=100 {0}>推荐人</th>
                            <th width=100 {0}>推荐人手机</th>
                            <th width=120 {0}>推荐人投资额</th></tr>", "bgcolor=#A9A9A9");

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
                    <td {0}>&nbsp;{5}</td>
                    <td align=right valign=middle>&nbsp;{6}</td>
                    <td {0}>&nbsp;{7}</td>
                    <td {0}>&nbsp;{8}</td>
                    <td align=right valign=middle>&nbsp;{9}</td></tr>"
                    , "align=center valign=middle", row["auId"].ToStdString(), row["loginName"].ToStdString()
                    , row["realName"].ToStdString(), row["mobile"].ToStdString(), row["datepoint"].ToDateTime()
                    , row["amt"].ToMoney(), row["recommendRealName"].ToStdString(), row["recommendMobile"].ToStdString()
                    , row["recommendAmt"].ToMoney());
                }

                info += "</table>";
                wbDataStatistic.DocumentText = info;

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }
    }
}
