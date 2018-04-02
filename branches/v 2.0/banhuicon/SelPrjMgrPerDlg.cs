using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    //选择借款人
    using BaseData;
    public partial class SelPrjMgrPerDlg : Form {

        public long SelMgrId { get; private set; }
        private int m_maxRow;
        public SelPrjMgrPerDlg(long mgrId) {
            InitializeComponent();
            SelMgrId = mgrId;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateData();
        }

        private void SelPrjMgr_Load(object sender, EventArgs e) {
            UpdateData();
        }

        private async void UpdateData() {
            btnSearch.Enabled = false;
            listView1.Items.Clear();
            var p = new Dictionary<string, object>();
            p["real-name"] = tbKey.Text.Trim();
            var r = await PrjBorPersons.GetAll(p);
            if (r.IsOk) {
                var dl = JArray.Parse(r.AsString).ToList();
                foreach (var d in dl) {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = d["bpmpId"].ToStdString();
                    if (SelMgrId.ToString() == lvi.Text) {
                        lvi.Checked = true;
                    }
                    lvi.SubItems.Add(d["realName"].ToStdString());
                    lvi.SubItems.Add(d["qualification"].ToStdString());
                    lvi.SubItems.Add(d["mobile"].ToStdString());
                    lvi.SubItems.Add(d["company"].ToStdString());
                    listView1.Items.Add(lvi);
                }
                m_maxRow = listView1.Items.Count;
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            if (listView1.CheckedItems.Count == 0) {
                SelMgrId = -1;
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
            SelMgrId = Convert.ToInt64(listView1.Items[e.Index].Text);
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e) {
            if (listView1.CheckedItems.Count == 0 && listView1.Items.Count == m_maxRow) {
                SelMgrId = -1;
            }

            if (listView1.CheckedItems.Count != 0)
                listView1.Items[listView1.CheckedItems[0].Index].EnsureVisible();
        }

        public string SelBorName {
            get {
                if (listView1.CheckedItems.Count != 0) {
                    return listView1.CheckedItems[0].SubItems[1].Text;
                } else
                    return "";
            }
        }
    }
}
