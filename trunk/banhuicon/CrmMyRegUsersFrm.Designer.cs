namespace Banhuitong.Console {
    partial class CrmMyRegUsersFrm {
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
            this.tbOpUser = new System.Windows.Forms.ToolStripTextBox();
            this.btnSelMgr = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cbbAge = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cbbGender = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cbbAccType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cbbAccStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.tbKeys = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnAccInfo = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tbOpUser,
            this.btnSelMgr,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.cbbAge,
            this.toolStripLabel4,
            this.cbbGender,
            this.toolStripLabel5,
            this.cbbAccType,
            this.toolStripLabel6,
            this.cbbAccStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 25);
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
            // btnSelMgr
            // 
            this.btnSelMgr.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnSelMgr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelMgr.Name = "btnSelMgr";
            this.btnSelMgr.Size = new System.Drawing.Size(120, 22);
            this.btnSelMgr.Text = "选择客户经理(&M)";
            this.btnSelMgr.Click += new System.EventHandler(this.btnSelMgr_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel2.Text = "查询日期(&D):";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel3.Text = "年龄(&A):";
            // 
            // cbbAge
            // 
            this.cbbAge.Name = "cbbAge";
            this.cbbAge.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel4.Text = "性别(&G):";
            // 
            // cbbGender
            // 
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel5.Text = "帐户类型:";
            // 
            // cbbAccType
            // 
            this.cbbAccType.Name = "cbbAccType";
            this.cbbAccType.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "帐户状态:";
            // 
            // cbbAccStatus
            // 
            this.cbbAccStatus.Name = "cbbAccStatus";
            this.cbbAccStatus.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel9,
            this.tbKeys,
            this.btnSearch});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1031, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel9.Text = "关键字(&K):";
            // 
            // tbKeys
            // 
            this.tbKeys.Name = "tbKeys";
            this.tbKeys.Size = new System.Drawing.Size(200, 25);
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
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccInfo});
            this.toolStrip3.Location = new System.Drawing.Point(0, 50);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1031, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnAccInfo
            // 
            this.btnAccInfo.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnAccInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccInfo.Name = "btnAccInfo";
            this.btnAccInfo.Size = new System.Drawing.Size(92, 22);
            this.btnAccInfo.Text = "帐户信息(&A)";
            this.btnAccInfo.Click += new System.EventHandler(this.btnAccInfo_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(1031, 416);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.VirtualMode = true;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("auId", "ID", MyLib.UI.MyGridColumnType.Number, 100, false, true),
            new MyLib.UI.MyGridColumn("loginName", "用户名", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("realName", "姓名", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("gender", "性别", MyLib.UI.MyGridColumnType.Text, 80, false, true),
            new MyLib.UI.MyGridColumn("age", "年龄", MyLib.UI.MyGridColumnType.Number, 80, false, true),
            new MyLib.UI.MyGridColumn("mobile", "手机", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("regTime", "注册时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("userType", "类型", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("jxStatus", "状态", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("assignTime", "分配时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("todayInvestAmt", "投资", MyLib.UI.MyGridColumnType.Money, 100, false, true),
            new MyLib.UI.MyGridColumn("todayRepayCapitalAmt", "还本", MyLib.UI.MyGridColumnType.Money, 100, false, true),
            new MyLib.UI.MyGridColumn("todayRechargeAmt", "充值", MyLib.UI.MyGridColumnType.Money, 100, false, true),
            new MyLib.UI.MyGridColumn("todayWithdrawAmt", "提现", MyLib.UI.MyGridColumnType.Money, 100, false, true),
            new MyLib.UI.MyGridColumn("investRemainAmt", "投资余额", MyLib.UI.MyGridColumnType.Money, 100, false, true),
            new MyLib.UI.MyGridColumn("investCount", "当月投资次数", MyLib.UI.MyGridColumnType.Number, 120, false, true),
            new MyLib.UI.MyGridColumn("sumInvestAmt", "累计投资额", MyLib.UI.MyGridColumnType.Money, 100, false, true),
            new MyLib.UI.MyGridColumn("tieCardTime", "绑卡时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Location = new System.Drawing.Point(309, 78);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(120, 21);
            this.dtpSearchDate.TabIndex = 4;
            // 
            // CrmMyRegUsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 491);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CrmMyRegUsersFrm";
            this.ShowIcon = false;
            this.Text = "客户关系管理-我的注册客户";
            this.Load += new System.EventHandler(this.CrmMyRegUsersFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbOpUser;
        private System.Windows.Forms.ToolStripButton btnSelMgr;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cbbAge;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cbbGender;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cbbAccType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cbbAccStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripTextBox tbKeys;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnAccInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
    }
}