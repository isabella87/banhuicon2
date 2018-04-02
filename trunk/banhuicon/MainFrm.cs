using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Banhuitong.Console.Excel;
using log4net;

namespace Banhuitong.Console {
    using BaseData;

    public partial class MainFrm : Form {
        public static bool IsAdmin { get; private set; }
        private ILog m_log = LogManager.GetLogger(typeof(MainFrm));

        public MainFrm() {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e) {
            Application.Idle += Application_Idle;
            Application.ThreadException += Application_ThreadException;
            RestoreWindow();
            UpdateTitle();
            var sDlg = new SignInDlg();
            if (sDlg.ShowDialog(this) != DialogResult.OK) {
                // 未成功登录的情况下，只允许操作工具和帮助。
                DisableActions(menuItemTools, menuItemHelp);
            } else {
                new Thread(new ThreadStart(CheckUpdate)).Start();
                UpdateCurrentUser();
            }
        }

        private async void CheckUpdate() {
            var p = await AppVersion.GetVersionOnServer();
            if (p == null) {
                return;
            }
            var serverVersion = new System.Version(Encoding.UTF8.GetString(p));
            var localVersion = new System.Version(Application.ProductVersion);

            if (serverVersion.CompareTo(localVersion) > 0) {
                tsUpdate.BeginInvoke(new Action(() => {
                    labLastVersion.Text = string.Format(labLastVersion.Text, serverVersion.ToString());
                    tsUpdate.Visible = true;
                }));
            }

        }


        void Application_Idle(object sender, EventArgs e) {
            UpdateHttpStatus();
            UpdateChildFrmRecordsCount();
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
            using (var dlg = new ErrorDlg()) {
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.Exception = e.Exception;
                dlg.ShowDialog(this);
            }

            Close();
        }

        private void UpdateHttpStatus() {
            switch (Rpc.Http.Status) {
                case Rpc.HttpStatus.Ready:
                    statusHttpStatus.Text = Properties.Resources.HttpStatus_Ready;
                    statusHttpProgress.Visible = false;
                    statusHttpProgress.Value = 0;
                    break;
                case Rpc.HttpStatus.Sending:
                    statusHttpStatus.Text = Properties.Resources.HttpStatus_Sending;
                    statusHttpProgress.Visible = true;
                    statusHttpProgress.Value = Rpc.Http.Progress;
                    break;
                case Rpc.HttpStatus.Waiting:
                    statusHttpStatus.Text = Properties.Resources.HttpStatus_Waiting;
                    statusHttpProgress.Visible = false;
                    statusHttpProgress.Value = 0;
                    break;
                case Rpc.HttpStatus.Receiving:
                    statusHttpStatus.Text = Properties.Resources.HttpStatus_Receiving;
                    statusHttpProgress.Visible = true;
                    statusHttpProgress.Value = Rpc.Http.Progress;
                    break;
                default:
                    statusHttpStatus.Text = "";
                    statusHttpProgress.Visible = false;
                    statusHttpProgress.Value = 0;
                    break;
            }
        }

        private void UpdateChildFrmRecordsCount() {
            var rc = ActiveMdiChild as IHasGridDataTable;
            var table = rc != null ? rc.GridViewBinding.DataTable : null;
            if (table != null) {
                statusRecordsCount.Text = string.Format(Properties.Resources.StatusBar_TotalRecords, table.Count);
                menuItemExportExcel.Enabled = true;
            } else {
                statusRecordsCount.Text = "";
                menuItemExportExcel.Enabled = false;
            }
        }
        /// <summary>
        /// 从配置文件中恢复窗体的各个属性。
        /// </summary>
        private void RestoreWindow() {
            var state = Properties.Settings.Default.MainFrm_State;
            var location = Properties.Settings.Default.MainFrm_Location;
            var size = Properties.Settings.Default.MainFrm_Size;
            // 如果配置文件中的窗体大小为0，那么根据当前屏幕工作区大小计算。
            if (size.IsEmpty) {
                var wa = Screen.FromControl(this).WorkingArea;
                size.Width = wa.Width * 4 / 5;
                size.Height = wa.Height * 4 / 5;
                location.X = wa.Width / 10;
                location.Y = wa.Height / 10;
            }

            WindowState = state != FormWindowState.Minimized ? state : FormWindowState.Normal;
            Location = location;
            Size = size;
        }

        /// <summary>
        /// 向配置文件中保存窗体的各个属性。
        /// </summary>
        private void SaveWindow() {
            Properties.Settings.Default.MainFrm_State = WindowState;
            if (WindowState == FormWindowState.Normal) {
                Properties.Settings.Default.MainFrm_Location = Location;
                Properties.Settings.Default.MainFrm_Size = Size;
            } else {
                Properties.Settings.Default.MainFrm_Location = RestoreBounds.Location;
                Properties.Settings.Default.MainFrm_Size = RestoreBounds.Size;
            }
        }

        /// <summary>
        /// 禁用所有的可操作项，除了工具和帮助。
        /// <param name="first">被禁用的操作项。</param>
        /// <param name="others">其它被禁用的操作项。</param>
        /// </summary>
        private void DisableActions(ToolStripItem first, params ToolStripItem[] others) {
            var excludes = new HashSet<ToolStripItem>();
            excludes.Add(first);
            excludes.UnionWith(others);
            foreach (var menuItem in mainMenu.Items.OfType<ToolStripMenuItem>()
                .Except(excludes)) {
                menuItem.Enabled = false;
            }
        }

        private void UpdateTitle() {
            var asmb = Assembly.GetExecutingAssembly();
            var titleAttribute = asmb.GetCustomAttributes<AssemblyTitleAttribute>().FirstOrDefault();
            if (titleAttribute != null) {
                Text = titleAttribute.Title + "［" + asmb.GetName().Version.ToString() + "］";
            }
        }

        private async void UpdateCurrentUser() {
            var ret = await Security.Users.GetCurrentUser();
            statusCurrentUser.Text = string.Format(Properties.Resources.StatusBar_CurrentUser,
                ret.AsDictionary.GetOrDefault("userName", ""));
            IsAdmin = statusCurrentUser.Text == string.Format(Properties.Resources.StatusBar_CurrentUser, "admin");
        }

        private void ShowChildFrmPrivate<T>() where T : Form, new() {
            var form = new T();
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
            form.Load += (sender, e) => {
                ((Form)sender).Icon = Properties.Resources.App72;
            };
        }

        private void ShowChildFrm<T>(bool allowMultiple = false) where T : Form, new() {
            if (allowMultiple) {
                ShowChildFrmPrivate<T>();
            } else {
                foreach (var mc in this.MdiChildren) {
                    if (mc is T) {
                        if (mc.Visible) {
                            if (mc.WindowState == FormWindowState.Minimized) {
                                mc.WindowState = FormWindowState.Maximized;
                            }
                        } else {
                            mc.Show();
                        }
                        mc.Focus();
                        return;
                    }
                }
                ShowChildFrmPrivate<T>();
            }
        }


        private void UpdateMenuItemWindow() {
            // 删除所有的动态菜单项。
            menuItemWindow.DropDownItems.OfType<ToolStripMenuItem>()
                .Where(menuItem => menuItem.Tag != null)
                .ToList()
                .ForEach(menuItem => menuItemWindow.DropDownItems.Remove(menuItem));

            var children = MdiChildren;
            if (children.Length != 0) {
                menuItemCascade.Enabled = true;
                menuItemTileHorizontal.Enabled = true;
                menuItemTileVertical.Enabled = true;
                menuItemArrangeIcons.Enabled = true;
                menuItemCloseAll.Enabled = true;
                menuItemWindowSplitter1.Visible = true;

                // 为每个MDI子窗体创建一个动态菜单项。
                for (int i = 0; i < children.Length; ++i) {
                    var menuItem = new ToolStripMenuItem(
                        string.Format("{0} - {1}", i + 1, children[i].Text),
                        null, menuItemWindowItems_Click);
                    menuItem.Tag = i;
                    menuItemWindow.DropDownItems.Add(menuItem);
                }
            } else {
                menuItemCascade.Enabled = false;
                menuItemTileHorizontal.Enabled = false;
                menuItemTileVertical.Enabled = false;
                menuItemArrangeIcons.Enabled = false;
                menuItemCloseAll.Enabled = false;
                menuItemWindowSplitter1.Visible = false;
            }
        }

        private void ShowOptionsDlg() {
            var dlg = new OptionsDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }


        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e) {
            SaveWindow();
        }

        private void menuItemOptions_Click(object sender, EventArgs e) {
            ShowOptionsDlg();
        }

        private void menuItemCascade_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuItemTileVertical_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuItemTileHorizontal_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuItemArrangeIcons_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void menuItemCloseAll_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void menuItemAbout_Click(object sender, EventArgs e) {
            var box = new AboutBox();
            box.ShowDialog(this);
        }

        private void menuItemSysUsers_Click(object sender, EventArgs e) {
            ShowChildFrm<SysUsersFrm>();
        }

        private void menuItemAssPrj_Click(object sender, EventArgs e) {
            ShowChildFrm<CreditAssignProjectFrm>();
        }

        private void menuItemWyjk_Click(object sender, EventArgs e) {
            ShowChildFrm<WyjksFrm>();
        }

        private void menuItemPrjEng_Click(object sender, EventArgs e) {
            ShowChildFrm<PrjEngineerFrm>();
        }

        private void menuItemPrjCtor_Click(object sender, EventArgs e) {
            ShowChildFrm<PrjCtorFrm>();
        }

        private void menuItemPrjOwner_Click(object sender, EventArgs e) {
            ShowChildFrm<PrjOwnerFrm>();
        }

        private void menuItemPrjGua_Click(object sender, EventArgs e) {
            ShowChildFrm<PrjGuaranteeOrgFrm>();
        }

        private void menuItemPrjPm_Click(object sender, EventArgs e) {
            ShowChildFrm<PrjBorPersonsFrm>();
        }

        private void menuItemPrjBorOrg_Click(object sender, EventArgs e) {
            ShowChildFrm<PrjBorOrgFrm>();
        }

        private void menuItemAccPer_Click(object sender, EventArgs e) {
            ShowChildFrm<AccPersonsFrm>();
        }

        private void menuItemAccOrg_Click(object sender, EventArgs e) {
            ShowChildFrm<AccOrgsFrm>();
        }

        private void menuItemBusTra_Click(object sender, EventArgs e) {
            ShowChildFrm<BusinessTransferFrm>();
        }

        private void menuItemSendMes_Click(object sender, EventArgs e) {
            ShowChildFrm<AccMessageFrm>();
        }

        private void menuItemAssInvest_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmInvestorFrm>();
        }

        private void menuItemMyInvest_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmMyInvestorsFrm>();
        }

        private void menuItemOutOfDate1_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmInvestor2To1Frm>();
        }

        private void menuItemOutOfDate2_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmInvestor3To2Frm>();
        }

        private void menuItemOutOfDate3_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmInvestor3TimeOutFrm>();
        }

        private void menuItemMgrs_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmMgrsFrm>();
        }

        private void menuItemPerformanceStatisticByDailyFrm_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmPerformanceStatisticByDailyFrm>();
        }

        private void menuItemPerformanceStatisticByMonthFrm_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmPerformanceStatisticByMonthFrm>();
        }

        private void menuItemRoleMgr_Click(object sender, EventArgs e) {
            ShowChildFrm<SysRoleMgrFrm>();
        }

        private void menuItemWindow_DropDownOpening(object sender, EventArgs e) {
            UpdateMenuItemWindow();
        }

        private void menuItemWindowItems_Click(object sender, EventArgs e) {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem != null && menuItem.Tag is int) {
                var i = (int)menuItem.Tag;
                MdiChildren[i].Focus();
            }
        }

        private void menuItemExportExcel_Click(object sender, EventArgs e) {
            var rc = ActiveMdiChild as IHasGridDataTable;
            if (rc != null && rc.GridViewBinding != null) {
                ExcelHelper.ExportExcel(rc.GridViewBinding);
            }
        }

        private void menuItemCrmNewReg_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmNewRegsFrm>();
        }

        private void menuItemExterprise_Click(object sender, EventArgs e) {
            ShowChildFrm<EnterprisePrjFrm>();
        }

        private void menuItemDaySta_Click(object sender, EventArgs e) {
            var dlg = new DailyStatisticDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void menuItemMonSta_Click(object sender, EventArgs e) {
            var dlg = new MonthStatisticDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void menuItemFstCus_Click(object sender, EventArgs e) {
            var dlg = new NewInvestorsStatisticDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void menuItemVipCus_Click(object sender, EventArgs e) {
            var dlg = new VipStatisticDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void menuItemChangePwd_Click(object sender, EventArgs e) {
            var dlg = new ChangePwdDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void menuItemRegUsers_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmRegUserFrm>();
        }

        private void menuItemMyRegUsers_Click(object sender, EventArgs e) {
            ShowChildFrm<CrmMyRegUsersFrm>();
        }

        private void menuItemCreatQRCode_Click(object sender, EventArgs e) {
            var dlg = new CrmSpreadQrcodeDlg();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void menuItemError_Click(object sender, EventArgs e) {
            var dlg = new ErrorCodeHelp();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog(this);
        }

        private void menuItemPrjGuaPer_Click(object sender, EventArgs e) {
            ShowChildFrm<PrjGuaranteePerFrm>();
        }

        private void menuItemClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void menuItemYiMeiMessages_Click(object sender, EventArgs e) {
            ShowChildFrm<YiMeiMessagesFrm>();
        }

        private void btnUpdateURL_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(Properties.Settings.Default.Update_BaseUrl + Commons.AddUrlTail(URLTYPES.UPDATE) + "/index.jsp");
        }

    }
}
