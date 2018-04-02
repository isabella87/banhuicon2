namespace Banhuitong.Console {
    partial class CrmBindMgrAndCrmInvestorDlg {
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
            this.labName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAssignManager = new System.Windows.Forms.Button();
            this.btnAssignHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "投资人客户:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labName.Location = new System.Drawing.Point(93, 27);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 12);
            this.labName.TabIndex = 1;
            this.labName.Text = "被分配人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户经理:";
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(90, 52);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(282, 284);
            this.treeView1.TabIndex = 3;
            // 
            // btnAssignManager
            // 
            this.btnAssignManager.AutoSize = true;
            this.btnAssignManager.Location = new System.Drawing.Point(192, 342);
            this.btnAssignManager.Name = "btnAssignManager";
            this.btnAssignManager.Size = new System.Drawing.Size(87, 23);
            this.btnAssignManager.TabIndex = 4;
            this.btnAssignManager.Text = "分配客户经理";
            this.btnAssignManager.UseVisualStyleBackColor = true;
            this.btnAssignManager.Click += new System.EventHandler(this.btnAssignManager_Click);
            // 
            // btnAssignHistory
            // 
            this.btnAssignHistory.AutoSize = true;
            this.btnAssignHistory.Location = new System.Drawing.Point(285, 342);
            this.btnAssignHistory.Name = "btnAssignHistory";
            this.btnAssignHistory.Size = new System.Drawing.Size(87, 23);
            this.btnAssignHistory.TabIndex = 5;
            this.btnAssignHistory.Text = "查看分配历史";
            this.btnAssignHistory.UseVisualStyleBackColor = true;
            this.btnAssignHistory.Click += new System.EventHandler(this.btnAssignHistory_Click);
            // 
            // CrmBindMgrAndCrmInvestorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 377);
            this.Controls.Add(this.btnAssignHistory);
            this.Controls.Add(this.btnAssignManager);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label1);
            this.Name = "CrmBindMgrAndCrmInvestorDlg";
            this.ShowIcon = false;
            this.Text = "分配客户经理-{0}";
            this.Load += new System.EventHandler(this.CrmBindMgrAndCrmInvestorDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAssignManager;
        private System.Windows.Forms.Button btnAssignHistory;
    }
}