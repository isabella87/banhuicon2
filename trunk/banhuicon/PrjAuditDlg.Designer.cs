namespace Banhuitong.Console {
    partial class PrjAuditDlg {
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
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnInvestors = new System.Windows.Forms.Button();
            this.btnTenders = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnInvests = new System.Windows.Forms.Button();
            this.btnCancelTenders = new System.Windows.Forms.Button();
            this.btnPrjClose = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labMoneyCompare = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("opTime", "时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("opUser", "操作人", MyLib.UI.MyGridColumnType.Text, 100, false, true),
            new MyLib.UI.MyGridColumn("aOrder", "业务操作", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("flag", "是否通过", MyLib.UI.MyGridColumnType.Boolean, 40, false, true),
            new MyLib.UI.MyGridColumn("comments", "备注", MyLib.UI.MyGridColumnType.Text, 120, false, true)});
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
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
            this.dataGridView1.Size = new System.Drawing.Size(788, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.VirtualMode = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnInvestors);
            this.panel1.Controls.Add(this.btnTenders);
            this.panel1.Controls.Add(this.btnLoans);
            this.panel1.Controls.Add(this.btnInvests);
            this.panel1.Controls.Add(this.btnCancelTenders);
            this.panel1.Controls.Add(this.btnPrjClose);
            this.panel1.Controls.Add(this.btnLock);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 27);
            this.panel1.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(11, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 27);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnInvestors
            // 
            this.btnInvestors.AutoSize = true;
            this.btnInvestors.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInvestors.Location = new System.Drawing.Point(86, 0);
            this.btnInvestors.Name = "btnInvestors";
            this.btnInvestors.Size = new System.Drawing.Size(129, 27);
            this.btnInvestors.TabIndex = 5;
            this.btnInvestors.Text = "生成出借人信息表(&L)";
            this.btnInvestors.UseVisualStyleBackColor = true;
            this.btnInvestors.Click += new System.EventHandler(this.btnInvestors_Click);
            // 
            // btnTenders
            // 
            this.btnTenders.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTenders.Location = new System.Drawing.Point(215, 0);
            this.btnTenders.Name = "btnTenders";
            this.btnTenders.Size = new System.Drawing.Size(79, 27);
            this.btnTenders.TabIndex = 1;
            this.btnTenders.Text = "查看投标(&T)";
            this.btnTenders.UseVisualStyleBackColor = true;
            this.btnTenders.Click += new System.EventHandler(this.btnTenders_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.AutoSize = true;
            this.btnLoans.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoans.Location = new System.Drawing.Point(294, 0);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(105, 27);
            this.btnLoans.TabIndex = 5;
            this.btnLoans.Text = "查询放款记录(&L)";
            this.btnLoans.UseVisualStyleBackColor = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // btnInvests
            // 
            this.btnInvests.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInvests.Location = new System.Drawing.Point(399, 0);
            this.btnInvests.Name = "btnInvests";
            this.btnInvests.Size = new System.Drawing.Size(79, 27);
            this.btnInvests.TabIndex = 2;
            this.btnInvests.Text = "有效投资(&I)";
            this.btnInvests.UseVisualStyleBackColor = true;
            this.btnInvests.Click += new System.EventHandler(this.btnInvests_Click);
            // 
            // btnCancelTenders
            // 
            this.btnCancelTenders.AutoSize = true;
            this.btnCancelTenders.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelTenders.Location = new System.Drawing.Point(478, 0);
            this.btnCancelTenders.Name = "btnCancelTenders";
            this.btnCancelTenders.Size = new System.Drawing.Size(81, 27);
            this.btnCancelTenders.TabIndex = 3;
            this.btnCancelTenders.Text = "执行流标(&A)";
            this.btnCancelTenders.UseVisualStyleBackColor = true;
            this.btnCancelTenders.Click += new System.EventHandler(this.btnCancelTenders_Click);
            // 
            // btnPrjClose
            // 
            this.btnPrjClose.AutoSize = true;
            this.btnPrjClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrjClose.Location = new System.Drawing.Point(559, 0);
            this.btnPrjClose.Name = "btnPrjClose";
            this.btnPrjClose.Size = new System.Drawing.Size(79, 27);
            this.btnPrjClose.TabIndex = 6;
            this.btnPrjClose.Text = "结清";
            this.btnPrjClose.UseVisualStyleBackColor = true;
            this.btnPrjClose.Click += new System.EventHandler(this.btnPrjClose_Click);
            // 
            // btnLock
            // 
            this.btnLock.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLock.Location = new System.Drawing.Point(638, 0);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 27);
            this.btnLock.TabIndex = 7;
            this.btnLock.Text = "锁定";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(713, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labMoneyCompare);
            this.groupBox1.Controls.Add(this.tbComments);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(&A)";
            // 
            // labMoneyCompare
            // 
            this.labMoneyCompare.AutoSize = true;
            this.labMoneyCompare.ForeColor = System.Drawing.Color.Red;
            this.labMoneyCompare.Location = new System.Drawing.Point(130, 29);
            this.labMoneyCompare.Name = "labMoneyCompare";
            this.labMoneyCompare.Size = new System.Drawing.Size(0, 12);
            this.labMoneyCompare.TabIndex = 4;
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(12, 68);
            this.tbComments.MaxLength = 2000;
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(764, 138);
            this.tbComments.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "备注(&C):";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(65, 27);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(59, 16);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "不通过";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(12, 27);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(47, 16);
            this.rbYes.TabIndex = 0;
            this.rbYes.Text = "通过";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(788, 12);
            this.label2.TabIndex = 5;
            // 
            // PrjAuditDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(788, 439);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PrjAuditDlg";
            this.ShowIcon = false;
            this.Text = "审批-{0}";
            this.Load += new System.EventHandler(this.PrjAuditDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelTenders;
        private System.Windows.Forms.Button btnInvests;
        private System.Windows.Forms.Button btnTenders;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labMoneyCompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInvestors;
        private System.Windows.Forms.Button btnPrjClose;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnLock;
    }
}