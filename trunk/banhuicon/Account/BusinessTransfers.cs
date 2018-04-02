using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Account {
    using CustomAttribute;
    public static class BusinessTransfers {
        [Jurisdiction("账户管理", "商户转账", "查询商户转账批次列表", "20611")]
        public static async Task<IResult> GetAll(IDictionary<string, object> data) {
            return await Http.Get("/mgr/trans/b2c-details", data);
        }

        [Jurisdiction("账户管理", "商户转账", "创建商户转账批次及备注", "20610")]
        public static async Task<IResult> SaveB2cDetail(IDictionary<string, object> data) {
            return await Http.Put("/mgr/trans/b2c-details", data);
        }

        [Jurisdiction("账户管理", "商户转账", "删除商户转账批次", "20612")]
        public static async Task<IResult> Delete(long tbdId) {
            return await Http.Delete("/mgr/trans/b2c-details/" + tbdId);
        }

        [Jurisdiction("账户管理", "商户转账", "创建商户转账明细", "20613")]
        public static async Task<IResult> SaveInvestBonus(IDictionary<string, object> data) {
            var id = data.Take<long>("tbd-id");
            return await Http.Put("/mgr/trans/b2c-details/" + id + "/mer-xfer", data);
        }

        [Jurisdiction("账户管理", "商户转账", "查询某批次商户转账明细列表", "20614")]
        public static async Task<IResult> InvestBonus(long tbdId) {
            return await Http.Get("/mgr/trans/b2c-details/" + tbdId + "/mer-xfer");
        }

        [Jurisdiction("账户管理", "商户转账", "执行某批次商户转账", "20615")]
        public static async Task<IResult> ExecuteInvestBonus(long tbdId, long id) {
            return await Http.Post("/mgr/trans/b2c-details/" + tbdId + "/mer-xfer/" + id + "/execution");
        }
    }
}
