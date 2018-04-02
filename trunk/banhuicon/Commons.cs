using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

using log4net;
using MyLib.UI;

namespace Banhuitong.Console {
    public enum URLTYPES { VISIT = 0, UPDATE = 1, FILE = 2 };
    /// <summary>
    /// 包含数据绑定关系。
    /// </summary>
    public interface IHasGridDataTable {
        /// <summary>
        /// 获取数据表的绑定关系。
        /// </summary>
        MyGridViewBinding GridViewBinding { get; }
    }

    public static partial class Commons {
        private static readonly ILog m_log = LogManager.GetLogger(typeof(Commons));

        /// <summary>
        /// 将字符串解析为整数。
        /// </summary>
        /// <param name="s">待解析的字符串。</param>
        /// <param name="dv">无法解析时的返回结果。</param>
        /// <returns></returns>
        public static int ToInt32(this string s, int dv = 0) {
            if (string.IsNullOrWhiteSpace(s)) {
                return dv;
            } else {
                s = NumberPattern.Replace(s.Trim(), "");
                int result;
                if (int.TryParse(s, out result)) {
                    return result;
                } else {
                    return dv;
                }
            }
        }

        private static Regex NumberPattern = new Regex(@"[^0-9\-.]+",
            RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

        /// <summary>
        /// 将字符串解析为长整数。
        /// </summary>
        /// <param name="s">待解析的字符串。</param>
        /// <param name="dv">无法解析时的返回结果。</param>
        /// <returns></returns>
        public static long ToInt64(this string s, long dv = 0L) {
            if (string.IsNullOrWhiteSpace(s)) {
                return dv;
            } else {
                s = NumberPattern.Replace(s.Trim(), "");
                long result;
                if (long.TryParse(s, out result)) {
                    return result;
                } else {
                    return dv;
                }
            }
        }

        /// <summary>
        /// 将字符串解析为十进制数。
        /// </summary>
        /// <param name="s">待解析的字符串。</param>
        /// <param name="dv">无法解析时的返回结果。</param>
        /// <returns></returns>
        public static decimal ToDecimal(this string s, decimal dv = 0M) {
            if (string.IsNullOrWhiteSpace(s)) {
                return dv;
            } else {
                s = NumberPattern.Replace(s.Trim(), "");
                decimal result;
                if (decimal.TryParse(s, out result)) {
                    return result;
                } else {
                    return dv;
                }
            }
        }

        /// <summary>
        /// 将字符串解析为布尔值。
        /// </summary>
        /// <param name="s">待解析的字符串。</param>
        /// <param name="dv">无法解析时的返回结果。</param>
        /// <returns></returns>
        public static bool ToBoolean(this string s, bool dv = false) {
            if (string.IsNullOrWhiteSpace(s)) {
                return dv;
            } else {
                s = s.Trim().ToLower();
                return s == "true" || s == "on" || s == "1" || s == "yes";
            }
        }

        /// <summary>
        /// 截取字符串的左边部分，如果截取长度超过原始字符串的长度则返回整个字符串，如果截取长度小于等于0则返回空字符串。
        /// </summary>
        /// <param name="s">原始字符串。</param>
        /// <param name="length">截取长度。</param>
        /// <returns></returns>
        public static string LeftStr(this string s, int length) {
            if (string.IsNullOrEmpty(s) || length <= 0) {
                return "";
            } else {
                if (length < 0) {
                    length += s.Length;
                }
                if (length < 0) {
                    return "";
                }

                return length < s.Length ? s.Substring(0, length) : s;
            }
        }

        /// <summary>
        /// 截取字符串的右边部分，如果截取长度超过原始字符串的长度则返回整个字符串，如果截取长度小于等于0则返回空字符串。
        /// </summary>
        /// <param name="s">原始字符串。</param>
        /// <param name="length">截取长度。</param>
        /// <returns></returns>
        public static string RightStr(this string s, int length) {
            if (string.IsNullOrEmpty(s) || length <= 0) {
                return "";
            } else {
                return length < s.Length ? s.Substring(s.Length - length, length) : s;
            }
        }

        /// <summary>
        /// 截取字符串的中间部分，如果截取长度超过原始字符串的长度则返回整个字符串，如果截取长度小于等于0则返回空字符串。
        /// </summary>
        /// <param name="s">原始字符串。</param>
        /// <param name="start">截取的起始下标，返回结果包含此下标。</param>
        /// <param name="end">截取的终止下标，返回结果不包含此下标。</param>        
        /// <returns></returns>
        public static string MidStr(this string s, int start, int end = int.MaxValue) {
            if (string.IsNullOrEmpty(s)) {
                return "";
            } else {
                if (start < 0) {
                    start = s.Length + start;
                }
                if (end < 0) {
                    end = s.Length + end;
                }
                if (end > s.Length) {
                    end = s.Length;
                }
                return end > start ? s.Substring(start, end - start) : "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string TrimStr(this object obj) {
            if (obj == null) {
                return "";
            } else if (obj is string) {
                return ((string)obj).Trim();
            } else if (obj is string[]) {
                return string.Join(",", obj as string[]);
            } else {
                return obj.ToString().Trim();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string TrimStr(this string s) {
            return s != null ? s.Trim() : "";
        }
        static DateTime Epoch1970 = new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Local);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static DateTime FromTimestamp(long timestamp) {
            return Epoch1970.AddMilliseconds(timestamp);
        }

        public static string TimestampToDateString(long timestamp) {
            if (timestamp == 0)
                return "";
            else
                return string.Format("{0:d}", FromTimestamp(timestamp));
        }

        public static string TimestampToDateTimeString(long timestamp) {
            if (timestamp == 0)
                return "";
            else
                return string.Format("{0:G}", FromTimestamp(timestamp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static long ToTimestamp(DateTime dt) {
            return (long)(dt - Epoch1970).TotalMilliseconds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="days"></param>
        /// <returns></returns>
        public static Tuple<DateTime, DateTime> MakeDateRange(int days = 1080) {
            return MakeDateRange(DateTime.Today, days);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endDate"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        public static Tuple<DateTime, DateTime> MakeDateRange(DateTime endDate, int days = 5*365) {
            var startDate = endDate.AddDays(-days);
            return Tuple.Create(startDate.TruncToStart(), endDate.TruncToEnd());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Take<T>(this IDictionary<string, object> data, string key) {
            key = NotBlank(key, "key").Trim();
            object value;
            if (data.TryGetValue(key, out value)) {
                T ret;
                if (value != null) {
                    ret = (T)Convert.ChangeType(value, typeof(T));
                } else {
                    ret = default(T);
                }
                data.Remove(key);
                return ret;
            } else {
                return default(T);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="d"></param>
        /// <param name="k"></param>
        /// <param name="dv"></param>
        /// <returns></returns>
        public static T GetOrDefault<T>(this IDictionary<string, object> d, string k, T dv = default(T)) {
            NotNull(d, "d");

            if (k == null) {
                return dv;
            } else {
                object v;
                if (d.TryGetValue(k, out v)) {
                    try {
                        return (T)Convert.ChangeType(v, typeof(T));
                    } catch (Exception) {
                        return dv;
                    }
                } else {
                    return dv;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enu"></param>
        /// <param name="act"></param>
        public static void ForEach<T>(this IEnumerable<T> enu, Action<T> act) {
            NotNull(enu, "enu");
            if (act != null) {
                foreach (var item in enu) {
                    act(item);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enu"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string JoinSome<T>(this IEnumerable<T> enu, string separator = "", int MaxElements = 10) {
            if (string.IsNullOrEmpty(separator)) {
                separator = Properties.Resources.Commons_Separator;
            }

            if (enu != null) {
                int c = 0;
                var sb = new System.Text.StringBuilder();
                foreach (var ele in enu) {
                    if (c >= MaxElements) {
                        sb.Append(Properties.Resources.Commons_Ellipse);
                        break;
                    }
                    if (sb.Length > 0) {
                        sb.Append(separator);
                    }
                    sb.Append(ele);
                    ++c;
                }
                return sb.ToString();
            } else {
                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public static T NotNull<T>(T value, string paramName) {
            if (value == null) {
                if (String.IsNullOrWhiteSpace(paramName)) {
                    throw new ArgumentNullException();
                } else {
                    throw new ArgumentNullException(paramName);
                }
            } else {
                return value;
            }
        }

        public static System.Threading.Tasks.Task<T> NotNull<T>(System.Threading.Tasks.Task<T> value, string paramName) {
            if (value == null) {
                if (String.IsNullOrWhiteSpace(paramName)) {
                    throw new ArgumentNullException();
                } else {
                    throw new ArgumentNullException(paramName);
                }
            } else {
                return value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public static string NotBlank(string value, string paramName) {
            if (value == null) {
                if (String.IsNullOrWhiteSpace(paramName)) {
                    throw new ArgumentException();
                } else {
                    throw new ArgumentException(paramName + " cannot be null or empty");
                }
            } else {
                return value;
            }
        }

        public static int IndexOf<T>(this IEnumerable<T> enu, Predicate<T> pred) {
            NotNull(enu, "enu");
            NotNull(pred, "pred");

            var i = 0;
            foreach (var t in enu) {
                if (pred(t)) {
                    return i;
                } else {
                    ++i;
                }
            }
            return -1;
        }

        /*
        public static byte[] ReadAll(Stream stream) {
            NotNull(stream, "stream");

            int BufferSize = 1024 * 4;
            var buffer = new byte[BufferSize];
            int l = 
        }

        /// <summary>
        /// 
         * 
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string ReadAllString(Stream stream, Encoding encoding = null) {
            NotNull(stream, "stream");
            if (encoding == null) {
                encoding = Encoding.UTF8;
            }

            int BufferSize = 1024 * 4;
            var buffer = new byte[BufferSize];
            encoding.GetDecoder().Convert()
            stream.Read(buffer, 0, BufferSize);
            return "";
        }*/

        public static void SetReadOnly(this Control ctrl, bool readOnly) {
            if (ctrl is TextBoxBase) {
                ((TextBoxBase)ctrl).ReadOnly = readOnly;
            } else if (ctrl is Form || ctrl is GroupBox || ctrl is TabPage) {
                foreach (var child in ctrl.Controls.OfType<Control>()) {
                    SetReadOnly(child, readOnly);
                }
            } else if (ctrl is TabControl) {
                foreach (var page in ((TabControl)ctrl).TabPages.OfType<TabPage>()) {
                    SetReadOnly(page, readOnly);
                }
            } else if (ctrl is TableLayoutPanel) {
                foreach (var c in ((TableLayoutPanel)ctrl).Controls.OfType<Control>()) {
                    SetReadOnly(c, readOnly);
                }
            } else if (ctrl is DataGridView) {
                ((DataGridView)ctrl).ReadOnly = readOnly;
            } else {
                ctrl.Enabled = !readOnly;
            }
        }

        public static string ToStdString(this JToken j) {
            return j != null ? j.ToString() : "";
        }

        public static string ToMoney(this JToken j) {
            string s = j.ToStdString();
            if (!string.IsNullOrEmpty(s)) {
                decimal d;
                if (decimal.TryParse(s, out d)) {
                    return d.ToString("#,##0.00");
                }
            }

            return "";
        }

        public static string ToDateTime(this JToken j) {
            string s = j.ToStdString();
            if (!string.IsNullOrEmpty(s)) {
                long d;
                if (long.TryParse(s, out d)) {
                    return Commons.TimestampToDateTimeString(d);
                }
            }
            return "";
        }

        public static string ToDate(this JToken j) {
            string s = j.ToStdString();
            if (!string.IsNullOrEmpty(s)) {
                long d;
                if (long.TryParse(s, out d)) {
                    return Commons.TimestampToDateString(d);
                }
            }
            return "";
        }

        public static long ToInt64(this JToken j) {
            string s = j.ToStdString();
            if (!string.IsNullOrEmpty(s)) {
                long d;
                if (long.TryParse(s, out d)) {
                    return d;
                }
            }
            return 0;
        }

        public static int ToInt32(this JToken j) {
            string s = j.ToStdString();
            if (!string.IsNullOrEmpty(s)) {
                int d;
                if (int.TryParse(s, out d)) {
                    return d;
                }
            }
            return 0;
        }

        public static decimal ToDecimal(this JToken j) {
            string s = j.ToStdString();
            if (!string.IsNullOrEmpty(s)) {
                decimal d;
                if (decimal.TryParse(s, out d)) {
                    return d;
                }
            }
            return 0;
        }

        public static bool ToBoolean(this JToken j) {
            string s = j.ToStdString();
            if (!string.IsNullOrEmpty(s)) {
                bool d;
                if (bool.TryParse(s, out d)) {
                    return d;
                }
            }
            return false;
        }

        /// <summary>
        /// 将日期截取到一天的开始，即凌晨0点0分0秒。
        /// </summary>
        /// <param name="startDate">需要截取的日期。</param>
        /// <returns>截取的结果。</returns>
        public static DateTime TruncToStart(this DateTime startDate) {
            return new DateTime(startDate.Year, startDate.Month, startDate.Day);
        }

        /// <summary>
        /// 将日期截取到一天的结束，即23点59分59秒998毫秒。
        /// </summary>
        /// <param name="endDate">需要截取的日期。</param>
        /// <returns>截取的结果。</returns>
        public static DateTime TruncToEnd(this DateTime endDate) {
            return new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59, 998);
        }

        /// <summary>
        /// 将指定的字符串正规化为表示数字的字符串，去掉所有非数字的字符。
        /// </summary>
        /// <param name="str">需要正规化的字符串。</param>
        /// <returns></returns>
        public static string NormalNumberStr(string str) {
            str = NotBlank(str, "str").Trim();
            var pattern = new Regex(@"[^0-9]+");
            return pattern.Replace(str, "");
        }

        /// <summary>
        /// 将长整数转化为表示文件长度的字符串。
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string ToFileLength(this long size) {
            if (size < 10 * 1024) {
                return string.Format("{0:#0} BYTE", size);
            } else if (size < 10 * 1024 * 1024) {
                return string.Format("{0:#0.0} KB", size / 1024);
            } else {
                return string.Format("{0:#0.0} MB", size / (1024 * 1024));
            }
        }

        /// <summary>
        /// 从指定的流中读取全部字符。
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string ReadToEnd(this System.IO.Stream stream, System.Text.Encoding encoding = null) {
            if (encoding == null) {
                encoding = System.Text.Encoding.UTF8;
            }

            try {
                var reader = new System.IO.StreamReader(stream, encoding);
                return reader.ReadToEnd();
            } finally {
                stream.Close();
            }
        }

        public static void DictionaryAddResult<T>(Dictionary<string, T> d, Rpc.IResult r) {
            foreach (var k in r.AsDictionary) {
                d[k.Key] = (T)Convert.ChangeType(k.Value, typeof(T));
            }
        }

        public static IList<T> Add2<T>(this IList<T> l, T t) {
            l.Add(t);
            return l;
        }

        public static List<T> Add2<T>(this List<T> l, T t) {
            l.Add(t);
            return l;
        }

        public static string AddUrlTail(URLTYPES ut) {
            switch (ut) {
                case URLTYPES.VISIT:
                    return "/p2psrv";
                case URLTYPES.UPDATE:
                    return "/update";
                case URLTYPES.FILE:
                    return "/ofs";
                default:
                    return "";
            }
        }

    }
}

