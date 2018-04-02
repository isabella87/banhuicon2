using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;
using System.IO;

namespace Banhuitong.Console.BaseData {
    using CustomAttribute;
    public static class Files {
        /// <summary>
        /// 获取指定目录下的文件列表。
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [Jurisdiction("文件操作", "文件", "查询列表", "80004")]
        public static async Task<IResult> List(Dictionary<string, object> data) {
            return await Http.Get("/mgr/files", data);
        }

        #region 权限ID同为80003
        /// <summary>
        /// 获取文件的长度。
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static async Task<long> Length(long fileId, string hash) {
            return await Http.Head("/mgr/files/" + fileId + "/" + hash);
        }

        /// <summary>
        /// 下载指定的文件。
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="hash"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        [Jurisdiction("文件操作", "文件", "下载", "80003")]
        public static async Task<byte[]> Download(long fileId, string hash, long start, long end) {
            return await Http.GetRaw("/mgr/files/" + fileId + "/" + hash, start, end);
        }
        #endregion

        #region 权限ID同为80001
        /// <summary>
        /// 创建文件。
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [Jurisdiction("文件操作", "文件", "上传", "80001")]
        public static async Task<IResult> Create(Dictionary<string, object> data) {
            return await Http.Put("/mgr/files", data);
        }

        /// <summary>
        /// 上传文件。
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task<IResult> Upload(long fileId, byte[] data) {
            return await Http.PostRaw("/mgr/files/" + fileId + "/content", data);
        }
        #endregion

        /// <summary>
        /// 删除文件。
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns></returns>
        [Jurisdiction("文件操作", "文件", "删除", "80005")]
        public static async Task<IResult> Delete(string fileId) {
            return await Http.Delete("/mgr/files/" + fileId);
        }
    }
}
