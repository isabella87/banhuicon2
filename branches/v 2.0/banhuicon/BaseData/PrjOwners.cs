using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.BaseData {
    using CustomAttribute;
    public static class PrjOwners {
        [Jurisdiction("项目基础数据", "项目业主", "查询列表", "80031")]
        public static async Task<IResult> GetOwners(IDictionary<string, object> data) {
            return await Http.Get("/mgr/ba/prj-owners", data);
        }

        [Jurisdiction("项目基础数据", "项目业主", "创建", "80032")]
        public static async Task<IResult> Create(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Put("/mgr/ba/prj-owners", data);
        }

        [Jurisdiction("项目基础数据", "项目业主", "更新", "80033")]
        public static async Task<IResult> Update(IDictionary<string, object> data) {
            var boId = data.Take<long>("bo-id");
            return await Http.Post("/mgr/ba/prj-owners/" + boId, data);
        }

        [Jurisdiction("项目基础数据", "项目业主", "删除", "80034")]
        public static async Task<IResult> Delete(long boId) {
            if (boId != 0) {
                return await Http.Delete("/mgr/ba/prj-owners/" + boId);
            } else {
                return new LocalResult();
            }
        }

        [Jurisdiction("项目基础数据", "项目业主", "查询详情", "80035")]
        public static async Task<IResult> GetOwner(long boId) {
            if (boId == 0) {
                return new LocalResult(new { ownerName = "[新项目业主]" });
            } else {
                return await Http.Get("/mgr/ba/prj-owners/" + boId);
            }
        }

    }
}
