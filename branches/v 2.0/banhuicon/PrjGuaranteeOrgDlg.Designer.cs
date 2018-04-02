namespace Banhuitong.Console {
    partial class PrjGuaranteeOrgDlg {
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
            this.tbRegFunds = new System.Windows.Forms.TextBox();
            this.tbRegYear = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.tbRanking = new System.Windows.Forms.TextBox();
            this.tbLegalIdCard = new System.Windows.Forms.TextBox();
            this.tbLinkMan = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbLegalPersonName = new System.Windows.Forms.TextBox();
            this.tbLegalPersonShowName = new System.Windows.Forms.TextBox();
            this.tbRegAddress = new System.Windows.Forms.TextBox();
            this.tbGetPrize = new System.Windows.Forms.TextBox();
            this.tbOrgWebSite = new System.Windows.Forms.TextBox();
            this.tbIntro = new System.Windows.Forms.TextBox();
            this.tbShowRegAddress = new System.Windows.Forms.TextBox();
            this.tbQualification = new System.Windows.Forms.TextBox();
            this.tbSocialCreditCode = new System.Windows.Forms.TextBox();
            this.tbShowSocialCreditCode = new System.Windows.Forms.TextBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.myValidator1.SetCriteria(this.tbName, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.RealName));
            this.tbName.Location = new System.Drawing.Point(119, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(240, 21);
            this.tbName.TabIndex = 13;
            // 
            // tbShowName
            // 
            this.myValidator1.SetCriteria(this.tbShowName, new MyLib.UI.MyValidationCriteria(true, "[\\w*]{2,40}"));
            this.tbShowName.Location = new System.Drawing.Point(502, 6);
            this.tbShowName.Name = "tbShowName";
            this.tbShowName.Size = new System.Drawing.Size(240, 21);
            this.tbShowName.TabIndex = 14;
            // 
            // tbRegFunds
            // 
            this.myValidator1.SetCriteria(this.tbRegFunds, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.Money));
            this.tbRegFunds.Location = new System.Drawing.Point(119, 62);
            this.tbRegFunds.Name = "tbRegFunds";
            this.tbRegFunds.Size = new System.Drawing.Size(121, 21);
            this.tbRegFunds.TabIndex = 16;
            // 
            // tbRegYear
            // 
            this.myValidator1.SetCriteria(this.tbRegYear, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.Year));
            this.tbRegYear.Location = new System.Drawing.Point(502, 33);
            this.tbRegYear.Name = "tbRegYear";
            this.tbRegYear.Size = new System.Drawing.Size(121, 21);
            this.tbRegYear.TabIndex = 17;
            // 
            // tbPostCode
            // 
            this.myValidator1.SetCriteria(this.tbPostCode, new MyLib.UI.MyValidationCriteria(false, "\\d{0,6}"));
            this.tbPostCode.Location = new System.Drawing.Point(119, 118);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(121, 21);
            this.tbPostCode.TabIndex = 19;
            // 
            // tbRanking
            // 
            this.myValidator1.SetCriteria(this.tbRanking, new MyLib.UI.MyValidationCriteria(false, "\\d{0,3}"));
            this.tbRanking.Location = new System.Drawing.Point(142, 231);
            this.tbRanking.Name = "tbRanking";
            this.tbRanking.Size = new System.Drawing.Size(55, 21);
            this.tbRanking.TabIndex = 22;
            // 
            // tbLegalIdCard
            // 
            this.myValidator1.SetCriteria(this.tbLegalIdCard, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.IdCard));
            this.tbLegalIdCard.Location = new System.Drawing.Point(119, 146);
            this.tbLegalIdCard.Name = "tbLegalIdCard";
            this.tbLegalIdCard.Size = new System.Drawing.Size(240, 21);
            this.tbLegalIdCard.TabIndex = 35;
            // 
            // tbLinkMan
            // 
            this.myValidator1.SetCriteria(this.tbLinkMan, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.RealName));
            this.tbLinkMan.Location = new System.Drawing.Point(119, 202);
            this.tbLinkMan.Name = "tbLinkMan";
            this.tbLinkMan.Size = new System.Drawing.Size(240, 21);
            this.tbLinkMan.TabIndex = 20;
            // 
            // tbMobile
            // 
            this.myValidator1.SetCriteria(this.tbMobile, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.Mobile));
            this.tbMobile.Location = new System.Drawing.Point(502, 202);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(240, 21);
            this.tbMobile.TabIndex = 21;
            // 
            // tbLegalPersonName
            // 
            this.myValidator1.SetCriteria(this.tbLegalPersonName, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.RealName));
            this.tbLegalPersonName.Location = new System.Drawing.Point(119, 174);
            this.tbLegalPersonName.Name = "tbLegalPersonName";
            this.tbLegalPersonName.Size = new System.Drawing.Size(240, 21);
            this.tbLegalPersonName.TabIndex = 38;
            // 
            // tbLegalPersonShowName
            // 
            this.myValidator1.SetCriteria(this.tbLegalPersonShowName, new MyLib.UI.MyValidationCriteria(true, "[\\w*]{2,40}"));
            this.tbLegalPersonShowName.Location = new System.Drawing.Point(502, 174);
            this.tbLegalPersonShowName.Name = "tbLegalPersonShowName";
            this.tbLegalPersonShowName.Size = new System.Drawing.Size(240, 21);
            this.tbLegalPersonShowName.TabIndex = 39;
            // 
            // tbRegAddress
            // 
            this.myValidator1.SetCriteria(this.tbRegAddress, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbRegAddress.Location = new System.Drawing.Point(119, 90);
            this.tbRegAddress.Name = "tbRegAddress";
            this.tbRegAddress.Size = new System.Drawing.Size(240, 21);
            this.tbRegAddress.TabIndex = 18;
            // 
            // tbGetPrize
            // 
            this.myValidator1.SetCriteria(this.tbGetPrize, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbGetPrize.Location = new System.Drawing.Point(119, 286);
            this.tbGetPrize.Name = "tbGetPrize";
            this.tbGetPrize.Size = new System.Drawing.Size(623, 21);
            this.tbGetPrize.TabIndex = 23;
            // 
            // tbOrgWebSite
            // 
            this.myValidator1.SetCriteria(this.tbOrgWebSite, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbOrgWebSite.Location = new System.Drawing.Point(119, 313);
            this.tbOrgWebSite.Name = "tbOrgWebSite";
            this.tbOrgWebSite.Size = new System.Drawing.Size(623, 21);
            this.tbOrgWebSite.TabIndex = 24;
            // 
            // tbIntro
            // 
            this.myValidator1.SetCriteria(this.tbIntro, new MyLib.UI.MyValidationCriteria(false, ".{0,1000}"));
            this.tbIntro.Location = new System.Drawing.Point(119, 340);
            this.tbIntro.Multiline = true;
            this.tbIntro.Name = "tbIntro";
            this.tbIntro.Size = new System.Drawing.Size(623, 188);
            this.tbIntro.TabIndex = 25;
            // 
            // tbShowRegAddress
            // 
            this.myValidator1.SetCriteria(this.tbShowRegAddress, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbShowRegAddress.Location = new System.Drawing.Point(502, 88);
            this.tbShowRegAddress.Name = "tbShowRegAddress";
            this.tbShowRegAddress.Size = new System.Drawing.Size(240, 21);
            this.tbShowRegAddress.TabIndex = 33;
            // 
            // tbQualification
            // 
            this.myValidator1.SetCriteria(this.tbQualification, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbQualification.Location = new System.Drawing.Point(502, 231);
            this.tbQualification.Name = "tbQualification";
            this.tbQualification.Size = new System.Drawing.Size(240, 21);
            this.tbQualification.TabIndex = 21;
            // 
            // tbSocialCreditCode
            // 
            this.myValidator1.SetCriteria(this.tbSocialCreditCode, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbSocialCreditCode.Location = new System.Drawing.Point(119, 258);
            this.tbSocialCreditCode.Name = "tbSocialCreditCode";
            this.tbSocialCreditCode.Size = new System.Drawing.Size(240, 21);
            this.tbSocialCreditCode.TabIndex = 20;
            // 
            // tbShowSocialCreditCode
            // 
            this.myValidator1.SetCriteria(this.tbShowSocialCreditCode, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbShowSocialCreditCode.Location = new System.Drawing.Point(502, 258);
            this.tbShowSocialCreditCode.Name = "tbShowSocialCreditCode";
            this.tbShowSocialCreditCode.Size = new System.Drawing.Size(240, 21);
            this.tbShowSocialCreditCode.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "企业名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "注册时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "注册资金:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "注册地址:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "联系人:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "行业地位:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "获得奖项:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "公司官网:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "企业介绍:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "展示名称:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "注册年限:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "邮编:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "联系电话:";
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Location = new System.Drawing.Point(119, 34);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(120, 21);
            this.dtpRegisterDate.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(629, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "年";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(246, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "万元";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(119, 234);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 28;
            this.label16.Text = "第";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(203, 234);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 29;
            this.label17.Text = "位";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(667, 534);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(586, 534);
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
            this.label18.Location = new System.Drawing.Point(413, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 12);
            this.label18.TabIndex = 32;
            this.label18.Text = "显示注册地址:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 12);
            this.label19.TabIndex = 34;
            this.label19.Text = "法人身份证号:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(54, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 36;
            this.label20.Text = "法人姓名:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(425, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 12);
            this.label21.TabIndex = 37;
            this.label21.Text = "法人展示名:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(437, 233);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 40;
            this.label22.Text = "行业资质:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 261);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 12);
            this.label23.TabIndex = 41;
            this.label23.Text = "统一社会信用代码:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(365, 261);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 12);
            this.label24.TabIndex = 42;
            this.label24.Text = "展示统一社会信用代码:";
            // 
            // PrjGuaranteeOrgDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(755, 561);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tbLegalPersonShowName);
            this.Controls.Add(this.tbLegalPersonName);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbLegalIdCard);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbShowRegAddress);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbIntro);
            this.Controls.Add(this.tbOrgWebSite);
            this.Controls.Add(this.tbGetPrize);
            this.Controls.Add(this.tbRanking);
            this.Controls.Add(this.tbShowSocialCreditCode);
            this.Controls.Add(this.tbQualification);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbSocialCreditCode);
            this.Controls.Add(this.tbLinkMan);
            this.Controls.Add(this.tbPostCode);
            this.Controls.Add(this.tbRegAddress);
            this.Controls.Add(this.tbRegYear);
            this.Controls.Add(this.tbRegFunds);
            this.Controls.Add(this.dtpRegisterDate);
            this.Controls.Add(this.tbShowName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
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
            this.Name = "PrjGuaranteeOrgDlg";
            this.ShowIcon = false;
            this.Text = "创建担保机构";
            this.Load += new System.EventHandler(this.PrjGuaranteeDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLib.UI.MyValidator myValidator1;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbShowName;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.TextBox tbRegFunds;
        private System.Windows.Forms.TextBox tbRegYear;
        private System.Windows.Forms.TextBox tbRegAddress;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.TextBox tbLinkMan;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbRanking;
        private System.Windows.Forms.TextBox tbGetPrize;
        private System.Windows.Forms.TextBox tbOrgWebSite;
        private System.Windows.Forms.TextBox tbIntro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbShowRegAddress;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbLegalIdCard;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbLegalPersonName;
        private System.Windows.Forms.TextBox tbLegalPersonShowName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbQualification;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbSocialCreditCode;
        private System.Windows.Forms.TextBox tbShowSocialCreditCode;
    }
}