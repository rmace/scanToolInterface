using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace scanToolInterface
{
    public partial class scanToolForm : Form
    {
        public scanToolForm()
        {
            InitializeComponent();
        }

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

        private void connectScanner()
        {
            posScanner.BeginInit();
            if (posScanner.Open("DATALOGIC PSC USB Handheld Scanner") != 0)
            {
                MessageBox.Show("Failed to Open Connection to Scanner");
            }
            else
            {
                posScanner.ClaimDevice(0);
                posScanner.DeviceEnabled = true;
                posScanner.DataEventEnabled = true;
                posScanner.DecodeData = true;
            }
        }

        private void scanToolForm_Load(object sender, EventArgs e)
        {
            refreshWindow();
            connectScanner();
        }

        private void refreshWindow()
        {
            windowList.Items.Clear();
            loadWindowList();
        }

        private void btnSendItemID_Click(object sender, EventArgs e)
        {
            sendItemID();
        }

        private void sendItemID()
        { 
            int iHandle = NativeWin32.FindWindow(null, windowList.Text);

            NativeWin32.SetForegroundWindow(iHandle);

            string keys = txtItemID.Text;
            System.Windows.Forms.SendKeys.Send(keys);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void axOPOSScanner1_DataEvent(object sender, AxOposScanner_CCO._IOPOSScannerEvents_DataEventEvent e)
        {
            // We got a scanner event!
            sendItemID();
        }
    }
}
