using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Account {
    using CustomAttribute;
    public static class Messages {
        [Jurisdiction("消息管理", "平台消息", "查询消息列表", "20630")]
        public static async Task<IResult> GetMessages(IDictionary<string, object> data) {
            return await Http.Get("/mgr/account/msg", data);
        }

        [Jurisdiction("消息管理", "平台消息", "查询消息详情", "20631")]
        public static async Task<IResult> GetMessage(long amId) {
            if (amId == 0) {
                return new LocalResult(new {
                    loginName = "[新收件人]"
                });
            } else {
                return await Http.Get("/mgr/account/msg/" + amId);
            }
        }

        [Jurisdiction("消息管理", "平台消息", "查询消息接收人信息", "20632")]
        public static async Task<IResult> MatchInvest(IDictionary<string, object> data) {
            return await Http.Get("/mgr/account/invest/persons/matches", data);
        }

        [Jurisdiction("消息管理", "平台消息", "创建消息", "20633")]
        public static async Task<IResult> SaveMessage(IDictionary<string, object> data) {
            return await Http.Put("/mgr/account/msg", data);
        }

        [Jurisdiction("消息管理", "亿美短信", "短信列表查询", "20640")]
        public static async Task<IResult> GetYiMeiMessages(IDictionary<string, object> data) {
            return await Http.Get("/mgr/ym", data);
        }
    }
}
