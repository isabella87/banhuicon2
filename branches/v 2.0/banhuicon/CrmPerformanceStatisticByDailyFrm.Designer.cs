namespace Banhuitong.Console
{
    partial class CrmPerformanceStatisticByDailyFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSearchDay = new System.Windows.Forms.ToolStripButton();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchDate = new System.Windows.Forms.DateTimePicker();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbbDepartments = new System.Windows.Forms.ToolStripComboBox();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnSearchDay,
            this.btnCustomers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1177, 25);
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
            // btnCustomers
            // 
            this.btnCustomers.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(94, 22);
            this.btnCustomers.Text = "客户名单(&N)";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(388, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 474);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.VirtualMode = true;
            // 
            // searchDate
            // 
            this.searchDate.CustomFormat = "";
            this.searchDate.Location = new System.Drawing.Point(8, 61);
            this.searchDate.Name = "searchDate";
            this.searchDate.ShowUpDown = true;
            this.searchDate.Size = new System.Drawing.Size(120, 21);
            this.searchDate.TabIndex = 2;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("uName", "客户经理", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("rCode", "客户经理编码", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("pName", "客户经理上级", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("position", "客户经理职务", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("sumInvestAmt", "投资余额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("sumTenderAmt", "投标总额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("sumRepaidCapitalAmt", "已还本金总额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("sumFirstInvestCount", "首次投标人数", MyLib.UI.MyGridColumnType.Number, 120, false, true),
            new MyLib.UI.MyGridColumn("sumInvesterCount", "投标人数", MyLib.UI.MyGridColumnType.Number, 120, false, true),
            new MyLib.UI.MyGridColumn("sumInvestCount", "投标次数", MyLib.UI.MyGridColumnType.Number, 120, false, true),
            new MyLib.UI.MyGridColumn("sumCreditAmt", "买入债权本金总额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("sumBindCount", "绑卡人数", MyLib.UI.MyGridColumnType.Number, 120, false, true),
            new MyLib.UI.MyGridColumn("sumIncomeAmt", "平台收入", MyLib.UI.MyGridColumnType.Money, 120, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(379, 443);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            this.treeView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyUp);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseUp);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(385, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 474);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 474);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.toolStripLabel2,
            this.cbbDepartments,
            this.btnAdd});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(385, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "部门:";
            // 
            // cbbDepartments
            // 
            this.cbbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartments.Name = "cbbDepartments";
            this.cbbDepartments.Size = new System.Drawing.Size(121, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Banhuitong.Console.Properties.Resources.AddImg;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 22);
            this.btnAdd.Text = "按所属部门选择(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // CrmPerformanceStatisticByDailyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.searchDate);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CrmPerformanceStatisticByDailyFrm";
            this.ShowIcon = false;
            this.Text = "日绩效统计";
            this.Load += new System.EventHandler(this.FrmCrmPerformanceInvest1_1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnSearchDay;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker searchDate;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbbDepartments;
        private System.Windows.Forms.ToolStripButton btnAdd;
    }
}