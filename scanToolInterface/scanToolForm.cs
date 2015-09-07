/*
Class Name:  scanToolForm   
Description:  Scan Tool form
   This form is used to test and prototype the functionality of the Scan Tool.
   The Scan Tool reads input from a barcode scanner and matches the input with
   an associated Item ID.  The Item ID is then inserted into the keyboard
   buffer, where it is read by an application open in another window.
   If a matching Item ID is not found for the barcode, then the user may
   associate the barcode with an Item ID.
Purpose:  This class is used to test the functions of the scan tool prototype.

Theory of Operation:

Date:  08/19/2015
Programmer:  Russell Mace 
Prototype completed on 9/6/2015
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using scanToolClasses;

namespace scanToolInterface
{
    public partial class scanToolForm : Form
    {

        private LinkedList<inventoryItem> items;

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
            if (posScanner.Open("USBHHScanner") != 0)
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
            String scanData = posScanner.ScanData.ToString();
            txtBarcodeData.Text = scanData;
            txtItemID.Text = scanData;
            posScanner.ClearInput();    // clear the data buffer
            posScanner.DataEventEnabled = true;   // have to set true each timeitem  or it won't rescan
            string itm = lookUpItem(scanData);
            if (itm != null) sendItemID();
        }

        public string lookUpItem(string strBarCode)
        {
            string strItemId = null;
            barcode bcode = barcode.findBarcode(strBarCode);
            if (bcode != null)
            {
                inventoryItem itm = bcode.getItem();
                txtItemID.Text = itm.ItemID;
                strItemId = itm.ItemID;
            }
            else
            {
                txtBarcodeData.ForeColor = Color.Red;
                btnSelectItem.Enabled = true;
                MessageBox.Show("Barcode not found, please select an item for this barcode.");
            }
            return strItemId;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Options();
            frm.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadItems_Click(object sender, EventArgs e)
        {
            DialogResult result = openItemFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                string itemFile = openItemFile.FileName;
                try
                {
                    inventoryItem.LoadItems(itemFile);
                    items = inventoryItem.itemList;
                    foreach (inventoryItem item in items)
                    {
                        lstListOfItems.Items.Add(item);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error while trying to open item file: " + exc.ToString());
                }
            }
        }

        private void btnSaveItemsToFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openItemFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                string itemFile = openItemFile.FileName;
                try
                {
                    inventoryItem.saveItems(itemFile);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error while trying to save items to file: " + exc.ToString());
                }
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtItemToAdd.Text.Length > 0)
            {
                inventoryItem i = new inventoryItem(txtItemToAdd.Text, txtDescription.Text);
                if (lstListOfItems.FindString(i.ToString()) == -1)
                { 
                    lstListOfItems.Items.Add(i);
                }
            }
        }

        private void bntDeleteItems_Click(object sender, EventArgs e)
        {
            lstListOfItems.SelectedItems.Remove(lstListOfItems.SelectedItem);
            lstListOfItems.Refresh();
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            // first, get the selected item
            inventoryItem itm = (inventoryItem) lstListOfItems.SelectedItem;
            if (itm == null)
            {
                MessageBox.Show("No item selected. Please select an item in the list.");
            }
            else
            {
                if (txtBarcodeData.Text == null)
                {
                    MessageBox.Show("No barcode data. Please scan again.");
                }
                else
                {
                    itm.assignBarcode(txtBarcodeData.Text);
                    txtItemID.Text = itm.ItemID;
                }
            }
        }
    }
}
