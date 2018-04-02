namespace Banhuitong.Console {
    partial class CrmSpreadQrcodeDlg {
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
            this.tbRCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbRAddress = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLogo = new System.Windows.Forms.TextBox();
            this.btnAddLogo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegisterBaseAddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "推广代号(R):";
            // 
            // tbRCode
            // 
            this.tbRCode.Location = new System.Drawing.Point(95, 34);
            this.tbRCode.MaxLength = 200;
            this.tbRCode.Name = "tbRCode";
            this.tbRCode.Size = new System.Drawing.Size(437, 21);
            this.tbRCode.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tbRAddress);
            this.groupBox1.Location = new System.Drawing.Point(11, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 313);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "推广注册地址(&A):";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 260);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbRAddress
            // 
            this.tbRAddress.Location = new System.Drawing.Point(6, 20);
            this.tbRAddress.Name = "tbRAddress";
            this.tbRAddress.ReadOnly = true;
            this.tbRAddress.Size = new System.Drawing.Size(518, 21);
            this.tbRAddress.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(304, 415);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "生成(&C)";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(385, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(466, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消(&Q)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Logo(长和宽小于100像素):";
            // 
            // tbLogo
            // 
            this.tbLogo.Location = new System.Drawing.Point(161, 63);
            this.tbLogo.Name = "tbLogo";
            this.tbLogo.Size = new System.Drawing.Size(306, 21);
            this.tbLogo.TabIndex = 11;
            // 
            // btnAddLogo
            // 
            this.btnAddLogo.Location = new System.Drawing.Point(473, 61);
            this.btnAddLogo.Name = "btnAddLogo";
            this.btnAddLogo.Size = new System.Drawing.Size(59, 23);
            this.btnAddLogo.TabIndex = 12;
            this.btnAddLogo.Text = "添加";
            this.btnAddLogo.UseVisualStyleBackColor = true;
            this.btnAddLogo.Click += new System.EventHandler(this.btnAddLogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "注册地址:";
            // 
            // tbRegisterBaseAddress
            // 
            this.tbRegisterBaseAddress.Location = new System.Drawing.Point(95, 6);
            this.tbRegisterBaseAddress.Name = "tbRegisterBaseAddress";
            this.tbRegisterBaseAddress.Size = new System.Drawing.Size(437, 21);
            this.tbRegisterBaseAddress.TabIndex = 14;
            // 
            // CrmSpreadQrcodeDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(556, 463);
            this.Controls.Add(this.tbRegisterBaseAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddLogo);
            this.Controls.Add(this.tbLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbRCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CrmSpreadQrcodeDlg";
            this.ShowIcon = false;
            this.Text = "生成推广二维码";
            this.Load += new System.EventHandler(this.CrmSpreadQrcodeDlg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRAddress;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbLogo;
        private System.Windows.Forms.Button btnAddLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegisterBaseAddress;
    }
}