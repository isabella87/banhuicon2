﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Projs;
    public partial class LoanUploadTimeDlg : Form {
        private static TextValues FILE_STATUS;

        static LoanUploadTimeDlg() {
            FILE_STATUS = new TextValues()
            .AddNew("未上传", -1)
            .AddNew("已上传", 0)
            .AddNew("处理失败", 1)
            .AddNew("处理成功", 2);
        }


        public LoanUploadTimeDlg() {
            InitializeComponent();
        }

        private async void UpdateTable() {
            btnUpdate.Enabled = false;
            var r = await Projects.LoanFileUploadHistory();
            if (r.IsOk) {
                myGridViewBinding1.BindTo(r);
            } else {
                Commons.ShowResultErrorBox(this, r);
            }
            btnUpdate.Enabled = true;
        }

        private void LoanUploadTimeDlg_Load(object sender, EventArgs e) {
            UpdateTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private async void DelFile() {
            btnDel.Enabled = false;
            if (Commons.ShowConfirmBox(this, "确定删除此上传文件吗？", "删除")) {
                var p = await Projects.LoanFileDelete(myGridViewBinding1.GetSelectedValues<long>("tlhId").FirstOrDefault()
                    , myGridViewBinding1.GetSelectedValues<long>("batch").FirstOrDefault());
                if (p.IsOk)
                    myGridViewBinding1.BindTo(p, Commons.BindFlag.Delete, "tlhId");
                else
                    Commons.ShowResultErrorBox(this, p);
            }
            btnDel.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e) {
            DelFile();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "status")
                e.Value = FILE_STATUS.FindByValue(Convert.ToInt32(e.Value));
        }

        private void myGridViewBinding1_GridDataTableSelectedRowChanged(object sender, MyLib.UI.MyGridDataTableSelectedRowChangedArgs e) {
            if (e.SelectedRowIndex.Length == 1) {
                var rowIndex = e.SelectedRowIndex[0];
                var status = Convert.ToInt32(e.GetValue(rowIndex, "status"));
                if (status == -1)
                    btnDel.Enabled = true;
                else
                    btnDel.Enabled = false;
            } else
                btnDel.Enabled = false;
        }
    }
}
