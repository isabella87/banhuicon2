namespace Banhuitong.Console {
    partial class PrjOwnerDlg {
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbShowName = new System.Windows.Forms.TextBox();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.tbRegYear = new System.Windows.Forms.TextBox();
            this.tbShowRegFunds = new System.Windows.Forms.TextBox();
            this.tbRegFunds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbEntIndustry = new System.Windows.Forms.ComboBox();
            this.tbIntro = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            this.cbbOwnerNature = new System.Windows.Forms.ComboBox();
            this.cbbOwnerStrength = new System.Windows.Forms.ComboBox();
            this.cbbOwnerQuality = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "企业名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "注册时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "注册资金:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "行业:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "项目业主介绍:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "展示名称:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "注册年限:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "展示注册资金:";
            // 
            // tbName
            // 
            this.myValidator1.SetCriteria(this.tbName, new MyLib.UI.MyValidationCriteria(false, "[\\w\\uff08\\uff09\\u3010\\u3011]{2,40}"));
            this.tbName.Location = new System.Drawing.Point(99, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(281, 21);
            this.tbName.TabIndex = 8;
            // 
            // tbShowName
            // 
            this.myValidator1.SetCriteria(this.tbShowName, new MyLib.UI.MyValidationCriteria(false, "[\\w\\uff08\\uff09\\u3010\\u3011*]{2,40}"));
            this.tbShowName.Location = new System.Drawing.Point(482, 12);
            this.tbShowName.Name = "tbShowName";
            this.tbShowName.Size = new System.Drawing.Size(281, 21);
            this.tbShowName.TabIndex = 9;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Location = new System.Drawing.Point(99, 45);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(120, 21);
            this.dtpRegisterDate.TabIndex = 10;
            // 
            // tbRegYear
            // 
            this.myValidator1.SetCriteria(this.tbRegYear, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.Year));
            this.tbRegYear.Location = new System.Drawing.Point(482, 45);
            this.tbRegYear.Name = "tbRegYear";
            this.tbRegYear.Size = new System.Drawing.Size(100, 21);
            this.tbRegYear.TabIndex = 11;
            // 
            // tbShowRegFunds
            // 
            this.myValidator1.SetCriteria(this.tbShowRegFunds, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.Money));
            this.tbShowRegFunds.Location = new System.Drawing.Point(482, 84);
            this.tbShowRegFunds.Name = "tbShowRegFunds";
            this.tbShowRegFunds.Size = new System.Drawing.Size(100, 21);
            this.tbShowRegFunds.TabIndex = 12;
            // 
            // tbRegFunds
            // 
            this.myValidator1.SetCriteria(this.tbRegFunds, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.Money));
            this.tbRegFunds.Location = new System.Drawing.Point(99, 84);
            this.tbRegFunds.Name = "tbRegFunds";
            this.tbRegFunds.Size = new System.Drawing.Size(100, 21);
            this.tbRegFunds.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(588, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "年";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "万元";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(588, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "万元";
            // 
            // cbbEntIndustry
            // 
            this.myValidator1.SetCriteria(this.cbbEntIndustry, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.cbbEntIndustry.FormattingEnabled = true;
            this.cbbEntIndustry.Items.AddRange(new object[] {
            "无",
            "农业",
            "工业",
            "建筑业",
            "运输和邮电",
            "批发和零售业",
            "住宿、餐饮和旅游业",
            "金融业",
            "教育和科技",
            "卫生和社会服务",
            "文化和体育",
            "公共管理、社会保障和其它",
            "房地产业"});
            this.cbbEntIndustry.Location = new System.Drawing.Point(99, 120);
            this.cbbEntIndustry.Name = "cbbEntIndustry";
            this.cbbEntIndustry.Size = new System.Drawing.Size(281, 20);
            this.cbbEntIndustry.TabIndex = 17;
            // 
            // tbIntro
            // 
            this.myValidator1.SetCriteria(this.tbIntro, new MyLib.UI.MyValidationCriteria(false, ".{0,2000}"));
            this.tbIntro.Location = new System.Drawing.Point(99, 192);
            this.tbIntro.Multiline = true;
            this.tbIntro.Name = "tbIntro";
            this.tbIntro.Size = new System.Drawing.Size(664, 189);
            this.tbIntro.TabIndex = 18;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(607, 387);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(688, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbbOwnerNature
            // 
            this.myValidator1.SetCriteria(this.cbbOwnerNature, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.cbbOwnerNature.FormattingEnabled = true;
            this.cbbOwnerNature.Items.AddRange(new object[] {
            "无",
            "上市房企",
            "股份制",
            "国有",
            "民营"});
            this.cbbOwnerNature.Location = new System.Drawing.Point(482, 120);
            this.cbbOwnerNature.Name = "cbbOwnerNature";
            this.cbbOwnerNature.Size = new System.Drawing.Size(281, 20);
            this.cbbOwnerNature.TabIndex = 27;
            // 
            // cbbOwnerStrength
            // 
            this.myValidator1.SetCriteria(this.cbbOwnerStrength, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.cbbOwnerStrength.FormattingEnabled = true;
            this.cbbOwnerStrength.Items.AddRange(new object[] {
            "无",
            "全国50强施工企业",
            "全国百强施工企业",
            "区域龙头施工企业",
            "全国性施工企业",
            "区域性施工企业"});
            this.cbbOwnerStrength.Location = new System.Drawing.Point(99, 156);
            this.cbbOwnerStrength.Name = "cbbOwnerStrength";
            this.cbbOwnerStrength.Size = new System.Drawing.Size(281, 20);
            this.cbbOwnerStrength.TabIndex = 28;
            // 
            // cbbOwnerQuality
            // 
            this.myValidator1.SetCriteria(this.cbbOwnerQuality, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.cbbOwnerQuality.FormattingEnabled = true;
            this.cbbOwnerQuality.Items.AddRange(new object[] {
            "无",
            "上市公司",
            "非上市公司"});
            this.cbbOwnerQuality.Location = new System.Drawing.Point(482, 156);
            this.cbbOwnerQuality.Name = "cbbOwnerQuality";
            this.cbbOwnerQuality.Size = new System.Drawing.Size(281, 20);
            this.cbbOwnerQuality.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "企业性质:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "企业实力:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(417, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 24;
            this.label14.Text = "企业质量:";
            // 
            // PrjOwnerDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 417);
            this.Controls.Add(this.cbbOwnerQuality);
            this.Controls.Add(this.cbbOwnerStrength);
            this.Controls.Add(this.cbbOwnerNature);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbIntro);
            this.Controls.Add(this.cbbEntIndustry);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbRegFunds);
            this.Controls.Add(this.tbShowRegFunds);
            this.Controls.Add(this.tbRegYear);
            this.Controls.Add(this.dtpRegisterDate);
            this.Controls.Add(this.tbShowName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PrjOwnerDlg";
            this.ShowIcon = false;
            this.Text = "创建项目业主";
            this.Load += new System.EventHandler(this.PrjOwnerDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
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
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbShowName;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.TextBox tbRegYear;
        private System.Windows.Forms.TextBox tbShowRegFunds;
        private System.Windows.Forms.TextBox tbRegFunds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbEntIndustry;
        private System.Windows.Forms.TextBox tbIntro;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private MyLib.UI.MyValidator myValidator1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbOwnerNature;
        private System.Windows.Forms.ComboBox cbbOwnerStrength;
        private System.Windows.Forms.ComboBox cbbOwnerQuality;
    }
}