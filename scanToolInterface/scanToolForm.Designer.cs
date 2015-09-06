namespace scanToolInterface
{
    partial class scanToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scanToolForm));
            this.windowList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.posScanner = new AxOposScanner_CCO.AxOPOSScanner();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendItemID = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBarcodeData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItemFile = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadItems = new System.Windows.Forms.Button();
            this.btnSaveItemsToFile = new System.Windows.Forms.Button();
            this.lstListOfItems = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.bntDeleteItems = new System.Windows.Forms.Button();
            this.txtItemToAdd = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.posScanner)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowList
            // 
            this.windowList.FormattingEnabled = true;
            this.windowList.Location = new System.Drawing.Point(13, 49);
            this.windowList.Name = "windowList";
            this.windowList.Size = new System.Drawing.Size(614, 21);
            this.windowList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Window where the scanned data will be entered:";
            // 
            // posScanner
            // 
            this.posScanner.Enabled = true;
            this.posScanner.Location = new System.Drawing.Point(16, 297);
            this.posScanner.Name = "posScanner";
            this.posScanner.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("posScanner.OcxState")));
            this.posScanner.Size = new System.Drawing.Size(192, 192);
            this.posScanner.TabIndex = 2;
            this.posScanner.DataEvent += new AxOposScanner_CCO._IOPOSScannerEvents_DataEventEventHandler(this.axOPOSScanner1_DataEvent);
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(410, 87);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(217, 20);
            this.txtItemID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item ID:";
            // 
            // btnSendItemID
            // 
            this.btnSendItemID.Location = new System.Drawing.Point(410, 137);
            this.btnSendItemID.Name = "btnSendItemID";
            this.btnSendItemID.Size = new System.Drawing.Size(102, 50);
            this.btnSendItemID.TabIndex = 5;
            this.btnSendItemID.Text = "Send Item ID To Selected Window";
            this.btnSendItemID.UseVisualStyleBackColor = true;
            this.btnSendItemID.Click += new System.EventHandler(this.btnSendItemID_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(519, 137);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 50);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBarcodeData
            // 
            this.txtBarcodeData.Location = new System.Drawing.Point(114, 87);
            this.txtBarcodeData.Name = "txtBarcodeData";
            this.txtBarcodeData.Size = new System.Drawing.Size(229, 20);
            this.txtBarcodeData.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Barcode Data:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // openItemFile
            // 
            this.openItemFile.FileName = "openFileDialog1";
            // 
            // btnLoadItems
            // 
            this.btnLoadItems.Location = new System.Drawing.Point(268, 151);
            this.btnLoadItems.Name = "btnLoadItems";
            this.btnLoadItems.Size = new System.Drawing.Size(75, 23);
            this.btnLoadItems.TabIndex = 10;
            this.btnLoadItems.Text = "Load Items From File";
            this.btnLoadItems.UseVisualStyleBackColor = true;
            this.btnLoadItems.Click += new System.EventHandler(this.btnLoadItems_Click);
            // 
            // btnSaveItemsToFile
            // 
            this.btnSaveItemsToFile.Location = new System.Drawing.Point(268, 180);
            this.btnSaveItemsToFile.Name = "btnSaveItemsToFile";
            this.btnSaveItemsToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveItemsToFile.TabIndex = 11;
            this.btnSaveItemsToFile.Text = "Save Items";
            this.btnSaveItemsToFile.UseVisualStyleBackColor = true;
            this.btnSaveItemsToFile.Click += new System.EventHandler(this.btnSaveItemsToFile_Click);
            // 
            // lstListOfItems
            // 
            this.lstListOfItems.FormattingEnabled = true;
            this.lstListOfItems.Location = new System.Drawing.Point(16, 114);
            this.lstListOfItems.Name = "lstListOfItems";
            this.lstListOfItems.Size = new System.Drawing.Size(246, 173);
            this.lstListOfItems.TabIndex = 12;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(268, 210);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // bntDeleteItems
            // 
            this.bntDeleteItems.Enabled = false;
            this.bntDeleteItems.Location = new System.Drawing.Point(268, 239);
            this.bntDeleteItems.Name = "bntDeleteItems";
            this.bntDeleteItems.Size = new System.Drawing.Size(75, 23);
            this.bntDeleteItems.TabIndex = 14;
            this.bntDeleteItems.Text = "Delete Item";
            this.bntDeleteItems.UseVisualStyleBackColor = true;
            this.bntDeleteItems.Click += new System.EventHandler(this.bntDeleteItems_Click);
            // 
            // txtItemToAdd
            // 
            this.txtItemToAdd.Location = new System.Drawing.Point(412, 210);
            this.txtItemToAdd.Name = "txtItemToAdd";
            this.txtItemToAdd.Size = new System.Drawing.Size(127, 20);
            this.txtItemToAdd.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(410, 237);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(217, 20);
            this.txtDescription.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Item to Add:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Description:";
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Enabled = false;
            this.btnSelectItem.Location = new System.Drawing.Point(268, 122);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(75, 23);
            this.btnSelectItem.TabIndex = 19;
            this.btnSelectItem.Text = "Select Item";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // scanToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.btnSelectItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtItemToAdd);
            this.Controls.Add(this.bntDeleteItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lstListOfItems);
            this.Controls.Add(this.btnSaveItemsToFile);
            this.Controls.Add(this.btnLoadItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBarcodeData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSendItemID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.posScanner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "scanToolForm";
            this.Text = "scanToolForm";
            this.Load += new System.EventHandler(this.scanToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posScanner)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox windowList;
        private System.Windows.Forms.Label label1;
        private AxOposScanner_CCO.AxOPOSScanner posScanner;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendItemID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBarcodeData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openItemFile;
        private System.Windows.Forms.Button btnLoadItems;
        private System.Windows.Forms.Button btnSaveItemsToFile;
        private System.Windows.Forms.ListBox lstListOfItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button bntDeleteItems;
        private System.Windows.Forms.TextBox txtItemToAdd;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectItem;
    }
}