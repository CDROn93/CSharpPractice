using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace PInvoke
{
    class PInvoke
    {
        static void Main(string[] args)
        {
            //beep continuously until program stopped
            while (true)
            {
                if (!MessageBeep(0))
                {

                    Int32 error = Marshal.GetLastWin32Error();
                    throw new Win32Exception(error);

                }
            }
        }
        [DllImport("User32.dll")]
        static extern Boolean MessageBeep(UInt32 beeptype);
        
    }
}
