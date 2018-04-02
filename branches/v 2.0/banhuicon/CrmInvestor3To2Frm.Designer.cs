namespace Banhuitong.Console
{
    partial class CrmInvestor3To2Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myGridViewBinding1 = new MyLib.UI.MyGridViewBinding();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1093, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Banhuitong.Console.Properties.Resources.SearchImg;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 22);
            this.btnSearch.Text = "搜索(&S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 500);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.VirtualMode = true;
            // 
            // myGridViewBinding1
            // 
            this.myGridViewBinding1.Columns.AddRange(new MyLib.UI.MyGridColumn[] {
            new MyLib.UI.MyGridColumn("auId", "ID", MyLib.UI.MyGridColumnType.Number, 50, false, true),
            new MyLib.UI.MyGridColumn("loginName", "用户名", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("realName", "姓名", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("mobile", "手机", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("jxStatus", "状态", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("uName", "客户经理", MyLib.UI.MyGridColumnType.Text, 120, false, true),
            new MyLib.UI.MyGridColumn("assignTime", "分配时间", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("firstInvestDate", "首次投资日期", MyLib.UI.MyGridColumnType.DateTime, 120, false, true),
            new MyLib.UI.MyGridColumn("sumInvestAmt", "累计投资总额", MyLib.UI.MyGridColumnType.Money, 120, false, true)});
            this.myGridViewBinding1.DataTable = null;
            this.myGridViewBinding1.View = this.dataGridView1;
            this.myGridViewBinding1.GridDataTableDisplayValueNeeded += new MyLib.UI.GridDataTableDisplayValueNeededEventHandler(this.myGridViewBinding1_GridDataTableDisplayValueNeeded);
            // 
            // CrmInvestor3To2Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CrmInvestor3To2Frm";
            this.ShowIcon = false;
            this.Text = "客户管理-三部转二部";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridViewBinding1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyLib.UI.MyGridViewBinding myGridViewBinding1;
    }
}