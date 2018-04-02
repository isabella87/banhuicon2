using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.BaseData {
    using CustomAttribute;
    public static class PrjCtors {
        [Jurisdiction("项目基础数据", "施工单位", "查询列表", "80021")]
        public static async Task<IResult> GetAll(IDictionary<string, object> data) {
            return await Http.Get("/mgr/ba/prj-ctors", data);
        }

        [Jurisdiction("项目基础数据", "施工单位", "创建", "80022")]
        public static async Task<IResult> Create(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Put("/mgr/ba/prj-ctors", data);
        }

        [Jurisdiction("项目基础数据", "施工单位", "更新", "80023")]
        public static async Task<IResult> Update(IDictionary<string, object> data) {
            var bcoId = data.Take<long>("bco-id");
            return await Http.Post("/mgr/ba/prj-ctors/" + bcoId, data);
        }

        [Jurisdiction("项目基础数据", "施工单位", "删除", "80024")]
        public static async Task<IResult> Delete(long bcoId) {
            if (bcoId != 0) {
                return await Http.Delete("/mgr/ba/prj-ctors/" + bcoId);
            } else {
                return new LocalResult();
            }
        }

        [Jurisdiction("项目基础数据", "施工单位", "查询详情", "80025")]
        public static async Task<IResult> GetCtor(long m_bcoId) {
            if (m_bcoId == 0) {
                return new LocalResult(new { name = "[新施工单位]" });
            } else {
                return await Http.Get("/mgr/ba/prj-ctors/" + m_bcoId);
            }
        }

    }

}
