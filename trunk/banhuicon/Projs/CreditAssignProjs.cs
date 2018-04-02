using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Projs {
    using CustomAttribute;
    public static class CreditAssignProjs {
        [Jurisdiction("债权项目", "基础操作", "查询债权项目列表", "60160")]
        public static async Task<IResult> GetAllPrjs(IDictionary<string, object> data) {
            return await Http.Get("/mgr/prj/credit-assign", data);
        }

        [Jurisdiction("债权项目", "基础操作", "提前撤销转让中的债权项目", "60163")]
        public static async Task<IResult> CancelProj(long pId) {
            return await Http.Post("/mgr/prj/credit-assign/" + pId);
        }

    }
}
