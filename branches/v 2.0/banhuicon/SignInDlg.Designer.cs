namespace Banhuitong.Console {
    partial class SignInDlg {
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCaptchaCode = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picCaptchaCode = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名(&U):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "口令(&P):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "验证码(&O):";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(83, 6);
            this.txtUserName.MaxLength = 40;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(305, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassword.Location = new System.Drawing.Point(83, 33);
            this.txtPassword.MaxLength = 40;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(305, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCaptchaCode
            // 
            this.txtCaptchaCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCaptchaCode.Location = new System.Drawing.Point(197, 66);
            this.txtCaptchaCode.MaxLength = 5;
            this.txtCaptchaCode.Name = "txtCaptchaCode";
            this.txtCaptchaCode.Size = new System.Drawing.Size(191, 21);
            this.txtCaptchaCode.TabIndex = 2;
            this.txtCaptchaCode.TextChanged += new System.EventHandler(this.txtCaptchaCode_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(222, 106);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 30);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(308, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picCaptchaCode
            // 
            this.picCaptchaCode.Location = new System.Drawing.Point(83, 60);
            this.picCaptchaCode.Name = "picCaptchaCode";
            this.picCaptchaCode.Size = new System.Drawing.Size(108, 32);
            this.picCaptchaCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCaptchaCode.TabIndex = 6;
            this.picCaptchaCode.TabStop = false;
            this.toolTip1.SetToolTip(this.picCaptchaCode, "看不清？点击可以更换");
            this.picCaptchaCode.Click += new System.EventHandler(this.picCaptchaCode_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.IsBalloon = true;
            // 
            // SignInDlg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(404, 144);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.picCaptchaCode);
            this.Controls.Add(this.txtCaptchaCode);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.DlgSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCaptchaCode;
        private System.Windows.Forms.PictureBox picCaptchaCode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}