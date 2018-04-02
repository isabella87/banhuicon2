using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;
using System.ComponentModel;

namespace Banhuitong.Console.Crm {
    using CustomAttribute;
    public static class CrmPerformance {
        [Jurisdiction("客户经理管理", "客户经理绩效", "查询日绩效统计", "20440")]
        public static async Task<IResult> GetPerformanceByDaily(IDictionary<string, object> data) {
            return await Http.Get("/crm/statistic/reg-user-daily", data);
        }

        [Jurisdiction("客户经理管理", "客户经理绩效", "查询日绩效统计客户详细列表", "20441")]
        public static async Task<IResult> GetCstmofMgrByDaily(IDictionary<string, object> data) {
            return await Http.Get("/crm/statistic/reg-users-daily", data);
        }

        [Jurisdiction("客户经理管理", "客户经理绩效", "查询月绩效统计", "20442")]
        public static async Task<IResult> GetPerformanceByMonth(IDictionary<string, object> data) {
            return await Http.Get("/crm/statistic/reg-user-month", data);
        }

        [Jurisdiction("客户经理管理", "客户经理绩效", "查询月绩效统计客户详细列表", "20443")]
        public static async Task<IResult> GetCstmofMgrByMonth(IDictionary<string, object> data) {
            return await Http.Get("/crm/statistic/reg-users-month", data);
        }
    }
}
