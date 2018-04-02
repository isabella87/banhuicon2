namespace Banhuitong.Console
{
    partial class CrmInvestorFrm
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbOpUser = new System.Windows.Forms.ToolStripTextBox();
            this.btnChooseManager = new System.Windows.Forms.ToolStripButton();
            this.cbDateTypes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbPrLevels = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tbKey = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnBatchBind = new System.Windows.Forms.ToolStripButton();
            this.btnReassignCustomers = new System.Windows.Forms.ToolStripButton();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnBindMgr = new System.Windows.Forms.ToolStripButton();
            this.btnFollow = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tbOpUser,
            this.btnChooseManager,
            this.cbDateTypes,
            this.toolStripLabel4,
            this.toolStripLabel2,
            this.cbPrLevels});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1085, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel1.Text = "客户经理(&C):";
            // 
            // tbOpUser
            // 
            this.tbOpUser.Name = "tbOpUser";
            this.tbOpUser.ReadOnly = true;
            this.tbOpUser.Size = new System.Drawing.Size(100, 25);
            // 
            // btnChooseManager
            // 
            this.btnChooseManager.Image = global::Banhuitong.Console.Properties.Resources.Flag3Img;
            this.btnChooseManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChooseManager.Name = "btnChooseManager";
            this.btnChooseManager.Size = new System.Drawing.Size(120, 22);
            this.btnChooseManager.Text = "选择客户经理(&M)";
            this.btnChooseManager.Click += new System.EventHandler(this.btnChooseManager_Click);
            // 
            // cbDateTypes
            // 
            this.cbDateTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateTypes.Name = "cbDateTypes";
            this.cbDateTypes.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel4.Text = "-";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel2.Text = "分级(&T):";
            // 
            // cbPrLevels
            // 
            this.cbPrLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrLevels.Name = "cbPrLevels";
            this.cbPrLevels.Size = new System.Drawing.Size(80, 25);
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
            this.dataGridView1.Size = new System.Drawing.Size(1085, 480);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.VirtualMode = true;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(393, 79);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(120, 21);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(519, 79);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(120, 21);
            this.endDate.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.tbKey,
            this.btnSearch,
            this.btnBatchBind,
            this.btnReassignCustomers});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1085, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel3.Text = "关键字(&K):";
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
            // btnBatchBind
            // 
            this.btnBatchBind.Image = global::Banhuitong.Console.Properties.Resources.Flag4Img;
            this.btnBatchBind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBatchBind.Name = "btnBatchBind";
            this.btnBatchBind.Size = new System.Drawing.Size(140, 22);
            this.btnBatchBind.Text = "批量分配客户经理(&B)";
            this.btnBatchBind.Click += new System.EventHandler(this.btnBatchBind_Click);
            // 
            // btnReassignCustomers
            // 
            this.btnReassignCustomers.Image = global::Banhuitong.Console.Properties.Resources.Flag6Img;
            this.btnReassignCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReassignCustomers.Name = "btnReassignCustomers";
            this.btnReassignCustomers.Size = new System.Drawing.Size(164, 22);
            this.btnReassignCustomers.Text = "快速重新分配客户经理(&R)";
            this.btnReassignCustomers.Click += new System.EventHandler(this.btnReassignCustomers_Click);
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("ciId", "ID", MyLib.UI.MyGridColumnType.Number, 50, false, true),
            new MyLib.UI.MyGridColumn("loginName", "关联帐户名", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("realName", "姓名", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("mobile", "手机", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("prLevel", "分级", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("importTime", "导入日期", MyLib.UI.MyGridColumnType.Date, 80, false, true),
            new MyLib.UI.MyGridColumn("opUser", "执行分配人", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("uName", "客户经理", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("lastOpUser", "最新跟进客户经理", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("lastRemark", "最新跟进情况", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("lastDatepoint", "最新跟进日期", MyLib.UI.MyGridColumnType.Date, 80, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnEdit,
            this.btnBindMgr,
            this.btnFollow,
            this.btnDelete});
            this.toolStrip3.Location = new System.Drawing.Point(0, 50);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1085, 25);
            this.toolStrip3.TabIndex = 5;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnImport});
            this.toolStripDropDownButton1.Image = global::Banhuitong.Console.Properties.Resources.AddImg;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(125, 22);
            this.toolStripDropDownButton1.Text = "创建跟进客户(&C)";
            // 
            // btnCreate
            // 
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 22);
            this.btnCreate.Text = "手工录入(&W)";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnImport
            // 
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(144, 22);
            this.btnImport.Text = "批量导入(&X)";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Banhuitong.Console.Properties.Resources.EditImg;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(52, 22);
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBindMgr
            // 
            this.btnBindMgr.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnBindMgr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBindMgr.Name = "btnBindMgr";
            this.btnBindMgr.Size = new System.Drawing.Size(52, 22);
            this.btnBindMgr.Text = "分配";
            this.btnBindMgr.Click += new System.EventHandler(this.btnBindMgr_Click);
            // 
            // btnFollow
            // 
            this.btnFollow.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnFollow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(52, 22);
            this.btnFollow.Text = "跟进";
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Banhuitong.Console.Properties.Resources.DeleteImg;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CrmInvestorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 555);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CrmInvestorFrm";
            this.ShowIcon = false;
            this.Text = "客户关系管理-分配跟进客户";
            this.Load += new System.EventHandler(this.FrmCrmInvestor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbOpUser;
        private System.Windows.Forms.ToolStripButton btnChooseManager;
        private System.Windows.Forms.ToolStripComboBox cbDateTypes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbPrLevels;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tbKey;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnBatchBind;
        private System.Windows.Forms.ToolStripButton btnReassignCustomers;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnImport;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnBindMgr;
        private System.Windows.Forms.ToolStripButton btnFollow;
        private System.Windows.Forms.ToolStripButton btnDelete;

    }
}