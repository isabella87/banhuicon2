using System;
using System.Windows.Forms;

namespace Banhuitong.Console {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            log4net.Config.XmlConfigurator.Configure();
#if DEBUG
            UnsafeNativeMethods.AllocConsole();
            Rpc.Http.BaseUrl = Properties.Settings.Default.Rpc_BaseUrlDebug + Commons.AddUrlTail(URLTYPES.VISIT);
            Rpc.Http.FileUrl = Properties.Settings.Default.Rpc_BaseUrlDebug + Commons.AddUrlTail(URLTYPES.FILE);
#else
            Rpc.Http.BaseUrl = Properties.Settings.Default.Rpc_BaseUrl + Commons.AddUrlTail(URLTYPES.VISIT);
            Rpc.Http.FileUrl = Properties.Settings.Default.Rpc_BaseUrl + Commons.AddUrlTail(URLTYPES.FILE);
#endif

            Application.Run(new MainFrm());

            Properties.Settings.Default.Save();

#if DEBUG
            UnsafeNativeMethods.FreeConsole();
#endif
        }
    }
}
