using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.BaseData {
    using CustomAttribute;
    public static class PrjGuaranteePers {
        [Jurisdiction("项目基础数据", "担保人", "查询列表", "80061")]
        public static async Task<IResult> GetGuarantees(IDictionary<string, object> data) {
            return await Http.Get("/mgr/ba/prj-guarantee-persons", data);
        }

        [Jurisdiction("项目基础数据", "担保人", "创建", "80062")]
        public static async Task<IResult> Create(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Put("/mgr/ba/prj-guarantee-persons", data);
        }

        [Jurisdiction("项目基础数据", "担保人", "更新", "80063")]
        public static async Task<IResult> Update(IDictionary<string, object> data) {
            var bgpId = data.Take<long>("bgp-id");
            return await Http.Post("/mgr/ba/prj-guarantee-persons/" + bgpId, data);
        }

        [Jurisdiction("项目基础数据", "担保人", "删除", "80064")]
        public static async Task<IResult> Delete(long bgoId) {
            if (bgoId != 0) {
                return await Http.Delete("/mgr/ba/prj-guarantee-persons/" + bgoId);
            } else {
                return new LocalResult();
            }
        }

        [Jurisdiction("项目基础数据", "担保人", "查询详情", "80065")]
        public static async Task<IResult> GetGuarantee(long bgoId) {
            if (bgoId == 0) {
                return new LocalResult(new { name = "[新担保人]" });
            } else {
                return await Http.Get("/mgr/ba/prj-guarantee-persons/" + bgoId);
            }
        }

    }
}
