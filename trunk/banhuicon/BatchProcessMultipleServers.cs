using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Banhuitong.Console {
    using Rpc;

    public delegate Task<IResult> BatchProcessMultipleServersRunSingle();
    public partial class BatchProcessMultipleServers : Form {
        public IList<BatchProcessMultipleServersRunSingle> ALL_SEVERS;
        public IList<Tuple<string, string>> m_errorIds;
        public IList<IResult> AllResult { set; get; }
        private int m_complete = 0;

        public BatchProcessMultipleServers() {
            InitializeComponent();
            ALL_SEVERS = new List<BatchProcessMultipleServersRunSingle>();
        }

        private void BatchProcessMultipleServers_Load(object sender, EventArgs e) {
            if (ALL_SEVERS.Count == 0) {
                Commons.ShowErrorBox(this, "未添加服务");
                return;
            }
            m_errorIds = new List<Tuple<string, string>>();
            AllResult = new List<IResult>();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            e.Result = Execute();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = string.Format("{0}%", e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Error != null) {
                Commons.ShowErrorBox(this, e.Error.Message);
            }
            if (m_errorIds.Count > 0) {
                string info = "尚有" + (ALL_SEVERS.Count - m_complete) + "个服务未成功执行.\n";
                foreach (var d in m_errorIds) {
                    info += d.Item1 + ":" + d.Item2 + "\r\n";
                }
                Commons.ShowErrorBox(this, info);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private int Execute() {
            int c = 0;
            for (int i = 0; i < ALL_SEVERS.Count; ++i) {
                if (!backgroundWorker1.CancellationPending) {
                    var r = ALL_SEVERS[i]().Result;
                    ++c;
                    AllResult.Add(r);
                    if (r.IsOk) {
                        ++m_complete;
                    } else {
                        m_errorIds.Add(Tuple.Create(ALL_SEVERS[i].ToString(), r.Exception.Message));
                    }
                    backgroundWorker1.ReportProgress(c * 100 / ALL_SEVERS.Count);
                } else {
                    break;
                }
            }
            return c;
        }

        private void BatchProcessMultipleServers_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = backgroundWorker1.IsBusy;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            backgroundWorker1.CancelAsync();
        }
    }
}
