using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.BaseData {
    using CustomAttribute;
    public class PrjBorOrgs {
        [Jurisdiction("项目基础数据", "借款机构", "查询列表", "80051")]
        public static async Task<IResult> GetOrgs(IDictionary<string, object> data) {
            return await Http.Get("/mgr/ba/prj-mgr-orgs", data);
        }

        [Jurisdiction("项目基础数据", "借款机构", "创建", "80052")]
        public static async Task<IResult> Create(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Put("/mgr/ba/prj-mgr-orgs", data);
        }

        [Jurisdiction("项目基础数据", "借款机构", "更新", "80053")]
        public static async Task<IResult> Update(IDictionary<string, object> data) {
            var bboId = data.Take<long>("bbo-id");
            return await Http.Post("/mgr/ba/prj-mgr-orgs/" + bboId, data);
        }

        [Jurisdiction("项目基础数据", "借款机构", "删除", "80054")]
        public static async Task<IResult> Delete(long bboId) {
            if (bboId != 0) {
                return await Http.Delete("/mgr/ba/prj-mgr-orgs/" + bboId);
            } else {
                return new LocalResult();
            }
        }

        [Jurisdiction("项目基础数据", "借款机构", "查询详情", "80055")]
        public static async Task<IResult> GetOrg(long bboId) {
            if (bboId == 0) {
                return new LocalResult(new {
                    orgName = "[新借款机构]"
                });
            } else {
                return await Http.Get("/mgr/ba/prj-mgr-orgs/" + bboId);
            }
        }

    }
}
