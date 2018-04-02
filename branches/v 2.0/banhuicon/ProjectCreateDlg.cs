using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banhuitong.Console.Projs;

namespace Banhuitong.Console {
    using Rpc;
    public partial class ProjectCreateDlg : Form {
        public IResult DlgResult { get; private set; }
        public long NewId {
            get;
            private set;
        }
        public ProjectCreateDlg() {
            InitializeComponent();
            DlgResult = new JsonResult("{}");
        }

        private void btnCommit_Click(object sender, EventArgs e) {
            Commit();

        }

        private async void Commit() {
            btnCommit.Enabled = false;
            try {
                var r = new Dictionary<string, object>();
                r["pid"] = 0;
                r["item-name"] = tbItemName.Text.Trim();
                r["item-show-name"] = "";
                r["out-proxy"] = "";
                r["in-proxy"] = "";
                r["amt"] = 1000;
                r["rate"] = "";
                r["extension-rate"] = "";
                r["time-out-rate"] = "";
                r["penalty-ratio"] = "";
                r["borrow-days"] = 180;
                r["extension-days"] = 0;
                r["cost-fee"] = 0;
                r["sold-fee"] = 0;
                r["invest-max-amt"] = 0;
                r["in-time"] = DateTime.Now;
                r["out-time"] = DateTime.Now;
                r["financing-days"] = 0;
                r["expected-borrow-time"] = DateTime.Now;
                r["per-invest-min-amt"] = 100;
                r["per-invest-amt"] = 1;
                r["fee-rate"] = 6;
                r["contract"] = 0;
                r["key"] = "";
                r["water-mark"] = "";
                r["flags"] = 0;
                r["visible"] = true;
                r["type"] = cbbPrjType.GetSelectedValue();

                var p = await Projects.Create(r);
                if (p.IsOk) {
                    var d = p.AsDictionary;
                    NewId = d.GetOrDefault<long>("pId");
                    DlgResult = p;
                    DialogResult = DialogResult.OK;
                } else {
                    Commons.ShowResultErrorBox(this, p);
                }
            } finally {
                btnCommit.Enabled = true;
            }

        }

        private void ProjectCreateDlg_Load(object sender, EventArgs e) {
            //cbbPrjType.BindTo(Projects.PrjProperty);
            cbbPrjType.BindTo(new TextValues().AddNew("企业贷", 10).AddNew("票据贷", 5));
        }
    }
}
