using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Account {
    using CustomAttribute;
    public static class FreezeMoney {
        [Jurisdiction("账户管理", "冻结资金", "查询账户余额", "20474")]
        public static async Task<IResult> SearchBalance(long auId) {
            return await Http.Get("/mgr/account/third-user-info/" + auId + "/balance");
        }

        [Jurisdiction("账户管理", "冻结资金", "查询用户冻结资金列表", "20650")]
        public static async Task<IResult> FreezeDetails(Dictionary<string, object> d) {
            return await Http.Get("/mgr/trans/balance-frz", d);
        }

        [Jurisdiction("账户管理", "冻结资金", "添加冻结资金", "20651")]
        public static async Task<IResult> AddFreeze(Dictionary<string, object> d) {
            return await Http.Post("/mgr/trans/balance-frz", d);
        }

        [Jurisdiction("账户管理", "冻结资金", "解除冻结资金", "20652")]
        public static async Task<IResult> DelFreeze(Dictionary<string, object> d) {
            return await Http.Post("/mgr/trans/balance-unfrz", d);
        }
    }
}
