namespace Banhuitong.Console {
    partial class BusinessTransferAddOneDlg {
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
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.tbRealName = new System.Windows.Forms.TextBox();
            this.nudAmt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录名(&L):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名或机构名称(&N):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "金额(&A):";
            // 
            // tbLoginName
            // 
            this.myValidator1.SetCriteria(this.tbLoginName, new MyLib.UI.MyValidationCriteria(true, ".{0,40}"));
            this.tbLoginName.Location = new System.Drawing.Point(122, 12);
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(310, 21);
            this.tbLoginName.TabIndex = 3;
            // 
            // tbRealName
            // 
            this.myValidator1.SetCriteria(this.tbRealName, new MyLib.UI.MyValidationCriteria(true, ".{0,200}"));
            this.tbRealName.Location = new System.Drawing.Point(122, 39);
            this.tbRealName.Name = "tbRealName";
            this.tbRealName.Size = new System.Drawing.Size(310, 21);
            this.tbRealName.TabIndex = 3;
            // 
            // nudAmt
            // 
            this.nudAmt.DecimalPlaces = 2;
            this.nudAmt.Location = new System.Drawing.Point(122, 66);
            this.nudAmt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudAmt.Name = "nudAmt";
            this.nudAmt.Size = new System.Drawing.Size(120, 21);
            this.nudAmt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "元";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(276, 89);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确认(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(357, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // BusinessTransferAddOneDlg
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(444, 124);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAmt);
            this.Controls.Add(this.tbRealName);
            this.Controls.Add(this.tbLoginName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BusinessTransferAddOneDlg";
            this.ShowIcon = false;
            this.Text = "手工录入-{0}";
            this.Load += new System.EventHandler(this.BusinessTransferAddOneDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.TextBox tbRealName;
        private System.Windows.Forms.NumericUpDown nudAmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private MyLib.UI.MyValidator myValidator1;
    }
}