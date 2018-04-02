namespace Banhuitong.Console {
    partial class CrmAddMgrDlg {
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPName = new System.Windows.Forms.TextBox();
            this.tbManager = new System.Windows.Forms.TextBox();
            this.tbRCode = new System.Windows.Forms.TextBox();
            this.cbbPositionType = new System.Windows.Forms.ComboBox();
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上级经理:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户经理:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "职务:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "编号:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(188, 135);
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
            this.btnCancel.Location = new System.Drawing.Point(269, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbPName
            // 
            this.myValidator1.SetCriteria(this.tbPName, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.RealName));
            this.tbPName.Location = new System.Drawing.Point(77, 15);
            this.tbPName.Name = "tbPName";
            this.tbPName.Size = new System.Drawing.Size(267, 21);
            this.tbPName.TabIndex = 5;
            // 
            // tbManager
            // 
            this.myValidator1.SetCriteria(this.tbManager, new MyLib.UI.MyValidationCriteria(false, MyLib.UI.MyValidationMode.RealName));
            this.tbManager.Location = new System.Drawing.Point(77, 46);
            this.tbManager.Name = "tbManager";
            this.tbManager.Size = new System.Drawing.Size(267, 21);
            this.tbManager.TabIndex = 5;
            // 
            // tbRCode
            // 
            this.tbRCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.myValidator1.SetCriteria(this.tbRCode, new MyLib.UI.MyValidationCriteria(false, ".{1,40}"));
            this.tbRCode.Location = new System.Drawing.Point(77, 108);
            this.tbRCode.MaxLength = 11;
            this.tbRCode.Name = "tbRCode";
            this.tbRCode.Size = new System.Drawing.Size(267, 21);
            this.tbRCode.TabIndex = 5;
            // 
            // cbbPositionType
            // 
            this.cbbPositionType.FormattingEnabled = true;
            this.cbbPositionType.Location = new System.Drawing.Point(77, 77);
            this.cbbPositionType.Name = "cbbPositionType";
            this.cbbPositionType.Size = new System.Drawing.Size(267, 20);
            this.cbbPositionType.TabIndex = 6;
            // 
            // CrmAddMgrDlg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(356, 164);
            this.Controls.Add(this.cbbPositionType);
            this.Controls.Add(this.tbRCode);
            this.Controls.Add(this.tbManager);
            this.Controls.Add(this.tbPName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CrmAddMgrDlg";
            this.Text = "添加客户经理";
            this.Load += new System.EventHandler(this.CrmAddMgrDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPName;
        private System.Windows.Forms.TextBox tbManager;
        private System.Windows.Forms.TextBox tbRCode;
        private System.Windows.Forms.ComboBox cbbPositionType;
        private MyLib.UI.MyValidator myValidator1;
    }
}