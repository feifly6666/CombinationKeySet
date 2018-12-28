using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CombinationKeySet
{
    static class Program
    {
        #region OpenNETCF native interface to mutex generation (version 1.4 of the SDF)


        public const Int32 NATIVE_ERROR_ALREADY_EXISTS = 183;


        #region P/Invoke Commands for Mutexes


        [DllImport("coredll.dll", EntryPoint = "CreateMutex", SetLastError = true)]
        public static extern IntPtr CreateMutex(
            IntPtr lpMutexAttributes,
            bool InitialOwner,
            string MutexName);


        [DllImport("coredll.dll", EntryPoint = "ReleaseMutex", SetLastError = true)]
        public static extern bool ReleaseMutex(IntPtr hMutex);


        #endregion


        public static bool IsInstanceRunning()
        {
            string strAppName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            IntPtr hMutex = CreateMutex(IntPtr.Zero, true, strAppName);
            if (hMutex == IntPtr.Zero)
            {
                throw new ApplicationException("Failure creating mutex: " + Marshal.GetLastWin32Error().ToString("X"));
            }
            if (Marshal.GetLastWin32Error() == NATIVE_ERROR_ALREADY_EXISTS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            if (IsInstanceRunning())//核心代码
                MessageBox.Show("CombinationKeySet is already running.");
            else
            Application.Run(new Form1());
        }
    }
}