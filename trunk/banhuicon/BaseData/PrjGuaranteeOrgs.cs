using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.BaseData {
    using CustomAttribute;
    public static class PrjGuaranteeOrgs {
        [Jurisdiction("项目基础数据", "担保机构", "查询列表", "80041")]
        public static async Task<IResult> GetGuarantees(IDictionary<string, object> data) {
            return await Http.Get("/mgr/ba/prj-guarantee-orgs", data);
        }

        [Jurisdiction("项目基础数据", "担保机构", "创建", "80042")]
        public static async Task<IResult> Create(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Put("/mgr/ba/prj-guarantee-orgs", data);
        }

        [Jurisdiction("项目基础数据", "担保机构", "更新", "80043")]
        public static async Task<IResult> Update(IDictionary<string, object> data) {
            var bgoId = data.Take<long>("bgo-id");
            return await Http.Post("/mgr/ba/prj-guarantee-orgs/" + bgoId, data);
        }

        [Jurisdiction("项目基础数据", "担保机构", "删除", "80044")]
        public static async Task<IResult> Delete(long bgoId) {
            if (bgoId != 0) {
                return await Http.Delete("/mgr/ba/prj-guarantee-orgs/" + bgoId);
            } else {
                return new LocalResult();
            }
        }

        [Jurisdiction("项目基础数据", "担保机构", "查询详情", "80045")]
        public static async Task<IResult> GetGuarantee(long bgoId) {
            if (bgoId == 0) {
                return new LocalResult(new { name = "[新担保机构]" });
            } else {
                return await Http.Get("/mgr/ba/prj-guarantee-orgs/" + bgoId);
            }
        }



    }
}
