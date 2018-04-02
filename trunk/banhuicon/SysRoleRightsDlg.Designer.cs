using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Banhuitong.Console {
    using CheckBoxProperty = Dictionary<string, string>;
    using GroupBoxProperty = Dictionary<string, Dictionary<string, string>>;

    partial class SysRoleRightsDlg {
        private static readonly string SELECTALLSIGN = "99999999";
        private TableLayoutPanel tableLayoutPanel;
        private Label title;
        private TabControl tabControl;
        private Panel panel1;
        private Button btnOk;
        private Button btnCancel;

        private void InitializeComponent() {
            tableLayoutPanel = new TableLayoutPanel();
            title = new Label();
            tabControl = new TabControl();
            panel1 = new Panel();
            btnOk = new Button();
            btnCancel = new Button();

            this.Controls.Add(tableLayoutPanel);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ShowIcon = false;
            this.Text = "分配权限-{0}";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Controls.Add(title, 0, 0);
            tableLayoutPanel.Controls.Add(tabControl, 0, 1);
            tableLayoutPanel.Controls.Add(panel1, 0, 2);

            title.Dock = DockStyle.Left;
            title.Margin = new Padding(5, 5, 0, 0);
            title.ForeColor = System.Drawing.Color.SteelBlue;

            panel1.Dock = DockStyle.Fill;
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(btnCancel);

            btnOk.Text = "确认(&O)";
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(75, 28);
            btnOk.Dock = DockStyle.Right;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += new System.EventHandler(this.btnOK_Click);

            btnCancel.Text = "取消(&C)";
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 28);
            btnCancel.Dock = DockStyle.Right;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.DialogResult = DialogResult.Cancel;

            tabControl.Dock = DockStyle.Fill;
            foreach (var tab in JurisdictionRelationShip.Keys) {
                tabControl.Controls.Add(MakeTabPage(tab, JurisdictionRelationShip[tab]));
            }
            this.Load += new System.EventHandler(this.JurisdictionDlg_Load);

        }

        private static TabPage MakeTabPage(string tabTitle, GroupBoxProperty groupBoxs) {
            var tabPage = new TabPage(tabTitle);
            tabPage.AutoScroll = true;
            tabPage.Padding = new Padding(0, 5, 0, 5);
            var keyList = groupBoxs.Keys.ToList();
            for (int i = keyList.Count - 1; i >= 0; --i) {
                tabPage.Controls.Add(MakeGroupBox(keyList[i], groupBoxs[keyList[i]]));
            }
            return tabPage;
        }

        private static GroupBox MakeGroupBox(string title, CheckBoxProperty checkBoxs) {
            var flowLayout = new FlowLayoutPanel();
            flowLayout.WrapContents = true;
            flowLayout.Dock = DockStyle.Fill;
            flowLayout.AutoSize = true;
            flowLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            flowLayout.Controls.Add(AddSelectAllCheckBox());

            foreach (var content in checkBoxs.Keys) {
                flowLayout.Controls.Add(MakeCheckBox(content, checkBoxs[content]));
            }

            var groupBox = new GroupBox();
            groupBox.Dock = DockStyle.Top;
            groupBox.Text = title;
            groupBox.Resize += new System.EventHandler(GroupBoxResize);
            groupBox.Controls.Add(flowLayout);

            return groupBox;
        }

        private static CheckBox AddSelectAllCheckBox() {
            var ckb = MakeCheckBox("全选", SELECTALLSIGN);
            ckb.CheckedChanged += SelectAll;
            return ckb;
        }

        private static CheckBox MakeCheckBox(string content, string id) {
            var checkBox = new CheckBox();
            checkBox.Text = content;
            checkBox.Tag = id;
            checkBox.AutoSize = true;
            checkBox.Padding = new Padding(0, 5, 0, 5);
            return checkBox;
        }

        private static void SelectAll(object sender, System.EventArgs e) {
            var ckb = (CheckBox)sender;
            if (ckb.Tag.ToString() == SELECTALLSIGN) {
                foreach (var child in ((FlowLayoutPanel)ckb.Parent).Controls) {
                    if (child is CheckBox) {
                        var c = (CheckBox)child;
                        if (c.Tag.ToString() != SELECTALLSIGN) {
                            c.CheckState = ckb.CheckState;
                        }
                    }
                }
            }
        }

        public static void GroupBoxResize(object sender, System.EventArgs e) {
            var gb = sender as GroupBox;
            foreach (var ctl in gb.Controls) {
                if (ctl is FlowLayoutPanel) {
                    var f = ctl as FlowLayoutPanel;
                    gb.Size = new System.Drawing.Size(gb.Size.Width, ((CheckBox)f.Controls[f.Controls.Count - 1]).Bounds.Bottom + 25);
                }
            }
        }

    }
}