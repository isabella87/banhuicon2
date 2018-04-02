namespace Banhuitong.Console {
    partial class CrmMgrDlg {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbSubDepartment = new System.Windows.Forms.CheckBox();
            this.cbbDepartmentType = new System.Windows.Forms.ComboBox();
            this.cbbPositionType = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属部门:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "职务:";
            // 
            // ckbSubDepartment
            // 
            this.ckbSubDepartment.AutoSize = true;
            this.ckbSubDepartment.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbSubDepartment.Checked = true;
            this.ckbSubDepartment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSubDepartment.Location = new System.Drawing.Point(12, 69);
            this.ckbSubDepartment.Name = "ckbSubDepartment";
            this.ckbSubDepartment.Size = new System.Drawing.Size(102, 16);
            this.ckbSubDepartment.TabIndex = 2;
            this.ckbSubDepartment.Text = "同步下属部门:";
            this.ckbSubDepartment.UseVisualStyleBackColor = true;
            // 
            // cbbDepartmentType
            // 
            this.cbbDepartmentType.FormattingEnabled = true;
            this.cbbDepartmentType.Location = new System.Drawing.Point(101, 14);
            this.cbbDepartmentType.Name = "cbbDepartmentType";
            this.cbbDepartmentType.Size = new System.Drawing.Size(162, 20);
            this.cbbDepartmentType.TabIndex = 3;
            // 
            // cbbPositionType
            // 
            this.cbbPositionType.FormattingEnabled = true;
            this.cbbPositionType.Location = new System.Drawing.Point(101, 40);
            this.cbbPositionType.Name = "cbbPositionType";
            this.cbbPositionType.Size = new System.Drawing.Size(162, 20);
            this.cbbPositionType.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(107, 86);
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
            this.btnCancel.Location = new System.Drawing.Point(188, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CrmMgrDlg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(280, 121);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbbPositionType);
            this.Controls.Add(this.cbbDepartmentType);
            this.Controls.Add(this.ckbSubDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CrmMgrDlg";
            this.ShowIcon = false;
            this.Text = "客户经理-{0}";
            this.Load += new System.EventHandler(this.CrmMgrDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbSubDepartment;
        private System.Windows.Forms.ComboBox cbbDepartmentType;
        private System.Windows.Forms.ComboBox cbbPositionType;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}