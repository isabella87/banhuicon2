using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HeyRed.MarkdownSharp;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using Projs;
    public partial class PrjRemarkDlg : Form {
        public enum PrjRemarkTypes { BorrowGuarantee = 2, PrjRating = 3, Bonus = 4, BorrowPerson = 10, BorrowOrg = 11, Others = 99 };
        private PrjRemarkTypes m_type;
        private long m_pId;
        private static Markdown md;
        private bool m_isPrj;
        string m_content;

        static PrjRemarkDlg() {
            md = new Markdown() {
                AutoHyperlink = true,
                AutoNewLines = true,
                LinkEmails = true,
                QuoteSingleLine = true,
                StrictBoldItalic = true
            };
        }

        public PrjRemarkDlg(long pid, PrjRemarkTypes type, bool isPrj = true, string content = "") {
            InitializeComponent();
            m_type = type;
            m_pId = pid;
            m_isPrj = isPrj;
            m_content = content;
        }

        private string GetTypeStr(PrjRemarkTypes type) {
            switch (type) {
                case PrjRemarkTypes.BorrowGuarantee:
                    return "借款担保备注";
                case PrjRemarkTypes.PrjRating:
                    return "项目评级备注";
                case PrjRemarkTypes.Bonus:
                    return "还款计划备注";
                case PrjRemarkTypes.BorrowPerson:
                    return "借款人备注";
                case PrjRemarkTypes.BorrowOrg:
                    return "借款机构备注";
                default:
                    return "编辑";
            }
        }

        private void PrjRemarkDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, GetTypeStr(m_type), m_pId);

            if (m_isPrj)
                UpdateTable();
            else {
                if (!string.IsNullOrWhiteSpace(m_content)) {
                    tbText.Text = m_content;
                    wbHtml.Document.Write(md.Transform(m_content));
                }
            }
        }

        private async void UpdateTable() {
            var p = await Projects.Remark(m_pId, (int)m_type);
            if (p.IsOk) {
                var content = JContainer.Parse(p.AsString).ToString();
                if ((int)m_type == 4 && string.IsNullOrWhiteSpace(content)) {
                    content = "**预计还款时间会随实际募集情况变化，已实际募集结果为准。**";
                }
                if (!string.IsNullOrWhiteSpace(content)) {
                    tbText.Text = content;
                    wbHtml.Document.Write(md.Transform(content));
                }

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void tbText_TextChanged(object sender, EventArgs e) {
            wbHtml.DocumentText = md.Transform(tbText.Text);
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (m_isPrj)
                SaveData();
            else
                DialogResult = DialogResult.OK;
        }

        private async void SaveData() {
            var d = new Dictionary<string, object>();
            d["p-id"] = m_pId;
            d["type"] = (int)m_type;
            d["content"] = tbText.Text;
            var p = await Projects.SaveRemark(d);
            if (p.IsOk) {
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnLinkRules_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://www.appinn.com/markdown/");
        }

        public string MarkDownContent {
            get {
                return tbText.Text;
            }
        }
    }
}
