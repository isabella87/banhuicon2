using System.Threading.Tasks;
using System.Net;

namespace Banhuitong.Console.BaseData {
    public static class AppVersion {

        public static async Task<byte[]> GetVersionOnServer() {
            try {
                using (var webClient = new WebClient()) {
                    return await webClient.DownloadDataTaskAsync(Properties.Settings.Default.Update_BaseUrl + Commons.AddUrlTail(URLTYPES.UPDATE) + "/banhuicon/latest");
                }
            } catch {
                return (byte[])null;
            }
        }

    }
}
