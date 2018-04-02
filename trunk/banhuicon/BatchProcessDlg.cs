using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using Rpc;

    public delegate IResult BatchProcessRunSingle(long id);

    public partial class BatchProcessDlg : Form {
        public event BatchProcessRunSingle RunSingle;

        private IList<long> m_ids;
        private IDictionary<long, string> m_errorIds;
        private int m_complete = 0;
        public IList<IResult> AllResult { set; get; }

        public BatchProcessDlg(ICollection<long> ids) {
            InitializeComponent();

            m_ids = new List<long>(ids);
        }

        private void BatchProcessDlg_Load(object sender, EventArgs e) {
            if (m_ids.Count == 0) {
                return;
            }

            if (!this.DesignMode) {
                System.Diagnostics.Debug.Assert(RunSingle != null, "未添加响应RungSingle事件的代码");
            }
            AllResult = new List<IResult>();
            m_errorIds = new Dictionary<long, string>();
            backgroundWorker1.RunWorkerAsync(m_ids);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            e.Result = Excute((IList<long>)e.Argument);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = string.Format("{0}%", e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Error != null) {
                Commons.ShowErrorBox(this, e.Error.Message);
            }
            if (m_errorIds != null && m_errorIds.Count > 0) {
                string info = "尚有" + (m_ids.Count - m_complete) + "条未成功执行.\n";
                foreach (var d in m_errorIds) {
                    info += d.Key + ":" + d.Value + "\n";
                }
                Commons.ShowErrorBox(this, info);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private int Excute(IList<long> ids) {
            int c = 0;
            foreach (var id in ids) {
                if (!backgroundWorker1.CancellationPending) {
                    if (RunSingle != null) {
                        IResult r = RunSingle(id);
                        ++c;
                        AllResult.Add(r);
                        if (r.IsOk) {
                            ++m_complete;
                        } else {
                            m_errorIds[id] = r.Exception.Message;
                        }
                        backgroundWorker1.ReportProgress(c * 100 / m_ids.Count);
                    }
                } else {
                    break;
                }
            }
            return c;
        }

        private void BatchProcessDlg_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = backgroundWorker1.IsBusy;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            backgroundWorker1.CancelAsync();
        }
    }
}
