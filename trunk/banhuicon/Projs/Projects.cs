using System.Collections.Generic;
using System.Threading.Tasks;
using Banhuitong.Console.Rpc;
using System;

namespace Banhuitong.Console.Projs {
    using CustomAttribute;
    public static class Projects {
        public enum PrjType {
            Engineer = 1, Bill = 5, Supplie = 7, Distributor = 8, Personal = 9, Enterprise = 10
        }
        public static readonly TextValues PrjProperty;
        static Projects() {
            PrjProperty = new TextValues()
            .AddNew("工程贷", (int)PrjType.Engineer)
            .AddNew("供应商贷", (int)PrjType.Supplie)
            .AddNew("分销商贷", (int)PrjType.Distributor)
            .AddNew("个人贷", (int)PrjType.Personal)
            .AddNew("企业贷", (int)PrjType.Enterprise)
            .AddNew("票据贷", (int)PrjType.Bill);

        }

        public static string GetPrjType(PrjType type) {
            return PrjProperty.FindByValue((int)type);
        }
        #region 项目基础操作权限设置
        [Jurisdiction("项目", "基础操作", "查询列表", "60012")]
        public static async Task<IResult> GetAllPrjs(IDictionary<string, object> data) {
            return await Http.Get("/mgr/prj/loan-projs", data);
        }

        [Jurisdiction("项目", "基础操作", "创建", "60010")]
        public static async Task<IResult> Create(IDictionary<string, object> data) {
            return await Http.Put("/mgr/prj/loan-projs", data);
        }

        [Jurisdiction("项目", "基础操作", "更新", "60011")]
        public static async Task<IResult> Update(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId, data);
        }

        [Jurisdiction("项目", "基础操作", "删除", "60014")]
        public static async Task<IResult> DeleteProj(long pId) {
            return await Http.Delete("/mgr/prj/loan-projs/" + pId);
        }

        [Jurisdiction("项目", "基础操作", "查询详情", "60013")]
        public static async Task<IResult> Prj(long pId) {
            return await Http.Get("/mgr/prj/loan-projs/" + pId);
        }

        [Jurisdiction("项目", "基础操作", "置顶(包含二级市场)", "60001")]
        public static async Task<IResult> PrjToTop(long pId) {
            return await Http.Post("/mgr/prj/" + pId + "/top-time");
        }

        [Jurisdiction("项目", "基础操作", "取消置顶(包含二级市场)", "60002")]
        public static async Task<IResult> PrjRevokeTop(long pId) {
            return await Http.Post("/mgr/prj/" + pId + "/revoke/top-time");
        }

        [Jurisdiction("项目", "基础操作", "项目显示或隐藏", "60003")]
        public static async Task<IResult> ShowProj(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/" + pId + "/visibility", data);
        }

        [Jurisdiction("项目", "基础操作", "募集期延期", "60015")]
        public static async Task<IResult> UpdateDelayDate(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/financing-period-delay", data);
        }

        [Jurisdiction("项目", "基础操作", "查询有效借款人列表", "20483")]
        public static async Task<IResult> GetAccounts(IDictionary<string, object> data) {
            return await Http.Get("/mgr/account/borrow/jx-completed", data);
        }

        [Jurisdiction("项目", "基础操作", "查询项目实际借款人", "60016")]
        public static async Task<IResult> Financier(long pId) {
            return await Http.Get("/mgr/prj/loan-projs/" + pId + "/financier");
        }

        [Jurisdiction("项目", "基础操作", "更新项目实际借款人", "60017")]
        public static async Task<IResult> SaveFinancier(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/financier", data);
        }

        [Jurisdiction("项目", "基础操作", "更新项目名义借款人及担保借款人", "60018")]
        public static async Task<IResult> SaveNorminalBor(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/related-financier", data);
        }

        [Jurisdiction("项目", "基础操作", "查询借款周期信息", "60019")]
        public static async Task<IResult> BonusPeriod(long pId) {
            return await Http.Get("/mgr/prj/loan-projs/" + pId + "/bonus-period");
        }

        [Jurisdiction("项目", "基础操作", "更新借款周期信息", "60020")]
        public static async Task<IResult> SaveBonusPeriod(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/bonus-period", data);
        }

        [Jurisdiction("项目", "基础操作", "预览项目还款计划", "60021")]
        public static async Task<IResult> PreviewBonus(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Get("/mgr/prj/loan-projs/" + pId + "/preview-bonus", data);
        }

        #endregion

        #region 项目白名单权限设置
        [Jurisdiction("项目", "白名单", "查询列表", "80106")]
        public static async Task<IResult> GetAllowInvest(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Get("/mgr/prj/" + pId + "/permissible-investor", data);
        }

        [Jurisdiction("项目", "白名单", "创建", "80107")]
        public static async Task<IResult> AddAllowInvest(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Put("/mgr/prj/" + pId + "/permissible-investor", data);
        }

        [Jurisdiction("项目", "白名单", "删除", "80108")]
        public static async Task<IResult> DelAllowInvest(long pId, long delId) {
            return await Http.Delete("/mgr/prj/" + pId + "/permissible-investor/" + delId);
        }

        #endregion

        #region 项目借款人快照权限设置
        [Jurisdiction("项目", "借款人快照", "查询列表", "80091")]
        public static async Task<IResult> BorrowPerGet(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/mgr-person");
        }

        [Jurisdiction("项目", "借款人快照", "创建", "80092")]
        public static async Task<IResult> BorrowPerPut(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Put("/mgr/prj/" + pId + "/mgr-person", data);
        }

        [Jurisdiction("项目", "借款人快照", "删除", "80093")]
        public static async Task<IResult> BorrowPerDel(long pid, long pmId) {
            return await Http.Delete("/mgr/prj/" + pid + "/mgr-person/" + pmId);
        }
        #endregion

        #region 项目借款机构快照权限设置
        [Jurisdiction("项目", "借款机构快照", "查询列表", "80096")]
        public static async Task<IResult> BorrowOrgGet(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/mgr-org");
        }

        [Jurisdiction("项目", "借款机构快照", "创建", "80097")]
        public static async Task<IResult> BorrowOrgPut(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Put("/mgr/prj/" + pId + "/mgr-org", data);
        }

        [Jurisdiction("项目", "借款机构快照", "删除", "80098")]
        public static async Task<IResult> BorrowOrgDel(long pid, long pmoId) {
            return await Http.Delete("/mgr/prj/" + pid + "/mgr-org/" + pmoId);
        }

        #endregion

        #region 项目担保人快照权限设置
        [Jurisdiction("项目", "担保人快照", "查询列表", "80081")]
        public static async Task<IResult> GuaranteePerGet(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/guarantee-person");
        }

        [Jurisdiction("项目", "担保人快照", "创建", "80082")]
        public static async Task<IResult> GuaranteePerPut(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Put("/mgr/prj/" + pId + "/guarantee-person", data);
        }

        [Jurisdiction("项目", "担保人快照", "删除", "80083")]
        public static async Task<IResult> GuaranteePerDel(long pid, long pgid) {
            return await Http.Delete("/mgr/prj/" + pid + "/guarantee-person/" + pgid);
        }
        #endregion

        #region 项目担保机构快照权限设置
        [Jurisdiction("项目", "担保机构快照", "查询列表", "80086")]
        public static async Task<IResult> GuaranteeOrgGet(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/guarantee-org");
        }

        [Jurisdiction("项目", "担保机构快照", "创建", "80087")]
        public static async Task<IResult> GuaranteeOrgPut(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Put("/mgr/prj/" + pId + "/guarantee-org", data);
        }

        [Jurisdiction("项目", "担保机构快照", "删除", "80088")]
        public static async Task<IResult> GuaranteeOrgDel(long pid, long pgid) {
            return await Http.Delete("/mgr/prj/" + pid + "/guarantee-org/" + pgid);
        }

        #endregion

        #region 项目评级权限设置
        [Jurisdiction("项目", "评级", "查询", "80101")]
        public static async Task<IResult> Rating(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/rating");
        }

        [Jurisdiction("项目", "评级", "创建", "80102")]
        public static async Task<IResult> SaveRating(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/" + pId + "/rating", data);
        }

        #endregion

        #region 项目审核权限设置
        [Jurisdiction("项目", "审核", "查询项目审核信息", "60061")]
        public static async Task<IResult> Actions(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/actions");
        }

        [Jurisdiction("项目", "审核", "项目提交", "60060")]
        public static async Task<IResult> PrjSubmit(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/submittal", data);
        }

        [Jurisdiction("项目", "审核", "项目经理审批", "60062")]
        public static async Task<IResult> PrjMgrAudit(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/prj-mgr-audit", data);
        }

        [Jurisdiction("项目", "审核", "风控审批", "60063")]
        public static async Task<IResult> PrjRiskCtrlAudit(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/risk-ctrl-audit", data);
        }

        [Jurisdiction("项目", "审核", "评委会秘书审批", "60064")]
        public static async Task<IResult> PrjBusSecAudit(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/bus-sec-audit", data);
        }

        [Jurisdiction("项目", "审核", "业务副总批准上线", "60065")]
        public static async Task<IResult> PrjBusVpAprOnline(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/bus-vp-apr-online", data);
        }

        [Jurisdiction("项目", "审核", "业务副总确认满标", "60066")]
        public static async Task<IResult> PrjBusVpConfirmFull(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/bus-vp-confirm-full", data);
        }

        #region 权限ID同为60067
        [Jurisdiction("项目", "审核", "财务核收服务费", "60067")]
        public static async Task<IResult> PrjCheckFee(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/check-fee", data);
        }

        public static async Task<IResult> SaveReservedAmt(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/" + pId + "/bond", data);
        }
        #endregion

        [Jurisdiction("项目", "审核", "业务副总批准放款", "60069")]
        public static async Task<IResult> PrjBusVpConfirmLoan(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/bus-vp-confirm-loan", data);
        }

        #endregion

        #region 项目高阶操作权限设置
        [Jurisdiction("项目", "高阶操作", "生成出借人信息表", "60080")]
        public static async Task<IResult> Investors(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/investors");
        }

        [Jurisdiction("项目", "高阶操作", "查看投标", "60087")]
        public static async Task<IResult> Tenders(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/tenders");
        }

        [Jurisdiction("项目", "高阶操作", "中途流标", "60088")]
        public static async Task<IResult> BusVpStopRaising(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Post("/mgr/prj/loan-projs/" + pId + "/bus-vp-stop-raising", data);
        }

        [Jurisdiction("项目", "高阶操作", "撤销投标", "60089")]
        public static async Task<IResult> CreateCancelTender(Dictionary<string, object> data) {
            var ttId = data.Take<long>("tt-id");
            return await Http.Put("/mgr/trans/tenders/" + ttId + "/cancellation", data);
        }

        [Jurisdiction("项目", "高阶操作", "查询流标记录", "60090")]
        public static async Task<IResult> GetCancelTenders(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/cancel-tenders");
        }

        [Jurisdiction("项目", "高阶操作", "执行流标", "60091")]
        public static async Task<IResult> CancelTenders(long pId) {
            return await Http.Post("/mgr/trans/cancel-tender/" + pId + "/execution");
        }

        [Jurisdiction("项目", "高阶操作", "查询是否存在未执行的投标记录", "60092")]
        public static async Task<IResult> IsExistsUncheckedTender(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/is-exists-uncheck-tender");
        }

        [Jurisdiction("项目", "高阶操作", "查询未执行的投标记录", "60093")]
        public static async Task<IResult> UncheckedTenders(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/unchecked-tenders");
        }

        [Jurisdiction("项目", "高阶操作", "检查投标", "60094")]
        public static async Task<IResult> UpdateUncheckedTenders(long pId, long jbId) {
            return await Http.Post("/mgr/prj/" + pId + "/update-unchecked-tender/" + jbId);
        }

        [Jurisdiction("项目", "高阶操作", "有效投资查询", "60095")]
        public static async Task<IResult> Invests(Dictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Get("/mgr/prj/" + pId + "/invests", data);
        }

        [Jurisdiction("项目", "高阶操作", "查询放款记录", "60097")]
        public static async Task<IResult> Loans(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/loans");
        }

        [Jurisdiction("项目", "高阶操作", "项目结清", "60098")]
        public static async Task<IResult> Complete(long pId) {
            return await Http.Post("/mgr/prj/" + pId + "/completed");
        }

        [Jurisdiction("项目", "高阶操作", "锁定", "60099")]
        public static async Task<IResult> Lock(long pId) {
            return await Http.Post("/mgr/prj/" + pId + "/prj-lock");
        }

        [Jurisdiction("项目", "高阶操作", "项目解锁", "60100")]
        public static async Task<IResult> UnLock(long pId) {
            return await Http.Post("/mgr/prj/" + pId + "/prj-unlock");
        }

        [Jurisdiction("项目", "高阶操作", "查询项目是否锁定", "60101")]
        public static async Task<IResult> IsLocked(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/prj-lock-status");
        }

        [Jurisdiction("项目", "高阶操作", "执行放款", "60102")]
        public static async Task<IResult> ExecuteLoan(long pId) {
            return await Http.Post("/mgr/prj/" + pId + "/batch-loan");
        }
        #endregion

        #region 项目还款权限设置
        [Jurisdiction("项目", "还款", "查询项目还款记录", "60130")]
        public static async Task<IResult> Bonus(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/bonus");
        }

        #region 权限设置ID同为60131
        [Jurisdiction("项目", "还款", "创建项目还款明细", "60131")]
        public static async Task<IResult> SaveBonusDetail(IDictionary<string, object> data) {
            var pId = data.Take<long>("pid");
            return await Http.Put("/mgr/prj/loan-projs/" + pId + "/bonus-details", data);
        }

        public static async Task<IResult> RepayFileUploadTime() {
            return await Http.Get("/mgr/prj/ts-repay");
        }
        #endregion

        [Jurisdiction("项目", "还款", "禁用还款明细", "60133")]
        public static async Task<IResult> DeleteBonusDetail(long pid, long pbdId) {
            return await Http.Delete("/mgr/prj/" + pid + "/bonus-details/" + pbdId);
        }

        [Jurisdiction("项目", "还款", "查询项目还款明细", "60134")]
        public static async Task<IResult> BonusDetails(long pId) {
            return await Http.Get("/mgr/prj/" + pId + "/bonus-details");
        }

        [Jurisdiction("项目", "还款", "查询单笔还款明细的详细还款记录", "60135")]
        public static async Task<IResult> Repays(long pid, long pbdId) {
            return await Http.Get("/mgr/prj/" + pid + "/bonus-details/" + pbdId + "/repays");
        }

        [Jurisdiction("项目", "还款", "执行还款", "60171")]
        public static async Task<IResult> ExecuteRepays(IDictionary<string, object> data) {
            var pid = data.Take<long>("p-id");
            var pbdId = data.Take<long>("pbd-id");
            return await Http.Post("/mgr/prj/" + pid + "/batch-repay/" + pbdId, data);
        }

        [Jurisdiction("项目", "还款", "查询还款文件上传记录", "60136")]
        public static async Task<IResult> RepayFileUploadHistory() {
            return await Http.Get("/mgr/prj/ts-repay-history");
        }

        [Jurisdiction("项目", "还款", "删除还款文件上传记录", "60137")]
        public static async Task<IResult> RepayFileDelete(long id, long batch) {
            return await Http.Delete("/mgr/prj/ts-repay-history/" + id + "/" + batch);
        }
        #endregion

        #region 项目放款权限设置
        [Jurisdiction("项目", "放款", "查询放款文件上传记录", "60120")]
        public static async Task<IResult> LoanFileUploadHistory() {
            return await Http.Get("/mgr/prj/ts-loan-history");
        }

        [Jurisdiction("项目", "放款", "删除放款文件上传记录", "60121")]
        public static async Task<IResult> LoanFileDelete(long id, long batch) {
            return await Http.Delete("/mgr/prj/ts-loan-history/" + id + "/" + batch);
        }
        #endregion

        public static async Task<IResult> Remark(long pId, int type) {
            return await Http.Get("/mgr/prj/" + pId + "/remarks/" + type);
        }

        public static async Task<IResult> SaveRemark(Dictionary<string, object> data) {
            var pId = data.Take<long>("p-id");
            var type = data.Take<int>("type");
            return await Http.Post("/mgr/prj/" + pId + "/remarks/" + type, data);
        }
    }
}
