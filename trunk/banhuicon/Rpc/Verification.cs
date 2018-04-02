using System.Security.Cryptography;
using System.Text;

namespace Banhuitong.Console.Rpc {
    public static class Verification {

        public static string GetSha1(string str) {
            var content = Encoding.UTF8.GetBytes(str);
            return Encoding.UTF8.GetString(new SHA1CryptoServiceProvider().ComputeHash(content));
        }

    }
}
