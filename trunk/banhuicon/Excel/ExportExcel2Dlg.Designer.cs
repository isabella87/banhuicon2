namespace Banhuitong.Console.Excel {
    partial class ExportExcel2Dlg {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(439, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Location = new System.Drawing.Point(185, 41);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(106, 34);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "打开(&O)...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Enabled = false;
            this.btnOpenFolder.Location = new System.Drawing.Point(297, 41);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(154, 34);
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.Text = "打开所在的文件夹(&F)...";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(12, 52);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(29, 12);
            this.labelProgress.TabIndex = 3;
            this.labelProgress.Text = "过程";
            // 
            // ExportExcel2Dlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 87);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.progressBar1);
            this.Name = "ExportExcel2Dlg";
            this.ShowIcon = false;
            this.Text = "导出Excel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportExcel2Dlg_FormClosing);
            this.Load += new System.EventHandler(this.ExportExcel2Dlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelProgress;
    }
}