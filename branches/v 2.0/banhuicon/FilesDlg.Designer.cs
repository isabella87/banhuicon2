namespace Banhuitong.Console {
    partial class FilesDlg {
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.btnDownLoad = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.btnUpload,
            this.btnDownLoad,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(605, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnUpload
            // 
            this.btnUpload.Image = global::Banhuitong.Console.Properties.Resources.AddImg;
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(69, 22);
            this.btnUpload.Text = "上传(&U)";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Enabled = false;
            this.btnDownLoad.Image = global::Banhuitong.Console.Properties.Resources.ExportImg;
            this.btnDownLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(69, 22);
            this.btnDownLoad.Text = "下载(&D)";
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Banhuitong.Console.Properties.Resources.SearchImg;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(52, 22);
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Image = global::Banhuitong.Console.Properties.Resources.DeleteImg;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 22);
            this.btnDel.Text = "删除(&X)";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.size,
            this.lastWriteTime});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 444);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "文件";
            this.name.Width = 249;
            // 
            // size
            // 
            this.size.Text = "大小";
            this.size.Width = 178;
            // 
            // lastWriteTime
            // 
            this.lastWriteTime.Text = "最新修改时间";
            this.lastWriteTime.Width = 174;
            // 
            // FilesDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 469);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FilesDlg";
            this.ShowIcon = false;
            this.Text = "文件-{0}/{1}";
            this.Load += new System.EventHandler(this.FilesDlg_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUpload;
        private System.Windows.Forms.ToolStripButton btnDownLoad;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader lastWriteTime;
        private System.Windows.Forms.ToolStripButton btnUpdate;
    }
}