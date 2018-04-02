namespace Banhuitong.Console {
    partial class CrmCstmOfMgrByDailyDlg {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSearchDay = new System.Windows.Forms.ToolStripButton();
            this.btnInvestRecord = new System.Windows.Forms.ToolStripButton();
            this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnSearchDay,
            this.btnInvestRecord,
            this.btnExportExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1100, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "查询时间:";
            // 
            // btnSearchDay
            // 
            this.btnSearchDay.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnSearchDay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchDay.Name = "btnSearchDay";
            this.btnSearchDay.Size = new System.Drawing.Size(67, 22);
            this.btnSearchDay.Text = "统计(&S)";
            this.btnSearchDay.Click += new System.EventHandler(this.btnSearchDay_Click);
            // 
            // btnInvestRecord
            // 
            this.btnInvestRecord.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnInvestRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInvestRecord.Name = "btnInvestRecord";
            this.btnInvestRecord.Size = new System.Drawing.Size(116, 22);
            this.btnInvestRecord.Text = "历史投资明细(&R)";
            this.btnInvestRecord.Click += new System.EventHandler(this.btnInvestRecord_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Image = global::Banhuitong.Console.Properties.Resources.ExcelImg;
            this.btnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(93, 22);
            this.btnExportExcel.Text = "导出为&Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 437);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.VirtualMode = true;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("auId", "ID", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("name", "客户名称", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("mobile", "手机号", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("investAmt", "投资总余额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("tenderAmt", "投标总额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("repaidCapitalAmt", "已还本金", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("creditAmt", "债权转入本金总额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("bindCount", "当日是否绑卡", MyLib.UI.MyGridColumnType.Boolean, 40, false, true),
            new MyLib.UI.MyGridColumn("firstInvest", "是否首次投资", MyLib.UI.MyGridColumnType.Boolean, 40, false, true),
            new MyLib.UI.MyGridColumn("isInvest", "是否投资", MyLib.UI.MyGridColumnType.Boolean, 40, false, true),
            new MyLib.UI.MyGridColumn("investCount", "日投资总次数", MyLib.UI.MyGridColumnType.Number, 120, false, true),
            new MyLib.UI.MyGridColumn("creditAssignCount", "日债权转入总次数", MyLib.UI.MyGridColumnType.Number, 120, false, true),
            new MyLib.UI.MyGridColumn("incomeAmt", "平台收入", MyLib.UI.MyGridColumnType.Money, 120, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(22, 28);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(120, 21);
            this.dtpDate.TabIndex = 2;
            // 
            // CrmCstmOfMgrByDailyDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 462);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CrmCstmOfMgrByDailyDlg";
            this.ShowIcon = false;
            this.Text = "日统计客户名单-{0}";
            this.Load += new System.EventHandler(this.CrmCstmOfMgrByDailyDlg_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnSearchDay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ToolStripButton btnInvestRecord;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
    }
}