namespace Banhuitong.Console {
    partial class PreviewBonusDlg {
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.date,
            this.money});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 347);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // type
            // 
            this.type.Text = "类型";
            this.type.Width = 150;
            // 
            // date
            // 
            this.date.Text = "日期";
            this.date.Width = 120;
            // 
            // money
            // 
            this.money.Text = "金额";
            this.money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.money.Width = 114;
            // 
            // PreviewBonusDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 347);
            this.Controls.Add(this.listView1);
            this.Name = "PreviewBonusDlg";
            this.ShowIcon = false;
            this.Text = "预览还款计划";
            this.Load += new System.EventHandler(this.PreviewBonusDlg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader money;

    }
}