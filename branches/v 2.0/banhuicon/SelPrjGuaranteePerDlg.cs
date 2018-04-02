using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using BaseData;
    //选择担保公司
    public partial class SelPrjGuaranteePerDlg : Form {

        public long SelGuaId { get; private set; }
        private int m_maxRow;
        public SelPrjGuaranteePerDlg(long guaId) {
            InitializeComponent();
            SelGuaId = guaId;
        }

        private void SelPrjGuaranteeDlg_Load(object sender, EventArgs e) {
            UpdateData();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateData();
        }

        private async void UpdateData() {
            btnSearch.Enabled = false;
            listView1.Items.Clear();
            var p = new Dictionary<string, object>();
            p["key"] = tbKey.Text.Trim();
            var r = await PrjGuaranteePers.GetGuarantees(p);
            if (r.IsOk) {
                var dl = JArray.Parse(r.AsString).ToList();
                foreach (var d in dl) {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = d["bgpId"].ToStdString();
                    if (SelGuaId.ToString() == lvi.Text) {
                        lvi.Checked = true;
                    }
                    lvi.SubItems.Add(d["name"].ToStdString());
                    lvi.SubItems.Add(d["showName"].ToStdString());
                    listView1.Items.Add(lvi);
                }
                m_maxRow = listView1.Items.Count;
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            if (listView1.CheckedItems.Count == 0) {
                SelGuaId = -1;
            }
            btnSearch.Enabled = true;
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e) {
            if (!listView1.Items[e.Index].Checked) {
                foreach (ListViewItem lv in listView1.Items) {
                    if (lv.Checked) {
                        lv.Checked = false;
                    }
                }
            }
            SelGuaId = Convert.ToInt64(listView1.Items[e.Index].Text);
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e) {
            if (listView1.CheckedItems.Count == 0 && listView1.Items.Count == m_maxRow) {
                SelGuaId = -1;
            }
            if (listView1.CheckedItems.Count != 0)
                listView1.Items[listView1.CheckedItems[0].Index].EnsureVisible();
        }

        public string SelGuaName {
            get {
                if (listView1.CheckedItems.Count != 0) {
                    return listView1.CheckedItems[0].SubItems[1].Text;
                } else
                    return "";
            }
        }

        public string SelGuaShowName {
            get {
                if (listView1.CheckedItems.Count != 0) {
                    return listView1.CheckedItems[0].SubItems[2].Text;
                } else
                    return "";
            }
        }
    }
}
