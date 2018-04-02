namespace Banhuitong.Console {
    partial class PrjTendersDlg {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCancelTenders = new System.Windows.Forms.ToolStripButton();
            this.btnCancelTenders2 = new System.Windows.Forms.ToolStripButton();
            this.btnCheckTenders = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnExportXml = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 25);
            this.panel2.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelTenders,
            this.btnCancelTenders2,
            this.btnCheckTenders,
            this.btnUpdate,
            this.btnExportXml});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCancelTenders
            // 
            this.btnCancelTenders.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnCancelTenders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTenders.Name = "btnCancelTenders";
            this.btnCancelTenders.Size = new System.Drawing.Size(96, 22);
            this.btnCancelTenders.Text = "中途流标(&M)";
            this.btnCancelTenders.Visible = false;
            this.btnCancelTenders.Click += new System.EventHandler(this.btnCancelTenders_Click);
            // 
            // btnCancelTenders2
            // 
            this.btnCancelTenders2.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnCancelTenders2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTenders2.Name = "btnCancelTenders2";
            this.btnCancelTenders2.Size = new System.Drawing.Size(91, 22);
            this.btnCancelTenders2.Text = "撤销投标(&T)";
            this.btnCancelTenders2.Click += new System.EventHandler(this.btnCancelTenders2_Click);
            // 
            // btnCheckTenders
            // 
            this.btnCheckTenders.Image = global::Banhuitong.Console.Properties.Resources.Flag3Img;
            this.btnCheckTenders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckTenders.Name = "btnCheckTenders";
            this.btnCheckTenders.Size = new System.Drawing.Size(92, 22);
            this.btnCheckTenders.Text = "检查投标(&C)";
            this.btnCheckTenders.Visible = false;
            this.btnCheckTenders.Click += new System.EventHandler(this.btnCheckTenders_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Banhuitong.Console.Properties.Resources.ResetImg;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 22);
            this.btnUpdate.Text = "刷新(&U)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExportXml
            // 
            this.btnExportXml.Image = global::Banhuitong.Console.Properties.Resources.ExcelImg;
            this.btnExportXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(81, 22);
            this.btnExportXml.Text = "导出&Excel";
            this.btnExportXml.Click += new System.EventHandler(this.btnExportXml_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(924, 577);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.VirtualMode = true;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("ttId", "ID", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("auId", "用户ID", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("realName", "投资人姓名/机构名", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("amt", "金额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("datepoint", "投资时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("seqno", "流水号", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("orderNo", "订单号", MyLib.UI.MyGridColumnType.Text, 120, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // PrjTendersDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "PrjTendersDlg";
            this.ShowIcon = false;
            this.Text = "查看投标";
            this.Load += new System.EventHandler(this.PrjTendersDlg_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCancelTenders;
        private System.Windows.Forms.ToolStripButton btnCancelTenders2;
        private System.Windows.Forms.ToolStripButton btnCheckTenders;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnExportXml;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
    }
}