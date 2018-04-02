namespace Banhuitong.Console {
    partial class PrjSignAgreementsDlg {
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
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.btnSign = new System.Windows.Forms.ToolStripButton();
            this.btnCheckAgreement = new System.Windows.Forms.ToolStripButton();
            this.btnSignInfo = new System.Windows.Forms.ToolStripButton();
            this.btnDownLoad = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch,
            this.btnUpload,
            this.btnSign,
            this.btnCheckAgreement,
            this.btnSignInfo,
            this.btnDownLoad,
            this.btnClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Banhuitong.Console.Properties.Resources.SearchImg;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 22);
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(88, 22);
            this.btnUpload.Text = "生成并上传";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSign
            // 
            this.btnSign.Enabled = false;
            this.btnSign.Image = global::Banhuitong.Console.Properties.Resources.Flag5Img;
            this.btnSign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(52, 22);
            this.btnSign.Text = "签章";
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnCheckAgreement
            // 
            this.btnCheckAgreement.Enabled = false;
            this.btnCheckAgreement.Image = global::Banhuitong.Console.Properties.Resources.Flag3Img;
            this.btnCheckAgreement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckAgreement.Name = "btnCheckAgreement";
            this.btnCheckAgreement.Size = new System.Drawing.Size(76, 22);
            this.btnCheckAgreement.Text = "核查签章";
            this.btnCheckAgreement.Click += new System.EventHandler(this.btnCheckAgreement_Click);
            // 
            // btnSignInfo
            // 
            this.btnSignInfo.Enabled = false;
            this.btnSignInfo.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnSignInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSignInfo.Name = "btnSignInfo";
            this.btnSignInfo.Size = new System.Drawing.Size(136, 22);
            this.btnSignInfo.Text = "查看借款人签章信息";
            this.btnSignInfo.Click += new System.EventHandler(this.btnSignInfo_Click);
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Enabled = false;
            this.btnDownLoad.Image = global::Banhuitong.Console.Properties.Resources.ExportImg;
            this.btnDownLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(52, 22);
            this.btnDownLoad.Text = "下载";
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Image = global::Banhuitong.Console.Properties.Resources.DeleteImg;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 22);
            this.btnClear.Text = "清空协议";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
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
            this.dataGridView1.Size = new System.Drawing.Size(840, 452);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.VirtualMode = true;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("fileId", "ID", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("name", "合同名称", MyLib.UI.MyGridColumnType.Text, 200, false, true),
            new MyLib.UI.MyGridColumn("fileType", "类型", MyLib.UI.MyGridColumnType.Text, 150, false, true),
            new MyLib.UI.MyGridColumn("status", "完成签章", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("signTime", "签章时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("fileHash", "文件hash值", MyLib.UI.MyGridColumnType.Text, 120, false, false)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 452);
            this.panel1.TabIndex = 2;
            // 
            // PrjSignAgreementsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PrjSignAgreementsDlg";
            this.ShowIcon = false;
            this.Text = "项目签章-";
            this.Load += new System.EventHandler(this.PrjSignDlg_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDownLoad;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnSignInfo;
        private System.Windows.Forms.ToolStripButton btnUpload;
        private System.Windows.Forms.ToolStripButton btnCheckAgreement;
        private System.Windows.Forms.ToolStripButton btnSign;
    }
}