using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Banhuitong.Console.Excel {
    using MyLib.UI;
    using NPOI.HSSF.UserModel;

    /// <summary>
    /// 实现从MyGridViewBinding导出Excel的对话框。
    /// </summary>
    public partial class ExportExcelDlg : Form {
        /// <summary>
        /// 执行导出时触发。
        /// </summary>
        public event ExportExcelEventHandler DoExport;

        /// <summary>
        /// 导出文件的全路径。
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// 需要导出的列。
        /// </summary>
        public IList<MyGridColumn> Columns { get; private set; }

        /// <summary>
        /// 需要导出的数据关联。
        /// </summary>
        public MyGridViewBinding Binding { get; private set; }

        public ExportExcelDlg(MyGridViewBinding binding, IEnumerable<MyGridColumn> columns, string fileName) {
            InitializeComponent();

            this.Binding = Commons.NotNull(binding, "binding");
            var columns_ = new List<MyGridColumn>();
            if (columns != null) {
                columns_.AddRange(columns);
            }
            this.Columns = columns_;
            this.FileName = Commons.NotBlank(fileName, "fileName").Trim();
        }

        /// <summary>
        /// 更新导出进度。
        /// </summary>
        /// <param name="current">当前成功导出的记录数。</param>
        /// <param name="message">表示导出进度的消息文本。</param>
        internal void UpdateProgress(int current, string message = "") {
            int percentage;
            int total = this.Binding.DataTable.Count;
            if (current == total) {
                percentage = 100;
            } else {
                percentage = current * 100 / total;
            }
            message = (message + "").Trim();
            if (message == "") {
                message = string.Format("{0}/{1}", current, total);
            }
            backgroundWorker1.ReportProgress(percentage, message);
        }

        protected void OnDoExport(System.ComponentModel.DoWorkEventArgs e) {
            if (this.DoExport != null) {
                this.DoExport(this, new ExportExcelEventArgs(this, e));
            }
        }

        private void ExportExcelDlg_Load(object sender, EventArgs e) {
            // 立刻启动后台导出任务。
            this.backgroundWorker1.RunWorkerAsync();
        }

        private void btnOpenFile_Click(object sender, EventArgs e) {
            // 调用Shell打开导出的文件。
            Process.Start(new ProcessStartInfo() {
                FileName = this.FileName,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void btnOpenFolder_Click(object sender, EventArgs e) {
            // 调用资源管理器打开文件夹，并选中导出的文件。
            Process.Start(new ProcessStartInfo() {
                FileName = @"explorer.exe",
                Arguments = "/select," + this.FileName,
            });
        }

        private void ExportExcelDlg_FormClosing(object sender, FormClosingEventArgs e) {
            // 关闭对话框时自动停止导出任务。
            if (backgroundWorker1.IsBusy) {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            // 触发导出事件。
            OnDoExport(e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) {
            // 更新进度条的值，以及状态文本。
            this.progressBar1.Value = e.ProgressPercentage;
            this.label1.Text = e.UserState + "";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            // 如果导出过程没有出现任何异常，那么导出成功，2个打开按钮变为可用。
            // 否则显示错误对话框。
            if (e.Error == null) {
                btnOpenFile.Enabled = true;
                btnOpenFolder.Enabled = true;
            } else {
                Commons.ShowErrorBox(this, e.Error.Message);
                Close();
            }
        }
    } // end of ExportExcelDlg.

    public class ExportExcelEventArgs : EventArgs {
        private ExportExcelDlg dialog;
        private System.ComponentModel.DoWorkEventArgs we;

        public ExportExcelEventArgs(ExportExcelDlg dialog, System.ComponentModel.DoWorkEventArgs we) {
            this.dialog = Commons.NotNull(dialog, "dialog");
            this.we = Commons.NotNull(we, "we");
        }

        /// <summary>
        /// 更新导出进度。
        /// </summary>
        /// <param name="current">当前成功导出的记录数。</param>
        /// <param name="message">表示导出进度的消息文本。</param>
        public void UpdateProgress(int current, string message = "") {
            this.dialog.UpdateProgress(current, message);
        }

        /// <summary>
        /// 导出的数据关联。
        /// </summary>
        public MyGridViewBinding Binding {
            get {
                return this.dialog.Binding;
            }
        }

        /// <summary>
        /// 导出的列。
        /// </summary>
        public IList<MyGridColumn> Columns {
            get {
                return this.dialog.Columns;
            }
        }

        /// <summary>
        /// 导出的文件名。
        /// </summary>
        public string FileName {
            get {
                return this.dialog.FileName;
            }
        }

        /// <summary>
        /// 是否取消导出。
        /// </summary>
        public bool Cannelled {
            get {
                return we.Cancel;
            }
        }
    }

    public delegate void ExportExcelEventHandler(object sender, ExportExcelEventArgs e);
}
