namespace Banhuitong.Console {
    partial class BusinessTransferDlg {
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
            this.btnCreate = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCreateOne = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnStart,
            this.btnUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCreate
            // 
            this.btnCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateOne,
            this.btnCreateBatch});
            this.btnCreate.Image = global::Banhuitong.Console.Properties.Resources.AddImg;
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(125, 22);
            this.btnCreate.Text = "创建商户转帐(&C)";
            // 
            // btnCreateOne
            // 
            this.btnCreateOne.Name = "btnCreateOne";
            this.btnCreateOne.Size = new System.Drawing.Size(144, 22);
            this.btnCreateOne.Text = "手工录入(&W)";
            this.btnCreateOne.Click += new System.EventHandler(this.btnCreateOne_Click);
            // 
            // btnCreateBatch
            // 
            this.btnCreateBatch.Name = "btnCreateBatch";
            this.btnCreateBatch.Size = new System.Drawing.Size(144, 22);
            this.btnCreateBatch.Text = "批量导入(&X)";
            this.btnCreateBatch.Click += new System.EventHandler(this.btnCreateBatch_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 22);
            this.btnStart.Text = "执行(&S)";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("jvpId", "ID", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("auId", "AUID", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("forAccountId", "转入电子账户", MyLib.UI.MyGridColumnType.Text, 150, false, true),
            new MyLib.UI.MyGridColumn("seqno", "流水号", MyLib.UI.MyGridColumnType.Text, 150, false, true),
            new MyLib.UI.MyGridColumn("txamount", "金额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("done", "状态", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("datepoint", "时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("retCode", "响应代码", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("retMsg", "响应消息", MyLib.UI.MyGridColumnType.Text, 200, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
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
            this.dataGridView1.Size = new System.Drawing.Size(984, 537);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.VirtualMode = true;
            // 
            // BusinessTransferDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BusinessTransferDlg";
            this.ShowIcon = false;
            this.Text = "执行商户转帐-{0}";
            this.Load += new System.EventHandler(this.BusinessTransferDlg_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnCreateOne;
        private System.Windows.Forms.ToolStripMenuItem btnCreateBatch;
        private System.Windows.Forms.ToolStripButton btnStart;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnUpdate;


    }
}