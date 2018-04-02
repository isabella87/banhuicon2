using System;
using System.Collections.Generic;

namespace Banhuitong.Console.Rpc {
    /// <summary>
    /// Rpc调用的返回结果
    /// </summary>
    public interface IResult {
        /// <summary>
        /// 该调用的返回结果是否正常。
        /// </summary>
        bool IsOk { get; }

        /// <summary>
        /// 该调用过程中出现的异常。
        /// </summary>
        RpcException Exception { get; }

        /// <summary>
        /// 将调用的返回结果转化为整数。
        /// </summary>
        int AsInt { get; }

        /// <summary>
        /// 
        /// </summary>
        long AsLong { get; }

        /// <summary>
        /// 
        /// </summary>
        decimal AsDecimal { get; }

        /// <summary>
        /// 
        /// </summary>
        DateTime AsDateTime { get; }

        /// <summary>
        /// 
        /// </summary>
        string AsString { get; }

        /// <summary>
        /// 
        /// </summary>
        bool AsBoolean { get; }

        /// <summary>
        /// 
        /// </summary>
        IDictionary<string, object> AsDictionary { get; }

        /// <summary>
        /// 
        /// </summary>
        IList<object> AsList { get; }

        /// <summary>
        /// 
        /// </summary>
        IList<IDictionary<string, object>> AsDictList { get; }

        /// <summary>
        /// 
        /// </summary>
        IDictionary<string, IList<IDictionary<string, object>>> AsDictListDict { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class LocalResult : IResult {
        private IDictionary<string, object> m_data;

        /// <summary>
        /// 构造一个空白结果。
        /// </summary>
        public LocalResult() {
            m_data = new Dictionary<string, object>(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public LocalResult(IDictionary<string, object> data) {
            m_data = data != null ? data : new Dictionary<string, object>(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public LocalResult(object data) {
            var d = new Dictionary<string, object>();
            if (data != null) {
                foreach (var p in data.GetType().GetProperties()) {
                    d[p.Name] = p.GetValue(data);
                }
            }

            m_data = d;
        }

        public bool IsOk {
            get {
                return true;
            }
        }

        public RpcException Exception {
            get {
                return null;
            }
        }

        public int AsInt {
            get { return 0; }
        }

        public long AsLong {
            get { return 0L; }
        }

        public decimal AsDecimal {
            get { return 0M; }
        }

        public DateTime AsDateTime {
            get { return DateTime.MinValue; }
        }

        public string AsString {
            get { return ""; }
        }

        public bool AsBoolean {
            get { return false; }
        }

        public IDictionary<string, object> AsDictionary {
            get { return m_data; }
        }

        public IList<object> AsList {
            get { return new List<object>(0); }
        }

        /// <summary>
        /// 
        /// </summary>
        public IList<IDictionary<string, object>> AsDictList {
            get {
                return new List<IDictionary<string, object>>(0);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, IList<IDictionary<string, object>>> AsDictListDict {
            get {
                return new Dictionary<string, IList<IDictionary<string, object>>>();
            }
        }
    }
}
