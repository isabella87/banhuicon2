using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Account {
    using CustomAttribute;
    public static class DataStatistic {
        [Jurisdiction("数据统计", "平台基础数据统计", "日数据统计", "80901")]
        public static async Task<IResult> DailyStatistic(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/daily", data);
        }

        [Jurisdiction("数据统计", "平台基础数据统计", "月数据统计", "80902")]
        public static async Task<IResult> MonthStatistic(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/month", data);
        }

        [Jurisdiction("数据统计", "平台基础数据统计", "第一次投资客户名单", "80903")]
        public static async Task<IResult> NewInvestorsStatistic(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/new-investors", data);
        }

        [Jurisdiction("数据统计", "平台基础数据统计", "VIP客户名单", "80904")]
        public static async Task<IResult> VipStatistic(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/vip", data);
        }

    }
}
