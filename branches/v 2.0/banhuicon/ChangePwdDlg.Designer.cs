namespace Banhuitong.Console {
    partial class ChangePwdDlg {
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword1 = new System.Windows.Forms.TextBox();
            this.tbNewPassword2 = new System.Windows.Forms.TextBox();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次输入新密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(22, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码最短8位，最长20位，只能包含数字、大写和小写英文字母。";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(243, 142);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确认(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(324, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbOldPassword
            // 
            this.myValidator1.SetCriteria(this.tbOldPassword, new MyLib.UI.MyValidationCriteria(false, "[a-zA-Z0-9]{6,20}"));
            this.tbOldPassword.Location = new System.Drawing.Point(112, 17);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(287, 21);
            this.tbOldPassword.TabIndex = 0;
            this.tbOldPassword.UseSystemPasswordChar = true;
            // 
            // tbNewPassword1
            // 
            this.myValidator1.SetCriteria(this.tbNewPassword1, new MyLib.UI.MyValidationCriteria(false, "[a-zA-Z0-9]{6,20}"));
            this.tbNewPassword1.Location = new System.Drawing.Point(112, 50);
            this.tbNewPassword1.Name = "tbNewPassword1";
            this.tbNewPassword1.Size = new System.Drawing.Size(287, 21);
            this.tbNewPassword1.TabIndex = 1;
            this.tbNewPassword1.UseSystemPasswordChar = true;
            // 
            // tbNewPassword2
            // 
            this.myValidator1.SetCriteria(this.tbNewPassword2, new MyLib.UI.MyValidationCriteria(false, "[a-zA-Z0-9]{6,20}"));
            this.tbNewPassword2.Location = new System.Drawing.Point(112, 83);
            this.tbNewPassword2.Name = "tbNewPassword2";
            this.tbNewPassword2.Size = new System.Drawing.Size(287, 21);
            this.tbNewPassword2.TabIndex = 2;
            this.tbNewPassword2.UseSystemPasswordChar = true;
            // 
            // ChangePwdDlg
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(411, 177);
            this.Controls.Add(this.tbNewPassword2);
            this.Controls.Add(this.tbNewPassword1);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangePwdDlg";
            this.ShowIcon = false;
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.TextBox tbNewPassword1;
        private System.Windows.Forms.TextBox tbNewPassword2;
        private MyLib.UI.MyValidator myValidator1;
    }
}