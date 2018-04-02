namespace Banhuitong.Console {
    partial class CrmMyInvestorsFrm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnWorkDetails = new System.Windows.Forms.ToolStripButton();
            this.btnWorkExamine = new System.Windows.Forms.ToolStripButton();
            this.btnFollow = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbOpUser = new System.Windows.Forms.ToolStripTextBox();
            this.btnSelectMgr = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cbbPrLevels = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cbbAge = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cbbGenders = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cbbCustomerSource = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.cbbAccStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.tbKey = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWorkDetails,
            this.btnWorkExamine,
            this.btnFollow});
            this.toolStrip3.Location = new System.Drawing.Point(0, 50);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1046, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip1";
            // 
            // btnWorkDetails
            // 
            this.btnWorkDetails.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnWorkDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkDetails.Name = "btnWorkDetails";
            this.btnWorkDetails.Size = new System.Drawing.Size(76, 22);
            this.btnWorkDetails.Text = "工作任务";
            this.btnWorkDetails.Click += new System.EventHandler(this.btnWorkDetails_Click);
            // 
            // btnWorkExamine
            // 
            this.btnWorkExamine.Enabled = false;
            this.btnWorkExamine.Image = global::Banhuitong.Console.Properties.Resources.Flag3Img;
            this.btnWorkExamine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkExamine.Name = "btnWorkExamine";
            this.btnWorkExamine.Size = new System.Drawing.Size(76, 22);
            this.btnWorkExamine.Text = "绩效考核";
            // 
            // btnFollow
            // 
            this.btnFollow.Image = global::Banhuitong.Console.Properties.Resources.Flag4Img;
            this.btnFollow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(76, 22);
            this.btnFollow.Text = "跟进情况";
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
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
            // btnSelectMgr
            // 
            this.btnSelectMgr.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnSelectMgr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectMgr.Name = "btnSelectMgr";
            this.btnSelectMgr.Size = new System.Drawing.Size(120, 22);
            this.btnSelectMgr.Text = "选择客户经理(&M)";
            this.btnSelectMgr.Click += new System.EventHandler(this.btnSelectMgr_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tbOpUser,
            this.btnSelectMgr,
            this.toolStripLabel3,
            this.cbbPrLevels,
            this.toolStripLabel4,
            this.cbbAge,
            this.toolStripLabel5,
            this.cbbGenders,
            this.toolStripLabel6,
            this.cbbCustomerSource});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1046, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel3.Text = "等级(&T):";
            // 
            // cbbPrLevels
            // 
            this.cbbPrLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPrLevels.Name = "cbbPrLevels";
            this.cbbPrLevels.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel4.Text = "年龄(&A):";
            // 
            // cbbAge
            // 
            this.cbbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAge.Name = "cbbAge";
            this.cbbAge.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel5.Text = "性别(&G):";
            // 
            // cbbGenders
            // 
            this.cbbGenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenders.Name = "cbbGenders";
            this.cbbGenders.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "客户来源:";
            // 
            // cbbCustomerSource
            // 
            this.cbbCustomerSource.Name = "cbbCustomerSource";
            this.cbbCustomerSource.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel7.Text = "帐户状态:";
            // 
            // cbbAccStatus
            // 
            this.cbbAccStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAccStatus.Name = "cbbAccStatus";
            this.cbbAccStatus.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel8.Text = "分配时间:";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel9.Text = "-";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel7,
            this.cbbAccStatus,
            this.toolStripLabel8,
            this.toolStripLabel9,
            this.toolStripLabel10,
            this.tbKey,
            this.btnSearch});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1046, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip3";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel10.Text = "关键字(&K)";
            // 
            // tbKey
            // 
            this.tbKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(200, 25);
            this.tbKey.ToolTipText = "精确匹配：姓名、登录名、手机号";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 486);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.VirtualMode = true;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(12, 78);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(120, 21);
            this.startDate.TabIndex = 5;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(138, 78);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(120, 21);
            this.endDate.TabIndex = 6;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("ciId", "ID", MyLib.UI.MyGridColumnType.Number, 50, false, true),
            new MyLib.UI.MyGridColumn("auId", "注册ID", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("loginName", "登录名", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("realName", "姓名", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("gender", "性别", MyLib.UI.MyGridColumnType.Text, 80, false, true),
            new MyLib.UI.MyGridColumn("age", "年龄", MyLib.UI.MyGridColumnType.Text, 80, false, true),
            new MyLib.UI.MyGridColumn("mobile", "手机", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("rCode", "推荐码", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("prLevel", "等级", MyLib.UI.MyGridColumnType.Text, 80, false, true),
            new MyLib.UI.MyGridColumn("regStatus", "状态", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("latestAction", "最新跟进状态", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("originType", "客户来源", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("assignTime", "分配时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true)});
            this.myGridViewBinding1.DataTable = null;
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // CrmMyInvestorsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 561);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CrmMyInvestorsFrm";
            this.ShowIcon = false;
            this.Text = "客户关系管理-我的跟进客户";
            this.Load += new System.EventHandler(this.FrmCrmMyInvestors_Load);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
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

        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnWorkDetails;
        private System.Windows.Forms.ToolStripButton btnWorkExamine;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbOpUser;
        private System.Windows.Forms.ToolStripButton btnSelectMgr;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cbbPrLevels;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cbbAge;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cbbGenders;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cbbCustomerSource;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox cbbAccStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripTextBox tbKey;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.ToolStripButton btnFollow;
    }
}