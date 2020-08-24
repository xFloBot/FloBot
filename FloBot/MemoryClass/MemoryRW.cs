using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
*   Credits to Jorndel from MPGH for this class
*/
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
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, uint Msg, Keys wParam, int lParam);

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
        private int processID = 0;
       
        public bool isGameInForeground()
        {
            return windowHandler == GetForegroundWindow();
        }

        public bool Process_Handle(string ProcessName,int processNumber,String windowName,bool updateWindow)
        {
            try
            {
                Process[] ProcList = Process.GetProcessesByName(ProcessName);
                if (ProcList.Length <= processNumber)
                {
                    return false;
                }
                
                if (processID == ProcList[processNumber].Id)
                {
                    if (updateWindow && !(windowHandler == null))
                    {
                        windowHandler = yourProcess.MainWindowHandle;
                        SetWindowText(windowHandler, windowName);
                        hWnd = FindWindow(null, windowName);
                    }
                    return true;
                }
                        
                    processID = ProcList[processNumber].Id;
                    yourProcess = ProcList[processNumber];
                    windowHandler = yourProcess.MainWindowHandle;
                   
                    pHandel = yourProcess.Handle;
                    baseAddress = yourProcess.MainModule.BaseAddress;
                    SetWindowText(windowHandler, windowName);
                    hWnd = FindWindow(null, windowName);
                    return true;
            
            }
            catch (Exception ex)
            { Console.Beep(); Console.WriteLine("Process_Handle - " + ex.Message); return false; }
        }

        public void ChangeWindowName(String windowName)
        {
            windowHandler = yourProcess.MainWindowHandle;
            SetWindowText(windowHandler, windowName);
            hWnd = FindWindow(null, windowName);
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
            SendMessage(hWnd, WM_KEYDOWN, k , 0);
            Thread.Sleep(new Random().Next(1, 300));
            SendMessage(hWnd, WM_KEYUP, k, 0);
        }

        public void sendLeftClick(int[] pos,int[] endPos)
        {
            int startCord = pos[0] | (pos[1] << 16);
            int endCord = endPos[0] | (endPos[1] << 16);
            const uint WM_LBUTTONDOWN = 0x201; //Left mousebutton down
            const uint WM_LBUTTONUP = 0x202;   //Left mousebutton up
            SendMessage(hWnd, WM_LBUTTONDOWN, 0, startCord);
            Thread.Sleep(new Random().Next(1, 150));
            SendMessage(hWnd, WM_LBUTTONUP, 0, endCord);
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
