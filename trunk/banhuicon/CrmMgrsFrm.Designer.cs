namespace Banhuitong.Console
{
    partial class CrmMgrsFrm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddManager = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteManager = new System.Windows.Forms.ToolStripButton();
            this.btnAssUpper = new System.Windows.Forms.ToolStripButton();
            this.btnEditInfo = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbKey = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditRcode = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddManager,
            this.btnDeleteManager,
            this.btnAssUpper,
            this.btnEditInfo,
            this.btnEditRcode,
            this.btnUpdateInfo,
            this.toolStripLabel1,
            this.tbKey,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1030, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddManager
            // 
            this.btnAddManager.Image = global::Banhuitong.Console.Properties.Resources.AddImg;
            this.btnAddManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(52, 22);
            this.btnAddManager.Text = "添加";
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // btnDeleteManager
            // 
            this.btnDeleteManager.Enabled = false;
            this.btnDeleteManager.Image = global::Banhuitong.Console.Properties.Resources.DeleteImg;
            this.btnDeleteManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteManager.Name = "btnDeleteManager";
            this.btnDeleteManager.Size = new System.Drawing.Size(52, 22);
            this.btnDeleteManager.Text = "删除";
            this.btnDeleteManager.Click += new System.EventHandler(this.btnDeleteManager_Click);
            // 
            // btnAssUpper
            // 
            this.btnAssUpper.Enabled = false;
            this.btnAssUpper.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnAssUpper.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAssUpper.Name = "btnAssUpper";
            this.btnAssUpper.Size = new System.Drawing.Size(76, 22);
            this.btnAssUpper.Text = "指定上级";
            this.btnAssUpper.Click += new System.EventHandler(this.btnAssUpper_Click);
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Enabled = false;
            this.btnEditInfo.Image = global::Banhuitong.Console.Properties.Resources.EditImg;
            this.btnEditInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(52, 22);
            this.btnEditInfo.Text = "编辑";
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Image = global::Banhuitong.Console.Properties.Resources.ResetImg;
            this.btnUpdateInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(52, 22);
            this.btnUpdateInfo.Text = "刷新";
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel1.Text = "登录名(&L):";
            // 
            // tbKey
            // 
            this.tbKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(200, 25);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 22);
            this.btnSearch.Text = "快速定位";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(157, 480);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(157, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 480);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.department,
            this.position,
            this.enabled,
            this.rCode});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(160, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(870, 480);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // department
            // 
            this.department.Text = "部门";
            this.department.Width = 126;
            // 
            // position
            // 
            this.position.Text = "职务";
            this.position.Width = 113;
            // 
            // enabled
            // 
            this.enabled.Text = "是否启用";
            this.enabled.Width = 98;
            // 
            // rCode
            // 
            this.rCode.Text = "编号";
            this.rCode.Width = 131;
            // 
            // btnEditRcode
            // 
            this.btnEditRcode.Enabled = false;
            this.btnEditRcode.Image = global::Banhuitong.Console.Properties.Resources.Flag1Img;
            this.btnEditRcode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditRcode.Name = "btnEditRcode";
            this.btnEditRcode.Size = new System.Drawing.Size(76, 22);
            this.btnEditRcode.Text = "修改编号";
            this.btnEditRcode.Click += new System.EventHandler(this.btnEditRcode_Click);
            // 
            // CrmMgrsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 505);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CrmMgrsFrm";
            this.ShowIcon = false;
            this.Text = "客户经理管理";
            this.Load += new System.EventHandler(this.CrmMgrsFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddManager;
        private System.Windows.Forms.ToolStripButton btnDeleteManager;
        private System.Windows.Forms.ToolStripButton btnAssUpper;
        private System.Windows.Forms.ToolStripButton btnEditInfo;
        private System.Windows.Forms.ToolStripButton btnUpdateInfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbKey;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader department;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.ColumnHeader enabled;
        private System.Windows.Forms.ColumnHeader rCode;
        private System.Windows.Forms.ToolStripButton btnEditRcode;
    }
}