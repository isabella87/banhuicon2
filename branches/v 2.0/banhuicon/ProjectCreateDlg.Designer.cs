namespace Banhuitong.Console
{
    partial class ProjectCreateDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPrjType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "融资项目名称:";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(111, 55);
            this.tbItemName.MaxLength = 40;
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(230, 21);
            this.tbItemName.TabIndex = 2;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(85, 90);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 4;
            this.btnCommit.Text = "确认(&O)";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(234, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "项目类型:";
            // 
            // cbbPrjType
            // 
            this.cbbPrjType.FormattingEnabled = true;
            this.cbbPrjType.Location = new System.Drawing.Point(111, 23);
            this.cbbPrjType.Name = "cbbPrjType";
            this.cbbPrjType.Size = new System.Drawing.Size(121, 20);
            this.cbbPrjType.TabIndex = 7;
            // 
            // ProjectCreateDlg
            // 
            this.AcceptButton = this.btnCommit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(369, 125);
            this.Controls.Add(this.cbbPrjType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProjectCreateDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建";
            this.Load += new System.EventHandler(this.ProjectCreateDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPrjType;
    }
}