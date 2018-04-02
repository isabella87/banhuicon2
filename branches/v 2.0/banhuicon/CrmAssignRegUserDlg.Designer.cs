namespace Banhuitong.Console {
    partial class CrmAssignRegUserDlg {
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbUName = new System.Windows.Forms.TextBox();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "注册客户姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "注册客户手机号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户经理登录名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "客户经理部门:";
            // 
            // tbUserName
            // 
            this.myValidator1.SetCriteria(this.tbUserName, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.RealName));
            this.tbUserName.Location = new System.Drawing.Point(112, 16);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(182, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // tbMobile
            // 
            this.myValidator1.SetCriteria(this.tbMobile, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.Mobile));
            this.tbMobile.Location = new System.Drawing.Point(112, 44);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(182, 21);
            this.tbMobile.TabIndex = 1;
            // 
            // tbUName
            // 
            this.myValidator1.SetCriteria(this.tbUName, new MyLib.UI.MyValidationCriteria(false, ".{2,40}"));
            this.tbUName.Location = new System.Drawing.Point(112, 72);
            this.tbUName.Name = "tbUName";
            this.tbUName.Size = new System.Drawing.Size(182, 21);
            this.tbUName.TabIndex = 1;
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(112, 100);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(121, 20);
            this.cbbDepartment.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(138, 140);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(219, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CrmAssignRegUserDlg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(307, 188);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbbDepartment);
            this.Controls.Add(this.tbUName);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CrmAssignRegUserDlg";
            this.ShowIcon = false;
            this.Text = "分配注册客户";
            this.Load += new System.EventHandler(this.AssignRegUserDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbUName;
        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private MyLib.UI.MyValidator myValidator1;
    }
}