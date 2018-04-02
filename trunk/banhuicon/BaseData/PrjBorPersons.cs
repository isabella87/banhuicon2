using System.Collections.Generic;
using System.Threading.Tasks;

namespace Banhuitong.Console.BaseData {
    using Rpc;
    using CustomAttribute;

    public static class PrjBorPersons {
        [Jurisdiction("项目基础数据", "借款人", "查询列表", "80011")]
        public static async Task<IResult> GetAll(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Get("/mgr/ba/prj-mgr-persons", data);
        }

        [Jurisdiction("项目基础数据", "借款人", "创建", "80012")]
        public static async Task<IResult> Create(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Put("/mgr/ba/prj-mgr-persons", data);
        }

        [Jurisdiction("项目基础数据", "借款人", "更新", "80013")]
        public static async Task<IResult> Update(IDictionary<string, object> data) {
            var bpmId = data.Take<long>("bpm-id");
            return await Http.Post("/mgr/ba/prj-mgr-persons/" + bpmId, data);
        }

        [Jurisdiction("项目基础数据", "借款人", "删除", "80014")]
        public static async Task<IResult> Delete(long bpmId) {
            if (bpmId != 0) {
                return await Http.Delete("/mgr/ba/prj-mgr-persons/" + bpmId);
            } else {
                return new LocalResult();
            }
        }

        [Jurisdiction("项目基础数据", "借款人", "查询详情", "80015")]
        public static async Task<IResult> GetById(long bpmId) {
            if (bpmId == 0) {
                return new LocalResult(new {
                    realName = "[新借款人]"
                });
            } else {
                return await Http.Get("/mgr/ba/prj-mgr-persons/" + bpmId);
            }
        }

    }
}
