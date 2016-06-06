namespace StyCopy
{
    partial class TyrosHDCopy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TyrosHDCopy));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.containerAListView = new System.Windows.Forms.ListView();
            this.containerBListView = new System.Windows.Forms.ListView();
            this.saveButton = new System.Windows.Forms.Button();
            this.BToAButton = new System.Windows.Forms.Button();
            this.AToBButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CountLabelAllFiles = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExtensieComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OverAllDirPath = new System.Windows.Forms.TextBox();
            this.MakeOverallDir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfFiles = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(298, 483);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 32);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.toolTip1.SetToolTip(this.browseButton, "Search for all files in a directory and all sub/directories.\r\nWhen you have a lot" +
        " of files this will take some time.\r\n\r\n");
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // containerAListView
            // 
            this.containerAListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.containerAListView.Location = new System.Drawing.Point(23, 101);
            this.containerAListView.Name = "containerAListView";
            this.containerAListView.Size = new System.Drawing.Size(350, 354);
            this.containerAListView.TabIndex = 2;
            this.toolTip1.SetToolTip(this.containerAListView, resources.GetString("containerAListView.ToolTip"));
            this.containerAListView.UseCompatibleStateImageBehavior = false;
            this.containerAListView.View = System.Windows.Forms.View.SmallIcon;
            this.containerAListView.SelectedIndexChanged += new System.EventHandler(this.containerAListView_SelectedIndexChanged);
            // 
            // containerBListView
            // 
            this.containerBListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.containerBListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.containerBListView.Location = new System.Drawing.Point(20, 101);
            this.containerBListView.Name = "containerBListView";
            this.containerBListView.Size = new System.Drawing.Size(351, 355);
            this.containerBListView.TabIndex = 3;
            this.toolTip1.SetToolTip(this.containerBListView, "Save all files from to blue-box to a directory\r\non your Tyros.\r\nRemember that 500" +
        " is the MAX otherwise you keyboard\r\nwill generate an error.\r\n\r\n");
            this.containerBListView.UseCompatibleStateImageBehavior = false;
            this.containerBListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(162, 483);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 32);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save on HD";
            this.toolTip1.SetToolTip(this.saveButton, resources.GetString("saveButton.ToolTip"));
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // BToAButton
            // 
            this.BToAButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BToAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BToAButton.Image = ((System.Drawing.Image)(resources.GetObject("BToAButton.Image")));
            this.BToAButton.Location = new System.Drawing.Point(277, 148);
            this.BToAButton.Name = "BToAButton";
            this.BToAButton.Size = new System.Drawing.Size(130, 65);
            this.BToAButton.TabIndex = 5;
            this.BToAButton.Text = "Back";
            this.toolTip1.SetToolTip(this.BToAButton, "I don\'t know why, but maybe you want to send \r\nsome selected files back to the se" +
        "arch results\r\nto copy them later on to another directory.\r\n\r\n");
            this.BToAButton.UseVisualStyleBackColor = true;
            this.BToAButton.Click += new System.EventHandler(this.BToAButton_Click);
            // 
            // AToBButton
            // 
            this.AToBButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AToBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AToBButton.Image = ((System.Drawing.Image)(resources.GetObject("AToBButton.Image")));
            this.AToBButton.Location = new System.Drawing.Point(3, 270);
            this.AToBButton.Name = "AToBButton";
            this.AToBButton.Size = new System.Drawing.Size(130, 65);
            this.AToBButton.TabIndex = 6;
            this.AToBButton.Text = "Copy";
            this.toolTip1.SetToolTip(this.AToBButton, "Copy max 500 files to this container.\r\nYou then will be able to save the files on" +
        " the HD\r\nof your Tyros.\r\n");
            this.AToBButton.UseVisualStyleBackColor = true;
            this.AToBButton.Click += new System.EventHandler(this.AToBButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(171, 75);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(54, 20);
            this.countLabel.TabIndex = 7;
            this.countLabel.Text = "0  /  0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.CountLabelAllFiles);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel1.Controls.Add(this.BToAButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.ExtensieComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.containerAListView);
            this.splitContainer1.Panel1.Controls.Add(this.browseButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel2.Controls.Add(this.OverAllDirPath);
            this.splitContainer1.Panel2.Controls.Add(this.MakeOverallDir);
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.AToBButton);
            this.splitContainer1.Panel2.Controls.Add(this.NumberOfFiles);
            this.splitContainer1.Panel2.Controls.Add(this.countLabel);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar2);
            this.splitContainer1.Panel2.Controls.Add(this.containerBListView);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(807, 524);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 8;
            // 
            // CountLabelAllFiles
            // 
            this.CountLabelAllFiles.AutoSize = true;
            this.CountLabelAllFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabelAllFiles.Location = new System.Drawing.Point(186, 75);
            this.CountLabelAllFiles.Name = "CountLabelAllFiles";
            this.CountLabelAllFiles.Size = new System.Drawing.Size(19, 20);
            this.CountLabelAllFiles.TabIndex = 12;
            this.CountLabelAllFiles.Text = "0";
            this.CountLabelAllFiles.Click += new System.EventHandler(this.CountLabelAllFiles_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(74, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "             A program \r\n                      by\r\nSamir Boelema  & Wim Kersten\r\n" +
        "                June 2016\r\n");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Look for extention:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExtensieComboBox
            // 
            this.ExtensieComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExtensieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtensieComboBox.FormattingEnabled = true;
            this.ExtensieComboBox.Items.AddRange(new object[] {
            "RGT",
            "MID",
            "PAD"});
            this.ExtensieComboBox.Location = new System.Drawing.Point(215, 486);
            this.ExtensieComboBox.Name = "ExtensieComboBox";
            this.ExtensieComboBox.Size = new System.Drawing.Size(68, 28);
            this.ExtensieComboBox.TabIndex = 8;
            this.ExtensieComboBox.Text = "STY";
            this.toolTip1.SetToolTip(this.ExtensieComboBox, resources.GetString("ExtensieComboBox.ToolTip"));
            this.ExtensieComboBox.SelectedIndexChanged += new System.EventHandler(this.ExtensieComboBox_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(23, 462);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 15);
            this.progressBar1.TabIndex = 7;
            // 
            // OverAllDirPath
            // 
            this.OverAllDirPath.Location = new System.Drawing.Point(21, 41);
            this.OverAllDirPath.Name = "OverAllDirPath";
            this.OverAllDirPath.Size = new System.Drawing.Size(350, 20);
            this.OverAllDirPath.TabIndex = 12;
            this.OverAllDirPath.Text = "Choose/make MAIN folder where all will be copied into seperate DIR\'s \r\n";
            this.OverAllDirPath.TextChanged += new System.EventHandler(this.OverAllDirPath_TextChanged);
            // 
            // MakeOverallDir
            // 
            this.MakeOverallDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MakeOverallDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeOverallDir.Location = new System.Drawing.Point(19, 10);
            this.MakeOverallDir.Name = "MakeOverallDir";
            this.MakeOverallDir.Size = new System.Drawing.Size(114, 25);
            this.MakeOverallDir.TabIndex = 11;
            this.MakeOverallDir.Text = "Choose Make";
            this.toolTip1.SetToolTip(this.MakeOverallDir, "Choose or make  one overall directory \r\nwhere all the sub-directories automaticly" +
        " \r\nwill be created and filled with 500 files.\r\n\r\n\r\n\r\n\r\n");
            this.MakeOverallDir.UseVisualStyleBackColor = true;
            this.MakeOverallDir.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(280, 485);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "             A program \r\n                      by\r\nSamir Boelema  & Wim Kersten\r\n" +
        "                June 2016\r\n");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Max files";
            this.toolTip1.SetToolTip(this.label2, "A directory on a Tyros harddisk can contain\r\n500 files max. But maybe you want ju" +
        "st 250 files\r\nin one directory. You can change that here.\r\nDefault is 500");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumberOfFiles
            // 
            this.NumberOfFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfFiles.Location = new System.Drawing.Point(85, 488);
            this.NumberOfFiles.Name = "NumberOfFiles";
            this.NumberOfFiles.Size = new System.Drawing.Size(65, 26);
            this.NumberOfFiles.TabIndex = 9;
            this.NumberOfFiles.Text = "500";
            this.NumberOfFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.NumberOfFiles, "A directory on a Tyros harddisk can contain\r\n500 files max. But maybe you want ju" +
        "st 250 files\r\nin one directory. You can change that here.\r\nDefault is 500\r\n");
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar2.Location = new System.Drawing.Point(21, 462);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(350, 15);
            this.progressBar2.TabIndex = 8;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // TyrosHDCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 524);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TyrosHDCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tyros HD Copy Tool     -     by Samir Boulema & Wim Kersten Boxmeer";
            this.Load += new System.EventHandler(this.TyrosHDCopy_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListView containerAListView;
        private System.Windows.Forms.ListView containerBListView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button BToAButton;
        private System.Windows.Forms.Button AToBButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox ExtensieComboBox;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberOfFiles;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label CountLabelAllFiles;
        private System.Windows.Forms.Button MakeOverallDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox OverAllDirPath;
    }
}

