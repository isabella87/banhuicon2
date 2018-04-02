using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Banhuitong.Console.Projs;

namespace Banhuitong.Console {
    using MyLib.UI;
    public partial class EnterprisePrjFrm : Form, IHasGridDataTable {
        private bool PrjReadOnly = false;
        private static readonly TextValues TIME_TYPES;
        private static readonly TextValues KEY_TYPES;
        public static readonly TextValues STATUS;
        public static readonly TextValues STATUS_SIGN;

        static EnterprisePrjFrm() {
            TIME_TYPES = new TextValues()
            .AddNew("创建时间", 1)
            .AddNew("上线时间", 2)
            .AddNew("放款时间", 3);
            KEY_TYPES = new TextValues()
                .AddNew("编号", 1)
                .AddNew("名称", 2)
                .AddNew("融资方", 3)
                .AddNew("创建人", 4);
            STATUS = new TextValues()
                .AddNew("未提交", 0)
                .AddNew("待项目经理审批", 1)
                .AddNew("待风控审批", 10)
                .AddNew("待评委会审批", 20)
                .AddNew("待业务副总审批", 30)
                .AddNew("募集中", 40)
                .AddNew("已募集满标", 50)
                .AddNew("已确认满标", 60)
                .AddNew("待复评", 70)
                .AddNew("已放款", 80)
                .AddNew("正在还款", 90)
                .AddNew("已结清", 999)
                .AddNew("流标", -1);
            STATUS_SIGN = new TextValues()
            .AddNew("未完成", 0)
            .AddNew("已完成", 1);
        }

        public EnterprisePrjFrm() {
            InitializeComponent();
        }

        public MyGridViewBinding GridViewBinding {
            get {
                return myGridViewBinding1;
            }
        }

        private async void UpdateTable1() {
            btnSearch.Enabled = false;
            var timeType = cbbTimeTypes.ComboBox.GetSelectedValue();
            var status = cbStatus.ComboBox.GetSelectedValue();
            var type = cbTypes.ComboBox.GetSelectedValue();
            var key = tbKey.Text.Trim();
            var prjType = cbbPrjType.ComboBox.GetSelectedValue();

            var p = new Dictionary<string, object>();
            switch (timeType) {
                case "1":
                    p["start-time"] = startDate.Value.TruncToStart();
                    p["end-time"] = endDate.Value.TruncToEnd();
                    break;
                case "2":
                    p["on-line-start-time"] = startDate.Value.TruncToStart();
                    p["on-line-end-time"] = endDate.Value.TruncToEnd();
                    break;
                case "3":
                    p["loan-start-time"] = startDate.Value.TruncToStart();
                    p["loan-end-time"] = endDate.Value.TruncToEnd();
                    break;
            }
            if (prjType != Commons.AllValue) {
                p["type"] = prjType;
            }
            if (status != Commons.AllValue) {
                p["status"] = status;
            }
            switch (type) {
                case "1":
                    p["item-no-key"] = key;
                    break;
                case "2":
                    p["item-name-key"] = key;
                    break;
                case "3":
                    p["financier-key"] = key;
                    break;
                case "4":
                    p["creator-key"] = key;
                    break;
            }

            var r = await Projects.GetAllPrjs(p);
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

        private void EnterprisePrjFrm_Load(object sender, EventArgs e) {
            toolStrip1.AddControlAfter(startDate, cbbTimeTypes);
            toolStrip1.AddControlAfter(endDate, toolStripLabel3);

            var dateRange = Commons.MakeDateRange(DateTime.Today);
            startDate.Value = dateRange.Item1;
            endDate.Value = dateRange.Item2;

            cbbTimeTypes.ComboBox.BindTo(TIME_TYPES);
            cbbPrjType.ComboBox.BindTo(Projects.PrjProperty, ExtraItems.AddAll);
            cbStatus.ComboBox.BindTo(STATUS, ExtraItems.AddAll);
            cbStatus.ComboBox.SelectedIndex = 6;
            cbTypes.ComboBox.BindTo(KEY_TYPES);
        }


        private void btnCreatePrj_Click(object sender, EventArgs e) {
            using (var dlgCreate = new ProjectCreateDlg()) {
                if (dlgCreate.ShowDialog(this) == DialogResult.OK) {
                    if (dlgCreate.NewId != 0) {
                        myGridViewBinding1.BindTo(dlgCreate.DlgResult, Commons.BindFlag.Update, "pId");
                        PrjReadOnly = false;
                        Edit(dlgCreate.NewId);
                    } else {
                        Commons.ShowErrorBox(this, "创建失败");
                    }
                }
            }
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyGridDataTableDisplayValueNeededArgs e) {
            var key = e.Key;
            if (key == "itemName") {
                e.Value = Convert.ToString(e.Value) + (Convert.ToBoolean(e.GetValue("visible")) ? "" : "(已隐藏)");
                e.Value = Convert.ToString(e.Value) + (Convert.ToBoolean(e.GetValue("topTime")) ? "(已置顶)" : "");
                e.Value = Convert.ToString(e.Value) + (Convert.ToBoolean(e.GetValue("lockedTime")) ? "(已锁定)" : "");
            } else if (key == "status") {
                e.Value = STATUS.FindByValue(Convert.ToString(e.Value));
            } else if (key == "type") {
                e.Value = Projects.PrjProperty.FindByValue(Convert.ToString(e.Value));
            } else if (key == "signStatus") {
                e.Value = STATUS_SIGN.FindByValue(Convert.ToString(e.Value));
            }
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 0) {
                btnPrjAudit.Enabled = false;
                btnPrjDel.Enabled = false;
                btnPrjEdit.Enabled = false;
                btnPrjHide.Enabled = false;
                btnPrjRepay.Enabled = false;
                btnPrjTop.Enabled = false;
                btnSignAgreements.Enabled = false;
            } else if (e.SelectedRowIndex.Length == 1) {
                var rowIndex = e.SelectedRowIndex[0];
                var status = Convert.ToInt32(e.GetValue(rowIndex, "status"));
                var visible = Convert.ToBoolean(e.GetValue(rowIndex, "visible"));
                var topTime = Convert.ToBoolean(e.GetValue(rowIndex, "topTime"));


                btnPrjAudit.Enabled = true;
                btnPrjDel.Enabled = status == 0;
                btnPrjEdit.Enabled = true;
                btnPrjHide.Enabled = true;
                btnPrjTop.Enabled = true;

                if (!MainFrm.IsAdmin && status != 0) {
                    btnPrjEdit.Text = "查看";
                    PrjReadOnly = true;
                } else {
                    btnPrjEdit.Text = "编辑";
                    PrjReadOnly = false;
                }

                btnPrjRepay.Enabled = status >= 90;

                btnSignAgreements.Enabled = status >= 60;

                if (visible)
                    btnPrjHide.Text = "隐藏";
                else
                    btnPrjHide.Text = "显示";

                if (topTime)
                    btnPrjTop.Text = "取消置顶";
                else
                    btnPrjTop.Text = "置顶";

            } else {
                btnPrjAudit.Enabled = false;
                btnPrjDel.Enabled = true;
                btnPrjEdit.Enabled = false;
                btnPrjHide.Enabled = false;
                btnPrjRepay.Enabled = false;
                btnPrjTop.Enabled = false;
                btnSignAgreements.Enabled = false;

                var selRows = e.SelectedRowIndex;
                foreach (var row in selRows) {
                    var status = e.GetValue(row, "status");
                    if (Convert.ToInt32(status) != 0) {
                        btnPrjDel.Enabled = false;
                        break;
                    }
                }
            }
        }

        private void Edit(long bpmId) {
            var dlg = new EnterprisePrjDlg(bpmId);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.SetReadOnly(PrjReadOnly);
            dlg.PrjReadOnly = PrjReadOnly;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                myGridViewBinding1.BindTo(dlg.DlgResult, Commons.BindFlag.Update, "pId");
            }
        }

        private void btnPrjEdit_Click(object sender, EventArgs e) {
            var pId = myGridViewBinding1.GetSelectedValues<long>("pId").FirstOrDefault();
            if (pId != 0) {
                Edit(pId);
            }
        }

        private async void Delete(IList<long> idArray) {
            btnPrjDel.Enabled = false;
            var ss = idArray.JoinSome();
            if (Commons.ShowConfirmBox(this, "删除以下项目：" + ss + " 此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    var p = await Projects.DeleteProj(id);
                    if (p.IsOk) {
                        myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "pId");
                    } else {
                        Commons.ShowResultErrorBox(this, p);
                    }
                }

                UpdateTable1();

                Commons.ShowInfoBox(this, "项目：" + ss + " 已被删除。");
            }
            btnPrjDel.Enabled = true;
        }

        private void btnPrjDel_Click(object sender, EventArgs e) {
            var idArray = myGridViewBinding1.GetSelectedValues<long>("pId").ToList();
            if (idArray.Count > 0) {
                Delete(idArray);
            }
        }

        private void btnPrjAudit_Click(object sender, EventArgs e) {
            if (myGridViewBinding1.View.SelectedRows.Count != 1) {
                return;
            }
            var dlg = new PrjAuditDlg(myGridViewBinding1.GetSelectedValues<long>("pId").FirstOrDefault(),
                myGridViewBinding1.GetSelectedValues<int>("status").FirstOrDefault(),
                myGridViewBinding1.GetSelectedValues<int>("signStatus").FirstOrDefault(),
                myGridViewBinding1.GetSelectedValues<bool>("lockedTime").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                UpdateTable1();
            }
        }

        private void btnPrjRepay_Click(object sender, EventArgs e) {
            if (myGridViewBinding1.View.SelectedRows.Count != 1) {
                return;
            }
            var dlg = new PrjRepayDlg(myGridViewBinding1.GetSelectedValues<long>("pId").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                UpdateTable1();
            }
        }

        private async void ShowProj(long id, bool visible) {
            var r = new Dictionary<string, object>();
            r["pid"] = id;
            r["visible"] = visible;
            var p = await Projects.ShowProj(r);
            if (p.IsOk) {
                UpdateTable1();
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnPrjHide_Click(object sender, EventArgs e) {
            if (myGridViewBinding1.View.SelectedRows.Count != 1) {
                return;
            }
            ShowProj(myGridViewBinding1.GetSelectedValues<long>("pId").FirstOrDefault(),
                !myGridViewBinding1.GetSelectedValues<bool>("visible").FirstOrDefault());
        }

        private async void ToTop(long id, bool isToTop) {
            if (isToTop) {
                var r = await Projects.PrjRevokeTop(id);
                if (r.IsOk) {
                    UpdateTable1();
                } else {
                    Commons.ShowResultErrorBox(this, r);
                }
            } else {
                var r = await Projects.PrjToTop(id);
                if (r.IsOk) {
                    UpdateTable1();
                } else {
                    Commons.ShowResultErrorBox(this, r);
                }
            }
        }

        private void btnPrjTop_Click(object sender, EventArgs e) {
            if (myGridViewBinding1.View.SelectedRows.Count != 1) {
                return;
            }
            ToTop(myGridViewBinding1.GetSelectedValues<long>("pId").FirstOrDefault(),
                myGridViewBinding1.GetSelectedValues<bool>("topTime").FirstOrDefault());
        }

        private void btnSearchRepayHistory_Click(object sender, EventArgs e) {
            var dlg = new RepayUploadTimeDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnSearchLoanHistory_Click(object sender, EventArgs e) {
            var dlg = new LoanUploadTimeDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void btnSignAgreements_Click(object sender, EventArgs e) {
            var dlg = new PrjSignAgreementsDlg(myGridViewBinding1.GetSelectedValues<long>("pId").FirstOrDefault());
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

    }
}
