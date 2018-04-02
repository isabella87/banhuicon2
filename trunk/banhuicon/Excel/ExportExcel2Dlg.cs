using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Banhuitong.Console.Excel {
    using StatisticsCell = Tuple<string, Excel.CellStyleCustom>;
    using StatisticsRow = List<Tuple<string, Excel.CellStyleCustom>>;

    public delegate void GetPageData(IList<Dictionary<string, object>> d);
    public delegate string GetCellStrDelegate(StatisticsCell s, IDictionary<string, object> d, ICell c);
    public partial class ExportExcel2Dlg : Form {
        public IList<GetPageData> ALL_SERVERS;
        public event GetCellStrDelegate GetCellStr;

        public IList<Dictionary<string, object>> m_contents;
        private IList<string> m_labels;
        private IList<StatisticsRow> m_pageModel;
        private string m_fileName;
        private HSSFWorkbook m_workBook;


        public ExportExcel2Dlg(IList<string> label, IList<StatisticsRow> model) {
            InitializeComponent();
            m_labels = label;
            m_pageModel = model;
            m_contents = new List<Dictionary<string, object>>();
            ALL_SERVERS = new List<GetPageData>();
        }

        private void ExportExcel2Dlg_Load(object sender, EventArgs e) {
            if (ALL_SERVERS.Count > 0) {
                var dlg = new System.Windows.Forms.SaveFileDialog();
                dlg.Title = Properties.Resources.Excel_SaveFile;
                dlg.Filter = Properties.Resources.Excel_SaveFile_Filter;
                dlg.AddExtension = true;
                dlg.AutoUpgradeEnabled = true;
                dlg.CheckPathExists = true;
                dlg.CreatePrompt = false;
                dlg.DefaultExt = "xls";
                dlg.DereferenceLinks = true;
                dlg.OverwritePrompt = true;
                dlg.SupportMultiDottedExtensions = true;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    m_fileName = dlg.FileName;
                    m_workBook = new HSSFWorkbook();
                    this.backgroundWorker1.RunWorkerAsync();
                }
            } else {
                Close();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            DoWork();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            labelProgress.BeginInvoke(new Action(() => {
                labelProgress.Text = "完成";
            }));
            btnOpenFile.Enabled = true;
            btnOpenFolder.Enabled = true;
        }

        private void DoWork() {
            for (int i = 0; i < ALL_SERVERS.Count * 2; ++i) {
                if (!backgroundWorker1.CancellationPending) {
                    if (i < ALL_SERVERS.Count) {
                        labelProgress.BeginInvoke(new Action(() => {
                            labelProgress.Text = string.Format("获取 {0} 数据", m_labels[i]);
                        }));
                        ALL_SERVERS[i](m_contents);
                    } else {
                        var index = i - m_labels.Count;
                        labelProgress.BeginInvoke(new Action(() => {
                            labelProgress.Text = string.Format("导出 {0} 数据", m_labels[index]);
                        }));
                        Export(m_labels[index], m_contents[index]);
                    }
                    backgroundWorker1.ReportProgress((i + 1) * 100 / (ALL_SERVERS.Count * 2));
                }
            }
        }

        private void ExportExcel2Dlg_FormClosing(object sender, FormClosingEventArgs e) {
            if (backgroundWorker1.IsBusy) {
                backgroundWorker1.CancelAsync();
            }
        }

        private void Export(string sheetName, IDictionary<string, object> data) {
            var sheet = m_workBook.CreateSheet(sheetName);
            ExcelHelper.CreateStyles(m_workBook);
            var maxColumn = 0;
            for (int i = 0; i < m_pageModel.Count; ++i) {
                var row = sheet.CreateRow(i + 1);
                maxColumn = maxColumn > m_pageModel[i].Count ? maxColumn : m_pageModel[i].Count;
                for (int j = 0; j < m_pageModel[i].Count; ++j) {
                    int index = j + 1;
                    var cell = row.CreateCell(index);
                    ExcelHelper.SetCellStyle(m_pageModel[i][j].Item2, cell);
                    GetCellStr(m_pageModel[i][j], data, cell);
                }
            }
            for (int i = 0; i < maxColumn + 1; ++i) {
                sheet.AutoSizeColumn(i);
            }
            using (var fs = File.OpenWrite(m_fileName)) {
                m_workBook.Write(fs);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e) {
            Process.Start(new ProcessStartInfo() {
                FileName = m_fileName,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void btnOpenFolder_Click(object sender, EventArgs e) {
            Process.Start(new ProcessStartInfo() {
                FileName = @"explorer.exe",
                Arguments = "/select," + m_fileName,
            });
        }

    }
}
