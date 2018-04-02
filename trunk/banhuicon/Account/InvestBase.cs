using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Account {
    using CustomAttribute;
    public static class InvestBase {
        [Jurisdiction("账户管理", "基础功能", "充值指令", "20466")]
        public static async Task<IResult> Recharges(Dictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/" + auId + "/jx-recharge", data);
        }

        [Jurisdiction("账户管理", "基础功能", "提现指令", "20467")]
        public static async Task<IResult> WithDraws(Dictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/" + auId + "/jx-withdraw", data);
        }

        [Jurisdiction("账户管理", "基础功能", "投标指令", "20468")]
        public static async Task<IResult> Tenders(Dictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/" + auId + "/jx-tender", data);
        }

        [Jurisdiction("账户管理", "基础功能", "买入债权指令", "20469")]
        public static async Task<IResult> CreditIns(Dictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/" + auId + "/jx-credit-assign", data);
        }

        [Jurisdiction("账户管理", "基础功能", "投资月报", "20470")]
        public static async Task<IResult> MonthReports(long auId) {
            return await Http.Get("/mgr/account/" + auId + "/month-reports");
        }

        [Jurisdiction("账户管理", "基础功能", "查看投标记录存管", "20471")]
        public static async Task<IResult> InvestDepository(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/third-user-info/" + auId + "/credit-detail", data);
        }

        [Jurisdiction("账户管理", "基础功能", "查看投标记录平台", "20472")]
        public static async Task<IResult> InvestPlatform(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/" + auId + "/ts-tender", data);
        }

        [Jurisdiction("账户管理", "基础功能", "查询用户借款记录", "20473")]
        public static async Task<IResult> GetBorrows(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/borrow/" + auId + "/borrows", data);
        }

        [Jurisdiction("账户管理", "基础功能", "设置允许/禁止用户投资", "20475")]
        public static async Task<IResult> AllowInvest(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Post("/mgr/account/invest/" + auId + "/invest-certification", data);
        }

        [Jurisdiction("账户管理", "基础功能", "设置允许/禁止用户借款", "20477")]
        public static async Task<IResult> AllowBorrow(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Post("/mgr/account/borrow/" + auId + "/borrow-certification", data);
        }

        [Jurisdiction("账户管理", "基础功能", "查询收支明细存管", "20479")]
        public static async Task<IResult> Runnings(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/third-user-info/" + auId + "/funds-details-latest", data);
        }

        [Jurisdiction("账户管理", "基础功能", "查询收支明细平台", "20480")]
        public static async Task<IResult> HistoryRunnings(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/third-user-info/" + auId + "/history-funds-detail", data);
        }

        [Jurisdiction("账户管理", "基础功能", "查询用户历史投资明细", "20481")]
        public static async Task<IResult> HistoryInvest(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/invest/" + auId + "/history-invests", data);
        }

        [Jurisdiction("账户管理", "基础功能", "查询银行流水", "20484")]
        public static async Task<IResult> BankRunnings(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Get("/mgr/account/third-user-info/" + auId + "/bank-all-funds-detail", data);
        }

        [Jurisdiction("账户管理", "基础功能", "解锁/锁定用户账户", "20482")]
        public static async Task<IResult> Unlock(IDictionary<string, object> data) {
            var auId = data.Take<long>("au-id");
            return await Http.Post("/mgr/account/" + auId + "/lock", data);
        }
    }
}
