using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.BaseData {
    using CustomAttribute;
    public static class PrjEngineers {
        [Jurisdiction("项目基础数据", "工程项目", "查询列表", "80071")]
        public static async Task<IResult> GetEngineers(IDictionary<string, object> data) {
            return await Http.Get("/mgr/ba/prj-engineers", data);
        }

        [Jurisdiction("项目基础数据", "工程项目", "创建", "80072")]
        public static async Task<IResult> Create(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Put("/mgr/ba/prj-engineers", data);
        }

        [Jurisdiction("项目基础数据", "工程项目", "更新", "80073")]
        public static async Task<IResult> Update(IDictionary<string, object> data) {
            var bpeId = data.Take<long>("bpe-id");
            return await Http.Post("/mgr/ba/prj-engineers/" + bpeId, data);
        }

        [Jurisdiction("项目基础数据", "工程项目", "删除", "80074")]
        public static async Task<IResult> Delete(long bpeId) {
            if (bpeId != 0) {
                return await Http.Delete("/mgr/ba/prj-engineers/" + bpeId);
            } else {
                return new LocalResult();
            }
        }

        [Jurisdiction("项目基础数据", "工程项目", "查询详情", "80075")]
        public static async Task<IResult> GetEngineer(long bpeId) {
            if (bpeId == 0) {
                return new LocalResult(new { name = "[新工程项目]" });
            } else {
                return await Http.Get("/mgr/ba/prj-engineers/" + bpeId);
            }
        }

    }
}
