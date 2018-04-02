using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Account {
    using CustomAttribute;
    public static class InvestPersons {
        [Jurisdiction("账户管理", "个人账户", "查询平台用户列表", "20460")]
        public static async Task<IResult> GetAllPersons(IDictionary<string, object> data) {
            return await Http.Get("/mgr/account/persons", data);
        }

        [Jurisdiction("账户管理", "个人账户", "查询账户详细信息", "20461")]
        public static async Task<IResult> Account(long auId) {
            return await Http.Get("/mgr/account/persons/" + auId);
        }

        [Jurisdiction("账户管理", "个人账户", "查看银行账户信息", "20462")]
        public static async Task<IResult> BankInfo(long auId) {
            return await Http.Get("/mgr/account/persons/" + auId + "/jx-userinfo");
        }

        [Jurisdiction("账户管理", "个人账户", "检查银行开户", "20463")]
        public static async Task<IResult> CheckBank(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Post("/mgr/account/third-user-info/" + auId + "/check-registry", data);
        }

        [Jurisdiction("账户管理", "个人账户", "修改账户级别", "20465")]
        public static async Task<IResult> UpdateLevel(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Post("/mgr/account/" + auId + "/level", data);
        }

    }
}
