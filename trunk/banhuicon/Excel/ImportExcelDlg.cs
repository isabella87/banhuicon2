using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console.Excel {
    using MyLib.UI;

    /// <summary>
    /// 实现向MyGridViewBinding导入Excel的对话框。
    /// </summary>
    public partial class ImportExcelDlg : Form {
        /// <summary>
        /// 执行导入时触发。
        /// </summary>
        public event ImportExcelEventHandler DoImport;

        /// <summary>
        /// 导入文件的全路径。
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// 需要导入的列。
        /// </summary>
        public IList<MyGridColumn> Columns { get; private set; }

        /// <summary>
        /// 需要导入的数据关联。
        /// </summary>
        public MyGridViewBinding Binding { get; private set; }

        public ImportExcelDlg(MyGridViewBinding binding, IEnumerable<MyGridColumn> columns, string fileName) {
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

        protected void OnDoImport(System.ComponentModel.DoWorkEventArgs e) {
            if (this.DoImport != null) {
                this.DoImport(this, new ImportExcelEventArgs(this, e));
            }
        }

        private void ImportExcelDlg_Load(object sender, EventArgs e) {
            // 立刻启动后台导入任务。
            this.backgroundWorker1.RunWorkerAsync();
        }

        private void ImportExcelDlg_FormClosing(object sender, FormClosingEventArgs e) {
            // 关闭对话框时自动停止导入任务。
            if (backgroundWorker1.IsBusy) {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            // 触发导出事件。
            OnDoImport(e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) {
            // 更新进度条的值，以及状态文本。
            this.progressBar1.Value = e.ProgressPercentage;
            this.label1.Text = e.UserState + "";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            // 如果导出过程没有出现任何异常，那么导入成功，对话框结果为OK。
            // 否则显示错误对话框，对话框结果为Cancel。
            if (e.Error == null) {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            } else {
                Commons.ShowErrorBox(this, e.Error.Message);
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            Close();
        }
    }

    public class ImportExcelEventArgs : EventArgs {
        private ImportExcelDlg dialog;
        private System.ComponentModel.DoWorkEventArgs we;

        public ImportExcelEventArgs(ImportExcelDlg dialog, System.ComponentModel.DoWorkEventArgs we) {
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

    public delegate void ImportExcelEventHandler(object sender, ImportExcelEventArgs e);
}
