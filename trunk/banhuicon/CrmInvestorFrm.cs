using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banhuitong.Console.Crm;
using System.Linq;

namespace Banhuitong.Console {
    using MyLib.UI;
    using Excel;
    //客户关系管理-分配客户
    public partial class CrmInvestorFrm : Form, IHasGridDataTable {
        private static readonly TextValues DATE_TYPES;
        private string m_selUName;

        static CrmInvestorFrm() {
            DATE_TYPES = new TextValues()
                .AddNew("导入时间", 1)
                .AddNew("最新跟进时间", 2);
        }

        public CrmInvestorFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private void FrmCrmInvestor_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, cbDateTypes);
            toolStrip1.AddControlAfter(endDate, toolStripLabel4);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

            cbDateTypes.ComboBox.BindTo(DATE_TYPES, ExtraItems.NoExtra);
            cbPrLevels.ComboBox.BindTo(CrmCommons.PrLevels, ExtraItems.AddAll);

            m_selUName = "";
            tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.NONE_TEXT);
        }

        private async void UpdateTable1() {
            if (m_selUName == CrmCommons.ALL_VALUE && string.IsNullOrWhiteSpace(tbKey.Text)) {
                Commons.ShowInfoBox(this, "请输入关键字");
                return;
            }
            btnSearch.Enabled = false;
            var dateType = cbDateTypes.ComboBox.GetSelectedValue();
            var prLevel = cbPrLevels.ComboBox.GetSelectedValue();

            var p = new Dictionary<string, object>();
            p["u-name"] = m_selUName;
            if (dateType == "1") {
                p["start-date1"] = startDate.Value.TruncToStart();
                p["end-date1"] = endDate.Value.TruncToEnd();
            } else {
                p["start-date2"] = startDate.Value.TruncToStart();
                p["end-date2"] = endDate.Value.TruncToEnd();
            }
            if (prLevel != Commons.AllValue) {
                p["pr-levels"] = prLevel;
            }
            p["search-key"] = tbKey.Text.Trim();

            var r = await CrmInvestor.GetAccounts(p);
            if (r.IsOk) {
                this.myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable1();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "prLevel") {
                e.Value = CrmCommons.PrLevels.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnEdit.Enabled = false;
                btnFollow.Enabled = false;
                btnBindMgr.Enabled = false;
                btnDelete.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                btnEdit.Enabled = true;
                btnFollow.Enabled = true;
                btnBindMgr.Enabled = true;
                btnDelete.Enabled = true;
            } else {
                btnEdit.Enabled = false;
                btnFollow.Enabled = false;
                btnBindMgr.Enabled = false;
                btnDelete.Enabled = true;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e) {
            var dlg = new CrmInvestorDlg(0);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "ciId");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var dlg = new CrmInvestorDlg(myGridViewBinding1.GetSelectedValues<long>("ciId").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "ciId");
            }
        }

        private void btnChooseManager_Click(object sender, EventArgs e) {
            var dlg = new CrmSelMgrDlg((int)CrmCommons.ExtraItem.AddNone |
                (int)CrmCommons.ExtraItem.AddAll | (int)CrmCommons.ExtraItem.AddSelf);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.SelManager = m_selUName;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                m_selUName = dlg.SelManager;
                if (CrmCommons.IsAll(m_selUName)) {
                    tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.ALL_TEXT);
                } else if (CrmCommons.IsNone(m_selUName)) {
                    tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.NONE_TEXT);
                } else if (CrmCommons.IsSelf(m_selUName)) {
                    tbOpUser.Text = CrmCommons.TextBoxShow(CrmCommons.SELF_TEXT);
                } else {
                    tbOpUser.Text = dlg.SelManager;
                }
            }

        }

        private void btnFollow_Click(object sender, EventArgs e) {
            var dlg = new CrmInvestorRemarksDlg(myGridViewBinding1.GetSelectedValues<long>("ciId").FirstOrDefault(), true);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.Cancel) {
                UpdateTable1();
            }
        }

        private async void Delete(IList<long> idArray) {
            btnDelete.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下投资客户：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await CrmInvestor.DelAccount(id);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "ciId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }

                Commons.ShowInfoBox(this, "投资客户：" + ss + " 已被删除。");
            }
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<long>("ciId").ToList();
            if (idArray.Count > 0)
                Delete(idArray);
        }

        private void btnImport_Click(object sender, EventArgs e) {
            var dlg = new ImportWizardDlg(new List<Tuple<string, CellType, bool>>() {
                ImportWizardDlg.MakeColumn("姓名",CellType.Text),
                ImportWizardDlg.MakeColumn("手机",CellType.Mobile,true),
                ImportWizardDlg.MakeColumn("工作单位",CellType.Text),
                ImportWizardDlg.MakeColumn("职务",CellType.Text),
                ImportWizardDlg.MakeColumn("所在城市",CellType.Text),
                ImportWizardDlg.MakeColumn("年龄",CellType.Age),
                ImportWizardDlg.MakeColumn("性别",CellType.Text),
                ImportWizardDlg.MakeColumn("备注",CellType.Text),
                ImportWizardDlg.MakeColumn("客户来源",CellType.Text),
                ImportWizardDlg.MakeColumn("等级",CellType.Text)});
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (index, gridView) => {
                var r = new Dictionary<string, object>();
                r["ci-id"] = 0;
                r["real-name"] = gridView.Rows[index].Cells[0].Value.TrimStr();
                r["mobile"] = gridView.Rows[index].Cells[1].Value.TrimStr();
                r["company"] = gridView.Rows[index].Cells[2].Value.TrimStr();
                r["position"] = gridView.Rows[index].Cells[3].Value.TrimStr();
                r["city"] = gridView.Rows[index].Cells[4].Value.TrimStr();
                var ageStr = gridView.Rows[index].Cells[5].Value.TrimStr();
                if (ageStr != "") {
                    var age = Convert.ToInt32(ageStr);
                    if (age > 0) {
                        r["birth"] = DateTime.Now.AddYears(-age).TruncToStart();
                    }
                }
                var gender = gridView.Rows[index].Cells[6].Value.TrimStr();
                if (gender == "男")
                    r["gender"] = 1;
                else if (gender == "女")
                    r["gender"] = 2;
                else r["gender"] = 0;
                var remark = gridView.Rows[index].Cells[7].Value.TrimStr();
                r["remark"] = remark.Substring(0, Math.Min(remark.Length, 200));
                r["origin-type"] = gridView.Rows[index].Cells[8].Value.TrimStr();
                var prLevelStr = CrmCommons.PrLevels.FindByText(gridView.Rows[index].Cells[9].Value.TrimStr());
                if (prLevelStr != "") {
                    var prLevel = Convert.ToInt32(prLevelStr);
                    if (prLevel > 0) {
                        r["pr-level"] = prLevel;
                    }
                }

                var p = CrmInvestor.Create(r).Result;
                if (p.IsOk)
                    myGridViewBinding1.BindTo(p, Commons.BindFlag.Update, "ciId");
                return p;
            };

            dlg.ShowDialog(this);
        }

        private void btnBatchBind_Click(object sender, EventArgs e) {
            var dlg = new ImportWizardDlg(new List<Tuple<string, CellType, bool>>() { 
                ImportWizardDlg.MakeColumn("姓名",CellType.Text,true), 
                ImportWizardDlg.MakeColumn("手机",CellType.Text,true), 
                ImportWizardDlg.MakeColumn("客户经理",CellType.Text,true)});
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.RunSingle += (index, gridView) => {
                var d = new Dictionary<string, object>();
                d["realName"] = gridView.Rows[index].Cells[0].Value;
                d["mobile"] = gridView.Rows[index].Cells[1].Value;
                d["u-name"] = gridView.Rows[index].Cells[2].Value;

                return CrmInvestor.BatchBindMgrAndCrmInvestor(d).Result;
            };

            if (dlg.ShowDialog(this) == DialogResult.Cancel) {
                UpdateTable1();
            }
        }

        private void btnReassignCustomers_Click(object sender, EventArgs e) {
            if (myGridViewBinding1.View.RowCount == 0) {
                Commons.ShowInfoBox(this, "无待分配客户");
                return;
            }
            var ids = new List<long>();
            for (int i = 0; i < myGridViewBinding1.View.RowCount; ++i) {
                ids.Add(Convert.ToInt64(myGridViewBinding1.DataTable[i, "ciId"]));
            }
            var dlg = new CrmBindMgrAndCrmInvestor2Dlg(ids, false, m_selUName);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                UpdateTable1();
            }
        }

        private void btnBindMgr_Click(object sender, EventArgs e) {
            var dlg = new CrmBindMgrAndCrmInvestorDlg(myGridViewBinding1.GetSelectedValues<long>("ciId").FirstOrDefault(),
                myGridViewBinding1.GetSelectedValues<string>("realName").FirstOrDefault(), false);
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                UpdateTable1();
            }
        }
    }
}
