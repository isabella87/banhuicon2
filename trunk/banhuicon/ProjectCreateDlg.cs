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
                string vf = "";

                var r = new Dictionary<string, object>();
                r.AddVF("item-name", tbItemName.Text.Trim(), ref vf)
                .AddVF("item-show-name", "", ref vf)
                .AddVF("out-proxy", "", ref vf)
                .AddVF("in-proxy", "", ref vf)
                .AddVF("amt", 1000, ref vf)
                .AddVF("rate", "", ref vf)
                .AddVF("extension-rate", "", ref vf)
                .AddVF("time-out-rate", "", ref vf)
                .AddVF("penalty-ratio", 0, ref vf)
                .AddVF("borrow-days", 180, ref vf)
                .AddVF("extension-days", 0, ref vf)
                .AddVF("cost-fee", 0, ref vf)
                .AddVF("sold-fee", 0, ref vf)
                .AddVF("invest-max-amt", 0, ref vf)
                .AddVF("in-time", DateTime.Now, ref vf)
                .AddVF("out-time", DateTime.Now, ref vf)
                .AddVF("financing-days", 0, ref vf)
                .AddVF("expected-borrow-time", DateTime.Now, ref vf)
                .AddVF("per-invest-min-amt", 100, ref vf)
                .AddVF("per-invest-amt", 1, ref vf)
                .AddVF("fee-rate", 6, ref vf)
                .AddVF("contract", 0, ref vf)
                .AddVF("key", "", ref vf)
                .AddVF("water-mark", "", ref vf)
                .AddVF("flags", 0, ref vf)
                .AddVF("visible", true, ref vf)
                .AddVF("type", cbbPrjType.GetSelectedValue(), ref vf);

                r["signature"] = Verification.GetSha1(vf);

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
