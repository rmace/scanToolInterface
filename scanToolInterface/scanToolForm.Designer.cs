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
            ((System.ComponentModel.ISupportInitialize)(this.posScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // windowList
            // 
            this.windowList.FormattingEnabled = true;
            this.windowList.Location = new System.Drawing.Point(13, 43);
            this.windowList.Name = "windowList";
            this.windowList.Size = new System.Drawing.Size(614, 21);
            this.windowList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
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
            this.posScanner.Size = new System.Drawing.Size(356, 41);
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
            // scanToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSendItemID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.posScanner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowList);
            this.Name = "scanToolForm";
            this.Text = "scanToolForm";
            this.Load += new System.EventHandler(this.scanToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posScanner)).EndInit();
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
    }
}