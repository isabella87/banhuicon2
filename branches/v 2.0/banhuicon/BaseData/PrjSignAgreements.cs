using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.BaseData {
    using CustomAttribute;
    public static class PrjSignAgreements {
        [Jurisdiction("项目", "项目协议", "查询", "60110")]
        public static Task<IResult> GetAgreement(long pid) {
            return Http.Get("/protocol/" + pid + "/prj");
        }

        [Jurisdiction("项目", "项目协议", "查看借款人签章信息", "60111")]
        public static Task<IResult> GetSignInfo(long pId) {
            return Http.Get("/protocol/" + pId + "/borrower-sign-info");
        }

        [Jurisdiction("项目", "项目协议", "生成并上传", "60112")]
        public static Task<IResult> UploadAgreements(IDictionary<string, object> data) {
            return Http.Post("/protocol/upload", data);
        }

        [Jurisdiction("项目", "项目协议", "签章", "60113")]
        public static Task<IResult> SignAgreements(IDictionary<string, object> data) {
            return Http.Post("/protocol/sign", data);
        }

        [Jurisdiction("项目", "项目协议", "核查签章", "60115")]
        public static Task<IResult> CheckAgreements(IDictionary<string, object> data) {
            return Http.Post("/protocol/check-download", data);
        }
    }
}
