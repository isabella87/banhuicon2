using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
            Rpc.Http.BaseUrl = Properties.Settings.Default.Rpc_BaseUrlDebug;
#else
            Rpc.Http.BaseUrl = Properties.Settings.Default.Rpc_BaseUrl;
#endif

            Application.Run(new MainFrm());

            Properties.Settings.Default.Save();

#if DEBUG
            UnsafeNativeMethods.FreeConsole();
#endif
        }
    }
}
