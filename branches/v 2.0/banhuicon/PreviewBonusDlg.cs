using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Projs;
    public partial class PreviewBonusDlg : Form {

        private long m_pId;
        private int m_bonusPeriod;
        private int m_bonusDay;
        private static readonly string[] Type ={
                                             "利息",
                                             "本金",
                                             "资金A期间分红",
                                             "资金B期间分红",
                                             "资金A本金",
                                             "资金A收益",
                                             "资金B本金",
                                             "资金B补贴",
                                             "资金A盈余分红",
                                             "资金B盈余分红",
                                               };



        public PreviewBonusDlg(long id, int bonusPeriod, int bonusDay) {
            InitializeComponent();
            m_pId = id;
            m_bonusPeriod = bonusPeriod;
            m_bonusDay = bonusDay;
        }

        private void PreviewBonusDlg_Load(object sender, EventArgs e) {

            UpdateData();
        }

        private async void UpdateData() {
            listView1.Items.Clear();
            var p = new Dictionary<string, object>();
            p["pid"] = m_pId;
            if (m_bonusPeriod > 0) {
                p["bonus-period"] = m_bonusPeriod;
                if (m_bonusDay > 0) {
                    p["bonus-day"] = m_bonusDay;
                }
            }
            var r = await Projects.PreviewBonus(p);
            if (r.IsOk) {
                var dl = JArray.Parse(r.AsString).ToList();
                decimal totalAmt = 0;
                foreach (var d in dl) {
                    ListViewItem lvi = new ListViewItem();
                    var type = d["type"].ToInt32();
                    lvi.Text = type >= Type.Length ? "" : Type[type];
                    lvi.SubItems.Add(d["datepoint"].ToDate());
                    string amt = d["amt"].ToMoney();
                    totalAmt = totalAmt + Convert.ToDecimal(amt);
                    lvi.SubItems.Add(amt);
                    listView1.Items.Add(lvi);
                }
                ListViewItem lvi2 = new ListViewItem();
                lvi2.Text = "总计";
                lvi2.SubItems.Add("");
                lvi2.SubItems.Add(string.Format("{0:N}", totalAmt));
                listView1.Items.Add(lvi2);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }
    }
}
