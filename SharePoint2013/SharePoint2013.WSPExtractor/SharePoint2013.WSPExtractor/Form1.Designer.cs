namespace SharePoint2013WSPExtractor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lists = new System.Windows.Forms.GroupBox();
            this.listWSP = new System.Windows.Forms.ListBox();
            this.Messages = new System.Windows.Forms.GroupBox();
            this.textBox_Mess = new System.Windows.Forms.RichTextBox();
            this.butt_Get = new System.Windows.Forms.Button();
            this.butt_Clipboard = new System.Windows.Forms.Button();
            this.butt_Clear = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btView = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btFolder = new System.Windows.Forms.Button();
            this.btOpenFolder = new System.Windows.Forms.Button();
            this.Lists.SuspendLayout();
            this.Messages.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lists
            // 
            this.Lists.Controls.Add(this.listWSP);
            this.Lists.Location = new System.Drawing.Point(12, 38);
            this.Lists.Name = "Lists";
            this.Lists.Size = new System.Drawing.Size(295, 255);
            this.Lists.TabIndex = 6;
            this.Lists.TabStop = false;
            this.Lists.Text = "WSPs (DisplayName)";
            // 
            // listWSP
            // 
            this.listWSP.FormattingEnabled = true;
            this.listWSP.Location = new System.Drawing.Point(13, 19);
            this.listWSP.Name = "listWSP";
            this.listWSP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listWSP.Size = new System.Drawing.Size(265, 225);
            this.listWSP.TabIndex = 0;
            // 
            // Messages
            // 
            this.Messages.Controls.Add(this.textBox_Mess);
            this.Messages.Location = new System.Drawing.Point(313, 38);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(348, 255);
            this.Messages.TabIndex = 7;
            this.Messages.TabStop = false;
            this.Messages.Text = "Messages";
            // 
            // textBox_Mess
            // 
            this.textBox_Mess.Location = new System.Drawing.Point(17, 19);
            this.textBox_Mess.Name = "textBox_Mess";
            this.textBox_Mess.Size = new System.Drawing.Size(315, 225);
            this.textBox_Mess.TabIndex = 5;
            this.textBox_Mess.Text = "";
            // 
            // butt_Get
            // 
            this.butt_Get.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butt_Get.Enabled = false;
            this.butt_Get.Location = new System.Drawing.Point(198, 308);
            this.butt_Get.Name = "butt_Get";
            this.butt_Get.Size = new System.Drawing.Size(75, 23);
            this.butt_Get.TabIndex = 8;
            this.butt_Get.Text = "GetWSPs";
            this.butt_Get.UseVisualStyleBackColor = false;
            this.butt_Get.Click += new System.EventHandler(this.butt_Get_Click);
            // 
            // butt_Clipboard
            // 
            this.butt_Clipboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butt_Clipboard.Location = new System.Drawing.Point(539, 308);
            this.butt_Clipboard.Name = "butt_Clipboard";
            this.butt_Clipboard.Size = new System.Drawing.Size(75, 23);
            this.butt_Clipboard.TabIndex = 9;
            this.butt_Clipboard.Text = "Clipboard";
            this.butt_Clipboard.UseVisualStyleBackColor = false;
            this.butt_Clipboard.Click += new System.EventHandler(this.butt_Clipboard_Click);
            // 
            // butt_Clear
            // 
            this.butt_Clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butt_Clear.Location = new System.Drawing.Point(368, 308);
            this.butt_Clear.Name = "butt_Clear";
            this.butt_Clear.Size = new System.Drawing.Size(75, 23);
            this.butt_Clear.TabIndex = 10;
            this.butt_Clear.Text = "Clear";
            this.butt_Clear.UseVisualStyleBackColor = false;
            this.butt_Clear.Click += new System.EventHandler(this.butt_Clear_Click);
            // 
            // tbPath
            // 
            this.tbPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPath.Location = new System.Drawing.Point(171, 9);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(444, 20);
            this.tbPath.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Folder to save files:";
            // 
            // btView
            // 
            this.btView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btView.Enabled = false;
            this.btView.Location = new System.Drawing.Point(52, 308);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 23);
            this.btView.TabIndex = 13;
            this.btView.Text = "View WSPs";
            this.btView.UseVisualStyleBackColor = false;
            this.btView.Click += new System.EventHandler(this.button1_Click);
            // 
            // btFolder
            // 
            this.btFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btFolder.Location = new System.Drawing.Point(133, 7);
            this.btFolder.Name = "btFolder";
            this.btFolder.Size = new System.Drawing.Size(32, 23);
            this.btFolder.TabIndex = 15;
            this.btFolder.Text = "...";
            this.btFolder.UseVisualStyleBackColor = false;
            this.btFolder.Click += new System.EventHandler(this.btFolder_Click);
            // 
            // btOpenFolder
            // 
            this.btOpenFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btOpenFolder.Enabled = false;
            this.btOpenFolder.Location = new System.Drawing.Point(621, 8);
            this.btOpenFolder.Name = "btOpenFolder";
            this.btOpenFolder.Size = new System.Drawing.Size(40, 23);
            this.btOpenFolder.TabIndex = 16;
            this.btOpenFolder.Text = "->>";
            this.btOpenFolder.UseVisualStyleBackColor = false;
            this.btOpenFolder.Click += new System.EventHandler(this.btOpenFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(673, 340);
            this.Controls.Add(this.btOpenFolder);
            this.Controls.Add(this.btFolder);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.butt_Clear);
            this.Controls.Add(this.butt_Clipboard);
            this.Controls.Add(this.butt_Get);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.Lists);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharePoint2013 WSP Extractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Lists.ResumeLayout(false);
            this.Messages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Lists;
        private System.Windows.Forms.GroupBox Messages;
        private System.Windows.Forms.Button butt_Get;
        private System.Windows.Forms.Button butt_Clipboard;
        private System.Windows.Forms.Button butt_Clear;
        private System.Windows.Forms.RichTextBox textBox_Mess;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.ListBox listWSP;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btFolder;
        private System.Windows.Forms.Button btOpenFolder;
    }
}

