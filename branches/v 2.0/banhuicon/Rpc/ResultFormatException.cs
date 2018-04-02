using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banhuitong.Console.Rpc {
    /// <summary>
    /// 表示返回值结果格式不正确的异常。
    /// </summary>
    public class ResultFormatException : Exception {
        public ResultFormatException(string expectedType, string detail)
            : base(FormatMessage(expectedType, detail)) {
        }

        private static string FormatMessage(string expectedType, string detail) {
            return string.Format(Properties.Resources.ResultFormatException_Default, expectedType.TrimStr(), Ellipsis(detail));
        }

        /// <summary>
        /// 返回指定字符串的缩略形式。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string Ellipsis(string s) {
            if (s == null) {
                return "";
            } else if (s.Length < 256) {
                return s;
            } else {
                return s.LeftStr(256) + "...";
            }
        }
    }
}
