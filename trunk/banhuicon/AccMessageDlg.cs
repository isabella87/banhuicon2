using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using HeyRed.MarkdownSharp;

namespace Banhuitong.Console {
    using Account;
    using Rpc;
    public partial class AccMessageDlg : Form {

        private long m_amId;
        private long m_auId = 0;
        private string m_mdText = "";
        private static Markdown m_md;
        public IResult DlgResult { get; private set; }

        static AccMessageDlg() {
            m_md = new Markdown() {
                AutoHyperlink = true,
                AutoNewLines = true,
                LinkEmails = true,
                QuoteSingleLine = true,
                StrictBoldItalic = true
            };
        }

        public AccMessageDlg(long amId) {
            InitializeComponent();
            m_amId = amId;
            DlgResult = new JsonResult("{}");
        }

        private void AccMessageDlg_Load(object sender, EventArgs e) {
            if (m_amId == 0) {
                this.Text = "创建消息";
            } else {
                this.Text = "查看消息-" + m_amId;
            }

            UpdateTable();
        }

        private async void UpdateTable() {
            var p = await Messages.GetMessage(m_amId);
            if (p.IsOk) {
                var d = p.AsDictionary;
                m_auId = d.GetOrDefault<long>("auId");
                tbTarget.Text = string.Format("{0}({1})", d.GetOrDefault<string>("loginName"), d.GetOrDefault<string>("realName"));
                tbTitle.Text = d.GetOrDefault<string>("title");
                tbBrief.Text = d.GetOrDefault<string>("brief");
                m_mdText = d.GetOrDefault<string>("content");
                wbHtml.DocumentText = m_md.Transform(m_mdText);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnEditHtml_Click(object sender, EventArgs e) {
            var dlg = new PrjRemarkDlg(m_amId, PrjRemarkDlg.PrjRemarkTypes.Others, false, m_mdText);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_mdText = dlg.MarkDownContent;
                wbHtml.DocumentText = m_md.Transform(m_mdText);
            }
        }

        private void btnMatch_Click(object sender, EventArgs e) {
            MatchInvest();
        }

        private async void MatchInvest() {
            btnMatch.Enabled = false;
            var d = new Dictionary<string, object>();
            d["key"] = tbTarget.Text;
            var p = await Messages.MatchInvest(d);
            if (p.IsOk) {
                var dl = JArray.Parse(p.AsString).ToList();
                if (dl.Count != 0) {
                    m_auId = dl[0]["auId"].ToInt64();
                    tbTarget.Text = string.Format("{0}({1})", dl[0]["loginName"].ToStdString(), dl[0]["realName"].ToStdString());
                } else {
                    m_auId = 0;
                    tbTarget.Text = "";
                    tbTarget.Focus();
                    Commons.ShowInfoBox(this, "未匹配到收件人!");
                }
            } else {
                m_auId = 0;
                tbTarget.Text = "";
                tbTarget.Focus();
                Commons.ShowResultErrorBox(this, p);
            }
            btnMatch.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren())
                SaveData();
        }

        private async void SaveData() {
            if (m_auId == 0) {
                btnMatch.Focus();
                Commons.ShowInfoBox(this, "未选择收件人");
                return;
            }
            if (string.IsNullOrWhiteSpace(m_mdText)) {
                Commons.ShowInfoBox(this, "不能发送空消息");
                return;
            }
            var r = new Dictionary<string, object>();
            r["au-id"] = m_auId;
            r["title"] = tbTitle.Text.Trim();
            r["brief"] = tbBrief.Text.Trim();
            r["content"] = m_mdText;
            r["type"] = 1;

            var p = await Messages.SaveMessage(r);
            if (p.IsOk) {
                DlgResult = p;
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }
    }
}
