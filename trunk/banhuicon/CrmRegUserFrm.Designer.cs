namespace Banhuitong.Console {
    partial class CrmRegUserFrm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrmRegUserFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbbDepartment = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbOpUser = new System.Windows.Forms.ToolStripTextBox();
            this.btnSelMgr = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnQuickDate1Year = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDate3Year = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDate5Year = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDateThisYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cbbJxStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tbKey = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAccInfo = new System.Windows.Forms.ToolStripButton();
            this.btnAssign = new System.Windows.Forms.ToolStripButton();
            this.btnCreateAssign = new System.Windows.Forms.ToolStripButton();
            this.btnBatchBind = new System.Windows.Forms.ToolStripButton();
            this.btnReassignCustomers = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbbDepartment,
            this.toolStripLabel2,
            this.tbOpUser,
            this.btnSelMgr,
            this.toolStripLabel6,
            this.toolStripLabel3,
            this.toolStripDropDownButton1,
            this.toolStripLabel4,
            this.cbbJxStatus,
            this.toolStripLabel5,
            this.tbKey,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1149, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel1.Text = "部门(&D):";
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel2.Text = "客户经理(&C):";
            // 
            // tbOpUser
            // 
            this.tbOpUser.Name = "tbOpUser";
            this.tbOpUser.ReadOnly = true;
            this.tbOpUser.Size = new System.Drawing.Size(100, 25);
            // 
            // btnSelMgr
            // 
            this.btnSelMgr.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnSelMgr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelMgr.Name = "btnSelMgr";
            this.btnSelMgr.Size = new System.Drawing.Size(115, 22);
            this.btnSelMgr.Text = "选择客户经理(&S)";
            this.btnSelMgr.Click += new System.EventHandler(this.btnSelMgr_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "查询时间:";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel3.Text = "-";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuickDate1Year,
            this.btnQuickDate3Year,
            this.btnQuickDate5Year,
            this.btnQuickDateThisYear});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripDropDownButton1.Text = "快速选择日期";
            // 
            // btnQuickDate1Year
            // 
            this.btnQuickDate1Year.Name = "btnQuickDate1Year";
            this.btnQuickDate1Year.Size = new System.Drawing.Size(152, 22);
            this.btnQuickDate1Year.Text = "最近一年";
            this.btnQuickDate1Year.Click += new System.EventHandler(this.btnQuickDate1Year_Click);
            // 
            // btnQuickDate3Year
            // 
            this.btnQuickDate3Year.Name = "btnQuickDate3Year";
            this.btnQuickDate3Year.Size = new System.Drawing.Size(152, 22);
            this.btnQuickDate3Year.Text = "最近三年";
            this.btnQuickDate3Year.Click += new System.EventHandler(this.btnQuickDate3Year_Click);
            // 
            // btnQuickDate5Year
            // 
            this.btnQuickDate5Year.Name = "btnQuickDate5Year";
            this.btnQuickDate5Year.Size = new System.Drawing.Size(152, 22);
            this.btnQuickDate5Year.Text = "最近五年";
            this.btnQuickDate5Year.Click += new System.EventHandler(this.btnQuickDate5Year_Click);
            // 
            // btnQuickDateThisYear
            // 
            this.btnQuickDateThisYear.Name = "btnQuickDateThisYear";
            this.btnQuickDateThisYear.Size = new System.Drawing.Size(152, 22);
            this.btnQuickDateThisYear.Text = "今年";
            this.btnQuickDateThisYear.Click += new System.EventHandler(this.btnQuickDateThisYear_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel4.Text = "状态(&T):";
            // 
            // cbbJxStatus
            // 
            this.cbbJxStatus.Name = "cbbJxStatus";
            this.cbbJxStatus.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel5.Text = "关键字(&K):";
            // 
            // tbKey
            // 
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
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccInfo,
            this.btnAssign,
            this.btnCreateAssign,
            this.btnBatchBind,
            this.btnReassignCustomers});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1149, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAccInfo
            // 
            this.btnAccInfo.Image = global::Banhuitong.Console.Properties.Resources.Flag5Img;
            this.btnAccInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccInfo.Name = "btnAccInfo";
            this.btnAccInfo.Size = new System.Drawing.Size(88, 22);
            this.btnAccInfo.Text = "帐户信息(&I)";
            this.btnAccInfo.Click += new System.EventHandler(this.btnAccInfo_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Image = global::Banhuitong.Console.Properties.Resources.Flag6Img;
            this.btnAssign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(91, 22);
            this.btnAssign.Text = "重新分配(&E)";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnCreateAssign
            // 
            this.btnCreateAssign.Image = global::Banhuitong.Console.Properties.Resources.Flag3Img;
            this.btnCreateAssign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateAssign.Name = "btnCreateAssign";
            this.btnCreateAssign.Size = new System.Drawing.Size(116, 22);
            this.btnCreateAssign.Text = "分配注册客户(&A)";
            this.btnCreateAssign.Click += new System.EventHandler(this.btnCreateAssign_Click);
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
            this.btnReassignCustomers.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnReassignCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReassignCustomers.Name = "btnReassignCustomers";
            this.btnReassignCustomers.Size = new System.Drawing.Size(164, 22);
            this.btnReassignCustomers.Text = "快速重新分配客户经理(&R)";
            this.btnReassignCustomers.Click += new System.EventHandler(this.btnReassignCustomers_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
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
            this.dataGridView1.Size = new System.Drawing.Size(1149, 481);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.VirtualMode = true;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("auId", "ID", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("loginName", "登录名", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("realName", "姓名", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("mobile", "手机", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("jxStatus", "状态", MyLib.UI.MyGridColumnType.Text, 80, false, true),
            new MyLib.UI.MyGridColumn("regTime", "注册时间", MyLib.UI.MyGridColumnType.Date, 80, false, true),
            new MyLib.UI.MyGridColumn("userType", "客户类型", MyLib.UI.MyGridColumnType.Text, 80, false, true),
            new MyLib.UI.MyGridColumn("opUser", "分配人", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("uName", "客户经理", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("assignTime", "分配时间", MyLib.UI.MyGridColumnType.Date, 80, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(453, 66);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(120, 21);
            this.startDate.TabIndex = 3;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(579, 66);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(120, 21);
            this.endDate.TabIndex = 4;
            // 
            // CrmRegUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 531);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CrmRegUserFrm";
            this.ShowIcon = false;
            this.Text = "客户关系管理-分配注册客户";
            this.Load += new System.EventHandler(this.RegUserFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbbDepartment;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbOpUser;
        private System.Windows.Forms.ToolStripButton btnSelMgr;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cbbJxStatus;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnReassignCustomers;
        private System.Windows.Forms.ToolStripButton btnCreateAssign;
        private System.Windows.Forms.ToolStripButton btnBatchBind;
        private System.Windows.Forms.ToolStripButton btnAccInfo;
        private System.Windows.Forms.ToolStripButton btnAssign;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tbKey;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDate1Year;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDate3Year;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDate5Year;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDateThisYear;
    }
}