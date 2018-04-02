namespace Banhuitong.Console {
    partial class VipStatisticDlg {
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
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.wbDataStatistic = new System.Windows.Forms.WebBrowser();
            this.nudAmt = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmt)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "查询截止日期:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel2.Text = "最低投资余额:";
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
            this.dtpSearchDate.Location = new System.Drawing.Point(12, 28);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(120, 21);
            this.dtpSearchDate.TabIndex = 1;
            // 
            // wbDataStatistic
            // 
            this.wbDataStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbDataStatistic.Location = new System.Drawing.Point(0, 25);
            this.wbDataStatistic.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDataStatistic.Name = "wbDataStatistic";
            this.wbDataStatistic.Size = new System.Drawing.Size(804, 417);
            this.wbDataStatistic.TabIndex = 2;
            // 
            // nudAmt
            // 
            this.nudAmt.Location = new System.Drawing.Point(138, 28);
            this.nudAmt.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudAmt.Name = "nudAmt";
            this.nudAmt.Size = new System.Drawing.Size(120, 21);
            this.nudAmt.TabIndex = 3;
            this.nudAmt.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // VipStatisticDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 442);
            this.Controls.Add(this.nudAmt);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.wbDataStatistic);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VipStatisticDlg";
            this.ShowIcon = false;
            this.Text = "VIP客户名单";
            this.Load += new System.EventHandler(this.VipStatisticDlg_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.WebBrowser wbDataStatistic;
        private System.Windows.Forms.NumericUpDown nudAmt;
    }
}