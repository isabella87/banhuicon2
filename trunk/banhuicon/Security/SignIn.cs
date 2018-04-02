using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;

namespace Banhuitong.Console.Security {
    /// <summary>
    /// 用于实现用户登录的类。
    /// </summary>
    public static class SignIn {
        /// <summary>
        /// 获取验证码图片。
        /// </summary>
        /// <returns>验证码图片。</returns>
        public static async Task<Image> GetCaptchaImage() {
            byte[] imageContent = await Rpc.Http.GetRaw("security/captcha-image");
            Image image = null;
            try {
                image = Image.FromStream(new MemoryStream(imageContent));
            } catch (Exception ex) {
#if DEBUG
                System.Console.WriteLine("cannot get captcha-image:", ex);
#endif
                return null;
            }
            return image;
        }

        /// <summary>
        /// 检查用户是否可以成功登录。
        /// </summary>
        /// <param name="userName">用户名。</param>
        /// <param name="password">口令。</param>
        /// <param name="captchaCode">验证码。</param>
        /// <returns></returns>
        public static async Task<bool> Validate(string userName, string password, string captchaCode) {
            var data = new Dictionary<string, object>();
            data["user-name"] = userName.TrimStr();
            data["password"] = password.TrimStr();
            data["captcha-code"] = captchaCode.TrimStr();
            var r = await Rpc.Http.Post("/security/signin", data);
            return r.AsBoolean;
        }

        public static async Task<bool> ValidateUser(string password) {
            var r = new Dictionary<string, object>();
            r["password"] = password;
            var p = await Rpc.Http.Get("/security/validate-user", r);
            return p.AsBoolean;
        }
    }
}
