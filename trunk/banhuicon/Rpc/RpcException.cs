using System;
using System.Net;
using System.Text;

namespace Banhuitong.Console.Rpc {
    /// <summary>
    /// 执行Rpc调用时引发的异常。
    /// </summary>
    [Serializable]
    public sealed class RpcException : InvalidOperationException {
        public RpcException(WebResponse rsp)
            : base(FormatMessage(rsp)) { }

        public RpcException(WebResponse rsp, Exception innerException)
            : base(FormatMessage(rsp), innerException) { }

        private static string FormatMessage(WebResponse rsp) {
            var response = rsp as HttpWebResponse;
            if (response == null) {
                return "invalid rsp: " + rsp.ToString();
            }

            switch (response.StatusCode) {
                case HttpStatusCode.Forbidden:
                    return string.Format(Properties.Resources.RpcException_Forbidden, response.ResponseUri);
                case HttpStatusCode.NotFound:
                    return string.Format(Properties.Resources.RpcException_NotFound, response.ResponseUri);
                case HttpStatusCode.BadGateway:
                    return string.Format(Properties.Resources.RpcException_BadGateway, response.ResponseUri);
                case HttpStatusCode.GatewayTimeout:
                    return string.Format(Properties.Resources.RpcException_BadGateway, response.ResponseUri);
                case HttpStatusCode.InternalServerError:
                    // 对于服务器内部错误，需要读取响应内容并解析。
                    var rs = response.GetResponseStream();
                    if (rs.CanRead) {
                        var buffer = new byte[1024];
                        var rl = rs.Read(buffer, 0, 1024);
                        var content = Encoding.UTF8.GetString(buffer, 0, rl).Trim();
                        if (content != "") {
                            var sidx = content.IndexOf('*');
                            if (sidx != -1) {
                                var ecode = Commons.ToInt32(content.MidStr(0, sidx), 0);
                                var emsg = content.MidStr(sidx + 1);
                                return emsg + "\r\n" + string.Format(Properties.Resources.RpcException_Default, response.ResponseUri, response.StatusCode);
                            } else {
                                return content + "\r\n" + string.Format(Properties.Resources.RpcException_Default, response.ResponseUri, response.StatusCode);
                            }
                        }
                    }
                    goto default;
                default:
                    return string.Format(Properties.Resources.RpcException_Default, response.ResponseUri);
            }

        }
    } // end of RpcException
}
