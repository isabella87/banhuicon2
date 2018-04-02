using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Banhuitong.Console.Security {
    using Rpc;
    using CustomAttribute;
    public static class Users {
        [Jurisdiction("运维管理", "账户管理", "查看账户列表信息", "10000")]
        public static async Task<IResult> GetAll(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Get("/mgr/sys-users", data);
        }

        [Jurisdiction("运维管理", "账户管理", "创建", "10001")]
        public static async Task<IResult> AddUser(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Put("/mgr/sys-users", data);
        }

        [Jurisdiction("运维管理", "账户管理", "修改", "10002")]
        public static async Task<IResult> UpdateUser(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            var userName = data.Take<string>("user-name");
            Debug.Assert(!string.IsNullOrWhiteSpace(userName));
            return await Http.Post("/mgr/sys-users/" + userName, data);
        }

        [Jurisdiction("运维管理", "账户管理", "删除", "10004")]
        public static async Task<IResult> DeleteUser(string userName) {
            Commons.NotBlank(userName, "userName");
            return await Http.Delete("/mgr/sys-users/" + userName);
        }

        [Jurisdiction("运维管理", "账户管理", "查看单个账户信息", "10003")]
        public static async Task<IResult> GetUser(string userName) {
            userName = userName.TrimStr();
            if (userName == "") {
                return new LocalResult(new { userName = "[新后台帐号]" });
            } else {
                return await Http.Get("/mgr/sys-users/" + userName);
            }
        }

        [Jurisdiction("运维管理", "账户管理", "查询账户角色信息", "10006")]
        public static async Task<IResult> Roles(string userName) {
            userName = userName.TrimStr();
            if (userName == "") {
                return new LocalResult();
            } else {
                return await Http.Get("/mgr/sys-users/" + userName + "/roles");
            }
        }

        [Jurisdiction("运维管理", "账户管理", "重置账户密码", "10005")]
        public static async Task<IResult> ResetPwd(string userName) {
            Commons.NotBlank(userName, "userName");
            return await Http.Post("/mgr/sys-users/" + userName + "/reset-pwd");
        }

        [Jurisdiction("运维管理", "账户管理", "修改账户密码", "10104")]
        public static async Task<IResult> ChangePwd(IDictionary<string, object> data) {
            Commons.NotNull(data, "data");
            return await Http.Post("/security/change-pwd", data);
        }

        //不需要设置权限
        public static async Task<IResult> GetCurrentUser() {
            return await Http.Get("/security/user");
        }
    }
}
