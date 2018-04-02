namespace Banhuitong.Console {
    partial class CrmInvestorDlg {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRealName = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbSourceType = new System.Windows.Forms.TextBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.cbbPrLevel = new System.Windows.Forms.ComboBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelAssign = new System.Windows.Forms.Button();
            this.btnChangePhone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名(&N):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "手机(&M):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "工作单位(&U):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "职务(&P):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "所在城市(&C):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "年龄(&A):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "性别(&G):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "来源(&S):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "分级(&T):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "备注(&R):";
            // 
            // tbRealName
            // 
            this.myValidator1.SetCriteria(this.tbRealName, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.RealName));
            this.tbRealName.Location = new System.Drawing.Point(93, 15);
            this.tbRealName.Name = "tbRealName";
            this.tbRealName.Size = new System.Drawing.Size(299, 21);
            this.tbRealName.TabIndex = 10;
            // 
            // tbMobile
            // 
            this.myValidator1.SetCriteria(this.tbMobile, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.Mobile));
            this.tbMobile.Location = new System.Drawing.Point(93, 41);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(299, 21);
            this.tbMobile.TabIndex = 10;
            // 
            // tbCompany
            // 
            this.myValidator1.SetCriteria(this.tbCompany, new MyLib.UI.MyValidationCriteria(false, ".{1,200}"));
            this.tbCompany.Location = new System.Drawing.Point(93, 67);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(299, 21);
            this.tbCompany.TabIndex = 10;
            // 
            // tbPosition
            // 
            this.myValidator1.SetCriteria(this.tbPosition, new MyLib.UI.MyValidationCriteria(false, ".{1,200}"));
            this.tbPosition.Location = new System.Drawing.Point(93, 93);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(299, 21);
            this.tbPosition.TabIndex = 10;
            // 
            // tbCity
            // 
            this.myValidator1.SetCriteria(this.tbCity, new MyLib.UI.MyValidationCriteria(false, ".{1,40}"));
            this.tbCity.Location = new System.Drawing.Point(93, 119);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(299, 21);
            this.tbCity.TabIndex = 10;
            // 
            // tbSourceType
            // 
            this.myValidator1.SetCriteria(this.tbSourceType, new MyLib.UI.MyValidationCriteria(false, ".{1,200}"));
            this.tbSourceType.Location = new System.Drawing.Point(93, 197);
            this.tbSourceType.Name = "tbSourceType";
            this.tbSourceType.Size = new System.Drawing.Size(299, 21);
            this.tbSourceType.TabIndex = 10;
            // 
            // tbRemark
            // 
            this.myValidator1.SetCriteria(this.tbRemark, new MyLib.UI.MyValidationCriteria(false, ".{1,200}"));
            this.tbRemark.Location = new System.Drawing.Point(93, 249);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(299, 134);
            this.tbRemark.TabIndex = 10;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(104, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 28);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(329, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbbGender
            // 
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Location = new System.Drawing.Point(93, 171);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(299, 20);
            this.cbbGender.TabIndex = 13;
            // 
            // cbbPrLevel
            // 
            this.cbbPrLevel.FormattingEnabled = true;
            this.cbbPrLevel.Location = new System.Drawing.Point(93, 223);
            this.cbbPrLevel.Name = "cbbPrLevel";
            this.cbbPrLevel.Size = new System.Drawing.Size(299, 20);
            this.cbbPrLevel.TabIndex = 13;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(93, 146);
            this.nudAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(299, 21);
            this.nudAge.TabIndex = 14;
            this.nudAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancelAssign);
            this.panel1.Controls.Add(this.btnChangePhone);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 28);
            this.panel1.TabIndex = 15;
            // 
            // btnCancelAssign
            // 
            this.btnCancelAssign.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelAssign.Location = new System.Drawing.Point(179, 0);
            this.btnCancelAssign.Name = "btnCancelAssign";
            this.btnCancelAssign.Size = new System.Drawing.Size(75, 28);
            this.btnCancelAssign.TabIndex = 13;
            this.btnCancelAssign.Text = "取消分配";
            this.btnCancelAssign.UseVisualStyleBackColor = true;
            this.btnCancelAssign.Click += new System.EventHandler(this.btnCancelAssign_Click);
            // 
            // btnChangePhone
            // 
            this.btnChangePhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangePhone.Location = new System.Drawing.Point(254, 0);
            this.btnChangePhone.Name = "btnChangePhone";
            this.btnChangePhone.Size = new System.Drawing.Size(75, 28);
            this.btnChangePhone.TabIndex = 14;
            this.btnChangePhone.Text = "修改手机号";
            this.btnChangePhone.UseVisualStyleBackColor = true;
            this.btnChangePhone.Click += new System.EventHandler(this.btnChangePhone_Click);
            // 
            // CrmInvestorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(404, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.cbbPrLevel);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.tbSourceType);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbRealName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CrmInvestorDlg";
            this.ShowIcon = false;
            this.Text = "创建/编辑跟进客户";
            this.Load += new System.EventHandler(this.CrmInvestorDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRealName;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbSourceType;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.ComboBox cbbPrLevel;
        private System.Windows.Forms.NumericUpDown nudAge;
        private MyLib.UI.MyValidator myValidator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelAssign;
        private System.Windows.Forms.Button btnChangePhone;
    }
}