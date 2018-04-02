namespace Banhuitong.Console {
    partial class EnterprisePrjFrm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterprisePrjFrm));
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbbTimeTypes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnQuickDate1Year = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDate3Year = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDate5Year = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDateThisYear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDateNextYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cbbPrjType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbStatus = new System.Windows.Forms.ToolStripComboBox();
            this.cbTypes = new System.Windows.Forms.ToolStripComboBox();
            this.tbKey = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCreatePrj = new System.Windows.Forms.ToolStripButton();
            this.btnSearchRepayHistory = new System.Windows.Forms.ToolStripButton();
            this.btnSearchLoanHistory = new System.Windows.Forms.ToolStripButton();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnPrjEdit = new System.Windows.Forms.ToolStripButton();
            this.btnPrjSignAgreements = new System.Windows.Forms.ToolStripButton();
            this.btnDebtSignAgreements = new System.Windows.Forms.ToolStripButton();
            this.btnPrjDel = new System.Windows.Forms.ToolStripButton();
            this.btnPrjAudit = new System.Windows.Forms.ToolStripButton();
            this.btnPrjRepay = new System.Windows.Forms.ToolStripButton();
            this.btnPrjHide = new System.Windows.Forms.ToolStripButton();
            this.btnPrjTop = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(342, 53);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(120, 21);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(468, 53);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(120, 21);
            this.endDate.TabIndex = 3;
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
            this.dataGridView1.Size = new System.Drawing.Size(1132, 342);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.VirtualMode = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbbTimeTypes,
            this.toolStripLabel3,
            this.toolStripDropDownButton1,
            this.toolStripLabel4,
            this.cbbPrjType,
            this.toolStripLabel2,
            this.cbStatus,
            this.cbTypes,
            this.tbKey,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1132, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbbTimeTypes
            // 
            this.cbbTimeTypes.Name = "cbbTimeTypes";
            this.cbbTimeTypes.Size = new System.Drawing.Size(100, 25);
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
            this.btnQuickDateThisYear,
            this.btnQuickDateNextYear});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripDropDownButton1.Text = "快速选择日期";
            // 
            // btnQuickDate1Year
            // 
            this.btnQuickDate1Year.Name = "btnQuickDate1Year";
            this.btnQuickDate1Year.Size = new System.Drawing.Size(124, 22);
            this.btnQuickDate1Year.Text = "最近一年";
            this.btnQuickDate1Year.Click += new System.EventHandler(this.btnQuickDate1Year_Click);
            // 
            // btnQuickDate3Year
            // 
            this.btnQuickDate3Year.Name = "btnQuickDate3Year";
            this.btnQuickDate3Year.Size = new System.Drawing.Size(124, 22);
            this.btnQuickDate3Year.Text = "最近三年";
            this.btnQuickDate3Year.Click += new System.EventHandler(this.btnQuickDate3Year_Click);
            // 
            // btnQuickDate5Year
            // 
            this.btnQuickDate5Year.Name = "btnQuickDate5Year";
            this.btnQuickDate5Year.Size = new System.Drawing.Size(124, 22);
            this.btnQuickDate5Year.Text = "最近五年";
            this.btnQuickDate5Year.Click += new System.EventHandler(this.btnQuickDate5Year_Click);
            // 
            // btnQuickDateThisYear
            // 
            this.btnQuickDateThisYear.Name = "btnQuickDateThisYear";
            this.btnQuickDateThisYear.Size = new System.Drawing.Size(124, 22);
            this.btnQuickDateThisYear.Text = "今年";
            this.btnQuickDateThisYear.Click += new System.EventHandler(this.btnQuickDateThisYear_Click);
            // 
            // btnQuickDateNextYear
            // 
            this.btnQuickDateNextYear.Name = "btnQuickDateNextYear";
            this.btnQuickDateNextYear.Size = new System.Drawing.Size(124, 22);
            this.btnQuickDateNextYear.Text = "明年";
            this.btnQuickDateNextYear.Click += new System.EventHandler(this.btnQuickDateNextYear_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel4.Text = "项目类型(&T):";
            // 
            // cbbPrjType
            // 
            this.cbbPrjType.Name = "cbbPrjType";
            this.cbbPrjType.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel2.Text = "项目状态(&S):";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 25);
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(80, 25);
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
            // btnCreatePrj
            // 
            this.btnCreatePrj.Image = global::Banhuitong.Console.Properties.Resources.AddImg;
            this.btnCreatePrj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreatePrj.Name = "btnCreatePrj";
            this.btnCreatePrj.Size = new System.Drawing.Size(92, 22);
            this.btnCreatePrj.Text = "发起项目(&C)";
            this.btnCreatePrj.Click += new System.EventHandler(this.btnCreatePrj_Click);
            // 
            // btnSearchRepayHistory
            // 
            this.btnSearchRepayHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearchRepayHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRepayHistory.Image")));
            this.btnSearchRepayHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchRepayHistory.Name = "btnSearchRepayHistory";
            this.btnSearchRepayHistory.Size = new System.Drawing.Size(148, 22);
            this.btnSearchRepayHistory.Text = "查询还款文件上传记录(&A)";
            this.btnSearchRepayHistory.Click += new System.EventHandler(this.btnSearchRepayHistory_Click);
            // 
            // btnSearchLoanHistory
            // 
            this.btnSearchLoanHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearchLoanHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchLoanHistory.Image")));
            this.btnSearchLoanHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchLoanHistory.Name = "btnSearchLoanHistory";
            this.btnSearchLoanHistory.Size = new System.Drawing.Size(148, 22);
            this.btnSearchLoanHistory.Text = "查询放款文件上传记录(&B)";
            this.btnSearchLoanHistory.Click += new System.EventHandler(this.btnSearchLoanHistory_Click);
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("pId", "ID", MyLib.UI.MyGridColumnType.Number, 50, false, true),
            new MyLib.UI.MyGridColumn("type", "类型", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("itemNo", "编号", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("itemName", "名称", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("visible", "是否可见", MyLib.UI.MyGridColumnType.Number, 40, false, false),
            new MyLib.UI.MyGridColumn("status", "状态", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("signStatus", "签章状态", MyLib.UI.MyGridColumnType.Text, 80, false, true),
            new MyLib.UI.MyGridColumn("amt", "金额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("investedAmt", "已募集金额", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("borrowDays", "借款天数", MyLib.UI.MyGridColumnType.Number, 80, false, true),
            new MyLib.UI.MyGridColumn("rate", "借款利率", MyLib.UI.MyGridColumnType.Percent, 100, false, true),
            new MyLib.UI.MyGridColumn("costFee", "总借款成本", MyLib.UI.MyGridColumnType.Percent, 100, false, true),
            new MyLib.UI.MyGridColumn("totalInterest", "总利息", MyLib.UI.MyGridColumnType.Money, 120, false, true),
            new MyLib.UI.MyGridColumn("inProxy", "融资项目经理", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("financier", "融资方", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("createTime", "创建时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("onLineTime", "上线时间", MyLib.UI.MyGridColumnType.Date, 80, false, true),
            new MyLib.UI.MyGridColumn("loanTime", "放款时间", MyLib.UI.MyGridColumnType.Date, 80, false, true),
            new MyLib.UI.MyGridColumn("capitalRepayTime", "预计还本时间", MyLib.UI.MyGridColumnType.Date, 80, false, true),
            new MyLib.UI.MyGridColumn("topTime", "置顶时间", MyLib.UI.MyGridColumnType.Number, 120, false, false),
            new MyLib.UI.MyGridColumn("lockedTime", "锁定时间", MyLib.UI.MyGridColumnType.Number, 120, false, false),
            new MyLib.UI.MyGridColumn("clearTime", "结清时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreatePrj,
            this.btnPrjEdit,
            this.btnPrjSignAgreements,
            this.btnDebtSignAgreements,
            this.btnPrjDel,
            this.btnPrjAudit,
            this.btnPrjRepay,
            this.btnPrjHide,
            this.btnPrjTop,
            this.btnSearchRepayHistory,
            this.btnSearchLoanHistory});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1132, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnPrjEdit
            // 
            this.btnPrjEdit.Image = global::Banhuitong.Console.Properties.Resources.EditImg;
            this.btnPrjEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrjEdit.Name = "btnPrjEdit";
            this.btnPrjEdit.Size = new System.Drawing.Size(52, 22);
            this.btnPrjEdit.Text = "编辑";
            this.btnPrjEdit.Click += new System.EventHandler(this.btnPrjEdit_Click);
            // 
            // btnPrjSignAgreements
            // 
            this.btnPrjSignAgreements.Image = global::Banhuitong.Console.Properties.Resources.Flag5Img;
            this.btnPrjSignAgreements.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrjSignAgreements.Name = "btnPrjSignAgreements";
            this.btnPrjSignAgreements.Size = new System.Drawing.Size(76, 22);
            this.btnPrjSignAgreements.Text = "项目签章";
            this.btnPrjSignAgreements.Click += new System.EventHandler(this.btnSignAgreements_Click);
            // 
            // btnDebtSignAgreements
            // 
            this.btnDebtSignAgreements.Image = global::Banhuitong.Console.Properties.Resources.Flag6Img;
            this.btnDebtSignAgreements.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDebtSignAgreements.Name = "btnDebtSignAgreements";
            this.btnDebtSignAgreements.Size = new System.Drawing.Size(124, 22);
            this.btnDebtSignAgreements.Text = "强制债权转让签章";
            this.btnDebtSignAgreements.Click += new System.EventHandler(this.btnDebtSignAgreements_Click);
            // 
            // btnPrjDel
            // 
            this.btnPrjDel.Image = global::Banhuitong.Console.Properties.Resources.DeleteImg;
            this.btnPrjDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrjDel.Name = "btnPrjDel";
            this.btnPrjDel.Size = new System.Drawing.Size(52, 22);
            this.btnPrjDel.Text = "删除";
            this.btnPrjDel.Click += new System.EventHandler(this.btnPrjDel_Click);
            // 
            // btnPrjAudit
            // 
            this.btnPrjAudit.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnPrjAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrjAudit.Name = "btnPrjAudit";
            this.btnPrjAudit.Size = new System.Drawing.Size(52, 22);
            this.btnPrjAudit.Text = "审批";
            this.btnPrjAudit.Click += new System.EventHandler(this.btnPrjAudit_Click);
            // 
            // btnPrjRepay
            // 
            this.btnPrjRepay.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnPrjRepay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrjRepay.Name = "btnPrjRepay";
            this.btnPrjRepay.Size = new System.Drawing.Size(52, 22);
            this.btnPrjRepay.Text = "还款";
            this.btnPrjRepay.Click += new System.EventHandler(this.btnPrjRepay_Click);
            // 
            // btnPrjHide
            // 
            this.btnPrjHide.Image = global::Banhuitong.Console.Properties.Resources.Flag3Img;
            this.btnPrjHide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrjHide.Name = "btnPrjHide";
            this.btnPrjHide.Size = new System.Drawing.Size(52, 22);
            this.btnPrjHide.Text = "隐藏";
            this.btnPrjHide.Click += new System.EventHandler(this.btnPrjHide_Click);
            // 
            // btnPrjTop
            // 
            this.btnPrjTop.Image = global::Banhuitong.Console.Properties.Resources.Flag4Img;
            this.btnPrjTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrjTop.Name = "btnPrjTop";
            this.btnPrjTop.Size = new System.Drawing.Size(52, 22);
            this.btnPrjTop.Text = "置顶";
            this.btnPrjTop.Click += new System.EventHandler(this.btnPrjTop_Click);
            // 
            // EnterprisePrjFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 392);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EnterprisePrjFrm";
            this.ShowIcon = false;
            this.Text = "项目管理";
            this.Load += new System.EventHandler(this.EnterprisePrjFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCreatePrj;
        private System.Windows.Forms.ToolStripButton btnSearchRepayHistory;
        private System.Windows.Forms.ToolStripButton btnSearchLoanHistory;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbStatus;
        private System.Windows.Forms.ToolStripComboBox cbTypes;
        private System.Windows.Forms.ToolStripTextBox tbKey;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnPrjEdit;
        private System.Windows.Forms.ToolStripButton btnPrjDel;
        private System.Windows.Forms.ToolStripButton btnPrjAudit;
        private System.Windows.Forms.ToolStripButton btnPrjRepay;
        private System.Windows.Forms.ToolStripButton btnPrjHide;
        private System.Windows.Forms.ToolStripButton btnPrjTop;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cbbPrjType;
        private System.Windows.Forms.ToolStripButton btnPrjSignAgreements;
        private System.Windows.Forms.ToolStripComboBox cbbTimeTypes;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDate1Year;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDate3Year;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDate5Year;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDateThisYear;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDateNextYear;
        private System.Windows.Forms.ToolStripButton btnDebtSignAgreements;
    }
}