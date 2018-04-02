using Banhuitong.Console.Rpc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Banhuitong.Console.Security {
    using CustomAttribute;
    public static class Roles {
        [Jurisdiction("运维管理", "角色管理", "查询角色列表信息", "10010")]
        public static async Task<IResult> GetAll(IDictionary<string, object> data) {
            return await Http.Get("/mgr/sys-roles", data);
        }

        [Jurisdiction("运维管理", "角色管理", "创建", "10007")]
        public static async Task<IResult> AddRole(IDictionary<string, object> data) {
            return await Http.Put("/mgr/sys-roles", data);
        }

        [Jurisdiction("运维管理", "角色管理", "修改", "10008")]
        public static async Task<IResult> UpdateRole(IDictionary<string, object> data) {
            var roleName = data.Take<string>("role-name");
            return await Http.Post("/mgr/sys-roles/" + roleName, data);
        }

        [Jurisdiction("运维管理", "角色管理", "删除", "10011")]
        public static async Task<IResult> Delete(string name) {
            return await Http.Delete("/mgr/sys-roles/" + name);
        }

        [Jurisdiction("运维管理", "角色管理", "查询单个角色信息", "10009")]
        public static async Task<IResult> Role(string roleName) {
            if (string.IsNullOrEmpty(roleName)) {
                return new LocalResult(new { name = "[新角色]", nameIsWritable = true });
            } else {
                return await Http.Get("/mgr/sys-roles/" + roleName);
            }
        }

        [Jurisdiction("运维管理", "角色管理", "查询角色权限", "10012")]
        public static async Task<IResult> Perms(string name) {
            return await Http.Get("/mgr/sys-roles/" + name + "/perms");
        }

        [Jurisdiction("运维管理", "角色管理", "分配角色权限", "10013")]
        public static async Task<IResult> AssignPerms(Dictionary<string, object> data) {
            var roleName = data.Take<string>("role-name");
            return await Http.Post("/mgr/sys-roles/" + roleName + "/perms", data);
        }

    }
}
