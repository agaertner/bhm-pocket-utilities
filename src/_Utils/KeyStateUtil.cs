using System;
using System.Runtime.InteropServices;

namespace Nekres.Inquest_Module {
    internal static class KeyStateUtil {
        #region PInvoke

        [DllImport("USER32.dll")]
        private static extern short GetKeyState(uint vk);

        #endregion

        private const uint KEY_PRESSED = 0x8000;

        private const uint VK_LSHIFT   = 0xA0;
        private const uint VK_RSHIFT   = 0xA1;

        private const uint VK_LCONTROL = 0xA2;
        private const uint VK_RCONTROL = 0xA3;

        private const uint VK_CONTROL = 0x11;
        private const uint VK_SHIFT   = 0x10;

        private static bool IsPressed(uint key) {
            return Convert.ToBoolean(GetKeyState(key) & KEY_PRESSED);
        }

        public static bool IsLControlPressed() {
            return Convert.ToBoolean(GetKeyState(VK_LCONTROL) & KEY_PRESSED);
        }

        public static bool IsRControlPressed() {
            return Convert.ToBoolean(GetKeyState(VK_RCONTROL) & KEY_PRESSED);
        }

        public static bool IsLShiftPressed() {
            return Convert.ToBoolean(GetKeyState(VK_LSHIFT) & KEY_PRESSED);
        }

        public static bool IsRShiftPressed() {
            return Convert.ToBoolean(GetKeyState(VK_RSHIFT) & KEY_PRESSED);
        }

        public static bool IsAnyControlPressed() {
            return Convert.ToBoolean(GetKeyState(VK_CONTROL) & KEY_PRESSED);
        }

        public static bool IsAnyShiftPressed() {
            return Convert.ToBoolean(GetKeyState(VK_SHIFT) & KEY_PRESSED);
        }
    }
}
