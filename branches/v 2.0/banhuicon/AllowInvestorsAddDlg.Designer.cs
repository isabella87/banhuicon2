namespace Banhuitong.Console {
    partial class AllowInvestorsAddDlg {
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
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录名(&L):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "手机号码(&M):";
            // 
            // tbLoginName
            // 
            this.myValidator1.SetCriteria(this.tbLoginName, new MyLib.UI.MyValidationCriteria(true, ".{0,40}"));
            this.tbLoginName.Location = new System.Drawing.Point(95, 16);
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(190, 21);
            this.tbLoginName.TabIndex = 2;
            // 
            // tbMobile
            // 
            this.myValidator1.SetCriteria(this.tbMobile, new MyLib.UI.MyValidationCriteria(true, MyLib.UI.MyValidationMode.Mobile));
            this.tbMobile.Location = new System.Drawing.Point(95, 44);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(190, 21);
            this.tbMobile.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(129, 71);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(210, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AllowInvestorsAddDlg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(296, 106);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbLoginName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AllowInvestorsAddDlg";
            this.ShowIcon = false;
            this.Text = "手工录入";
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private MyLib.UI.MyValidator myValidator1;
    }
}