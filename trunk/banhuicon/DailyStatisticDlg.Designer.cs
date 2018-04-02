namespace Banhuitong.Console {
    partial class DailyStatisticDlg {
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.wbInvestorsInfo = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "查询日期:";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Banhuitong.Console.Properties.Resources.SearchImg;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 22);
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.CustomFormat = "";
            this.dtpSearchDate.Location = new System.Drawing.Point(26, 28);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(120, 21);
            this.dtpSearchDate.TabIndex = 1;
            // 
            // wbInvestorsInfo
            // 
            this.wbInvestorsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbInvestorsInfo.Location = new System.Drawing.Point(0, 25);
            this.wbInvestorsInfo.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbInvestorsInfo.Name = "wbInvestorsInfo";
            this.wbInvestorsInfo.Size = new System.Drawing.Size(694, 717);
            this.wbInvestorsInfo.TabIndex = 2;
            // 
            // DailyStatisticDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 742);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.wbInvestorsInfo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DailyStatisticDlg";
            this.ShowIcon = false;
            this.Text = "日数据统计";
            this.Load += new System.EventHandler(this.DailyStatisticDlg_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.WebBrowser wbInvestorsInfo;
    }
}