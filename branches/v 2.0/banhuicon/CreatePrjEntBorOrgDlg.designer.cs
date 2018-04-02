﻿namespace Banhuitong.Console {
    partial class CreatePrjEntBorOrgDlg {
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
            this.tbBorName = new System.Windows.Forms.TextBox();
            this.tbLoanPurpose = new System.Windows.Forms.TextBox();
            this.tbSituation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelBorOrg = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            this.tbOtherOverDueNum = new System.Windows.Forms.TextBox();
            this.tbOverDueNum = new System.Windows.Forms.TextBox();
            this.cbbVisible = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nudOrder = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudOtherOverDueAmt = new System.Windows.Forms.NumericUpDown();
            this.nudOverDueAmt = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudOtherLoanBal = new System.Windows.Forms.NumericUpDown();
            this.nudLoanBal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOtherOverDueAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverDueAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOtherLoanBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanBal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "借款机构:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "借款用途:";
            // 
            // tbBorName
            // 
            this.tbBorName.Location = new System.Drawing.Point(116, 15);
            this.tbBorName.Name = "tbBorName";
            this.tbBorName.Size = new System.Drawing.Size(346, 21);
            this.tbBorName.TabIndex = 4;
            // 
            // tbLoanPurpose
            // 
            this.myValidator1.SetCriteria(this.tbLoanPurpose, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbLoanPurpose.Location = new System.Drawing.Point(116, 50);
            this.tbLoanPurpose.Name = "tbLoanPurpose";
            this.tbLoanPurpose.Size = new System.Drawing.Size(424, 21);
            this.tbLoanPurpose.TabIndex = 5;
            // 
            // tbSituation
            // 
            this.tbSituation.Location = new System.Drawing.Point(116, 212);
            this.tbSituation.Multiline = true;
            this.tbSituation.Name = "tbSituation";
            this.tbSituation.Size = new System.Drawing.Size(427, 211);
            this.tbSituation.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "借款概况:";
            // 
            // btnSelBorOrg
            // 
            this.btnSelBorOrg.Location = new System.Drawing.Point(468, 15);
            this.btnSelBorOrg.Name = "btnSelBorOrg";
            this.btnSelBorOrg.Size = new System.Drawing.Size(75, 23);
            this.btnSelBorOrg.TabIndex = 12;
            this.btnSelBorOrg.Text = "选择(&S)...";
            this.btnSelBorOrg.UseVisualStyleBackColor = true;
            this.btnSelBorOrg.Click += new System.EventHandler(this.btnSelBorOrg_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(387, 429);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(468, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbOtherOverDueNum
            // 
            this.myValidator1.SetCriteria(this.tbOtherOverDueNum, new MyLib.UI.MyValidationCriteria(false, "\\d{0,4}"));
            this.tbOtherOverDueNum.Location = new System.Drawing.Point(401, 115);
            this.tbOtherOverDueNum.Name = "tbOtherOverDueNum";
            this.tbOtherOverDueNum.Size = new System.Drawing.Size(107, 21);
            this.tbOtherOverDueNum.TabIndex = 43;
            // 
            // tbOverDueNum
            // 
            this.myValidator1.SetCriteria(this.tbOverDueNum, new MyLib.UI.MyValidationCriteria(false, "\\d{0,4}"));
            this.tbOverDueNum.Location = new System.Drawing.Point(116, 115);
            this.tbOverDueNum.Name = "tbOverDueNum";
            this.tbOverDueNum.Size = new System.Drawing.Size(107, 21);
            this.tbOverDueNum.TabIndex = 42;
            // 
            // cbbVisible
            // 
            this.cbbVisible.FormattingEnabled = true;
            this.cbbVisible.Location = new System.Drawing.Point(401, 175);
            this.cbbVisible.Name = "cbbVisible";
            this.cbbVisible.Size = new System.Drawing.Size(107, 20);
            this.cbbVisible.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(336, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 46;
            this.label17.Text = "协议可见:";
            // 
            // nudOrder
            // 
            this.nudOrder.Location = new System.Drawing.Point(116, 173);
            this.nudOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrder.Name = "nudOrder";
            this.nudOrder.Size = new System.Drawing.Size(107, 21);
            this.nudOrder.TabIndex = 45;
            this.nudOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 44;
            this.label16.Text = "排列顺序:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(514, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 41;
            this.label15.Text = "万元";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 40;
            this.label11.Text = "万元";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(514, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "次";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 39;
            this.label10.Text = "次";
            // 
            // nudOtherOverDueAmt
            // 
            this.nudOtherOverDueAmt.DecimalPlaces = 2;
            this.nudOtherOverDueAmt.Location = new System.Drawing.Point(401, 142);
            this.nudOtherOverDueAmt.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudOtherOverDueAmt.Name = "nudOtherOverDueAmt";
            this.nudOtherOverDueAmt.Size = new System.Drawing.Size(107, 21);
            this.nudOtherOverDueAmt.TabIndex = 37;
            // 
            // nudOverDueAmt
            // 
            this.nudOverDueAmt.DecimalPlaces = 2;
            this.nudOverDueAmt.Location = new System.Drawing.Point(116, 142);
            this.nudOverDueAmt.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudOverDueAmt.Name = "nudOverDueAmt";
            this.nudOverDueAmt.Size = new System.Drawing.Size(107, 21);
            this.nudOverDueAmt.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 12);
            this.label14.TabIndex = 35;
            this.label14.Text = "其它平台逾期金额:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "本平台逾期金额:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "其它平台逾期次数:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "本平台逾期次数:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "万元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "万元";
            // 
            // nudOtherLoanBal
            // 
            this.nudOtherLoanBal.DecimalPlaces = 2;
            this.nudOtherLoanBal.Location = new System.Drawing.Point(401, 86);
            this.nudOtherLoanBal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudOtherLoanBal.Name = "nudOtherLoanBal";
            this.nudOtherLoanBal.Size = new System.Drawing.Size(107, 21);
            this.nudOtherLoanBal.TabIndex = 29;
            // 
            // nudLoanBal
            // 
            this.nudLoanBal.DecimalPlaces = 2;
            this.nudLoanBal.Location = new System.Drawing.Point(116, 86);
            this.nudLoanBal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudLoanBal.Name = "nudLoanBal";
            this.nudLoanBal.Size = new System.Drawing.Size(107, 21);
            this.nudLoanBal.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "其它平台借款余额:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "本平台借款余额:";
            // 
            // CreatePrjEntBorOrgDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(552, 464);
            this.Controls.Add(this.cbbVisible);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.nudOrder);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbOtherOverDueNum);
            this.Controls.Add(this.tbOverDueNum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudOtherOverDueAmt);
            this.Controls.Add(this.nudOverDueAmt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudOtherLoanBal);
            this.Controls.Add(this.nudLoanBal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSelBorOrg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSituation);
            this.Controls.Add(this.tbLoanPurpose);
            this.Controls.Add(this.tbBorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreatePrjEntBorOrgDlg";
            this.ShowIcon = false;
            this.Text = "创建借款机构";
            this.Load += new System.EventHandler(this.CreatePrjEntBorOrg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOtherOverDueAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverDueAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOtherLoanBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanBal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBorName;
        private System.Windows.Forms.TextBox tbLoanPurpose;
        private System.Windows.Forms.TextBox tbSituation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelBorOrg;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private MyLib.UI.MyValidator myValidator1;
        private System.Windows.Forms.ComboBox cbbVisible;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudOrder;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbOtherOverDueNum;
        private System.Windows.Forms.TextBox tbOverDueNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudOtherOverDueAmt;
        private System.Windows.Forms.NumericUpDown nudOverDueAmt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudOtherLoanBal;
        private System.Windows.Forms.NumericUpDown nudLoanBal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}