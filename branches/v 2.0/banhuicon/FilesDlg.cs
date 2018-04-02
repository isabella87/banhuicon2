using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Banhuitong.Console {
    using BaseData;
    public enum AcceptFilter { Any = 0, PlainText = 1, Image = 2, Doc = 4, Xls = 8, Pdf = 16 };
    public partial class FilesDlg : Form {
        private long m_objectId;
        private int m_fileType;
        private string m_filter;
        private string m_pname;
        private int m_maxCount;
        private readonly int MB = 1024 * 1024;
        private readonly int m_maxSize = 20;

        public bool ReadOnly { set; get; }


        private string MakeFilter(AcceptFilter filter) {
            string result = "";
            switch (filter) {
                case AcceptFilter.PlainText:
                    result = "文本文件|*.txt;*.text|";
                    break;
                case AcceptFilter.Image:
                    result = "图片文件|*.png;*.jpg;*.jpeg;*.gif|";
                    break;
                case AcceptFilter.Doc:
                    result = "Word文档|*.doc;*.docx|)";
                    break;
                case AcceptFilter.Xls:
                    result = "Excel文档|*.xls;*.xlsx|";
                    break;
                case AcceptFilter.Pdf:
                    result = "Pdf文档|*.pdf|";
                    break;
            }
            result += "所有文件(*.*)|*.*";

            return result;
        }

        public FilesDlg(long objectId, int fileType, AcceptFilter filter = AcceptFilter.Any, string pname = "", int maxCount = 0) {
            InitializeComponent();
            m_objectId = objectId;
            m_fileType = fileType;
            m_filter = MakeFilter(filter);
            m_pname = pname;
            m_maxCount = maxCount;
        }

        private void FilesDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_objectId, m_fileType) + (m_pname == "" ? m_pname : ("/" + m_pname));
            if (ReadOnly && !MainFrm.IsAdmin) {
                btnDel.Visible = false;
                btnUpload.Visible = false;
            }
            UpdateTable();
        }

        private async void UpdateTable() {
            listView1.Items.Clear();
            btnUpdate.Enabled = false;
            var r = new Dictionary<string, object>();
            r["objectId"] = m_objectId;
            r["fileType"] = m_fileType;
            if (m_pname != "") {
                r["parentName"] = m_pname;
            }

            var p = await Files.List(r);
            if (p.IsOk) {
                var dl = JArray.Parse(p.AsString).ToList();
                foreach (var d in dl) {
                    var lvi = new ListViewItem();
                    lvi.Text = d["name"].ToStdString();
                    lvi.ToolTipText = d["description"].ToStdString();
                    lvi.SubItems.Add(d["size"].ToInt64().ToFileLength());
                    lvi.SubItems.Add(d["lastWriteTime"].ToDateTime());
                    lvi.SubItems.Add(d["id"].ToStdString());
                    lvi.SubItems.Add(d["hash"].ToStdString());

                    listView1.Items.Add(lvi);
                }
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnUpdate.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count == 0) {
                btnDel.Enabled = false;
                btnDownLoad.Enabled = false;
            } else if (listView1.SelectedItems.Count == 1) {
                btnDel.Enabled = true;
                btnDownLoad.Enabled = true;
            } else {
                btnDel.Enabled = true;
                btnDownLoad.Enabled = false;
            }

        }

        private void btnDownLoad_Click(object sender, EventArgs e) {
            DownLoad();
        }

        /// <summary>
        /// 下载选中的文件。
        /// </summary>
        private void DownLoad() {
            btnDownLoad.Enabled = false;

            if (listView1.SelectedItems.Count > 0) {
                // 如果选中了项则继续。
                var fileId = Commons.ToInt64(listView1.SelectedItems[0].SubItems[3].Text.Trim());
                var fileHash = listView1.SelectedItems[0].SubItems[4].Text.Trim();

                if (fileId != 0L && fileHash.Length != 0) {
                    // 如果选中项的文件ID和文件hash合法则继续。
                    string localFileName = "";
                    using (var dlg = new SaveFileDialog()) {
                        dlg.FileName = listView1.SelectedItems[0].Text;
                        if (dlg.ShowDialog(this) == DialogResult.OK) {
                            localFileName = dlg.FileName;
                        }
                    }

                    if (localFileName.Length != 0) {
                        // 如果输入了本地文件的名字则执行下载。
                        using (var dlg = new DownloadFileDlg(fileId, fileHash, localFileName)) {
                            dlg.ShowDialog(this);
                        }
                    }
                }
            }

            btnDownLoad.Enabled = true;
        }


        private void btnUpload_Click(object sender, EventArgs e) {
            UploadFiles();
        }

        private async void UploadFiles() {
            if (m_maxCount > 0) {
                if (listView1.Items.Count >= m_maxCount) {
                    Commons.ShowInfoBox(this, string.Format("最多只能上传 {0} 个文件，请删除后再上传！", m_maxCount));
                }
            }

            using (var oFile = new OpenFileDialog()) {
                oFile.Filter = m_filter;
                if (oFile.ShowDialog() == DialogResult.OK) {
                    if (m_fileType == 37) {
                        if (!oFile.FileName.StartsWith("intermediary_") && !oFile.FileName.StartsWith("loan_")) {
                            Commons.ShowInfoBox(this, "上传文件应以“intermediary_”或“loan_”开头");
                            return;
                        }
                    }
                    FileStream fileStream;
                    try {
                        fileStream = new FileStream(oFile.FileName, FileMode.Open);
                    } catch (Exception e) {
                        Commons.ShowInfoBox(this, e.Message);
                        return;
                    }
                    if (fileStream.Length > m_maxSize * MB) {
                        Commons.ShowInfoBox(this, string.Format("文件 {0} 太大，大小不能超过 {1} MB", oFile.FileName, m_maxSize));
                        return;
                    }
                    btnUpload.Enabled = false;
                    var d = new Dictionary<string, object>();
                    d["objectId"] = m_objectId;
                    d["fileType"] = m_fileType;
                    d["fileName"] = oFile.SafeFileName;
                    if (m_pname != "") {
                        d["parentName"] = m_pname;
                    }
                    d["force"] = true;
                    var p = await Files.Create(d);
                    if (p.IsOk) {
                        var fileId = p.AsLong;
                        if (fileId == 0) {
                            Commons.ShowInfoBox(this, "创建新文件失败!");
                            btnUpload.Enabled = true;
                            return;
                        }
                        var data = new byte[fileStream.Length];
                        try {
                            fileStream.Read(data, 0, data.Length);
                        } catch (Exception e) {
                            Commons.ShowInfoBox(this, e.Message);
                            btnUpload.Enabled = true;
                            return;
                        }
                        var p2 = await Files.Upload(fileId, data);
                        if (p2.IsOk) {
                            UpdateTable();
                        } else {
                            Commons.ShowResultErrorBox(this, p2);
                        }
                    }

                    fileStream.Close();
                    btnUpload.Enabled = true;
                }
            }

        }

        private void btnDel_Click(object sender, EventArgs e) {
            btnDel.Enabled = false;
            var idArray = new List<Tuple<string, string>>();
            foreach (ListViewItem item in listView1.SelectedItems) {
                idArray.Add(Tuple.Create(item.SubItems[0].Text, item.SubItems[3].Text));
            }
            if (idArray.Count > 0)
                Del(idArray);
        }

        private async void Del(List<Tuple<string, string>> idArray) {
            string tips = "";
            for (int i = 0; i < idArray.Count; ++i) {
                tips += idArray[i].Item1;
                tips += i == (idArray.Count - 1) ? "，" : "、";
            }

            if (Commons.ShowConfirmBox(this, "删除以下文件：" + tips + "此操作不可恢复！确认吗？")) {
                foreach (var id in idArray) {
                    await Files.Delete(id.Item2);
                }
                UpdateTable();
                listView1.SelectedItems.Clear();
                Commons.ShowInfoBox(this, "文件：" + tips + "已被删除");
            }
            btnDel.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateTable();
        }
    }
}
