namespace Banhuitong.Console
{
    partial class PrjBorPersonsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrjBorPersonsFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbDateType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnQuickDate1Year = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDate3Year = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDate5Year = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickDateThisYear = new System.Windows.Forms.ToolStripMenuItem();
            this.cbKeyType = new System.Windows.Forms.ToolStripComboBox();
            this.tbKey = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnCerts = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCreditFiles = new System.Windows.Forms.ToolStripButton();
            this.btnIncomeFiles = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbDateType,
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.cbKeyType,
            this.tbKey,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1017, 25);
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
            // cbKeyType
            // 
            this.cbKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeyType.Name = "cbKeyType";
            this.cbKeyType.Size = new System.Drawing.Size(80, 25);
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
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(39, 49);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(120, 21);
            this.startDate.TabIndex = 1;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(165, 49);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(120, 21);
            this.endDate.TabIndex = 2;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("bpmpId", "ID", MyLib.UI.MyGridColumnType.Number, 50, false, true),
            new MyLib.UI.MyGridColumn("realName", "姓名", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("mobile", "手机", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("company", "工作单位", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("createTime", "创建时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("creator", "创建人", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("updateTime", "修改时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("updater", "修改人", MyLib.UI.MyGridColumnType.Text, 120, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableSelectedRowChanged += new MyLib.UI.GridDataTableSelectedRowChangedEventHandler(this.myGridViewBinding1_GridDataTableSelectedRowChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 353);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.VirtualMode = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnEdit,
            this.btnCerts,
            this.btnDelete,
            this.btnCreditFiles,
            this.btnIncomeFiles});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1017, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCreate
            // 
            this.btnCreate.Image = global::Banhuitong.Console.Properties.Resources.AddImg;
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(52, 22);
            this.btnCreate.Text = "创建";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            // btnCerts
            // 
            this.btnCerts.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnCerts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerts.Name = "btnCerts";
            this.btnCerts.Size = new System.Drawing.Size(76, 22);
            this.btnCerts.Text = "核实列表";
            this.btnCerts.Click += new System.EventHandler(this.btnCerts_Click);
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
            // btnCreditFiles
            // 
            this.btnCreditFiles.Image = global::Banhuitong.Console.Properties.Resources.Flag2Img;
            this.btnCreditFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreditFiles.Name = "btnCreditFiles";
            this.btnCreditFiles.Size = new System.Drawing.Size(124, 22);
            this.btnCreditFiles.Text = "征信报告情况文件";
            this.btnCreditFiles.Click += new System.EventHandler(this.btnCreditFiles_Click);
            // 
            // btnIncomeFiles
            // 
            this.btnIncomeFiles.Image = global::Banhuitong.Console.Properties.Resources.Flag3Img;
            this.btnIncomeFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncomeFiles.Name = "btnIncomeFiles";
            this.btnIncomeFiles.Size = new System.Drawing.Size(136, 22);
            this.btnIncomeFiles.Text = "收入及负债情况文件";
            this.btnIncomeFiles.Click += new System.EventHandler(this.btnIncomeFiles_Click);
            // 
            // PrjBorPersonsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PrjBorPersonsFrm";
            this.ShowIcon = false;
            this.Text = "基础数据-借款人";
            this.Load += new System.EventHandler(this.PrjBorPersonFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbKey;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.ToolStripComboBox cbDateType;
        private System.Windows.Forms.ToolStripComboBox cbKeyType;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCreate;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnCerts;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDate1Year;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDate3Year;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDate5Year;
        private System.Windows.Forms.ToolStripMenuItem btnQuickDateThisYear;
        private System.Windows.Forms.ToolStripButton btnCreditFiles;
        private System.Windows.Forms.ToolStripButton btnIncomeFiles;
    }
}