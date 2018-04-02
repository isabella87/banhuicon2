namespace Banhuitong.Console {
    partial class CrmInvestorRemarksDlg {
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbFollowRecord = new System.Windows.Forms.ComboBox();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnInvestsDepository = new System.Windows.Forms.Button();
            this.btnInvestsPlatform = new System.Windows.Forms.Button();
            this.btnRunnings = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户姓名:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "跟进记录";
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
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
            this.dataGridView1.Size = new System.Drawing.Size(612, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(77, 14);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(140, 21);
            this.tbName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRemark);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.cbbFollowRecord);
            this.groupBox2.Location = new System.Drawing.Point(0, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 225);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加跟进信息";
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(14, 70);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(598, 149);
            this.tbRemark.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "备注:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(537, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbFollowRecord
            // 
            this.cbbFollowRecord.Enabled = false;
            this.cbbFollowRecord.FormattingEnabled = true;
            this.cbbFollowRecord.Location = new System.Drawing.Point(14, 22);
            this.cbbFollowRecord.Name = "cbbFollowRecord";
            this.cbbFollowRecord.Size = new System.Drawing.Size(517, 20);
            this.cbbFollowRecord.TabIndex = 0;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("opUser", "客户经理", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("datepoint", "创建时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("action", "跟进状态", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("remark", "备注", MyLib.UI.MyGridColumnType.Text, 120, false, true)});
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
            // 
            // btnAccount
            // 
            this.btnAccount.AutoSize = true;
            this.btnAccount.Enabled = false;
            this.btnAccount.Location = new System.Drawing.Point(119, 606);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(81, 23);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "详细信息(&D)";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnInvestsDepository
            // 
            this.btnInvestsDepository.AutoSize = true;
            this.btnInvestsDepository.Enabled = false;
            this.btnInvestsDepository.Location = new System.Drawing.Point(207, 607);
            this.btnInvestsDepository.Name = "btnInvestsDepository";
            this.btnInvestsDepository.Size = new System.Drawing.Size(117, 23);
            this.btnInvestsDepository.TabIndex = 5;
            this.btnInvestsDepository.Text = "投标记录(存管)(&S)";
            this.btnInvestsDepository.UseVisualStyleBackColor = true;
            this.btnInvestsDepository.Click += new System.EventHandler(this.btnInvestsDepository_Click);
            // 
            // btnInvestsPlatform
            // 
            this.btnInvestsPlatform.AutoSize = true;
            this.btnInvestsPlatform.Enabled = false;
            this.btnInvestsPlatform.Location = new System.Drawing.Point(331, 607);
            this.btnInvestsPlatform.Name = "btnInvestsPlatform";
            this.btnInvestsPlatform.Size = new System.Drawing.Size(117, 23);
            this.btnInvestsPlatform.TabIndex = 6;
            this.btnInvestsPlatform.Text = "投标记录(平台)(&P)";
            this.btnInvestsPlatform.UseVisualStyleBackColor = true;
            this.btnInvestsPlatform.Click += new System.EventHandler(this.btnInvestsPlatform_Click);
            // 
            // btnRunnings
            // 
            this.btnRunnings.AutoSize = true;
            this.btnRunnings.Enabled = false;
            this.btnRunnings.Location = new System.Drawing.Point(455, 607);
            this.btnRunnings.Name = "btnRunnings";
            this.btnRunnings.Size = new System.Drawing.Size(81, 23);
            this.btnRunnings.TabIndex = 7;
            this.btnRunnings.Text = "收支明细(&R)";
            this.btnRunnings.UseVisualStyleBackColor = true;
            this.btnRunnings.Click += new System.EventHandler(this.btnRunnings_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(543, 607);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CrmInvestorRemarksDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(621, 642);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRunnings);
            this.Controls.Add(this.btnInvestsPlatform);
            this.Controls.Add(this.btnInvestsDepository);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CrmInvestorRemarksDlg";
            this.ShowIcon = false;
            this.Text = "跟进情况-{0}";
            this.Load += new System.EventHandler(this.CrmInvestorRemarksDlg_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbFollowRecord;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnInvestsDepository;
        private System.Windows.Forms.Button btnInvestsPlatform;
        private System.Windows.Forms.Button btnRunnings;
        private System.Windows.Forms.Button btnCancel;
    }
}