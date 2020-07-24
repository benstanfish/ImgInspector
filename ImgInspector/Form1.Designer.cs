namespace ImgInspector
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
            this.checkedListBoxImages = new System.Windows.Forms.CheckedListBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonSelectNone = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.buttonWriteFile = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.labelPreview = new System.Windows.Forms.Label();
            this.buttonFileLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogPath = new System.Windows.Forms.TextBox();
            this.buttonLogPath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxImages
            // 
            this.checkedListBoxImages.AllowDrop = true;
            this.checkedListBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxImages.FormattingEnabled = true;
            this.checkedListBoxImages.Location = new System.Drawing.Point(129, 30);
            this.checkedListBoxImages.Name = "checkedListBoxImages";
            this.checkedListBoxImages.Size = new System.Drawing.Size(901, 563);
            this.checkedListBoxImages.TabIndex = 0;
            this.checkedListBoxImages.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxImages_SelectedIndexChanged);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpen.Location = new System.Drawing.Point(12, 30);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(110, 30);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.Location = new System.Drawing.Point(12, 97);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(110, 30);
            this.buttonSelectAll.TabIndex = 2;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonSelectNone
            // 
            this.buttonSelectNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectNone.Location = new System.Drawing.Point(12, 133);
            this.buttonSelectNone.Name = "buttonSelectNone";
            this.buttonSelectNone.Size = new System.Drawing.Size(110, 30);
            this.buttonSelectNone.TabIndex = 3;
            this.buttonSelectNone.Text = "Select None";
            this.buttonSelectNone.UseVisualStyleBackColor = true;
            this.buttonSelectNone.Click += new System.EventHandler(this.buttonSelectNone_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreview.Location = new System.Drawing.Point(1037, 30);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(199, 148);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 4;
            this.pictureBoxPreview.TabStop = false;
            // 
            // buttonWriteFile
            // 
            this.buttonWriteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWriteFile.BackColor = System.Drawing.Color.LightGreen;
            this.buttonWriteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWriteFile.Location = new System.Drawing.Point(1126, 507);
            this.buttonWriteFile.Name = "buttonWriteFile";
            this.buttonWriteFile.Size = new System.Drawing.Size(110, 30);
            this.buttonWriteFile.TabIndex = 5;
            this.buttonWriteFile.Text = "Write";
            this.buttonWriteFile.UseVisualStyleBackColor = false;
            this.buttonWriteFile.Click += new System.EventHandler(this.buttonWriteFile_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(1126, 624);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 30);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(126, 7);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(72, 17);
            this.labelList.TabIndex = 7;
            this.labelList.Text = "Image List";
            // 
            // labelPreview
            // 
            this.labelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(1034, 7);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(99, 17);
            this.labelPreview.TabIndex = 8;
            this.labelPreview.Text = "Image Preview";
            // 
            // buttonFileLoc
            // 
            this.buttonFileLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileLoc.Location = new System.Drawing.Point(1126, 543);
            this.buttonFileLoc.Name = "buttonFileLoc";
            this.buttonFileLoc.Size = new System.Drawing.Size(110, 30);
            this.buttonFileLoc.TabIndex = 9;
            this.buttonFileLoc.Text = "Explorer";
            this.buttonFileLoc.UseVisualStyleBackColor = true;
            this.buttonFileLoc.Click += new System.EventHandler(this.buttonFileLoc_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Log Path";
            // 
            // textBoxLogPath
            // 
            this.textBoxLogPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogPath.Location = new System.Drawing.Point(129, 634);
            this.textBoxLogPath.Name = "textBoxLogPath";
            this.textBoxLogPath.Size = new System.Drawing.Size(901, 22);
            this.textBoxLogPath.TabIndex = 11;
            // 
            // buttonLogPath
            // 
            this.buttonLogPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogPath.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLogPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogPath.Location = new System.Drawing.Point(13, 630);
            this.buttonLogPath.Name = "buttonLogPath";
            this.buttonLogPath.Size = new System.Drawing.Size(110, 30);
            this.buttonLogPath.TabIndex = 12;
            this.buttonLogPath.Text = "Save";
            this.buttonLogPath.UseVisualStyleBackColor = false;
            this.buttonLogPath.Click += new System.EventHandler(this.buttonLogPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 670);
            this.Controls.Add(this.buttonLogPath);
            this.Controls.Add(this.textBoxLogPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFileLoc);
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWriteFile);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.buttonSelectNone);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.checkedListBoxImages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Inspector v0.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxImages;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectNone;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button buttonWriteFile;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.Button buttonFileLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogPath;
        private System.Windows.Forms.Button buttonLogPath;
    }
}

