using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Projs;
    public partial class SelPrjBorDlg : Form {
        public enum BorType {
            //借款人帐户
            Borrow,
            //名义借款人帐户
            Borrow2,
            //保证金帐户
            Guarantor
        }
        public long SelBorId { get; private set; }
        private int m_maxRow;
        private BorType m_bt;
        private static readonly TextValues USER_TYPES;
        private static readonly TextValues USER_STATUS;
        private static readonly TextValues CP_STATUS;

        static SelPrjBorDlg() {
            USER_TYPES = new TextValues()
            .AddNew("个人", 1)
            .AddNew("机构", 2);

            USER_STATUS = new TextValues()
            .AddNew("已注册", -2)
            .AddNew("审核未通过", -1)
            .AddNew("待审核", 0)
            .AddNew("激活", 1)
            .AddNew("审核通过", 2)
            .AddNew("停用", 99);

            CP_STATUS = new TextValues()
            .AddNew("未开户", 0)
            .AddNew("已开户", 1);
        }

        public SelPrjBorDlg(long id, BorType bt) {
            InitializeComponent();
            SelBorId = id;
            m_bt = bt;
        }

        private async void UpdateData() {
            btnSearch.Enabled = false;
            listView1.Items.Clear();
            var p = new Dictionary<string, object>();
            p["key"] = tbKey.Text.Trim();
            var userType = cbbUserType.ComboBox.GetSelectedValue();
            if (userType != Commons.AllValue)
                p["user-type"] = cbbUserType.ComboBox.GetSelectedValue();
            var r = await Projects.GetAccounts(p);
            if (r.IsOk) {
                var dl = JArray.Parse(r.AsString).ToList();
                foreach (var d in dl) {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = d["auId"].ToStdString();
                    if (SelBorId.ToString() == lvi.Text) {
                        lvi.Checked = true;
                    }
                    lvi.SubItems.Add((d["loginName"].ToStdString()));
                    lvi.SubItems.Add(USER_TYPES.FindByValue(d["userType"].ToStdString()));
                    lvi.SubItems.Add(USER_STATUS.FindByValue(d["status"].ToStdString()));
                    lvi.SubItems.Add(CP_STATUS.FindByValue(d["jxStatus"].ToStdString()));
                    lvi.SubItems.Add(d["realName"].ToStdString());
                    lvi.SubItems.Add(d["orgName"].ToStdString());
                    lvi.SubItems.Add(d["mobile"].ToStdString());
                    listView1.Items.Add(lvi);
                }
                m_maxRow = listView1.Items.Count;
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void SelPrjBorDlg_Load(object sender, EventArgs e) {
            switch (m_bt) {
                case BorType.Borrow:
                    this.Text = "选择借款人帐户";
                    break;
                case BorType.Borrow2:
                    this.Text = "选择名义借款人帐户";
                    break;
                case BorType.Guarantor:
                    this.Text = "选择担保人帐户";
                    break;
            }

            cbbUserType.ComboBox.BindTo(USER_TYPES, ExtraItems.AddAll);

            UpdateData();

        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateData();
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e) {
            if (!listView1.Items[e.Index].Checked) {
                foreach (ListViewItem lv in listView1.Items) {
                    if (lv.Checked) {
                        lv.Checked = false;
                    }
                }
            }
            SelBorId = Convert.ToInt64(listView1.Items[e.Index].Text);
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e) {
            if (listView1.CheckedItems.Count == 0 && listView1.Items.Count == m_maxRow) {
                SelBorId = -1;
            }
            if (listView1.CheckedItems.Count != 0)
                listView1.Items[listView1.CheckedItems[0].Index].EnsureVisible();

        }

        public string SelBorName {
            get {
                if (listView1.CheckedItems.Count != 0) {
                    if (SelType == "1")
                        return listView1.CheckedItems[0].SubItems[5].Text;
                    else if (SelType == "2")
                        return listView1.CheckedItems[0].SubItems[6].Text;
                    else
                        return "";
                } else
                    return "";
            }
        }

        public string SelType {
            get {
                if (listView1.CheckedItems.Count != 0) {
                    return USER_TYPES.FindByText(listView1.CheckedItems[0].SubItems[2].Text);
                } else
                    return "";
            }
        }

    }
}
