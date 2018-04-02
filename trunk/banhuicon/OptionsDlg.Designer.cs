namespace Banhuitong.Console {
    partial class OptionsDlg {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneric = new System.Windows.Forms.TabPage();
            this.tbBaseUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUpdateUrl = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneric.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneric);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageGeneric
            // 
            this.tabPageGeneric.Controls.Add(this.label2);
            this.tabPageGeneric.Controls.Add(this.tbUpdateUrl);
            this.tabPageGeneric.Controls.Add(this.tbBaseUri);
            this.tabPageGeneric.Controls.Add(this.label1);
            this.tabPageGeneric.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneric.Name = "tabPageGeneric";
            this.tabPageGeneric.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneric.Size = new System.Drawing.Size(583, 350);
            this.tabPageGeneric.TabIndex = 0;
            this.tabPageGeneric.Text = "常用";
            this.tabPageGeneric.UseVisualStyleBackColor = true;
            // 
            // tbBaseUri
            // 
            this.tbBaseUri.Location = new System.Drawing.Point(132, 24);
            this.tbBaseUri.Name = "tbBaseUri";
            this.tbBaseUri.Size = new System.Drawing.Size(445, 21);
            this.tbBaseUri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务地址(&S):";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(433, 394);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(519, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "更新地址(&U):";
            // 
            // tbUpdateUrl
            // 
            this.tbUpdateUrl.Location = new System.Drawing.Point(132, 63);
            this.tbUpdateUrl.Name = "tbUpdateUrl";
            this.tbUpdateUrl.Size = new System.Drawing.Size(445, 21);
            this.tbUpdateUrl.TabIndex = 1;
            // 
            // OptionsDlg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(615, 428);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OptionsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选项";
            this.Load += new System.EventHandler(this.OptionsDlg_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneric.ResumeLayout(false);
            this.tabPageGeneric.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneric;
        private System.Windows.Forms.TextBox tbBaseUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUpdateUrl;
    }
}