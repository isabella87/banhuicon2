using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Projs {
    using CustomAttribute;
    public static class Wyjks {
        [Jurisdiction("项目", "借款申请", "查询列表", "60150")]
        public static async Task<IResult> GetFinaciers(IDictionary<string, object> data) {
            return await Http.Get("/mgr/finacier", data);
        }

        [Jurisdiction("项目", "借款申请", "查询详细信息", "60151")]
        public static async Task<IResult> GetFinacierDetails(long fId) {
            return await Http.Get("/mgr/finacier/" + fId);
        }
    }
}
