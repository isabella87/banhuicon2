using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using System.IO;
    using BaseData;

    /// <summary>
    /// 实现从MyGridViewBinding导出Excel的对话框。
    /// </summary>
    public partial class DownloadFileDlg : Form {
        /// <summary>
        /// 保存到本地文件的全路径。
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// 下载文件的长度。
        /// </summary>
        public long FileSize { get; private set; }

        /// <summary>
        /// 下载文件的ID。
        /// </summary>
        public long FileId { get; private set; }

        /// <summary>
        /// 下载文件的Hash。
        /// </summary>
        public string FileHash { get; private set; }

        private struct DownloadState {
            private long total;
            private long current;
            private double elapsed;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="total"></param>
            /// <param name="current"></param>
            /// <param name="elapsed"></param>
            public DownloadState(long total, long current, double elapsed) {
                this.total = total;
                this.current = current;
                this.elapsed = elapsed;
            }

            public long Total { get { return total; } }
            public long Current { get { return current; } }
            public double Elpased { get { return elapsed; } }
            public double Speed { get { return elapsed <= 0.01D ? 0D : current / 1024L / elapsed; } }
        }

        public DownloadFileDlg(long fileId, string fileHash, string fileName) {
            InitializeComponent();

            this.FileId = fileId;
            this.FileHash = Commons.NotBlank(fileHash, "fileHash").Trim();
            this.FileName = Commons.NotBlank(fileName, "fileName").Trim();
            this.label2.Text = string.Format(Properties.Resources.DownloadFileDlg_Downloading, this.FileName);
        }

        private void UpdateProgress(long total, long current, double elapsed) {
            var percent = (int)(current * 100 / total);
            backgroundWorker1.ReportProgress(percent, new DownloadState(total, current, elapsed));
        }

        private void DownloadFileDlg_Load(object sender, EventArgs e) {
            // 立刻启动后台下载任务。
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            var d1 = DateTime.Now;
            var total = Files.Length(FileId, FileHash).Result;
            System.Console.WriteLine("total={0}", total);
            var current = 0L;

            using (var fs = new FileStream(FileName, FileMode.Create)) {
                if (total > 0L) {
                    // 只下载长度大于0的文件。
                    UpdateProgress(total, 0, 0D);

                    while (current < total) {
                        var content = Files.Download(FileId, FileHash, current, current + 1024 * 1024L).Result;
                        if (content.Length > 0) {
                            fs.Write(content, 0, content.Length);

                            current += content.Length;
                            if (current > total) {
                                current = total;
                            }
                            var d2 = DateTime.Now;
                            var elapsed = (d2 - d1).TotalSeconds;

                            UpdateProgress(total, current, elapsed);
                        } // end of ContentLength > 0L
                    } // end of while
                } // end of total > 0L
            } // end of using.
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) {
            // 更新进度条的值，以及状态文本。
            this.progressBar1.Value = e.ProgressPercentage;
            var state = (DownloadState)e.UserState;
            var speed = state.Speed;
            var speedMsg = "";
            if (state.Elpased < 1D) {
                // 1秒钟内不显示速度。
                speedMsg = "";
            } else if (double.IsNaN(speed) || double.IsInfinity(speed)) {
                // 速度值无意义时不显示速度。
                speedMsg = "";
            } else if (speed >= 100) {
                // 100KB以上转化为MB每秒。
                speed /= 1024L;
                speedMsg = string.Format("{0:#0.00}MB/s", speed);
            } else {
                // 否则按照KB每秒显示速度。
                speedMsg = string.Format("{0:#0.0}KB/s", speed);
            }
            this.label1.Text = string.Format("{0}/{1}  {2}", state.Current.ToFileLength(), state.Total.ToFileLength(), speedMsg);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            // 如果导出过程没有出现任何异常，那么导出成功，2个打开按钮变为可用。
            // 否则显示错误对话框。
            if (e.Error == null) {
                btnOpenFile.Enabled = true;
                btnOpenFolder.Enabled = true;
                label2.Text = string.Format(Properties.Resources.DownloadFileDlg_Downloaded, FileName);
            } else {
                Commons.ShowErrorBox(this, e.Error.Message);
                Close();
            }
        }

        private void DownloadFileDlg_FormClosing(object sender, FormClosingEventArgs e) {
            // 关闭对话框时自动停止下载任务。
            if (backgroundWorker1.IsBusy) {
                backgroundWorker1.CancelAsync();
            }
        }
    } // end of DownloadFileDlg.
}
