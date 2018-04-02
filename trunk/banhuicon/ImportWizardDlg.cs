using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Banhuitong.Console.Excel {
    using Rpc;
    public enum CellType { Text = 0, Age = 1, Mobile = 2, Money = 3 };
    public delegate IResult ImportProcessRunSingle(int index, DataGridView gridView);

    /// <summary>
    /// 导入数据向导。
    /// </summary>
    public partial class ImportWizardDlg : Form {
        public event ImportProcessRunSingle RunSingle;
        /// <summary>
        /// string:列标题
        /// CellType:列类型
        /// bool:必填列
        /// </summary>
        private IList<Tuple<string, CellType, bool>> m_cell;
        public ImportWizardDlg(IList<Tuple<string, CellType, bool>> cell) {
            InitializeComponent();
            m_cell = cell;
            m_cell.Add(MakeColumn("状态", CellType.Text));
        }

        private void ImportExcelDlg_Load(object sender, EventArgs e) {
            for (int i = 0; i < m_cell.Count; ++i) {
                dataGridView1.Columns.Add("Column" + i, m_cell[i].Item1);
            }
            toolStrip1.AddControlAfter(progressBar1, btnStop);
            labShow.Visible = false;
            progressBar1.Visible = false;
        }

        private void btnLoadFile_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            Import(GetFileName());
        }

        private string GetFileName() {
            using (var oFile = new OpenFileDialog()) {
                oFile.Filter = "Excel|*.xlsx;*.xls";
                if (oFile.ShowDialog() == DialogResult.OK) {
                    return oFile.FileName;
                }
            }
            return "";
        }

        private void Import(string fileName) {
            if (fileName == "")
                return;

            ISheet sheet = null;
            FileStream fs = null;
            IWorkbook workbook = null;
            try {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                if (fileName.IndexOf(".xlsx") > 0) {
                    workbook = new XSSFWorkbook(fs);
                } else if (fileName.IndexOf(".xls") > 0) {
                    workbook = new HSSFWorkbook(fs);
                }

                sheet = workbook.GetSheetAt(0);
                if (sheet != null) {
                    var error = new List<int>();
                    for (int i = 1; i <= sheet.LastRowNum; ++i) {
                        var row = sheet.GetRow(i);
                        if (row == null) {
                            error.Add(i + 1);
                            continue;
                        }
                        var index = dataGridView1.Rows.Add();
                        bool add = true;
                        for (int j = 0; j < m_cell.Count - 1; ++j) {
                            ICell cell = row.GetCell(j);
                            if (cell != null) {
                                string str;
                                if (CellTypeTest(cell, j, out str)) {
                                    dataGridView1.Rows[index].Cells[j].Value = str;
                                } else {
                                    add = false;
                                    error.Add(i + 1);
                                    break;
                                }
                            } else {
                                if (m_cell[j].Item3) {
                                    add = false;
                                    error.Add(i + 1);
                                    break;
                                }
                            }
                        }
                        if (!add) {
                            dataGridView1.Rows.RemoveAt(index);
                        } else {
                            dataGridView1.Rows[index].HeaderCell.Value = string.Format("{0}", index + 1);
                        }
                    }
                    string errorStr = "";
                    if (error.Count > 0) {
                        errorStr = string.Format("，第 {0} 行未导入成功!", error.JoinSome("、", sheet.LastRowNum));
                    }
                    Commons.ShowInfoBox(this, string.Format("成功导入 {0} 条记录", sheet.LastRowNum - error.Count) + errorStr);
                }
            } catch (Exception e) {
                if (fs != null) {
                    fs.Close();
                }
                Commons.ShowInfoBox(this, e.Message);
            }
        }

        private bool CellTypeTest(ICell cell, int column, out string str) {
            str = cell.ToString().Trim();
            switch (m_cell[column].Item2) {
                case CellType.Text:
                    return string.IsNullOrEmpty(str) ? (m_cell[column].Item3 ? false : true) : true;
                case CellType.Age:
                    str = Commons.NormalNumberStr(str);
                    var age = Convert.ToInt32(str);
                    if (age < 1 || age > 200) {
                        str = "1";
                        return !m_cell[column].Item3;
                    } else {
                        return true;
                    }
                case CellType.Mobile:
                    str = Commons.NormalNumberStr(str);
                    var pattern = new Regex("^((11)|(12)|(13)|(14)|(15)|(16)|(17)|(18)|(19))\\d{9}$");
                    if (!pattern.IsMatch(str, 0)) {
                        str = "";
                        return !m_cell[column].Item3;
                    } else {
                        return true;
                    }
                case CellType.Money:
                    decimal money;
                    if (!decimal.TryParse(str, out money)) {
                        str = "0.00";
                        return !m_cell[column].Item3;
                    } else {
                        return true;
                    }
                default:
                    return true;
            }
        }


        private void btnCommit_Click(object sender, EventArgs e) {
            progressBar1.Visible = true;
            labShow.Visible = true;
            btnCommit.Enabled = false;
            btnStop.Enabled = true;
            backgroundWorker1.RunWorkerAsync(dataGridView1.Rows.Count);
        }

        private void btnDel_Click(object sender, EventArgs e) {
            btnDel.Enabled = false;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) {
                dataGridView1.Rows.Remove(row);
            }
            dataGridView1.ClearSelection();
            btnDel.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            e.Result = Excute((int)e.Argument);
        }

        private int Excute(int count) {
            int success = 0;
            for (int i = 0; i < count; ++i) {
                if (!backgroundWorker1.CancellationPending) {
                    if (RunSingle != null) {
                        var p = RunSingle(i, dataGridView1);
                        if (p.IsOk) {
                            ++success;
                            dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 1].Value = "成功";
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        } else {
                            dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 1].Value = p.Exception.Message;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        backgroundWorker1.ReportProgress((i + 1) * 100 / dataGridView1.Rows.Count);
                    }
                }
            }
            return success;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
            labShow.Text = string.Format("{0}%", e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            progressBar1.Visible = false;
            labShow.Visible = false;
            btnCommit.Enabled = true;
            btnStop.Enabled = false;
            if (e.Error != null)
                Commons.ShowErrorBox(this, e.Error.Message);

            if (Convert.ToInt32(e.Result) != dataGridView1.Rows.Count) {
                Commons.ShowInfoBox(this, string.Format("尚有{0}条未执行成功", dataGridView1.Rows.Count - Convert.ToInt32(e.Result)));
            }
        }

        private void btnStop_Click(object sender, EventArgs e) {
            backgroundWorker1.CancelAsync();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0)
                btnDel.Enabled = true;
            else
                btnDel.Enabled = false;
        }

        public static Tuple<string, CellType, bool> MakeColumn(string title, CellType type, bool necessary = false) {
            return Tuple.Create(title, type, necessary);
        }

    }
}
