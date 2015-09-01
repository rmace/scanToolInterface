using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// These are needed for sending the keys to another application
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace scanToolInterface
{
    public partial class scanTool : Form
    {
        private static int testcount = 0;

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        static extern int SetForegroundWindow(IntPtr point);


        public scanTool()
        {
            InitializeComponent();
        }

        /*private void _Load(object sender, EventArgs e)
        {
            testSendKey("Print This!");
            // Initialize everything 
            scanner.BeginInit();
            scanner.Open("DataLogicScanner.1");
            // The profile name of the device.
            scanner.ClaimDevice(0);
            scanner.DeviceEnabled = true;
            scanner.DataEventEnabled = true;
            scanner.DecodeData = true;
        }
        */

        // The loadWindowList method populates the windowList combobox control with a list of
        // all currently running windows in the program
        private void loadWindowList()
        {
            // Get the desktopwindow handle
            int nDeshWndHandle = NativeWin32.GetDesktopWindow();
            // Get the first child window
            int nChildHandle = NativeWin32.GetWindow(nDeshWndHandle, NativeWin32.GW_CHILD);

            while (nChildHandle != 0)
            {
                //If the child window is this (SendKeys) application then ignore it.
                if (nChildHandle == this.Handle.ToInt32())
                {
                    nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
                }

                // Get only visible windows
                if (NativeWin32.IsWindowVisible(nChildHandle) != 0)
                {
                    StringBuilder sbTitle = new StringBuilder(1024);
                    // Read the Title bar text on the windows to put in combobox
                    NativeWin32.GetWindowText(nChildHandle, sbTitle, sbTitle.Capacity);
                    String sWinTitle = sbTitle.ToString();
                    {
                        if (sWinTitle.Length > 0)
                        {
                            windowList.Items.Add(sWinTitle);
                        }
                    }
                }
                // Look for the next child.
                nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
            }
        }

        private void testSendKey(string stringToSend)
        {
            // This method will eventually go away.
            // Its code, once proven, will be incorporated into the scanTool
            // application
            Process p = Process.GetProcessesByName("Programming and Development Notes - Notepad")[0];
            IntPtr pointer = p.MainWindowHandle;
            ShowWindow(pointer, 1);
            //SetForegroundWindow(pointer);
            SendKeys.SendWait(stringToSend);

            // Process notepad = new Process();

            //  notepad.StartInfo.FileName = @"C:\Windows\Notepad.exe";
            //    notepad.Start();

            // Need to wait for notepad to start
            //    notepad.WaitForInputIdle();

            //    IntPtr p = notepad.MainWindowHandle;
            //    ShowWindow(p, 1);
            //    SendKeys.SendWait("ABC");


        }
        private void scanner_DataEvent(object sender, AxOposScanner_CCO._IOPOSScannerEvents_DataEventEvent e)
        {
            String scanString = scanner.ScanData.ToString();

        }
    }
}
