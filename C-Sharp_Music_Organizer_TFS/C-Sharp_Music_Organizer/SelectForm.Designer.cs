namespace C_Sharp_Music_Organizer
{
    partial class MusicOrganizer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicOrganizer));
            this.cmdSelectFolder = new System.Windows.Forms.Button();
            this.lnkPath = new System.Windows.Forms.LinkLabel();
            this.lstMusic = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.cmdAddFolder = new System.Windows.Forms.Button();
            this.lnkErrorReport = new System.Windows.Forms.LinkLabel();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSelectFolder
            // 
            this.cmdSelectFolder.Location = new System.Drawing.Point(18, 53);
            this.cmdSelectFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSelectFolder.Name = "cmdSelectFolder";
            this.cmdSelectFolder.Size = new System.Drawing.Size(158, 32);
            this.cmdSelectFolder.TabIndex = 0;
            this.cmdSelectFolder.Text = "Select Folder";
            this.cmdSelectFolder.UseVisualStyleBackColor = true;
            this.cmdSelectFolder.Click += new System.EventHandler(this.cmdSelectFolder_Click);
            // 
            // lnkPath
            // 
            this.lnkPath.AutoSize = true;
            this.lnkPath.Enabled = false;
            this.lnkPath.Location = new System.Drawing.Point(184, 12);
            this.lnkPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkPath.Name = "lnkPath";
            this.lnkPath.Size = new System.Drawing.Size(50, 18);
            this.lnkPath.TabIndex = 2;
            this.lnkPath.TabStop = true;
            this.lnkPath.Text = "Path...";
            this.lnkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPath_LinkClicked);
            // 
            // lstMusic
            // 
            this.lstMusic.FormattingEnabled = true;
            this.lstMusic.ItemHeight = 18;
            this.lstMusic.Location = new System.Drawing.Point(18, 93);
            this.lstMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMusic.Name = "lstMusic";
            this.lstMusic.Size = new System.Drawing.Size(1480, 652);
            this.lstMusic.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(184, 30);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(36, 18);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0 / 0";
            // 
            // cmdAddFolder
            // 
            this.cmdAddFolder.Location = new System.Drawing.Point(18, 12);
            this.cmdAddFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAddFolder.Name = "cmdAddFolder";
            this.cmdAddFolder.Size = new System.Drawing.Size(158, 32);
            this.cmdAddFolder.TabIndex = 5;
            this.cmdAddFolder.Text = "Add Folder";
            this.cmdAddFolder.UseVisualStyleBackColor = true;
            this.cmdAddFolder.Click += new System.EventHandler(this.cmdAddFolder_Click);
            // 
            // lnkErrorReport
            // 
            this.lnkErrorReport.AutoSize = true;
            this.lnkErrorReport.Enabled = false;
            this.lnkErrorReport.Location = new System.Drawing.Point(184, 53);
            this.lnkErrorReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkErrorReport.Name = "lnkErrorReport";
            this.lnkErrorReport.Size = new System.Drawing.Size(91, 18);
            this.lnkErrorReport.TabIndex = 6;
            this.lnkErrorReport.TabStop = true;
            this.lnkErrorReport.Text = "Error Report";
            this.lnkErrorReport.Visible = false;
            this.lnkErrorReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkErrorReport_LinkClicked);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Enabled = false;
            this.cmdEdit.Location = new System.Drawing.Point(18, 762);
            this.cmdEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(112, 32);
            this.cmdEdit.TabIndex = 7;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdManage
            // 
            this.cmdManage.Enabled = false;
            this.cmdManage.Location = new System.Drawing.Point(140, 762);
            this.cmdManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdManage.Name = "cmdManage";
            this.cmdManage.Size = new System.Drawing.Size(112, 32);
            this.cmdManage.TabIndex = 8;
            this.cmdManage.Text = "Manage";
            this.cmdManage.UseVisualStyleBackColor = true;
            this.cmdManage.Click += new System.EventHandler(this.cmdManage_Click);
            // 
            // MusicOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 810);
            this.Controls.Add(this.cmdManage);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.lnkErrorReport);
            this.Controls.Add(this.cmdAddFolder);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lstMusic);
            this.Controls.Add(this.lnkPath);
            this.Controls.Add(this.cmdSelectFolder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusicOrganizer";
            this.Text = "MusicOrganizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSelectFolder;
        private System.Windows.Forms.LinkLabel lnkPath;
        private System.Windows.Forms.ListBox lstMusic;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button cmdAddFolder;
        private System.Windows.Forms.LinkLabel lnkErrorReport;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdManage;
    }
}

