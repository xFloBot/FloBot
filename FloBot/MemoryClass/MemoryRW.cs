using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloBot.MemoryClass
{
    class MemoryRW
    {
        #region Basic Stuff
        [DllImport("kernel32.dll")]
        private static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        private static extern Int32 WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);
        IntPtr pHandel;
        IntPtr baseAddress;
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, Keys wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);


        public IntPtr getBaseAdress()
        {
            return baseAddress;
        }

        private IntPtr windowHandler;
        private Process yourProcess = null;

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetExitCodeProcess(IntPtr hProcess, out uint ExitCode);
        public bool isProcessStillRunning
        {
            get
            {
                if (yourProcess == null)
                    return false;
                uint exitCode = 0;
                if(!GetExitCodeProcess(pHandel, out exitCode))return false;
                
                return exitCode == 259;
            }
        }
        public bool isGameInForeground()
        {
            return windowHandler == GetForegroundWindow();
        }

        public bool Process_Handle(string ProcessName,string multiClientName,int processNumber,String windowName)
        {
            try
            {
                Process[] ProcList = Process.GetProcessesByName(multiClientName);
                if (ProcList.Length == 0)
                {

                    ProcList = Process.GetProcessesByName(ProcessName);
                    if (ProcList.Length == 0)
                        return false;
                }

                if (ProcList.Length != 0 && ProcList.Length > processNumber) ;
                {
                    yourProcess = ProcList[processNumber];
                    windowHandler = yourProcess.MainWindowHandle;
                    SetWindowText(windowHandler, windowName);
                    hWnd = FindWindow(null, windowName);
                    pHandel = yourProcess.Handle;
                    baseAddress = yourProcess.MainModule.BaseAddress;
                    
                    return true;
                }
            }
            catch (Exception ex)
            { Console.Beep(); Console.WriteLine("Process_Handle - " + ex.Message); return false; }
        }
        private byte[] Read(int Address, int Length)
        {
            byte[] Buffer = new byte[Length];
            IntPtr Zero = IntPtr.Zero;
            ReadProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
            return Buffer;
        }
        private void Write(int Address, int Value)
        {
            byte[] Buffer = BitConverter.GetBytes(Value);
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }
        #endregion

        //This is the part you want to edit
        #region Write Functions (Integer & String)

        public void WriteInteger(int Address, int Value)
        {
            Write(Address, Value);
        }
        public void WriteString(int Address, string Text)
        {
            byte[] Buffer = new ASCIIEncoding().GetBytes(Text);
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }
        public void WriteBytes(int Address, byte[] Bytes)
        {
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Bytes, (uint)Bytes.Length, out Zero);
        }
        public void WriteNOP(int Address)
        {
            byte[] Buffer = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 };
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }


        #endregion
        #region Read Functions (Integer & String)
        public int ReadInteger(int Address, int Length = 4)
        {
            return BitConverter.ToInt32(Read(Address, Length), 0);
        }
        public Single ReadSingle(int Address, int Length = 4)
        {
            return BitConverter.ToSingle(Read(Address, Length), 0);
        }
        public string ReadString(int Address, int Length = 4)
        {
            return new ASCIIEncoding().GetString(Read(Address, Length));
        }
        public byte[] ReadBytes(int Address, int Length)
        {
            return Read(Address, Length);
        }
        #endregion

        private IntPtr hWnd;
        public void sendKeystroke(Keys k)
        {
            const uint WM_KEYDOWN = 0x100;
            const uint WM_KEYUP = 0x101;
            PostMessage(hWnd, WM_KEYDOWN, k , 0);
            Thread.Sleep(new Random().Next(1, 300));
            PostMessage(hWnd, WM_KEYUP, k, 0);
        }

        public void sendLeftClick(int[] pos)
        {
            int coordinates = pos[0] | (pos[1] << 16);
            const uint WM_LBUTTONDOWN = 0x201; //Left mousebutton down
            const uint WM_LBUTTONUP = 0x202;   //Left mousebutton up
            PostMessage(hWnd, WM_LBUTTONDOWN, 0, coordinates);
            Thread.Sleep(new Random().Next(1, 300));
            PostMessage(hWnd, WM_LBUTTONUP, 0, coordinates);
        }


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right cornerd
        }

        public int[] getPixelsByPercent(Single xPerc,Single yPerc)
        {
            RECT floWin;
            GetWindowRect(hWnd, out floWin);
            int[] res = { (int)((floWin.Right - floWin.Left + 1)/(100.0/xPerc)), (int)((floWin.Bottom - floWin.Top + 1) / (100.0 / yPerc)) };

            return res ;

        }

    }

}
