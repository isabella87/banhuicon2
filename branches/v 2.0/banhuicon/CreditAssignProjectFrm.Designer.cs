namespace Banhuitong.Console
{
    partial class CreditAssignProjectFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbDateType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbProjType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cbTransType = new System.Windows.Forms.ToolStripComboBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cbKeyValue = new System.Windows.Forms.ToolStripComboBox();
            this.tbKey = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnTop = new System.Windows.Forms.ToolStripButton();
            this.btnCheckTransfer = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbDateType,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.cbProjType,
            this.toolStripLabel3,
            this.cbTransType});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1010, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbDateType
            // 
            this.cbDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateType.Name = "cbDateType";
            this.cbDateType.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel1.Text = "-";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel2.Text = "项目类型(&P):";
            // 
            // cbProjType
            // 
            this.cbProjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjType.Name = "cbProjType";
            this.cbProjType.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel3.Text = "转让状态(&T):";
            // 
            // cbTransType
            // 
            this.cbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransType.Name = "cbTransType";
            this.cbTransType.Size = new System.Drawing.Size(100, 25);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(0, 86);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(120, 21);
            this.startDate.TabIndex = 1;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(126, 86);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(120, 21);
            this.endDate.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.cbKeyValue,
            this.tbKey,
            this.btnSearch,
            this.toolStripLabel5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1010, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel4.Text = "关键字(&K):";
            // 
            // cbKeyValue
            // 
            this.cbKeyValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeyValue.Name = "cbKeyValue";
            this.cbKeyValue.Size = new System.Drawing.Size(120, 25);
            // 
            // tbKey
            // 
            this.tbKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(200, 25);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Banhuitong.Console.Properties.Resources.SearchImg;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 22);
            this.btnSearch.Text = "搜索(&S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel5.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(182, 22);
            this.toolStripLabel5.Text = "标价差额 = 债权本金 - 转让标价";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 75);
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
            this.dataGridView1.Size = new System.Drawing.Size(1010, 481);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.VirtualMode = true;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("pId", "ID", MyLib.UI.MyGridColumnType.Number, 50, false, true),
            new MyLib.UI.MyGridColumn("itemNo", "转让编号", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("itemName", "转让项目名称", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("pyeRealName", "转让人", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("prjType", "项目类型", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("status", "项目状态", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("totalTranNo", "总期次", MyLib.UI.MyGridColumnType.Number, 120, false, true),
            new MyLib.UI.MyGridColumn("unpaidTranNo", "剩余期次", MyLib.UI.MyGridColumnType.Number, 120, false, true),
            new MyLib.UI.MyGridColumn("assignAmt", "转让标价", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("creditAmount", "原本金", MyLib.UI.MyGridColumnType.Money, 120, false, false),
            new MyLib.UI.MyGridColumn("gapAmt", "标价差额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("fee", "转让手续费", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("realAmount", "实收金额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("assignStartTime", "发布时间", MyLib.UI.MyGridColumnType.Date, 80, false, true),
            new MyLib.UI.MyGridColumn("assignStartTime", "截止时间", MyLib.UI.MyGridColumnType.Date, 80, false, true),
            new MyLib.UI.MyGridColumn("pyrRealName", "受让人", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("oldRate", "原年化收益率", MyLib.UI.MyGridColumnType.Percent, 120, false, true),
            new MyLib.UI.MyGridColumn("assignRate", "折算/当前年化收益率", MyLib.UI.MyGridColumnType.Percent, 120, false, true),
            new MyLib.UI.MyGridColumn("invokeTime", "撤销时间", MyLib.UI.MyGridColumnType.Date, 80, false, true),
            new MyLib.UI.MyGridColumn("invokeRes", "撤销来源", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("topTime", "置顶时间", MyLib.UI.MyGridColumnType.Number, 120, false, false),
            new MyLib.UI.MyGridColumn("tiId", "债权协议ID", MyLib.UI.MyGridColumnType.Text, 120, false, false)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelete,
            this.btnTop,
            this.btnCheckTransfer});
            this.toolStrip3.Location = new System.Drawing.Point(0, 50);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1010, 25);
            this.toolStrip3.TabIndex = 5;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Banhuitong.Console.Properties.Resources.DeleteImg;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 22);
            this.btnDelete.Text = "提前撤销";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(52, 22);
            this.btnTop.Text = "置顶";
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnCheckTransfer
            // 
            this.btnCheckTransfer.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnCheckTransfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckTransfer.Name = "btnCheckTransfer";
            this.btnCheckTransfer.Size = new System.Drawing.Size(100, 22);
            this.btnCheckTransfer.Text = "查看债权协议";
            this.btnCheckTransfer.Click += new System.EventHandler(this.btnCheckTransfer_Click);
            // 
            // CreditAssignProjectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 556);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CreditAssignProjectFrm";
            this.ShowIcon = false;
            this.Text = "项目管理-二级市场";
            this.Load += new System.EventHandler(this.CreditAssignProjectFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox tbKey;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripComboBox cbDateType;
        private System.Windows.Forms.ToolStripComboBox cbProjType;
        private System.Windows.Forms.ToolStripComboBox cbTransType;
        private System.Windows.Forms.ToolStripComboBox cbKeyValue;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnTop;
        private System.Windows.Forms.ToolStripButton btnCheckTransfer;
    }
}