namespace Banhuitong.Console {
    partial class CreatePrjEntGuaranteePerDlg {
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbShowName = new System.Windows.Forms.TextBox();
            this.btnSelGuarantee = new System.Windows.Forms.Button();
            this.labRealName = new System.Windows.Forms.Label();
            this.cbbTypes = new System.Windows.Forms.ComboBox();
            this.cbbRange = new System.Windows.Forms.ComboBox();
            this.cbbLimit = new System.Windows.Forms.ComboBox();
            this.cbbRelationShip = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudLastYearIncome = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbGuaRightMan = new System.Windows.Forms.TextBox();
            this.tbGuaRightManNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudOrder = new System.Windows.Forms.NumericUpDown();
            this.cbbVisible = new System.Windows.Forms.ComboBox();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudLastYearIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "担保人:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "展示名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "担保方式:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "担保范围:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "担保期限:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "与借款人关系:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(398, 323);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(479, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbShowName
            // 
            this.tbShowName.Location = new System.Drawing.Point(146, 45);
            this.tbShowName.Name = "tbShowName";
            this.tbShowName.ReadOnly = true;
            this.tbShowName.Size = new System.Drawing.Size(408, 21);
            this.tbShowName.TabIndex = 8;
            // 
            // btnSelGuarantee
            // 
            this.btnSelGuarantee.Location = new System.Drawing.Point(146, 15);
            this.btnSelGuarantee.Name = "btnSelGuarantee";
            this.btnSelGuarantee.Size = new System.Drawing.Size(75, 23);
            this.btnSelGuarantee.TabIndex = 9;
            this.btnSelGuarantee.Text = "选择(&S)...";
            this.btnSelGuarantee.UseVisualStyleBackColor = true;
            this.btnSelGuarantee.Click += new System.EventHandler(this.btnSelGuarantee_Click);
            // 
            // labRealName
            // 
            this.labRealName.AutoSize = true;
            this.labRealName.Location = new System.Drawing.Point(227, 20);
            this.labRealName.Name = "labRealName";
            this.labRealName.Size = new System.Drawing.Size(29, 12);
            this.labRealName.TabIndex = 10;
            this.labRealName.Text = "(无)";
            // 
            // cbbTypes
            // 
            this.myValidator1.SetCriteria(this.cbbTypes, new MyLib.UI.MyValidationCriteria(false, ".{1,200}"));
            this.cbbTypes.FormattingEnabled = true;
            this.cbbTypes.Items.AddRange(new object[] {
            "一般保证",
            "最高额连带责任保证",
            "连带责任担保",
            "动产抵押",
            "不动产抵押",
            "浮动抵押",
            "动产质押",
            "权利质押",
            "让与担保",
            "买卖型担保",
            "最高额抵押",
            "最高额权利质押",
            "工程履约保险",
            "其他担保"});
            this.cbbTypes.Location = new System.Drawing.Point(146, 73);
            this.cbbTypes.Name = "cbbTypes";
            this.cbbTypes.Size = new System.Drawing.Size(156, 20);
            this.cbbTypes.TabIndex = 11;
            // 
            // cbbRange
            // 
            this.myValidator1.SetCriteria(this.cbbRange, new MyLib.UI.MyValidationCriteria(false, ".{1,200}"));
            this.cbbRange.FormattingEnabled = true;
            this.cbbRange.Items.AddRange(new object[] {
            "主债权及利息、违约金、损害赔偿金和实现债权的费用",
            "主债权及利息、违约金、损害赔偿金、保管担保财产和实现担保物权的费用"});
            this.cbbRange.Location = new System.Drawing.Point(146, 101);
            this.cbbRange.Name = "cbbRange";
            this.cbbRange.Size = new System.Drawing.Size(408, 20);
            this.cbbRange.TabIndex = 12;
            // 
            // cbbLimit
            // 
            this.myValidator1.SetCriteria(this.cbbLimit, new MyLib.UI.MyValidationCriteria(false, ".{1,200}"));
            this.cbbLimit.FormattingEnabled = true;
            this.cbbLimit.Items.AddRange(new object[] {
            "同主债权诉讼时效",
            "主债务履行期届满之日起二年"});
            this.cbbLimit.Location = new System.Drawing.Point(146, 129);
            this.cbbLimit.Name = "cbbLimit";
            this.cbbLimit.Size = new System.Drawing.Size(156, 20);
            this.cbbLimit.TabIndex = 13;
            // 
            // cbbRelationShip
            // 
            this.myValidator1.SetCriteria(this.cbbRelationShip, new MyLib.UI.MyValidationCriteria(false, ".{1,200}"));
            this.cbbRelationShip.FormattingEnabled = true;
            this.cbbRelationShip.Items.AddRange(new object[] {
            "亲戚",
            "朋友",
            "任职公司",
            "项目业主",
            "担保公司",
            "股东或高管",
            "第三方公司担保",
            "保险公司",
            "其他"});
            this.cbbRelationShip.Location = new System.Drawing.Point(146, 185);
            this.cbbRelationShip.Name = "cbbRelationShip";
            this.cbbRelationShip.Size = new System.Drawing.Size(156, 20);
            this.cbbRelationShip.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "上一年度主营业务收入:";
            // 
            // nudLastYearIncome
            // 
            this.nudLastYearIncome.DecimalPlaces = 2;
            this.nudLastYearIncome.Location = new System.Drawing.Point(146, 158);
            this.nudLastYearIncome.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudLastYearIncome.Name = "nudLastYearIncome";
            this.nudLastYearIncome.Size = new System.Drawing.Size(156, 21);
            this.nudLastYearIncome.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "万元";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "担保权人:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "担保权人社会信用代码:";
            // 
            // tbGuaRightMan
            // 
            this.myValidator1.SetCriteria(this.tbGuaRightMan, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbGuaRightMan.Location = new System.Drawing.Point(146, 213);
            this.tbGuaRightMan.Name = "tbGuaRightMan";
            this.tbGuaRightMan.Size = new System.Drawing.Size(408, 21);
            this.tbGuaRightMan.TabIndex = 20;
            // 
            // tbGuaRightManNo
            // 
            this.myValidator1.SetCriteria(this.tbGuaRightManNo, new MyLib.UI.MyValidationCriteria(false, ".{0,200}"));
            this.tbGuaRightManNo.Location = new System.Drawing.Point(146, 239);
            this.tbGuaRightManNo.Name = "tbGuaRightManNo";
            this.tbGuaRightManNo.Size = new System.Drawing.Size(408, 21);
            this.tbGuaRightManNo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "排列顺序:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "协议可见:";
            // 
            // nudOrder
            // 
            this.nudOrder.Location = new System.Drawing.Point(146, 266);
            this.nudOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrder.Name = "nudOrder";
            this.nudOrder.Size = new System.Drawing.Size(75, 21);
            this.nudOrder.TabIndex = 23;
            this.nudOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbVisible
            // 
            this.cbbVisible.FormattingEnabled = true;
            this.cbbVisible.Location = new System.Drawing.Point(146, 291);
            this.cbbVisible.Name = "cbbVisible";
            this.cbbVisible.Size = new System.Drawing.Size(75, 20);
            this.cbbVisible.TabIndex = 24;
            // 
            // CreatePrjEntGuaranteePerDlg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(566, 359);
            this.Controls.Add(this.cbbVisible);
            this.Controls.Add(this.nudOrder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbGuaRightManNo);
            this.Controls.Add(this.tbGuaRightMan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudLastYearIncome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbRelationShip);
            this.Controls.Add(this.cbbLimit);
            this.Controls.Add(this.cbbRange);
            this.Controls.Add(this.cbbTypes);
            this.Controls.Add(this.labRealName);
            this.Controls.Add(this.btnSelGuarantee);
            this.Controls.Add(this.tbShowName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreatePrjEntGuaranteePerDlg";
            this.ShowIcon = false;
            this.Text = "创建担保人";
            this.Load += new System.EventHandler(this.CreatePrjEntGuaranteeDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLastYearIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).EndInit();
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
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbShowName;
        private System.Windows.Forms.Button btnSelGuarantee;
        private System.Windows.Forms.Label labRealName;
        private System.Windows.Forms.ComboBox cbbTypes;
        private System.Windows.Forms.ComboBox cbbRange;
        private System.Windows.Forms.ComboBox cbbLimit;
        private System.Windows.Forms.ComboBox cbbRelationShip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudLastYearIncome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbGuaRightMan;
        private System.Windows.Forms.TextBox tbGuaRightManNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudOrder;
        private System.Windows.Forms.ComboBox cbbVisible;
        private MyLib.UI.MyValidator myValidator1;
    }
}