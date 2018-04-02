using System.Runtime.InteropServices;

namespace Banhuitong.Console {
    /// <summary>
    /// 不安全的本地方法。
    /// </summary>
    static class UnsafeNativeMethods {
        [DllImport("kernel32.dll", SetLastError = true)]
        public extern static bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public extern static int FreeConsole();
    }
}
