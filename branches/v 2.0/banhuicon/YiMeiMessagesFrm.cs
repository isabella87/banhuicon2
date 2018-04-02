using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using MyLib.UI;
    using Account;
    public partial class YiMeiMessagesFrm : Form, IHasGridDataTable {
        private static readonly TextValues STATUS;

        static YiMeiMessagesFrm() {
            STATUS = new TextValues()
            .AddNew("未发送", 0)
            .AddNew("失败", 1)
            .AddNew("成功", 2);
        }

        public YiMeiMessagesFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void YiMeiMessagesFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, toolStripLabel1);
            toolStrip1.AddControlAfter(endDate, toolStripLabel2);
            startDate.Value = startDate.Value.AddYears(-3);
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private async void UpdateTable() {
            btnSearch.Enabled = false;
            var d = new Dictionary<string, object>();
            d["start-time"] = startDate.Value.TruncToStart();
            d["end-time"] = endDate.Value.TruncToEnd();
            d["mobile"] = tbMobile.Text.Trim();
            d["search-key"] = tbKey.Text.Trim();

            var p = await Messages.GetYiMeiMessages(d);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }

            btnSearch.Enabled = true;
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "status") {
                e.Value = STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

    }
}
