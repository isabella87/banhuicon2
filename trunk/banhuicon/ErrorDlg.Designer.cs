namespace Banhuitong.Console {
    partial class ErrorDlg {
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowMore = new System.Windows.Forms.Button();
            this.txtStackTrace = new System.Windows.Forms.TextBox();
            this.btnCopyStackTrace = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(83, 12);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(462, 160);
            this.txtMessage.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(253, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowMore
            // 
            this.btnShowMore.Location = new System.Drawing.Point(339, 178);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(100, 30);
            this.btnShowMore.TabIndex = 2;
            this.btnShowMore.Text = "更多(&M)...";
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Click += new System.EventHandler(this.btnShowMore_Click);
            // 
            // txtStackTrace
            // 
            this.txtStackTrace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStackTrace.Location = new System.Drawing.Point(12, 214);
            this.txtStackTrace.Multiline = true;
            this.txtStackTrace.Name = "txtStackTrace";
            this.txtStackTrace.ReadOnly = true;
            this.txtStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStackTrace.Size = new System.Drawing.Size(533, 280);
            this.txtStackTrace.TabIndex = 3;
            this.txtStackTrace.Visible = false;
            // 
            // btnCopyStackTrace
            // 
            this.btnCopyStackTrace.Enabled = false;
            this.btnCopyStackTrace.Location = new System.Drawing.Point(445, 178);
            this.btnCopyStackTrace.Name = "btnCopyStackTrace";
            this.btnCopyStackTrace.Size = new System.Drawing.Size(100, 30);
            this.btnCopyStackTrace.TabIndex = 4;
            this.btnCopyStackTrace.Text = "复制到剪贴板";
            this.btnCopyStackTrace.UseVisualStyleBackColor = true;
            this.btnCopyStackTrace.Click += new System.EventHandler(this.btnCopyStackTrace_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banhuitong.Console.Properties.Resources.ErrorImg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorDlg
            // 
            this.AcceptButton = this.btnShowMore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(557, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCopyStackTrace);
            this.Controls.Add(this.txtStackTrace);
            this.Controls.Add(this.btnShowMore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "应用程序错误";
            this.Load += new System.EventHandler(this.DlgError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowMore;
        private System.Windows.Forms.TextBox txtStackTrace;
        private System.Windows.Forms.Button btnCopyStackTrace;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}