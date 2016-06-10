namespace StyCopy
{
    partial class StyCopy
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.containerBListView = new System.Windows.Forms.ListView();
            this.saveButton = new System.Windows.Forms.Button();
            this.BToAButton = new System.Windows.Forms.Button();
            this.AToBButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.containerAListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionTextBox.Location = new System.Drawing.Point(132, 371);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(39, 20);
            this.extensionTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(177, 369);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // containerBListView
            // 
            this.containerBListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerBListView.Location = new System.Drawing.Point(3, 12);
            this.containerBListView.Name = "containerBListView";
            this.containerBListView.Size = new System.Drawing.Size(271, 348);
            this.containerBListView.TabIndex = 3;
            this.containerBListView.UseCompatibleStateImageBehavior = false;
            this.containerBListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(199, 371);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // BToAButton
            // 
            this.BToAButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BToAButton.Location = new System.Drawing.Point(258, 208);
            this.BToAButton.Name = "BToAButton";
            this.BToAButton.Size = new System.Drawing.Size(36, 23);
            this.BToAButton.TabIndex = 5;
            this.BToAButton.Text = "<-";
            this.BToAButton.UseVisualStyleBackColor = true;
            this.BToAButton.Click += new System.EventHandler(this.BToAButton_Click);
            // 
            // AToBButton
            // 
            this.AToBButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AToBButton.Location = new System.Drawing.Point(258, 149);
            this.AToBButton.Name = "AToBButton";
            this.AToBButton.Size = new System.Drawing.Size(36, 23);
            this.AToBButton.TabIndex = 6;
            this.AToBButton.Text = "->";
            this.AToBButton.UseVisualStyleBackColor = true;
            this.AToBButton.Click += new System.EventHandler(this.AToBButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(3, 376);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 13);
            this.countLabel.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.containerAListBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.browseButton);
            this.splitContainer1.Panel1.Controls.Add(this.BToAButton);
            this.splitContainer1.Panel1.Controls.Add(this.AToBButton);
            this.splitContainer1.Panel1.Controls.Add(this.extensionTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.containerBListView);
            this.splitContainer1.Panel2.Controls.Add(this.countLabel);
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Size = new System.Drawing.Size(596, 401);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 368);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // containerAListBox
            // 
            this.containerAListBox.FormattingEnabled = true;
            this.containerAListBox.Location = new System.Drawing.Point(12, 12);
            this.containerAListBox.Name = "containerAListBox";
            this.containerAListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.containerAListBox.Size = new System.Drawing.Size(240, 342);
            this.containerAListBox.TabIndex = 9;
            // 
            // StyCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 401);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StyCopy";
            this.Text = "StyCopy";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ListView containerBListView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button BToAButton;
        private System.Windows.Forms.Button AToBButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox containerAListBox;
    }
}

