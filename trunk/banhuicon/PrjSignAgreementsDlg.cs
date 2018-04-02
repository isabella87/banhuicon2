using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using BaseData;
    using Rpc;
    public partial class PrjSignAgreementsDlg : Form {

        private long m_pId;
        private static readonly int STATUSBLANK = -2;
        private static readonly TextValues ALL_AGREEMENTS;
        private static readonly TextValues SIGN_STATUS;
        private static readonly JArray baseData;

        static PrjSignAgreementsDlg() {
            ALL_AGREEMENTS = new TextValues()
            .AddNew("借款协议(脱敏)", 37)
            .AddNew("借款协议(不脱敏)", 38)
            .AddNew("借款协议(半脱敏)", 39)
            .AddNew("出借居间协议(脱敏)", 40)
            .AddNew("出借居间协议(不脱敏)", 41)
            .AddNew("借款居间协议(不脱敏)", 42);

            SIGN_STATUS = new TextValues()
            .AddNew("未上传", STATUSBLANK)
            .AddNew("已上传", -1)
            .AddNew("未签章", 0)
            .AddNew("部分签章", 1)
            .AddNew("已签章", 2)
            .AddNew("拒绝签署", 3);

            baseData = new JArray();
            foreach (var row in ALL_AGREEMENTS) {
                var jo = new JObject();
                jo.Add("fileType", row.Item2);
                jo.Add("status", STATUSBLANK);
                baseData.Add(jo);
            }
        }

        public PrjSignAgreementsDlg(long pid) {
            InitializeComponent();
            m_pId = pid;
        }

        private void PrjSignDlg_Load(object sender, EventArgs e) {
            this.Text += m_pId;
            UpdateTable();
        }

        private async void UpdateTable() {
            toolStrip1.Enabled = false;
            var r = new Dictionary<string, object>();
            var p = await PrjSignAgreements.GetPrjAgreement(m_pId);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(new JsonResult(baseData.ToString()), Commons.BindFlag.Replace, "",
                    () => {
                        myGridViewBinding1.BindTo(p.AsDictList, Commons.BindFlag.Update, "fileType", ButtonCheck);
                    });
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            toolStrip1.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "fileType") {
                e.Value = ALL_AGREEMENTS.FindByValue(Convert.ToString(e.Value));
            } else if (e.Key == "status") {
                e.Value = SIGN_STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnDownLoad.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                var row = e.SelectedRowIndex[0];
                var status = Convert.ToInt32(e.GetValue(row, "status"));

                btnDownLoad.Enabled = status == 2;
            } else {
                btnDownLoad.Enabled = false;
            }
        }

        private void btnDownLoad_Click(object sender, EventArgs e) {
            var dlg = new FilesDlg(m_pId, myGridViewBinding1.GetSelectedValues<int>("fileType").FirstOrDefault(), AcceptFilter.Image);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private async void Del(IList<Tuple<string, string>> delInfo) {
            toolStrip1.Enabled = false;
            var ss = delInfo.JoinSome();
            if (Commons.ShowConfirmBox(this, "确定清空协议嘛?", "清空")) {
                foreach (var single in delInfo) {
                    var d = new Dictionary<string, object>();
                    d["p-id"] = m_pId;
                    d["file-name"] = single.Item1;
                    d["file-type"] = ALL_AGREEMENTS.FindByText(single.Item2);
                    await PrjSignAgreements.deleteAgreements(d);
                }
                UpdateTable();
            }

            toolStrip1.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            var delInfo = new List<Tuple<string, string>>();
            for (var i = 0; i < myGridViewBinding1.DataTable.Count; ++i) {
                var status = Convert.ToInt32(myGridViewBinding1.DataTable[i, "status"]);
                if (status != STATUSBLANK) {
                    delInfo.Add(Tuple.Create(Convert.ToString(myGridViewBinding1.GetCellValue(i, "name")),
                        Convert.ToString(myGridViewBinding1.GetCellValue(i, "fileType"))));
                }
            }

            if (delInfo.Count > 0) {
                Del(delInfo);
            }
        }

        private void btnSignInfo_Click(object sender, EventArgs e) {
            var dlg = new PrjSignInfoDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnUpload_Click(object sender, EventArgs e) {
            var dlg = new BatchProcessDlg(ALL_AGREEMENTS.Select<Tuple<string, string>, long>(a => { return Convert.ToInt64(a.Item2); }).ToList());
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (type) => {
                var d = new Dictionary<string, object>();
                d["p-id"] = m_pId;
                d["type"] = type;
                return PrjSignAgreements.UploadPrjAgreements(d).Result;
            };
            dlg.ShowDialog();
            UpdateTable();
        }

        private void btnCheckAgreement_Click(object sender, EventArgs e) {
            var dlg = new BatchProcessDlg(ALL_AGREEMENTS.Select<Tuple<string, string>, long>(a => { return Convert.ToInt64(a.Item2); }).ToList());
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (type) => {
                var d = new Dictionary<string, object>();
                d["p-id"] = m_pId;
                d["type"] = type;
                return PrjSignAgreements.CheckAgreements(d).Result;
            };
            dlg.ShowDialog();
            UpdateTable();
        }

        private void btnSign_Click(object sender, EventArgs e) {
            var types = new List<long>(new long[] { 1, 2, 3 });
            var dlg = new BatchProcessDlg(types);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (type) => {
                var d = new Dictionary<string, object>();
                d["p-id"] = m_pId;
                d["type"] = type;
                return PrjSignAgreements.SignPrjAgreements(d).Result;
            };
            dlg.ShowDialog();
            UpdateTable();
        }

        /// <summary>
        /// btnUpload在全部签章状态为-2时才能点
        /// btnSign在状态为-1时才能点
        /// btnCheckAgreement在状态大于-1时才可以用
        /// btnSignInfo在状态大于-1时才能用
        /// btnClear在状态都大于-2时才能用
        /// </summary>
        private void ButtonCheck() {
            btnUpload.Enabled = true;
            btnSign.Enabled = true;
            btnCheckAgreement.Enabled = true;
            btnSignInfo.Enabled = true;
            btnClear.Enabled = true;

            for (var i = 0; i < myGridViewBinding1.DataTable.Count; ++i) {
                var status = Convert.ToInt32(myGridViewBinding1.DataTable[i, "status"]);
                if (status > STATUSBLANK) {
                    btnUpload.Enabled = false;
                    if (status > -1) {
                        btnSign.Enabled = false;
                    } else {
                        btnSignInfo.Enabled = false;
                        btnCheckAgreement.Enabled = false;
                    }
                } else {
                    btnSignInfo.Enabled = false;
                    btnSign.Enabled = false;
                    btnCheckAgreement.Enabled = false;
                }
            }

            btnClear.Enabled = !btnUpload.Enabled;

        }
    }
}
