using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Crm;
    public partial class CrmTodoDlg : Form {

        private string m_uName;
        public CrmTodoDlg(string uName) {
            InitializeComponent();
            m_uName = uName;
        }

        private void CrmTodoDlg_Load(object sender, EventArgs e) {
            if (m_uName == "+") {
                this.Text = "我的工作任务";
                btnBatchCommit.Enabled = true;
            } else {
                this.Text = string.Format(this.Text, m_uName);
            }

            foreach (var btn in panel2.Controls) {
                if (btn is Button) {
                    ((Button)btn).Tag = ((Button)btn).Text;
                }
            }

            Updatetable1();
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e) {
            if (listView1.CheckedItems.Count == 0) {
                btnFollow.Enabled = false;
            } else if (listView1.CheckedItems.Count == 1) {
                btnFollow.Enabled = true;
            } else {
                btnFollow.Enabled = false;
            }
        }

        private async void Updatetable1() {
            var r = new Dictionary<string, object>();
            r["u-name"] = m_uName;
            var p = await CrmInvestor.GetNumInStatus(r);
            if (p.IsOk) {
                var dl = p.AsDictionary;
                foreach (var btn in panel2.Controls) {
                    if (btn is Button) {
                        ((Button)btn).Text = string.Format(Convert.ToString(((Button)btn).Tag), dl.GetOrDefault<string>(Commons.NormalNumberStr(((Button)btn).Name)));
                    }
                }
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private async void Details(object sender, bool showBatch = false) {
            SetBtnsEnabled(false);
            listView1.Items.Clear();
            listView1.Tag = sender;
            if (showBatch) {
                btnBatchCommit.Visible = true;
                ckbAll.Visible = true;
            } else {
                btnBatchCommit.Visible = false;
                ckbAll.Visible = false;
            }

            ckbAll.Checked = false;

            var r = new Dictionary<string, object>();
            r["action"] = Commons.NormalNumberStr(((Button)sender).Name);
            r["u-name"] = m_uName;

            var p = await CrmInvestor.GetInvestorByStatus(r);
            if (p.IsOk) {
                var dl = JArray.Parse(p.AsString).ToList();
                foreach (var d in dl) {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = d["ciId"].ToStdString();
                    lvi.SubItems.Add(d["loginName"].ToStdString());
                    lvi.SubItems.Add(d["realName"].ToStdString());
                    lvi.SubItems.Add(d["mobile"].ToStdString());
                    lvi.SubItems.Add(CrmCommons.PrLevels.FindByValue(d["prLevel"].ToStdString()));

                    listView1.Items.Add(lvi);
                }

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            SetBtnsEnabled(true);
        }

        private void btn101_Click(object sender, EventArgs e) {
            Details(sender, true);
        }

        private void btn102_Click(object sender, EventArgs e) {
            Details(sender, true);
        }

        private void btn103_Click(object sender, EventArgs e) {
            Details(sender, true);
        }

        private void btn104_Click(object sender, EventArgs e) {
            Details(sender, true);
        }

        private void btn201_Click(object sender, EventArgs e) {
            Details(sender);
        }

        private void btn202_Click(object sender, EventArgs e) {
            Details(sender);
        }

        private void btn203_Click(object sender, EventArgs e) {
            Details(sender);
        }

        private void btn301_Click(object sender, EventArgs e) {
            Details(sender);
        }

        private void btn401_Click(object sender, EventArgs e) {
            Details(sender);
        }

        private void btn402_Click(object sender, EventArgs e) {
            Details(sender);
        }

        private void btn403_Click(object sender, EventArgs e) {
            Details(sender);
        }

        private void btn620_Click(object sender, EventArgs e) {
            Details(sender);
        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e) {
            if (((CheckBox)sender).Checked) {
                if (listView1.Items.Count > 0) {
                    for (int i = 0; i < listView1.Items.Count; ++i) {
                        listView1.Items[i].Checked = true;
                    }
                }
            }
        }



        private void btnBatchCommit_Click(object sender, EventArgs e) {
            if (listView1.CheckedItems.Count == 0)
                return;
            var ids = new List<long>();
            for (int i = 0; i < listView1.CheckedItems.Count; ++i) {
                ids.Add(Convert.ToInt64(listView1.CheckedItems[i].Text));
            }
            var dlg = new BatchProcessDlg(ids);
            dlg.StartPosition = FormStartPosition.CenterParent;
            var d = new Dictionary<string, object>();
            d["remark"] = "批量操作";
            d["action"] = Commons.NormalNumberStr(((Button)listView1.Tag).Name);

            dlg.RunSingle += (id) => CrmInvestor.SaveRemark(id, d).Result;
            dlg.ShowDialog();
            Updatetable1();
            ((Button)listView1.Tag).PerformClick();
        }

        private void btnFollow_Click(object sender, EventArgs e) {
            var dlg = new CrmInvestorRemarksDlg(Convert.ToInt64(listView1.CheckedItems[0].Text), m_uName != "+");
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
            if (dlg.DialogResult == DialogResult.Cancel) {
                Updatetable1();
                ((Button)listView1.Tag).PerformClick();
            }
        }

        private void SetBtnsEnabled(bool b) {
            foreach (var btn in panel2.Controls) {
                if (btn is Button) {
                    ((Button)btn).Enabled = b;
                }
            }
        }
    }
}
