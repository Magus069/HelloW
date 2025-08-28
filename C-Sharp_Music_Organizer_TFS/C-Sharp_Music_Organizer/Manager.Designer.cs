namespace C_Sharp_Music_Organizer
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optGenreArtist = new System.Windows.Forms.RadioButton();
            this.optGenreAlbum = new System.Windows.Forms.RadioButton();
            this.optGenreArtistAlbum = new System.Windows.Forms.RadioButton();
            this.optGenre = new System.Windows.Forms.RadioButton();
            this.optArtistAlbum = new System.Windows.Forms.RadioButton();
            this.optAlbum = new System.Windows.Forms.RadioButton();
            this.optArtist = new System.Windows.Forms.RadioButton();
            this.lblExamplePath = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.chkCutPaste = new System.Windows.Forms.CheckBox();
            this.chkDelAll = new System.Windows.Forms.CheckBox();
            this.cmdOrganize = new System.Windows.Forms.Button();
            this.lblNumberFiles = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkChangeName = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkUseFileInfo = new System.Windows.Forms.CheckBox();
            this.lnkInfo = new System.Windows.Forms.LinkLabel();
            this.trvFilesFolder = new System.Windows.Forms.TreeView();
            this.trvDestinationFolder = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optGenreArtist);
            this.groupBox1.Controls.Add(this.optGenreAlbum);
            this.groupBox1.Controls.Add(this.optGenreArtistAlbum);
            this.groupBox1.Controls.Add(this.optGenre);
            this.groupBox1.Controls.Add(this.optArtistAlbum);
            this.groupBox1.Controls.Add(this.optAlbum);
            this.groupBox1.Controls.Add(this.optArtist);
            this.groupBox1.Location = new System.Drawing.Point(406, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(322, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organisation";
            // 
            // optGenreArtist
            // 
            this.optGenreArtist.AutoSize = true;
            this.optGenreArtist.Location = new System.Drawing.Point(140, 58);
            this.optGenreArtist.Margin = new System.Windows.Forms.Padding(4);
            this.optGenreArtist.Name = "optGenreArtist";
            this.optGenreArtist.Size = new System.Drawing.Size(111, 17);
            this.optGenreArtist.TabIndex = 6;
            this.optGenreArtist.Text = "Genres and Artists";
            this.optGenreArtist.UseVisualStyleBackColor = true;
            this.optGenreArtist.CheckedChanged += new System.EventHandler(this.optGenreArtist_CheckedChanged);
            // 
            // optGenreAlbum
            // 
            this.optGenreAlbum.AutoSize = true;
            this.optGenreAlbum.Location = new System.Drawing.Point(140, 91);
            this.optGenreAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.optGenreAlbum.Name = "optGenreAlbum";
            this.optGenreAlbum.Size = new System.Drawing.Size(117, 17);
            this.optGenreAlbum.TabIndex = 5;
            this.optGenreAlbum.Text = "Genres and Albums";
            this.optGenreAlbum.UseVisualStyleBackColor = true;
            this.optGenreAlbum.CheckedChanged += new System.EventHandler(this.optGenreAlbum_CheckedChanged);
            // 
            // optGenreArtistAlbum
            // 
            this.optGenreArtistAlbum.AutoSize = true;
            this.optGenreArtistAlbum.Checked = true;
            this.optGenreArtistAlbum.Location = new System.Drawing.Point(9, 122);
            this.optGenreArtistAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.optGenreArtistAlbum.Name = "optGenreArtistAlbum";
            this.optGenreArtistAlbum.Size = new System.Drawing.Size(151, 17);
            this.optGenreArtistAlbum.TabIndex = 4;
            this.optGenreArtistAlbum.TabStop = true;
            this.optGenreArtistAlbum.Text = "Genres, Artists and Albums";
            this.optGenreArtistAlbum.UseVisualStyleBackColor = true;
            this.optGenreArtistAlbum.CheckedChanged += new System.EventHandler(this.optGenreArtistAlbum_CheckedChanged);
            // 
            // optGenre
            // 
            this.optGenre.AutoSize = true;
            this.optGenre.Location = new System.Drawing.Point(9, 90);
            this.optGenre.Margin = new System.Windows.Forms.Padding(4);
            this.optGenre.Name = "optGenre";
            this.optGenre.Size = new System.Drawing.Size(59, 17);
            this.optGenre.TabIndex = 3;
            this.optGenre.Text = "Genres";
            this.optGenre.UseVisualStyleBackColor = true;
            this.optGenre.CheckedChanged += new System.EventHandler(this.optGenre_CheckedChanged);
            // 
            // optArtistAlbum
            // 
            this.optArtistAlbum.AutoSize = true;
            this.optArtistAlbum.Location = new System.Drawing.Point(140, 26);
            this.optArtistAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.optArtistAlbum.Name = "optArtistAlbum";
            this.optArtistAlbum.Size = new System.Drawing.Size(111, 17);
            this.optArtistAlbum.TabIndex = 2;
            this.optArtistAlbum.Text = "Artists and Albums";
            this.optArtistAlbum.UseVisualStyleBackColor = true;
            this.optArtistAlbum.CheckedChanged += new System.EventHandler(this.optArtistAlbum_CheckedChanged);
            // 
            // optAlbum
            // 
            this.optAlbum.AutoSize = true;
            this.optAlbum.Location = new System.Drawing.Point(9, 58);
            this.optAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.optAlbum.Name = "optAlbum";
            this.optAlbum.Size = new System.Drawing.Size(59, 17);
            this.optAlbum.TabIndex = 1;
            this.optAlbum.Text = "Albums";
            this.optAlbum.UseVisualStyleBackColor = true;
            this.optAlbum.CheckedChanged += new System.EventHandler(this.optAlbum_CheckedChanged);
            // 
            // optArtist
            // 
            this.optArtist.AutoSize = true;
            this.optArtist.Location = new System.Drawing.Point(9, 26);
            this.optArtist.Margin = new System.Windows.Forms.Padding(4);
            this.optArtist.Name = "optArtist";
            this.optArtist.Size = new System.Drawing.Size(53, 17);
            this.optArtist.TabIndex = 0;
            this.optArtist.Text = "Artists";
            this.optArtist.UseVisualStyleBackColor = true;
            this.optArtist.CheckedChanged += new System.EventHandler(this.optArtist_CheckedChanged);
            // 
            // lblExamplePath
            // 
            this.lblExamplePath.AutoSize = true;
            this.lblExamplePath.Location = new System.Drawing.Point(246, 24);
            this.lblExamplePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamplePath.Name = "lblExamplePath";
            this.lblExamplePath.Size = new System.Drawing.Size(194, 18);
            this.lblExamplePath.TabIndex = 1;
            this.lblExamplePath.Text = "C:\\Music\\Genre\\Artist\\Album";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(18, 17);
            this.cmdBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(219, 32);
            this.cmdBrowse.TabIndex = 2;
            this.cmdBrowse.Text = "Browse Folder Destination";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // chkCutPaste
            // 
            this.chkCutPaste.AutoSize = true;
            this.chkCutPaste.Location = new System.Drawing.Point(9, 26);
            this.chkCutPaste.Margin = new System.Windows.Forms.Padding(4);
            this.chkCutPaste.Name = "chkCutPaste";
            this.chkCutPaste.Size = new System.Drawing.Size(100, 17);
            this.chkCutPaste.TabIndex = 3;
            this.chkCutPaste.Text = "Delete Old Files";
            this.chkCutPaste.UseVisualStyleBackColor = true;
            this.chkCutPaste.CheckedChanged += new System.EventHandler(this.chkCutPaste_CheckedChanged);
            // 
            // chkDelAll
            // 
            this.chkDelAll.AutoSize = true;
            this.chkDelAll.Location = new System.Drawing.Point(148, 27);
            this.chkDelAll.Margin = new System.Windows.Forms.Padding(4);
            this.chkDelAll.Name = "chkDelAll";
            this.chkDelAll.Size = new System.Drawing.Size(113, 17);
            this.chkDelAll.TabIndex = 4;
            this.chkDelAll.Text = "Delete Old Folders";
            this.chkDelAll.UseVisualStyleBackColor = true;
            this.chkDelAll.CheckedChanged += new System.EventHandler(this.chkDelAll_CheckedChanged);
            // 
            // cmdOrganize
            // 
            this.cmdOrganize.Location = new System.Drawing.Point(405, 384);
            this.cmdOrganize.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOrganize.Name = "cmdOrganize";
            this.cmdOrganize.Size = new System.Drawing.Size(112, 32);
            this.cmdOrganize.TabIndex = 5;
            this.cmdOrganize.Text = "Organize";
            this.cmdOrganize.UseVisualStyleBackColor = true;
            this.cmdOrganize.Click += new System.EventHandler(this.cmdOrganize_Click);
            // 
            // lblNumberFiles
            // 
            this.lblNumberFiles.AutoSize = true;
            this.lblNumberFiles.Location = new System.Drawing.Point(531, 391);
            this.lblNumberFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberFiles.Name = "lblNumberFiles";
            this.lblNumberFiles.Size = new System.Drawing.Size(46, 18);
            this.lblNumberFiles.TabIndex = 6;
            this.lblNumberFiles.Text = "0 files";
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(9, 90);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(343, 24);
            this.txtFileName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // chkChangeName
            // 
            this.chkChangeName.AutoSize = true;
            this.chkChangeName.Location = new System.Drawing.Point(70, 66);
            this.chkChangeName.Margin = new System.Windows.Forms.Padding(4);
            this.chkChangeName.Name = "chkChangeName";
            this.chkChangeName.Size = new System.Drawing.Size(118, 17);
            this.chkChangeName.TabIndex = 9;
            this.chkChangeName.Text = "Change Files Name";
            this.chkChangeName.UseVisualStyleBackColor = true;
            this.chkChangeName.CheckedChanged += new System.EventHandler(this.chkChangeName_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chkUseFileInfo);
            this.groupBox2.Controls.Add(this.lnkInfo);
            this.groupBox2.Controls.Add(this.chkChangeName);
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkDelAll);
            this.groupBox2.Controls.Add(this.chkCutPaste);
            this.groupBox2.Location = new System.Drawing.Point(18, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(380, 212);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Use Files Information";
            // 
            // chkUseFileInfo
            // 
            this.chkUseFileInfo.AutoSize = true;
            this.chkUseFileInfo.Enabled = false;
            this.chkUseFileInfo.Location = new System.Drawing.Point(14, 125);
            this.chkUseFileInfo.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseFileInfo.Name = "chkUseFileInfo";
            this.chkUseFileInfo.Size = new System.Drawing.Size(15, 14);
            this.chkUseFileInfo.TabIndex = 12;
            this.chkUseFileInfo.UseVisualStyleBackColor = true;
            // 
            // lnkInfo
            // 
            this.lnkInfo.AutoSize = true;
            this.lnkInfo.Location = new System.Drawing.Point(235, 68);
            this.lnkInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkInfo.Name = "lnkInfo";
            this.lnkInfo.Size = new System.Drawing.Size(83, 18);
            this.lnkInfo.TabIndex = 11;
            this.lnkInfo.TabStop = true;
            this.lnkInfo.Text = "More info...";
            this.lnkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInfo_LinkClicked);
            // 
            // trvFilesFolder
            // 
            this.trvFilesFolder.CheckBoxes = true;
            this.trvFilesFolder.Location = new System.Drawing.Point(18, 316);
            this.trvFilesFolder.Name = "trvFilesFolder";
            this.trvFilesFolder.Size = new System.Drawing.Size(380, 327);
            this.trvFilesFolder.TabIndex = 11;
            this.trvFilesFolder.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvFilesFolder_AfterCheck);
            // 
            // trvDestinationFolder
            // 
            this.trvDestinationFolder.CheckBoxes = true;
            this.trvDestinationFolder.Location = new System.Drawing.Point(607, 316);
            this.trvDestinationFolder.Name = "trvDestinationFolder";
            this.trvDestinationFolder.Size = new System.Drawing.Size(384, 327);
            this.trvDestinationFolder.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Folder Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Folder to organize";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trvDestinationFolder);
            this.Controls.Add(this.trvFilesFolder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblNumberFiles);
            this.Controls.Add(this.cmdOrganize);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.lblExamplePath);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optArtistAlbum;
        private System.Windows.Forms.RadioButton optAlbum;
        private System.Windows.Forms.RadioButton optArtist;
        private System.Windows.Forms.RadioButton optGenreArtist;
        private System.Windows.Forms.RadioButton optGenreAlbum;
        private System.Windows.Forms.RadioButton optGenreArtistAlbum;
        private System.Windows.Forms.RadioButton optGenre;
        private System.Windows.Forms.Label lblExamplePath;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.CheckBox chkCutPaste;
        private System.Windows.Forms.CheckBox chkDelAll;
        private System.Windows.Forms.Button cmdOrganize;
        private System.Windows.Forms.Label lblNumberFiles;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkChangeName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkUseFileInfo;
        private System.Windows.Forms.LinkLabel lnkInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView trvFilesFolder;
        private System.Windows.Forms.TreeView trvDestinationFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}