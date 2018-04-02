using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using BaseData;
    using Rpc;
    public partial class PrjDebtSignAgreementsDlg : Form {

        private long m_pId;
        private static readonly int STATUSBLANK = -2;
        private static TextValues ALL_AGREEMENTS;
        private static readonly TextValues SIGN_STATUS;
        private static JArray baseData;

        static PrjDebtSignAgreementsDlg() {
            ALL_AGREEMENTS = new TextValues()
            .AddNew("强制债权转让协议通知书(脱敏)", "qz_credit_assign_{0}_54_01.pdf")
            .AddNew("强制债权转让协议通知书(不脱敏)", "qz_credit_assign_{0}_54_00.pdf")
            .AddNew("强制债权转让协议(脱敏)", "qz_credit_assign_notify_{0}_54_01.pdf")
            .AddNew("强制债权转让协议(不脱敏)", "qz_credit_assign_notify_{0}_54_00.pdf");

            SIGN_STATUS = new TextValues()
            .AddNew("未上传", STATUSBLANK)
            .AddNew("已上传", -1)
            .AddNew("未签章", 0)
            .AddNew("部分签章", 1)
            .AddNew("已签章", 2)
            .AddNew("拒绝签署", 3);


        }

        public PrjDebtSignAgreementsDlg(long pid) {
            InitializeComponent();
            m_pId = pid;

            baseData = new JArray();
            foreach (var row in ALL_AGREEMENTS) {
                var jo = new JObject();
                jo.Add("fileType", row.Item1);
                jo.Add("name", string.Format(row.Item2, m_pId));
                jo.Add("status", STATUSBLANK);
                baseData.Add(jo);
            }
        }

        private void PrjSignDlg_Load(object sender, EventArgs e) {
            this.Text += m_pId;
            UpdateTable();
        }

        private async void UpdateTable() {
            toolStrip1.Enabled = false;
            var r = new Dictionary<string, object>();
            var p = await PrjSignAgreements.GetDebtAgreements(m_pId);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(new JsonResult(baseData.ToString()), Commons.BindFlag.Replace, "",
                    () => {
                        myGridViewBinding1.BindTo(p.AsDictList, Commons.BindFlag.Update, "name", ButtonCheck);
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
                e.Value = ALL_AGREEMENTS.FindByValue(Convert.ToString(e.GetValue("name")).Replace(m_pId.ToString(), "{0}"));
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
            var dlg = new FilesDlg(m_pId, 54, AcceptFilter.Image);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private async void Del(IList<string> idArray) {
            toolStrip1.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "确定清空协议嘛?", "清空")) {
                foreach (var id in idArray) {
                    await Files.Delete(id, "");
                }
                UpdateTable();
            }

            toolStrip1.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            var idArray = new List<string>();
            for (var i = 0; i < myGridViewBinding1.DataTable.Count; ++i) {
                var status = Convert.ToInt32(myGridViewBinding1.DataTable[i, "status"]);
                if (status != STATUSBLANK) {
                    idArray.Add(Convert.ToString(myGridViewBinding1.GetCellValue(i, "fileId")));
                }
            }

            if (idArray.Count > 0) {
                Del(idArray);
            }
        }

        private async void UploadDebtAgreements() {
            toolStrip1.Enabled = false;
            var d = new Dictionary<string, object>();
            d["p-id"] = m_pId;
            var p = await PrjSignAgreements.UploadDebtAgreements(d);
            if (p.IsOk) {
                UpdateTable();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            toolStrip1.Enabled = true;
        }

        private void btnUpload_Click(object sender, EventArgs e) {
            UploadDebtAgreements();
        }

        private async void CheckAgreement() {
            toolStrip1.Enabled = false;
            var d = new Dictionary<string, object>();
            d["p-id"] = m_pId;
            d["type"] = 54;
            var p = await PrjSignAgreements.CheckAgreements(d);
            if (p.IsOk) {
                UpdateTable();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            toolStrip1.Enabled = true;
        }

        private void btnCheckAgreement_Click(object sender, EventArgs e) {
            CheckAgreement();
        }

        private async void Sign() {
            toolStrip1.Enabled = false;
            var d = new Dictionary<string, object>();
            d["p-id"] = m_pId;
            var p = await PrjSignAgreements.SignDebtAgreements(d);
            if (p.IsOk) {
                UpdateTable();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            toolStrip1.Enabled = true;
        }

        private void btnSign_Click(object sender, EventArgs e) {
            Sign();
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
            btnClear.Enabled = true;
            btnCreditorInfo.Enabled = true;

            for (var i = 0; i < myGridViewBinding1.DataTable.Count; ++i) {
                var status = Convert.ToInt32(myGridViewBinding1.DataTable[i, "status"]);
                if (status > STATUSBLANK) {
                    btnUpload.Enabled = false;
                    if (status > -1) {
                        btnSign.Enabled = false;
                    } else {
                        btnCheckAgreement.Enabled = false;
                        btnCreditorInfo.Enabled = false;
                    }
                } else {
                    btnSign.Enabled = false;
                    btnCreditorInfo.Enabled = false;
                    btnCheckAgreement.Enabled = false;
                }
            }

            btnClear.Enabled = !btnUpload.Enabled;

        }

        private void btnCreditorInfo_Click(object sender, EventArgs e) {
            var dlg = new PrjCreditorInfoDlg(m_pId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }
    }
}
