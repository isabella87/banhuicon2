namespace Banhuitong.Console {
    partial class SysRoleMgrDlg {
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
            this.ckbEnable = new System.Windows.Forms.CheckBox();
            this.tbRoleName = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "标题:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "说明:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "是否启用:";
            // 
            // ckbEnable
            // 
            this.ckbEnable.AutoSize = true;
            this.ckbEnable.Location = new System.Drawing.Point(75, 230);
            this.ckbEnable.Name = "ckbEnable";
            this.ckbEnable.Size = new System.Drawing.Size(15, 14);
            this.ckbEnable.TabIndex = 4;
            this.ckbEnable.UseVisualStyleBackColor = true;
            // 
            // tbRoleName
            // 
            this.myValidator1.SetCriteria(this.tbRoleName, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.RealName));
            this.tbRoleName.Location = new System.Drawing.Point(75, 18);
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(307, 21);
            this.tbRoleName.TabIndex = 5;
            // 
            // tbTitle
            // 
            this.myValidator1.SetCriteria(this.tbTitle, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.RealName));
            this.tbTitle.Location = new System.Drawing.Point(75, 41);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(307, 21);
            this.tbTitle.TabIndex = 5;
            // 
            // tbDescription
            // 
            this.myValidator1.SetCriteria(this.tbDescription, new MyLib.UI.MyValidationCriteria(false, ".{0,500}"));
            this.tbDescription.Location = new System.Drawing.Point(75, 64);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(307, 160);
            this.tbDescription.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(226, 254);
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
            this.btnCancel.Location = new System.Drawing.Point(307, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SysRoleMgrDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(394, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbRoleName);
            this.Controls.Add(this.ckbEnable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SysRoleMgrDlg";
            this.ShowIcon = false;
            this.Text = "创建/修改角色";
            this.Load += new System.EventHandler(this.SysRoleMgrDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbEnable;
        private System.Windows.Forms.TextBox tbRoleName;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private MyLib.UI.MyValidator myValidator1;
    }
}