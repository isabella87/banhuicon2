namespace Banhuitong.Console {
    partial class PrjGuaranteePerDlg {
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
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbShowName = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.tbIdCard = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbShowAge = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbIntro = new System.Windows.Forms.TextBox();
            this.tbShowAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbGenders = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.myValidator1.SetCriteria(this.tbName, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.RealName));
            this.tbName.Location = new System.Drawing.Point(76, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(268, 21);
            this.tbName.TabIndex = 13;
            // 
            // tbShowName
            // 
            this.myValidator1.SetCriteria(this.tbShowName, new MyLib.UI.MyValidationCriteria(true, "[\\w*]{2,40}"));
            this.tbShowName.Location = new System.Drawing.Point(415, 6);
            this.tbShowName.Name = "tbShowName";
            this.tbShowName.Size = new System.Drawing.Size(268, 21);
            this.tbShowName.TabIndex = 14;
            // 
            // tbPostCode
            // 
            this.myValidator1.SetCriteria(this.tbPostCode, new MyLib.UI.MyValidationCriteria(false, "\\d{0,6}"));
            this.tbPostCode.Location = new System.Drawing.Point(415, 130);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(121, 21);
            this.tbPostCode.TabIndex = 19;
            // 
            // tbIdCard
            // 
            this.myValidator1.SetCriteria(this.tbIdCard, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.IdCard));
            this.tbIdCard.Location = new System.Drawing.Point(76, 68);
            this.tbIdCard.Name = "tbIdCard";
            this.tbIdCard.Size = new System.Drawing.Size(268, 21);
            this.tbIdCard.TabIndex = 35;
            // 
            // tbMobile
            // 
            this.myValidator1.SetCriteria(this.tbMobile, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.Mobile));
            this.tbMobile.Location = new System.Drawing.Point(76, 130);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(268, 21);
            this.tbMobile.TabIndex = 21;
            // 
            // tbAge
            // 
            this.myValidator1.SetCriteria(this.tbAge, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.Age));
            this.tbAge.Location = new System.Drawing.Point(76, 37);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(268, 21);
            this.tbAge.TabIndex = 38;
            // 
            // tbShowAge
            // 
            this.myValidator1.SetCriteria(this.tbShowAge, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.Age));
            this.tbShowAge.Location = new System.Drawing.Point(415, 37);
            this.tbShowAge.Name = "tbShowAge";
            this.tbShowAge.Size = new System.Drawing.Size(268, 21);
            this.tbShowAge.TabIndex = 39;
            // 
            // tbAddress
            // 
            this.myValidator1.SetCriteria(this.tbAddress, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbAddress.Location = new System.Drawing.Point(76, 99);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(268, 21);
            this.tbAddress.TabIndex = 18;
            // 
            // tbIntro
            // 
            this.myValidator1.SetCriteria(this.tbIntro, new MyLib.UI.MyValidationCriteria(false, ".{0,1000}"));
            this.tbIntro.Location = new System.Drawing.Point(76, 161);
            this.tbIntro.Multiline = true;
            this.tbIntro.Name = "tbIntro";
            this.tbIntro.Size = new System.Drawing.Size(607, 229);
            this.tbIntro.TabIndex = 25;
            // 
            // tbShowAddress
            // 
            this.myValidator1.SetCriteria(this.tbShowAddress, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbShowAddress.Location = new System.Drawing.Point(415, 99);
            this.tbShowAddress.Name = "tbShowAddress";
            this.tbShowAddress.Size = new System.Drawing.Size(268, 21);
            this.tbShowAddress.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "地址:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "个人介绍:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "展示姓名:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "邮编:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "联系电话:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(608, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(527, 396);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(350, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 32;
            this.label18.Text = "展示地址:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 34;
            this.label19.Text = "身份证号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "年龄:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "展示年龄:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 40;
            this.label5.Text = "性别:";
            // 
            // cbbGenders
            // 
            this.cbbGenders.FormattingEnabled = true;
            this.cbbGenders.Location = new System.Drawing.Point(415, 68);
            this.cbbGenders.Name = "cbbGenders";
            this.cbbGenders.Size = new System.Drawing.Size(121, 20);
            this.cbbGenders.TabIndex = 41;
            // 
            // PrjGuaranteePerDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(695, 426);
            this.Controls.Add(this.cbbGenders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbShowAge);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdCard);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbShowAddress);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbIntro);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbPostCode);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbShowName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PrjGuaranteePerDlg";
            this.ShowIcon = false;
            this.Text = "创建担保人";
            this.Load += new System.EventHandler(this.PrjGuaranteeDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLib.UI.MyValidator myValidator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbShowName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbIntro;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbShowAddress;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbIdCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbShowAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbGenders;
    }
}