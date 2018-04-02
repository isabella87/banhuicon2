namespace Banhuitong.Console {
    partial class MonthStatisticDlg {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthStatisticDlg));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.exportStatistics = new System.Windows.Forms.ToolStripDropDownButton();
            this.statisticsOfYear1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsOfYear2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsOfYear3 = new System.Windows.Forms.ToolStripMenuItem();
            this.wbDataStatistic = new System.Windows.Forms.WebBrowser();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnSearch,
            this.exportStatistics});
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
            this.toolStripLabel1.Text = "查询月份:";
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
            // exportStatistics
            // 
            this.exportStatistics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportStatistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsOfYear1,
            this.statisticsOfYear2,
            this.statisticsOfYear3});
            this.exportStatistics.Image = ((System.Drawing.Image)(resources.GetObject("exportStatistics.Image")));
            this.exportStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportStatistics.Name = "exportStatistics";
            this.exportStatistics.Size = new System.Drawing.Size(93, 22);
            this.exportStatistics.Text = "导出整年数据";
            // 
            // statisticsOfYear1
            // 
            this.statisticsOfYear1.Name = "statisticsOfYear1";
            this.statisticsOfYear1.Size = new System.Drawing.Size(152, 22);
            this.statisticsOfYear1.Text = "年一";
            this.statisticsOfYear1.Click += new System.EventHandler(this.statisticsOfYear1_Click);
            // 
            // statisticsOfYear2
            // 
            this.statisticsOfYear2.Name = "statisticsOfYear2";
            this.statisticsOfYear2.Size = new System.Drawing.Size(152, 22);
            this.statisticsOfYear2.Text = "年二";
            this.statisticsOfYear2.Click += new System.EventHandler(this.statisticsOfYear2_Click);
            // 
            // statisticsOfYear3
            // 
            this.statisticsOfYear3.Name = "statisticsOfYear3";
            this.statisticsOfYear3.Size = new System.Drawing.Size(152, 22);
            this.statisticsOfYear3.Text = "年三";
            this.statisticsOfYear3.Click += new System.EventHandler(this.statisticsOfYear3_Click);
            // 
            // wbDataStatistic
            // 
            this.wbDataStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbDataStatistic.Location = new System.Drawing.Point(0, 25);
            this.wbDataStatistic.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDataStatistic.Name = "wbDataStatistic";
            this.wbDataStatistic.Size = new System.Drawing.Size(694, 717);
            this.wbDataStatistic.TabIndex = 1;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.CustomFormat = "yyyy年MM月";
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.Location = new System.Drawing.Point(12, 38);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(90, 21);
            this.dtpSearchDate.TabIndex = 2;
            // 
            // MonthStatisticDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 742);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.wbDataStatistic);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MonthStatisticDlg";
            this.ShowIcon = false;
            this.Text = "月数据统计";
            this.Load += new System.EventHandler(this.MonthStatisticDlg_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.WebBrowser wbDataStatistic;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripDropDownButton exportStatistics;
        private System.Windows.Forms.ToolStripMenuItem statisticsOfYear1;
        private System.Windows.Forms.ToolStripMenuItem statisticsOfYear2;
        private System.Windows.Forms.ToolStripMenuItem statisticsOfYear3;
    }
}