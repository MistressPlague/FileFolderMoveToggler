namespace FileFolderMoveToggler
{
    partial class Toggler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toggler));
            this.MoveToLabel = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.MovedToggle = new System.Windows.Forms.CheckBox();
            this.AddFolderButton = new System.Windows.Forms.Button();
            this.FileAndFolderList = new FileFolderMoveToggler.TransparentListBox();
            this.MoveToTextBox = new ZBobb.AlphaBlendTextBox();
            this.FolderBrowser = new Plague.Dialogs.WinForms.BetterFolderBrowserDialog();
            this.SuspendLayout();
            // 
            // MoveToLabel
            // 
            this.MoveToLabel.AutoSize = true;
            this.MoveToLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoveToLabel.ForeColor = System.Drawing.Color.Black;
            this.MoveToLabel.Location = new System.Drawing.Point(8, 13);
            this.MoveToLabel.Name = "MoveToLabel";
            this.MoveToLabel.Size = new System.Drawing.Size(98, 13);
            this.MoveToLabel.TabIndex = 0;
            this.MoveToLabel.Text = "Move Selected To:";
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.Transparent;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.Color.Black;
            this.BrowseButton.Location = new System.Drawing.Point(281, 8);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(53, 24);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.BackColor = System.Drawing.Color.Transparent;
            this.AddFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFileButton.ForeColor = System.Drawing.Color.Black;
            this.AddFileButton.Location = new System.Drawing.Point(11, 65);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(155, 23);
            this.AddFileButton.TabIndex = 4;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = false;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // MovedToggle
            // 
            this.MovedToggle.AutoSize = true;
            this.MovedToggle.BackColor = System.Drawing.Color.Transparent;
            this.MovedToggle.ForeColor = System.Drawing.Color.Black;
            this.MovedToggle.Location = new System.Drawing.Point(11, 37);
            this.MovedToggle.Name = "MovedToggle";
            this.MovedToggle.Size = new System.Drawing.Size(65, 17);
            this.MovedToggle.TabIndex = 5;
            this.MovedToggle.Text = "Moved?";
            this.MovedToggle.UseVisualStyleBackColor = false;
            this.MovedToggle.CheckedChanged += new System.EventHandler(this.MovedToggle_CheckedChanged);
            // 
            // AddFolderButton
            // 
            this.AddFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.AddFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFolderButton.ForeColor = System.Drawing.Color.Black;
            this.AddFolderButton.Location = new System.Drawing.Point(179, 65);
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.Size = new System.Drawing.Size(155, 23);
            this.AddFolderButton.TabIndex = 6;
            this.AddFolderButton.Text = "Add Folder";
            this.AddFolderButton.UseVisualStyleBackColor = false;
            this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // FileAndFolderList
            // 
            this.FileAndFolderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FileAndFolderList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FileAndFolderList.ForeColor = System.Drawing.Color.Black;
            this.FileAndFolderList.FormattingEnabled = true;
            this.FileAndFolderList.Location = new System.Drawing.Point(11, 97);
            this.FileAndFolderList.Name = "FileAndFolderList";
            this.FileAndFolderList.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.FileAndFolderList.Size = new System.Drawing.Size(323, 238);
            this.FileAndFolderList.TabIndex = 3;
            // 
            // MoveToTextBox
            // 
            this.MoveToTextBox.BackAlpha = 0;
            this.MoveToTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MoveToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoveToTextBox.ForeColor = System.Drawing.Color.Black;
            this.MoveToTextBox.Location = new System.Drawing.Point(112, 10);
            this.MoveToTextBox.Name = "MoveToTextBox";
            this.MoveToTextBox.Size = new System.Drawing.Size(158, 20);
            this.MoveToTextBox.TabIndex = 1;
            this.MoveToTextBox.Text = "text";
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.UseDescriptionForTitle = true;
            // 
            // Toggler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(346, 347);
            this.Controls.Add(this.AddFolderButton);
            this.Controls.Add(this.MovedToggle);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.FileAndFolderList);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.MoveToTextBox);
            this.Controls.Add(this.MoveToLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "Toggler";
            this.Text = "File/Folder Move Toggler";
            this.Load += new System.EventHandler(this.Toggler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoveToLabel;
        private ZBobb.AlphaBlendTextBox MoveToTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private TransparentListBox FileAndFolderList;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.CheckBox MovedToggle;
        private System.Windows.Forms.Button AddFolderButton;
        private Plague.Dialogs.WinForms.BetterFolderBrowserDialog FolderBrowser;
    }
}

