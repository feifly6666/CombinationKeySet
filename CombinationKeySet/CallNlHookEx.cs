using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace CombinationKeySet
{
    class CallNlHookEx
    {
        #region 常数和结构

        public const int WM_KEYDOWN = 0x100;

        public const int WM_KEYUP = 0x101;

        public const int WM_SYSKEYDOWN = 0x104;

        public const int WM_SYSKEYUP = 0x105;

        public const int WH_KEYBOARD_LL = 20;



        [StructLayout(LayoutKind.Sequential)] //声明键盘钩子的封送结构类型 

        public class KeyboardHookStruct
        {

            public byte vkCode; //表示一个在1到254间的虚似键盘码 

            public int scanCode; //表示硬件扫描码 

            public int flags;

            public int time;

            public int dwExtraInfo;

        }

        #endregion

        #region Api

        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);

        //安装钩子的函数 
        [DllImport("NlsHookEx.dll", EntryPoint = "?SetWindowsHookEx@@YAPAUHHOOK__@@HP6AJHIJ@ZPAUHINSTANCE__@@K@Z")]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        //卸下钩子的函数 
        [DllImport("NlsHookEx.dll",EntryPoint = "?UnhookWindowsHookEx@@YAHPAUHHOOK__@@@Z")]
        public static extern bool UnhookWindowsHookEx(int idHook);

        //下一个钩挂的函数 
        [DllImport("NlsHookEx.dll", EntryPoint = "?CallNextHookEx@@YAHPAUHHOOK__@@HIJ@Z")]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);

        
        [DllImport("coredll.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("coredll.dll", EntryPoint = "keybd_event", SetLastError = true)]
        internal static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        #endregion

    }
}
