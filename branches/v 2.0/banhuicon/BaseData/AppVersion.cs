using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace Banhuitong.Console.BaseData {
    public static class AppVersion {

        public static async Task<byte[]> GetVersionOnServer() {
            try {
                using (var webClient = new WebClient()) {
                    return await webClient.DownloadDataTaskAsync(Properties.Settings.Default.Update_BaseUrl + "/banhuicon/latest");
                }
            } catch {
                return (byte[])null;
            }
        }

    }
}
