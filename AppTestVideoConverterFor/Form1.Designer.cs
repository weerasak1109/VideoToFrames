namespace AppTestVideoConverterFor
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
            this.PanelAll = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.PanelLower = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.CountFramesLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SUrl = new MetroFramework.Controls.MetroLabel();
            this.LUrl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BSave = new MetroFramework.Controls.MetroButton();
            this.BOpen = new MetroFramework.Controls.MetroButton();
            this.BConverter = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelAll.SuspendLayout();
            this.PanelLower.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAll
            // 
            this.PanelAll.Controls.Add(this.metroLabel4);
            this.PanelAll.Controls.Add(this.PanelLower);
            this.PanelAll.Controls.Add(this.PanelTop);
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Location = new System.Drawing.Point(20, 60);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Size = new System.Drawing.Size(921, 544);
            this.PanelAll.TabIndex = 0;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 518);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 2;
            // 
            // PanelLower
            // 
            this.PanelLower.Controls.Add(this.progressBar);
            this.PanelLower.Location = new System.Drawing.Point(0, 490);
            this.PanelLower.Name = "PanelLower";
            this.PanelLower.Size = new System.Drawing.Size(921, 25);
            this.PanelLower.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(13, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(896, 19);
            this.progressBar.TabIndex = 1;
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.TBoxName);
            this.PanelTop.Controls.Add(this.CountFramesLabel);
            this.PanelTop.Controls.Add(this.metroLabel3);
            this.PanelTop.Controls.Add(this.richTextBox);
            this.PanelTop.Controls.Add(this.SUrl);
            this.PanelTop.Controls.Add(this.LUrl);
            this.PanelTop.Controls.Add(this.metroLabel2);
            this.PanelTop.Controls.Add(this.metroLabel1);
            this.PanelTop.Controls.Add(this.BSave);
            this.PanelTop.Controls.Add(this.BOpen);
            this.PanelTop.Controls.Add(this.BConverter);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(921, 484);
            this.PanelTop.TabIndex = 0;
            // 
            // TBoxName
            // 
            this.TBoxName.Location = new System.Drawing.Point(94, 71);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(289, 22);
            this.TBoxName.TabIndex = 10;
            // 
            // CountFramesLabel
            // 
            this.CountFramesLabel.AutoSize = true;
            this.CountFramesLabel.Location = new System.Drawing.Point(151, 117);
            this.CountFramesLabel.Name = "CountFramesLabel";
            this.CountFramesLabel.Size = new System.Drawing.Size(21, 25);
            this.CountFramesLabel.TabIndex = 9;
            this.CountFramesLabel.Text = "0";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(142, 20);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "จำนวนFrames ที่จะได้ :";
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(13, 153);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(896, 320);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            // 
            // SUrl
            // 
            this.SUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SUrl.AutoSize = true;
            this.SUrl.Location = new System.Drawing.Point(94, 42);
            this.SUrl.Name = "SUrl";
            this.SUrl.Size = new System.Drawing.Size(92, 20);
            this.SUrl.TabIndex = 6;
            this.SUrl.Text = "ที่อยู่ที่จะบันทึก";
            // 
            // LUrl
            // 
            this.LUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LUrl.AutoSize = true;
            this.LUrl.Location = new System.Drawing.Point(94, 11);
            this.LUrl.Name = "LUrl";
            this.LUrl.Size = new System.Drawing.Size(72, 20);
            this.LUrl.TabIndex = 5;
            this.LUrl.Text = "ยังไม่มี URL";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "จะบันทึกที่ :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "ที่อยู่วีดีโอ :";
            // 
            // BSave
            // 
            this.BSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BSave.Location = new System.Drawing.Point(593, 68);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(181, 57);
            this.BSave.TabIndex = 2;
            this.BSave.Text = "Save";
            this.BSave.UseSelectable = true;
            this.BSave.Click += new System.EventHandler(this.ButVdoSave_Click);
            // 
            // BOpen
            // 
            this.BOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BOpen.Location = new System.Drawing.Point(593, 11);
            this.BOpen.Name = "BOpen";
            this.BOpen.Size = new System.Drawing.Size(181, 51);
            this.BOpen.TabIndex = 1;
            this.BOpen.Text = "Open Video";
            this.BOpen.UseSelectable = true;
            this.BOpen.Click += new System.EventHandler(this.BOpen_Click);
            // 
            // BConverter
            // 
            this.BConverter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BConverter.Location = new System.Drawing.Point(780, 9);
            this.BConverter.Name = "BConverter";
            this.BConverter.Size = new System.Drawing.Size(120, 116);
            this.BConverter.TabIndex = 0;
            this.BConverter.Text = "Video Converter";
            this.BConverter.UseSelectable = true;
            this.BConverter.Click += new System.EventHandler(this.BConverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "สิ่งนี้คือ :";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(961, 624);
            this.Controls.Add(this.PanelAll);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Video To Frames";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelAll.ResumeLayout(false);
            this.PanelAll.PerformLayout();
            this.PanelLower.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel PanelAll;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelLower;
        private MetroFramework.Controls.MetroButton BConverter;
        private System.Windows.Forms.ProgressBar progressBar;
        private MetroFramework.Controls.MetroButton BOpen;
        private MetroFramework.Controls.MetroButton BSave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel SUrl;
        private MetroFramework.Controls.MetroLabel LUrl;
        private System.Windows.Forms.RichTextBox richTextBox;
        private MetroFramework.Controls.MetroLabel CountFramesLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Label label1;
    }
}

