using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console.Rpc {
    /// <summary>
    /// 使用Http协议的Rpc调用的返回结果
    /// </summary>
    sealed class JsonResult : IResult {
        private ILog m_log = LogManager.GetLogger(typeof(JsonResult));

        private string m_value;
        private RpcException m_exception;

        /// <summary>
        /// 初始化返回结果。
        /// </summary>
        /// <param name="url">Rpc调用的地址。</param>
        /// <param name="code">Rpc调用的返回码。</param>
        /// <param name="value">调用的返回结果。</param>
        public JsonResult(string value) {
            value = value.TrimStr();
            m_value = string.Equals(value, "null", StringComparison.OrdinalIgnoreCase) ? "" : value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        public JsonResult(RpcException exception) {
            if (exception != null) {
                m_exception = exception;
            } else {
                m_value = "";
            }
        }

        public bool IsOk {
            get {
                return m_exception == null;
            }
        }

        public RpcException Exception {
            get {
                return m_exception;
            }
        }

        public int AsInt {
            get { return Commons.ToInt32(m_value); }
        }

        public long AsLong {
            get { return Commons.ToInt64(m_value); }
        }

        public decimal AsDecimal {
            get { return Commons.ToDecimal(m_value); }
        }

        public DateTime AsDateTime {
            get { return Commons.FromTimestamp(Commons.ToInt64(m_value)); }
        }

        public string AsString {
            get { return m_value; }
        }

        public bool AsBoolean {
            get { return Commons.ToBoolean(m_value); }
        }

        private static object ToObject(JToken jt) {
            if (jt is JValue) {
                var jv = jt as JValue;
                return jv.Type != JTokenType.Null ? jv.Value : null;
            } else if (jt is JArray) {
                var ja = jt as JArray;
                return ja.Select(_ => _.ToStdString()).ToArray();
            } else {
                return null;
            }
        }

        private static IDictionary<string, object> ToDictionary(JObject jo) {
            return jo.Properties().ToDictionary(_ => _.Name, _ => ToObject(_.Value));
        }

        private static IList<object> ToList(JArray ja) {
            return ja.Children().Select(_ => ToObject(_)).ToList();
        }

        private static IList<IDictionary<string, object>> ToDictList(JArray ja) {
            return ja.Children()
                .OfType<JObject>()
                .Select(_ => ToDictionary(_)).ToList();
        }

        public IDictionary<string, object> AsDictionary {
            get {
                try {
                    return ToDictionary(JObject.Parse(m_value));
                } catch (Newtonsoft.Json.JsonReaderException) {
                    throw new ResultFormatException("object {}", m_value);
                }
            }
        }

        public IList<object> AsList {
            get {
                try {
                    return ToList(JArray.Parse(m_value));
                } catch (Newtonsoft.Json.JsonReaderException) {
                    throw new ResultFormatException("list []", m_value);
                }
            }
        }

        public IList<IDictionary<string, object>> AsDictList {
            get {
                try {
                    return ToDictList(JArray.Parse(m_value));
                } catch (Newtonsoft.Json.JsonReaderException) {
                    throw new ResultFormatException("list [{}]", m_value);
                }
            }
        }

        public IDictionary<string, IList<IDictionary<string, object>>> AsDictListDict {
            get {
                try {
                    var jo = JObject.Parse(m_value);
                    return jo.Properties().OrderBy(_ => _.Name)
                        .Where(_ => _.Value.Type == JTokenType.Array)
                        .ToDictionary(
                        _ => _.Name,
                        _ => ToDictList(_.Value as JArray));
                } catch (Newtonsoft.Json.JsonReaderException) {
                    throw new ResultFormatException("object {[{}],[{}]}", m_value);
                }
            }
        }
    }

    [System.ComponentModel.DesignerCategory("Code")]
    sealed class HttpWebClient : WebClient {
        private CookieContainer m_cookieContainer;

        private long m_start;
        private long m_end;
        private bool m_onlyHead;
        private long m_contentLength;

        public HttpWebClient(CookieContainer cc) {
            m_cookieContainer = cc;
            m_start = 0L;
            m_end = 0L;
            m_onlyHead = false;
        }

        public void AddRange(long start, long end) {
            this.m_start = start;
            this.m_end = end;
        }

        public bool OnlyHead {
            get { return m_onlyHead; }
            set { m_onlyHead = value; }
        }

        public long ContentLength {
            get {
                return m_contentLength;
            }
        }

        protected override WebRequest GetWebRequest(Uri address) {
            var ret = base.GetWebRequest(address);
            if (ret is HttpWebRequest) {
                var req = ret as HttpWebRequest;
                req.CookieContainer = m_cookieContainer;
                req.Timeout = 5000;
                if (m_start != 0L || m_end != 0L) {
                    req.AddRange(m_start, m_end - 1);
                }
                if (m_onlyHead && req.Method.ToUpper() == "GET") {
                    req.Method = "HEAD";
                }

#if DEBUG
                foreach (string key in req.Headers) {
                    System.Console.WriteLine("> {0}={1}", key, req.Headers[key]);
                }
#endif
            }
            return ret;
        }

        protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result) {
            var ret = base.GetWebResponse(request, result);
            if (ret is HttpWebResponse) {
                var rsp = ret as HttpWebResponse;
                m_contentLength = rsp.ContentLength;

#if DEBUG
                foreach (string key in rsp.Headers) {
                    System.Console.WriteLine("< {0}={1}", key, rsp.Headers[key]);
                }
#endif
            }
            return ret;
        }
    }

    /// <summary>
    /// 通过Http协议访问服务的状态。
    /// </summary>
    public enum HttpStatus {
        /// <summary>
        /// 准备发送Http请求。
        /// </summary>
        Ready = 0,

        /// <summary>
        /// 正在发送Http请求。
        /// </summary>
        Sending = 1,

        /// <summary>
        /// 正在等待服务。
        /// </summary>
        Waiting = 2,

        /// <summary>
        /// 正在接收Http响应。
        /// </summary>
        Receiving = 3,
    }

    /// <summary>
    /// 通过Http协议实现Rpc调用的工具类。
    /// </summary>
    public static class Http {
        private static CookieContainer m_cookieContainer = new CookieContainer();

        private static ILog m_log = LogManager.GetLogger(typeof(Http));

        private static string m_baseUrl;
        private static HttpStatus m_status;
        private static int m_progress;

        private static ILog Log {
            get {
                return LogManager.GetLogger(typeof(Http));
            }
        }

        /// <summary>
        /// 获取或者设置Rpc请求的基础地址。
        /// </summary>
        public static string BaseUrl {
            get {
                if (m_baseUrl == null) {
                    throw new InvalidOperationException("value of BaseUri has not been set");
                } else {
                    return m_baseUrl;
                }
            }
            set {
                if (String.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("value cannot be null or empty");
                } else {
                    value = value.Trim();
                    m_baseUrl = value.EndsWith("/") ? value.MidStr(0, -1) : value;
                }
            }
        }

        /// <summary>
        /// 当前状态。
        /// </summary>
        public static HttpStatus Status {
            get {
                return m_status;
            }
        }

        /// <summary>
        /// 当前状态的进度。
        /// </summary>
        public static int Progress {
            get {
                return m_progress;
            }
        }

        /// <summary>
        /// 使用基础地址将调用地址正规化。
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static Uri NormalUri(string url) {
            url = Commons.NotBlank(url, "url").Trim();

            var fullUrl = url.StartsWith("/") ? BaseUrl + url : BaseUrl + "/" + url;

            Uri uri;
            if (Uri.TryCreate(fullUrl, UriKind.Absolute, out uri)) {
                return uri;
            } else {
                throw new InvalidOperationException("无效的服务地址: " + url);
            }
        }

        /// <summary>
        /// 获取指定地址的资源的长度(以字节为单位)。
        /// </summary>
        /// <param name="url">请求地址。</param>
        /// <returns>资源内容的长度，如果资源不存在则返回0。</returns>
        public static async Task<long> Head(string url) {
            var uri = NormalUri(url);
            using (var client = new HttpWebClient(m_cookieContainer)) {
                m_status = HttpStatus.Receiving;

                client.OnlyHead = true;

                client.UploadProgressChanged += client_UploadProgressChanged;
                client.UploadValuesCompleted += client_UploadValuesCompleted;
                client.DownloadProgressChanged += client_DownloadProgressChanged;
                client.DownloadDataCompleted += client_DownloadDataCompleted;

                try {
                    await client.DownloadDataTaskAsync(uri);
                    return client.ContentLength;
                } catch (WebException) {
                    return 0;
                } finally {
                    m_status = HttpStatus.Ready;
                    m_progress = 0;
                }
            }
        }

        /// <summary>
        /// 从指定的地址获取包含原始数据的字节数组。如果参数start和end都是0，那么表示不指定范围。
        /// </summary>
        /// <param name="url">请求地址。</param>
        /// <param name="start">请求内容的起始偏移(从0开始)。</param>
        /// <param name="end">请求内容的终止偏移(从0开始，不包含。)</param>
        /// <returns></returns>
        public static async Task<byte[]> GetRaw(string url, long start = 0L, long end = 0L) {
            var uri = NormalUri(url);
            using (var client = new HttpWebClient(m_cookieContainer)) {
                m_status = HttpStatus.Receiving;

                client.AddRange(start, end);

                client.UploadProgressChanged += client_UploadProgressChanged;
                client.UploadValuesCompleted += client_UploadValuesCompleted;
                client.DownloadProgressChanged += client_DownloadProgressChanged;
                client.DownloadDataCompleted += client_DownloadDataCompleted;

                try {
                    return await client.DownloadDataTaskAsync(uri);
                } catch (WebException) {
                    return new byte[0];
                } finally {
                    m_status = HttpStatus.Ready;
                    m_progress = 0;
                }
            }
        }

        /// <summary>
        /// 向指定的地址上传数据
        /// </summary>
        /// <param name="url">请求地址。</param>
        /// <param name="data">参数。</param>
        /// <returns>上传的响应。</returns>
        public static async Task<IResult> PostRaw(string url, byte[] data, IDictionary<string, object> d = null) {
            var uri = NormalUri(url);
            using (var client = new HttpWebClient(m_cookieContainer)) {
                m_status = HttpStatus.Receiving;

                client.UploadProgressChanged += client_UploadProgressChanged;
                client.UploadValuesCompleted += client_UploadValuesCompleted;
                client.DownloadProgressChanged += client_DownloadProgressChanged;
                client.DownloadDataCompleted += client_DownloadDataCompleted;

                try {
                    var content = Encoding.UTF8.GetString(await client.UploadDataTaskAsync(uri, "POST", data));
                    return ToResult(content);
                } catch (WebException ex) {
                    return new JsonResult(new RpcException(ex.Response, ex));
                } finally {
                    m_status = HttpStatus.Ready;
                    m_progress = 0;
                }
            }
        }

        private struct FileRange {
            private long start;
            private long end;
            private long total;

            public FileRange(long start, long end, long total) {
                this.start = start;
                this.end = end;
                this.total = total;
            }

            public long Start { get { return start; } }
            public long End { get { return end; } }
            public long Total { get { return total; } }
            public bool Valid { get { return total > 0L; } }
        }

        private static FileRange ParseFileRange(string range) {
            range = range.TrimStr();
            if (range.StartsWith("bytes", StringComparison.OrdinalIgnoreCase)) {
                range = range.Substring(5).Trim();
            }
            if (range.Length == 0L) {
                return new FileRange(0, 0, 0);
            } else {
                long start;
                long end;
                long total;

                var pt = range.IndexOf('/');
                if (pt == -1) {
                    return new FileRange(0, 0, 0);
                }

                total = range.Substring(pt + 1).ToInt64();
                range = range.Substring(0, pt);

                if (range.StartsWith("-")) {
                    // bytes=-num
                    start = 0L;
                    end = range.Substring(1).ToInt64();
                } else if (range.EndsWith("-")) {
                    // bytes=num-
                    start = range.LeftStr(-1).ToInt64();
                    end = int.MaxValue;
                } else if (range.Contains("-")) {
                    // bytes=num1-num2
                    var p = range.IndexOf('-');
                    start = range.Substring(0, p).ToInt64();
                    end = range.Substring(p + 1).ToInt64();
                } else {
                    // bytes=XXXX
                    start = range.ToInt64();
                    end = 0L;
                }

                return new FileRange(start, end, total);
            }
        }

        /// <summary>
        /// 从指定的地址获取包装为JSON对象的响应结果。
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task<IResult> Get(string url, IDictionary<string, object> data = null) {
            var uri = NormalUri(url);
            using (var client = new HttpWebClient(m_cookieContainer)) {
                m_status = HttpStatus.Receiving;

                client.UploadProgressChanged += client_UploadProgressChanged;
                client.UploadValuesCompleted += client_UploadValuesCompleted;
                client.DownloadProgressChanged += client_DownloadProgressChanged;
                client.DownloadDataCompleted += client_DownloadDataCompleted;

                client.Headers.Set("Accept", "application/json");
                client.QueryString = UrlEncode(ToNameValueCollection(data));

                if (client.QueryString != null) {
                    Log.DebugFormat("params = {{{0}}}", string.Join(", ", client.QueryString.AllKeys
                        .Select(_ => string.Format("{0}:{1}", _, client.QueryString[_]))));
                }
                Log.DebugFormat("receiving data from: {0}", uri);
                try {
                    var content = Encoding.UTF8.GetString(await client.DownloadDataTaskAsync(uri));
                    return ToResult(content);
                } catch (WebException ex) {
                    return new JsonResult(new RpcException(ex.Response, ex));
                } finally {
                    m_status = HttpStatus.Ready;
                    m_progress = 0;
                }
            }
        }

        /// <summary>
        /// 从指定的地址获取包装为JSON对象的响应结果。
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task<IResult> Post(string url, IDictionary<string, object> data = null) {
            return await Execute(url, "POST", data);
        }

        /// <summary>
        /// 从指定的地址获取包装为JSON对象的响应结果。
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task<IResult> Put(string url, IDictionary<string, object> data = null) {
            return await Execute(url, "PUT", data);
        }

        /// <summary>
        /// 从指定的地址获取包装为JSON对象的响应结果。
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task<IResult> Delete(string url, IDictionary<string, object> data = null) {
            return await Execute(url, "DELETE", data);
        }

        /// <summary>
        /// 从指定的地址获取包装为JSON对象的响应结果。
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private static async Task<IResult> Execute(string url, string method, IDictionary<string, object> data = null) {
            var uri = NormalUri(url);
            method = Commons.NotBlank(method, "method").Trim().ToUpper();
            using (var client = new HttpWebClient(m_cookieContainer)) {
                try {
                    client.Headers.Set("Accept", "application/json");
                    Log.DebugFormat("sending data to: {0}", uri);
                    m_status = HttpStatus.Sending;

                    client.UploadProgressChanged += client_UploadProgressChanged;
                    client.UploadValuesCompleted += client_UploadValuesCompleted;
                    client.DownloadProgressChanged += client_DownloadProgressChanged;
                    client.DownloadDataCompleted += client_DownloadDataCompleted;

                    var content = Encoding.UTF8.GetString(
                        await client.UploadValuesTaskAsync(uri, method, ToNameValueCollection(data)));
                    Log.DebugFormat("received data: {0}", content);
                    return ToResult(content);
                } catch (WebException ex) {
                    return new JsonResult(new RpcException(ex.Response, ex));
                } finally {
                    m_status = HttpStatus.Ready;
                    m_progress = 0;
                }
            }
        }

        static void client_UploadProgressChanged(object sender, UploadProgressChangedEventArgs e) {
            m_status = HttpStatus.Sending;
            m_progress = e.ProgressPercentage;
        }

        static void client_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e) {
            m_status = HttpStatus.Waiting;
        }

        static void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            m_status = HttpStatus.Receiving;
            m_progress = e.ProgressPercentage;
        }

        static void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e) {
            m_status = HttpStatus.Ready;
        }

        private static NameValueCollection ToNameValueCollection(IDictionary<string, object> data) {
            var ret = new NameValueCollection();
            if (data != null) {
                foreach (var item in data) {
                    if (item.Value == null) {
                        // nothing
                    } else if (item.Value is string || item.Value is StringBuilder) {
                        var s = item.Value.ToString();
                        if (!string.IsNullOrEmpty(s)) {
                            ret[item.Key] = s;
                        }
                    } else if (item.Value is DateTime) {
                        var dt = (DateTime)item.Value;
                        ret.Add(item.Key, Commons.ToTimestamp(dt).ToString());
                    } else if (item.Value is decimal) {
                        var dec = (decimal)item.Value;
                        ret.Add(item.Key, dec.ToString("#0.00"));
                    } else if (item.Value is bool) {
                        ret.Add(item.Key, (bool)item.Value ? "true" : "false");
                    } else {
                        ret.Add(item.Key, item.Value.ToString());
                    }
                }
            }
            foreach (var r in ret.AllKeys) {
                System.Console.WriteLine(r + ":" + ret[r]);
            }
            return ret;
        }

        /// <summary>
        /// Get服务时，没有自动转换，需要手动将数据进行转换
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        private static NameValueCollection UrlEncode(NameValueCollection src) {
            var ret = new NameValueCollection();
            if (src != null) {
                foreach (var key in src.AllKeys) {
                    var value = src[key];
                    ret[UrlEncode(key)] = UrlEncode(value);
                }
            }
            return ret;
        }

        /// <summary>
        /// 将"+"转换成"%2B"
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        private static String UrlEncode(string src) {
            if (!String.IsNullOrWhiteSpace(src)) {
                return src.Replace("+", "%2B");
            } else {
                return src;
            }
        }

        /// <summary>
        /// 将JSON格式的响应结果包装为Rpc调用结果。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static IResult ToResult(string s) {
            return new JsonResult(s.TrimStr());
        }
    }
}
