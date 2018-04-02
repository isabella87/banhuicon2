using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Account {
    using CustomAttribute;
    public static class DataStatistic {
        #region 日数据统计
        [Jurisdiction("数据统计", "平台基础数据统计", "日数据统计", "80901")]
        public static async Task<IResult> DailyStatistic1(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/1-daily", data);
        }

        public static async Task<IResult> DailyStatistic2(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/2-daily", data);
        }

        public static async Task<IResult> DailyStatistic3(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/3-daily", data);
        }

        public static async Task<IResult> DailyStatistic4(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/4-daily", data);
        }

        public static async Task<IResult> DailyStatistic5(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/5-daily", data);
        }
        #endregion

        #region 月数据统计
        [Jurisdiction("数据统计", "平台基础数据统计", "月数据统计", "80902")]
        public static async Task<IResult> MonthStatistic1(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/1-month", data);
        }

        public static async Task<IResult> MonthStatistic2(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/2-month", data);
        }

        public static async Task<IResult> MonthStatistic3(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/3-month", data);
        }

        public static async Task<IResult> MonthStatistic4(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/4-month", data);
        }

        public static async Task<IResult> MonthStatistic5(IDictionary<string, object> data) {
            return await Http.Get("/mgr/statistic/5-month", data);
        }
        #endregion

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
