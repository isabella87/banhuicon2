using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Banhuitong.Console.BaseData {
    using Rpc;

    public static class BorrowPersons {
        public static async Task<IResult> GetAll(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Get("/mgr/ba/prj-mgrs", data);
        }

        public static async Task<IResult> GetById(long bpmId) {
            if (bpmId == 0) {
                return new LocalResult(new {
                    realName = "[新借款人]"
                });
            } else {
                return await Http.Get("/mgr/ba/prj-mgrs/" + bpmId);
            }
        }

        public static async Task<IResult> Save(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            var bpmId = data.Take<long>("bpmId");
            if (bpmId == 0) {
                // 创建
                return await Http.Put("/mgr/ba/prj-mgrs", data);
            } else {
                // 更新
                return await Http.Post("/mgr/ba/prj-mgrs/" + bpmId, data);
            }
        }

        public static async Task<IResult> Delete(long bpmId) {
            if (bpmId != 0) {
                return await Http.Delete("/mgr/ba/prj-mgrs/" + bpmId);
            } else {
                return new LocalResult();
            }
        }
    }
}
