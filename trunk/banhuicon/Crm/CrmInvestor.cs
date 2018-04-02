using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;

namespace Banhuitong.Console.Crm {
    using CustomAttribute;
    public static class CrmInvestor {
        #region 跟进客户关系管理权限设置
        [Jurisdiction("客户关系管理", "跟进客户关系管理", "查询跟进客户列表", "20401")]
        public static async Task<IResult> GetAccounts(IDictionary<string, object> data) {
            return await Http.Get("/crm/track-investors", data);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "创建跟进客户", "20402")]
        public static async Task<IResult> Create(IDictionary<string, object> data) {
            return await Http.Put("/crm/track-investors", data);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "更新跟进客户详细信息", "20403")]
        public static async Task<IResult> Update(IDictionary<string, object> data) {
            var ciId = data.Take<long>("ci-id");
            return await Http.Post("/crm/track-investors/" + ciId, data);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "删除跟进客户", "20404")]
        public static async Task<IResult> DelAccount(long ciId) {
            return await Http.Delete("/crm/track-investors/" + ciId);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "查询跟进客户详细信息", "20407")]
        public static async Task<IResult> Account(long id) {
            if (id == 0) {
                return new LocalResult(new { realName = "[新投资人]", prLevel = 1 });
            } else
                return await Http.Get("/crm/track-investors/" + id + "/investor");
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "跟进客户客户经理分配", "20501")]
        public static async Task<IResult> BindMgr(IDictionary<string, object> data) {
            var ciId = data.Take<long>("ci-id");
            return await Http.Post("/crm/track-investors/" + ciId + "/rebind", data);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "批量分配跟进客户客户经理", "20501")]
        public static async Task<IResult> BatchBindMgrAndCrmInvestor(IDictionary<string, object> data) {
            var realName = data.Take<string>("realName");
            var mobile = data.Take<string>("mobile");
            return await Http.Post("/crm/track-investors/" + realName + "(" + mobile + ")/bind", data);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "取消跟进客户分配的客户经理", "20501")]
        public static async Task<IResult> UnBindMgr(long id) {
            return await Http.Post("/crm/track-investors/" + id + "/unbind");
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "查询跟踪客户的历史分配客户经理", "20501")]
        public static async Task<IResult> GetHistoryMgrs(long id) {
            return await Http.Get("/crm/track-investors/" + id + "/cm/history");
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "根据手机号查询用户注册AUID", "20406")]
        public static async Task<IResult> GetAuIdOfAccount(long ciId) {
            return await Http.Get("/crm/track-investors/" + ciId + "/auId");
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "查询跟进客户跟进信息", "20502")]
        public static async Task<IResult> Remarks(long ciId) {
            return await Http.Get("/crm/track-investors/" + ciId + "/remarks");
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "创建跟进客户跟进信息", "20502")]
        public static async Task<IResult> SaveRemark(long ciId, IDictionary<string, object> data) {
            return await Http.Put("/crm/track-investors/" + ciId + "/remarks", data);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "修改跟进客户手机号", "20405")]
        public static async Task<IResult> ChangeMobile(IDictionary<string, object> data) {
            var ciId = data.Take<long>("ci-id");
            return await Http.Post("/crm/track-investors/mobile/" + ciId, data);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "查询我的跟进客户列表信息", "20502")]
        public static async Task<IResult> MyInvestors(IDictionary<string, object> data) {
            return await Http.Get("/crm/track-investors/my", data);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "查询工作任务中已跟进的跟进情况", "20502")]
        public static async Task<IResult> GetInvestorByStatus(IDictionary<string, object> data) {
            return await Http.Get("/crm/track-investors/my-task", data);
        }

        [Jurisdiction("客户关系管理", "跟进客户关系管理", "查询工作任务中已完成工作任务的数量", "20502")]
        public static async Task<IResult> GetNumInStatus(IDictionary<string, object> data) {
            return await Http.Get("/crm/track-investors/my-task-count", data);
        }

        #endregion

        #region 查询分配注册客户列表权限设置
        [Jurisdiction("客户关系管理", "注册客户关系管理", "查询分配注册客户列表", "20701")]
        public static async Task<IResult> RegUsers(IDictionary<string, object> data) {
            return await Http.Get("/crm/reg-investors/relations", data);
        }

        [Jurisdiction("客户关系管理", "注册客户关系管理", "分配注册客户", "20704")]
        public static async Task<IResult> CreateAssignOfRegUser(IDictionary<string, object> data) {
            return await Http.Post("/crm/reg-investors/assign", data);
        }

        [Jurisdiction("客户关系管理", "注册客户关系管理", "快速重新分配注册客户", "20703")]
        public static async Task<IResult> BindMgrWithRegUser(IDictionary<string, object> data) {
            return await Http.Post("/crm/reg-investors/bind", data);
        }

        [Jurisdiction("客户关系管理", "注册客户关系管理", "查询客户历史客户经理绑定记录", "20704")]
        public static async Task<IResult> GetHistoryMgrsOfRegUser(long id) {
            return await Http.Get("/crm/reg-investors/" + id + "/history-relations");
        }

        #region 权限ID同为20424
        [Jurisdiction("客户关系管理", "注册客户关系管理", "查询我的注册客户列表", "20702")]
        public static async Task<IResult> MyRegUsers(IDictionary<string, object> data) {
            return await Http.Get("/crm/reg-investors/my", data);
        }

        public static async Task<IResult> MyRegUserDetail(long id, IDictionary<string, object> data) {
            return await Http.Get("/crm/reg-investors/" + id, data);
        }
        #endregion

        [Jurisdiction("客户关系管理", "注册客户关系管理", "查询新增注册用户列表", "20503")]
        public static async Task<IResult> GetNewRegs(IDictionary<string, object> data) {
            return await Http.Get("/crm/reg-investors/new-regs", data);
        }

        [Jurisdiction("客户关系管理", "注册客户关系管理", "查询三部超时注册用户列表", "20507")]
        public static async Task<IResult> GetInvestors3TimeOut() {
            return await Http.Get("/crm/statistic/reassigned");
        }

        [Jurisdiction("客户关系管理", "注册客户关系管理", "查询三部转二部注册用户列表", "20506")]
        public static async Task<IResult> GetInvestors3To2() {
            return await Http.Get("/crm/statistic/transferred");
        }

        [Jurisdiction("客户关系管理", "注册客户关系管理", "查询二部转一部注册用户列表", "20505")]
        public static async Task<IResult> GetInvestors2To1() {
            return await Http.Get("/crm/statistic/upgraded");
        }
        #endregion

        #region 客户经理模块基础操作权限设置
        [Jurisdiction("客户经理管理", "基础操作", "查看客户经理层级树", "20931")]
        public static async Task<IResult> GetAllRelations(IDictionary<string, object> data) {
            return await Http.Get("/crm/cm/all-relations", data);
        }

        [Jurisdiction("客户经理管理", "基础操作", "添加", "20430")]
        public static async Task<IResult> CreateManager(IDictionary<string, object> data) {
            return await Http.Put("/crm/cm", data);
        }

        [Jurisdiction("客户经理管理", "基础操作", "编辑", "20432")]
        public static async Task<IResult> UpdateManager(IDictionary<string, object> data) {
            var uname = data.Take<string>("u-name");
            return await Http.Post("/crm/cm/" + uname, data);
        }

        [Jurisdiction("客户经理管理", "基础操作", "删除", "20433")]
        public static async Task<IResult> DeleteManager(string name) {
            return await Http.Delete("/crm/cm/" + name);
        }

        [Jurisdiction("客户经理管理", "基础操作", "指定上级", "20434")]
        public static async Task<IResult> MoveManager(IDictionary<string, object> data) {
            var uname = data.Take<string>("u-name");
            return await Http.Post("/crm/cm/" + uname + "/position", data);
        }

        [Jurisdiction("客户经理管理", "基础操作", "查询", "20435")]
        public static async Task<IResult> GetManager(string name) {
            return await Http.Get("/crm/cm/" + name);
        }

        [Jurisdiction("客户经理管理", "基础操作", "修改编号", "20436")]
        public static async Task<IResult> EditRCode(IDictionary<string, object> data) {
            var name = data.Take<string>("u-name");
            return await Http.Post("/crm/cm/" + name + "/r-code", data);
        }

        #endregion

    }
}
