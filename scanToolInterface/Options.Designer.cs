namespace scanToolInterface
{
    partial class Options
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
            this.configFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtConfigFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectConfigFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // configFileDialog
            // 
            this.configFileDialog.FileName = "configFileDialog";
            // 
            // txtConfigFile
            // 
            this.txtConfigFile.Location = new System.Drawing.Point(101, 32);
            this.txtConfigFile.Name = "txtConfigFile";
            this.txtConfigFile.Size = new System.Drawing.Size(297, 20);
            this.txtConfigFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuration File:";
            // 
            // btnSelectConfigFile
            // 
            this.btnSelectConfigFile.Location = new System.Drawing.Point(410, 20);
            this.btnSelectConfigFile.Name = "btnSelectConfigFile";
            this.btnSelectConfigFile.Size = new System.Drawing.Size(117, 43);
            this.btnSelectConfigFile.TabIndex = 2;
            this.btnSelectConfigFile.Text = "Browse to Select Configuration File";
            this.btnSelectConfigFile.UseVisualStyleBackColor = true;
            this.btnSelectConfigFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 155);
            this.Controls.Add(this.btnSelectConfigFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfigFile);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog configFileDialog;
        private System.Windows.Forms.TextBox txtConfigFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectConfigFile;
    }
}