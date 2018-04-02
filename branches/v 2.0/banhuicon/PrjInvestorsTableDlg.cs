using System;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Projs;
    public partial class PrjInvestorsTableDlg : Form {
        private long m_pId;
        public PrjInvestorsTableDlg(long pId) {
            InitializeComponent();
            m_pId = pId;
        }

        private void PrjInvestorsTableDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_pId);
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private async void UpdateTable1() {
            btnUpdate.Enabled = false;
            wbInfo.DocumentText = "";
            var r = await Projects.Investors(m_pId);
            if (r.IsOk) {
                var rows = JArray.Parse(r.AsString).ToList();
                string info;
                info = string.Format(@"<table border=1 cellspacing=0 align=center>
                    <tr><th width=80 {0}>序号</th>
                    <th width=100 {0}>姓名/名称</th>
                    <th width=250 {0}>身份证号/统一社会信用代码</th>
                    <th width=150 {0}>手机</th>
                    <th width=150 {0}>电子邮箱</th>
                    <th width=150 {0}>出借金额</th></tr>",
                    "bgcolor=#A9A9A9 ");

                if (rows.Count == 0) {
                    info += "</table>";
                    wbInfo.DocumentText = info;
                    btnUpdate.Enabled = true;
                    Commons.ShowInfoBox(this, "未查询到数据!");
                    return;
                }

                int index = 1;
                foreach (var row in rows) {
                    string name, code, mobile, email, temp;
                    decimal amt;
                    name = row["name"].ToStdString();
                    name = name[0].ToString().PadRight(name.Length, '*');

                    code = row["code"].ToStdString();
                    code = code.LeftStr(6).PadRight(code.Length - 4, '*') + code.RightStr(4);

                    mobile = row["mobile"].ToStdString();
                    mobile = mobile.LeftStr(3).PadRight(mobile.Length - 4, '*') + mobile.RightStr(4);

                    email = row["email"].ToStdString();

                    amt = row["amt"].ToDecimal();

                    temp = string.Format(@"<tr><td {0}>&nbsp;{1}</td>
                        <td {0}>&nbsp;{2}</td>
                        <td {0}>&nbsp;{3}</td>
                        <td {0}>&nbsp;{4}</td>
                        <td {0}>&nbsp;{5}</td>
                        <td align=right valign=middle>&nbsp;{6:N}</td></tr>",
                        "align=center valign=middle", index, name, code, mobile, email, amt);

                    ++index;
                    info += temp;

                }
                info += "</table>";
                wbInfo.DocumentText = info;
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnUpdate.Enabled = true;
        }
    }
}
