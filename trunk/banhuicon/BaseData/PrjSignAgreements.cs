using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console.BaseData {
    using CustomAttribute;
    public static class PrjSignAgreements {
        public static readonly TextValues IDTypes;
        public static readonly TextValues CertTypes;
        public static readonly TextValues SIGN_STATUS;

        static PrjSignAgreements() {
            IDTypes = new TextValues()
            .AddNew("XY", "社会信用号码")
            .AddNew("SF", "身份证号码");

            CertTypes = new TextValues()
            .AddNew("1", "UKey保存证书")
            .AddNew("2", "快捷签证书")
            .AddNew("3", "CA保存证书");

            SIGN_STATUS = new TextValues()
            .AddNew("未签章", -1)
            .AddNew("拒绝签署", 0)
            .AddNew("已签章", 1);
        }

        [Jurisdiction("项目", "项目协议", "查询", "60110")]
        public static Task<IResult> GetPrjAgreement(long pid) {
            return Http.Get("/protocol/" + pid + "/prj");
        }

        [Jurisdiction("项目", "项目协议", "查看借款人签章信息", "60111")]
        public static Task<IResult> GetSignInfo(long pId) {
            return Http.Get("/protocol/" + pId + "/borrower-sign-info");
        }

        [Jurisdiction("项目", "项目协议", "生成并上传", "60112")]
        public static Task<IResult> UploadPrjAgreements(IDictionary<string, object> data) {
            return Http.Post("/protocol", data);
        }

        //[Jurisdiction("项目", "项目协议", "清空协议", "60112")]
        public static Task<IResult> deleteAgreements(IDictionary<string, object> data) {
            return Http.Delete("/protocol", data);
        }

        [Jurisdiction("项目", "项目协议", "签章", "60113")]
        public static Task<IResult> SignPrjAgreements(IDictionary<string, object> data) {
            return Http.Post("/protocol/sign", data);
        }

        [Jurisdiction("项目", "项目协议", "核查签章", "60115")]
        public static Task<IResult> CheckAgreements(IDictionary<string, object> data) {
            return Http.Post("/protocol/check-download", data);
        }

        [Jurisdiction("项目", "项目协议", "获取签章人信息", "60116")]
        public static Task<IResult> GetSignerInfoAgreements(IDictionary<string, object> data) {
            return Http.Get("/protocol/signer-ca-info", data);
        }

        [Jurisdiction("项目", "强制债权转让协议", "查询", "60114")]
        public static Task<IResult> GetDebtAgreements(long pid) {
            return Http.Get("/protocol/" + pid + "/force-credit-prj");
        }

        [Jurisdiction("项目", "强制债权转让协议", "上传强制债权转让协议", "60117")]
        public static Task<IResult> UploadDebtAgreements(IDictionary<string, object> data) {
            return Http.Post("/protocol/force-credit-upload", data);
        }

        [Jurisdiction("项目", "强制债权转让协议", "强制债权转让签章", "60118")]
        public static Task<IResult> SignDebtAgreements(IDictionary<string, object> data) {
            return Http.Post("/protocol/force-credit-sign", data);
        }

        [Jurisdiction("项目", "强制债权转让协议", "查看债权人签章信息", "60119")]
        public static Task<IResult> GetCreditorInfo(long pId) {
            return Http.Get("/protocol/" + pId + "/credit-account-sign-info");
        }

    }
}
