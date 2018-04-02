namespace Banhuitong.Console {
    partial class AccMessageDlg {
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
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbBrief = new System.Windows.Forms.TextBox();
            this.wbHtml = new System.Windows.Forms.WebBrowser();
            this.btnEditHtml = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.myValidator1 = new MyLib.UI.MyValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "收件人:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "标题:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "摘要:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "内容:";
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(65, 6);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(503, 21);
            this.tbTarget.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbTarget, "精确匹配：手机号、姓名、登录名\r\n目前只支持推送消息到个人账户\r\n匹配成功后会自动显示账户登录名和姓名");
            // 
            // btnMatch
            // 
            this.btnMatch.AutoSize = true;
            this.btnMatch.Location = new System.Drawing.Point(574, 6);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(58, 23);
            this.btnMatch.TabIndex = 5;
            this.btnMatch.Text = "匹配";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // tbTitle
            // 
            this.myValidator1.SetCriteria(this.tbTitle, new MyLib.UI.MyValidationCriteria(true, ".{2,200}"));
            this.tbTitle.Location = new System.Drawing.Point(65, 43);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(567, 21);
            this.tbTitle.TabIndex = 6;
            // 
            // tbBrief
            // 
            this.myValidator1.SetCriteria(this.tbBrief, new MyLib.UI.MyValidationCriteria(true, ".{1,1000}"));
            this.tbBrief.Location = new System.Drawing.Point(65, 80);
            this.tbBrief.Multiline = true;
            this.tbBrief.Name = "tbBrief";
            this.tbBrief.Size = new System.Drawing.Size(567, 73);
            this.tbBrief.TabIndex = 7;
            // 
            // wbHtml
            // 
            this.wbHtml.Location = new System.Drawing.Point(65, 165);
            this.wbHtml.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbHtml.Name = "wbHtml";
            this.wbHtml.Size = new System.Drawing.Size(567, 210);
            this.wbHtml.TabIndex = 8;
            // 
            // btnEditHtml
            // 
            this.btnEditHtml.Location = new System.Drawing.Point(2, 258);
            this.btnEditHtml.Name = "btnEditHtml";
            this.btnEditHtml.Size = new System.Drawing.Size(57, 21);
            this.btnEditHtml.TabIndex = 9;
            this.btnEditHtml.Text = "编辑";
            this.btnEditHtml.UseVisualStyleBackColor = true;
            this.btnEditHtml.Click += new System.EventHandler(this.btnEditHtml_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(476, 392);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "确认(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AccMessageDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 427);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnEditHtml);
            this.Controls.Add(this.wbHtml);
            this.Controls.Add(this.tbBrief);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.tbTarget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AccMessageDlg";
            this.ShowIcon = false;
            this.Text = "创建/查看消息";
            this.Load += new System.EventHandler(this.AccMessageDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbBrief;
        private System.Windows.Forms.WebBrowser wbHtml;
        private System.Windows.Forms.Button btnEditHtml;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private MyLib.UI.MyValidator myValidator1;
    }
}