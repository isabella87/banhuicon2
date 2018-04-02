using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;


namespace Banhuitong.Console.Account {
    using CustomAttribute;
    public static class InvestOrgs {
        [Jurisdiction("账户管理", "机构账户", "查询平台用户列表", "20490")]
        public static async Task<IResult> GetAllOrgs(IDictionary<string, object> data) {
            return await Http.Get("/mgr/account/orgs", data);
        }

        [Jurisdiction("账户管理", "机构账户", "查询账户详细信息", "20491")]
        public static async Task<IResult> Account(long auId) {
            return await Http.Get("/mgr/account/orgs/" + auId);
        }

        [Jurisdiction("账户管理", "机构账户", "更新账户基本信息", "20493")]
        public static async Task<IResult> UpdateInfo(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Post("/mgr/account/orgs/" + auId + "/user-info", data);
        }

        [Jurisdiction("账户管理", "机构账户", "查询银行账户信息", "20492")]
        public static async Task<IResult> BankInfo(long auId) {
            return await Http.Get("/mgr/account/orgs/" + auId + "/jx-userinfo");
        }

        [Jurisdiction("账户管理", "机构账户", "确认开户", "20494")]
        public static async Task<IResult> UpdateRegistry(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Post("/mgr/account/orgs/" + auId + "/registry", data);
        }

    }
}
