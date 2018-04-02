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
        //[Jurisdiction("文件操作", "文件", "查询列表", "80004")]
        public static async Task<IResult> List(Dictionary<string, object> data) {
            return await Http.Get("/root", data, URLTYPES.FILE);
        }

        /// <summary>
        /// 下载指定的文件。
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="hash"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        //[Jurisdiction("文件操作", "文件", "下载", "80003")]
        public static async Task<byte[]> Download(long fileId, string hash) {
            return await Http.GetFileData("/" + fileId + "/" + hash);
        }

        #region 权限ID同为80001
        /// <summary>
        /// 上传文件。
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        //[Jurisdiction("文件操作", "文件", "上传", "80001")]
        public static async Task<IResult> Upload(string fileName, byte[] data, long objId, int fileType) {
            return await Http.PostFileData("/root?object-id=" + objId + "&file-type=" + fileType, fileName, data);
        }
        #endregion

        /// <summary>
        /// 删除文件。
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns></returns>
        //[Jurisdiction("文件操作", "文件", "删除", "80005")]
        public static async Task<IResult> Delete(string fileId, string hash) {
            return await Http.DeleteFileData("/" + fileId + "/" + hash);
        }
    }
}
