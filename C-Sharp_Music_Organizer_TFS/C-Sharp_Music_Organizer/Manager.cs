using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace C_Sharp_Music_Organizer
{
    public partial class Manager : Form
    {
        #region Variables
        string strFolderPath = "";
        List<string> strPath = new List<string>();
        FileManager myFileManager;

        private readonly Object jeton = new Object();

        #endregion

        #region Form_Event
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            lblNumberFiles.Text = myFileManager.getList().Count().ToString() + " files";
            MessageBox.Show("During this operation, it is highly recommended to close all other applications using or playing music files.\n\nOnce the operation completed all the affected files will have their path changed, so any media player will not be aware of any changes made by this operation!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            trvFilesFolder.BeginUpdate();
            strPath = myFileManager.getPath();
            foreach (string onePath in strPath)
            {
                DirectoryInfo mainFolder = new DirectoryInfo(onePath);
                TreeNode mainNode = new TreeNode(mainFolder.Name);

                TreeNode newNode = populateTreeView(mainNode, mainFolder);
                trvFilesFolder.Nodes.Add(mainNode);
            }
            trvFilesFolder.EndUpdate();
        }
        #endregion

        #region Methods
        public void setList(FileManager myFileManager)
        {
            this.myFileManager = myFileManager;
        }

        private TreeNode populateTreeView(TreeNode myNode, DirectoryInfo myFolder)
        {
            foreach (string strPath in Directory.GetDirectories(myFolder.FullName))
            {
                try
                {
                    if (Directory.Exists(strPath))
                    {
                        DirectoryInfo newFolder = new DirectoryInfo(strPath);
                        TreeNode newNode = new TreeNode(newFolder.Name);
                        myNode.Nodes.Add(populateTreeView(newNode, newFolder));
                    }
                }
                catch (Exception ex) { 
                    
                }
            }

            foreach (string strPath in Directory.GetFiles(myFolder.FullName))
            {
                try
                {
                    if (File.Exists(strPath))
                    {
                        FileInfo newFile = new FileInfo(strPath);
                        TreeNode newNode = new TreeNode(newFile.Name);
                        myNode.Nodes.Add(newNode);
                    }
                }
                catch (Exception ex) { 
                    
                }
            }

            return myNode;
        }

        #endregion

        #region OptionButtons
        private void optArtist_CheckedChanged(object sender, EventArgs e)
        {
            if (strFolderPath != "")
            {
                lblExamplePath.Text = strFolderPath + @"\Artist";
            }
            else
            {
                lblExamplePath.Text = @"C:\Music\Artist";
            }
        }

        private void optArtistAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (strFolderPath != "")
            {
                lblExamplePath.Text = strFolderPath + @"\Artist\Album";
            }
            else
            {
                lblExamplePath.Text = @"C:\Music\Artist\Album";
            }
        }

        private void optAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (strFolderPath != "")
            {
                lblExamplePath.Text = strFolderPath + @"\Album";
            }
            else
            {
                lblExamplePath.Text = @"C:\Music\Album";
            }
        }

        private void optGenreArtist_CheckedChanged(object sender, EventArgs e)
        {
            if (strFolderPath != "")
            {
                lblExamplePath.Text = strFolderPath + @"\Genre\Artist";
            }
            else
            {
                lblExamplePath.Text = @"C:\Music\Genre\Artist";
            }
        }

        private void optGenreAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (strFolderPath != "")
            {
                lblExamplePath.Text = strFolderPath + @"\Genre\Album";
            }
            else
            {
                lblExamplePath.Text = @"C:\Music\Genre\Album";
            }
        }

        private void optGenre_CheckedChanged(object sender, EventArgs e)
        {
            if (strFolderPath != "")
            {
                lblExamplePath.Text = strFolderPath + @"\Genre";
            }
            else
            {
                lblExamplePath.Text = @"C:\Music\Genre";
            }
        }

        private void optGenreArtistAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (strFolderPath != "")
            {
                lblExamplePath.Text = strFolderPath + @"\Genre\Artist\Album";
            }
            else
            {
                lblExamplePath.Text = @"C:\Music\Genre\Artist\Album";
            }
        }

        private void chkDelAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelAll.Checked == true)
            {
                chkCutPaste.Checked = true;
            }
        }

        private void chkCutPaste_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCutPaste.Checked == false && chkDelAll.Checked == true)
            {
                chkDelAll.Checked = false;
            }
        }

        private void chkChangeName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeName.Checked == true)
            {
                txtFileName.Enabled = true;
                chkUseFileInfo.Checked = true;
            }
            else if (chkChangeName.Checked == false)
            {
                txtFileName.Text = "";
                txtFileName.Enabled = false;
                chkUseFileInfo.Checked = false;
            }
        }
        #endregion

        #region Click_Event
        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdbMusicFolder = new FolderBrowserDialog();
            fdbMusicFolder.ShowNewFolderButton = true;
            fdbMusicFolder.ShowDialog();
            strFolderPath = fdbMusicFolder.SelectedPath;
            if (strFolderPath != "")
            {
                if (optAlbum.Checked)
                {
                    lblExamplePath.Text = strFolderPath + @"\Album";
                }
                else if (optArtist.Checked)
                {
                    lblExamplePath.Text = strFolderPath + @"\Artist";
                }
                else if (optArtistAlbum.Checked)
                {
                    lblExamplePath.Text = strFolderPath + @"\Artist\Album";
                }
                else if (optGenre.Checked)
                {
                    lblExamplePath.Text = strFolderPath + @"\Genre";
                }
                else if (optGenreAlbum.Checked)
                {
                    lblExamplePath.Text = strFolderPath + @"\Genre\Album";
                }
                else if (optGenreArtist.Checked)
                {
                    lblExamplePath.Text = strFolderPath + @"\Genre\Artist";
                }
                else if (optGenreArtistAlbum.Checked)
                {
                    lblExamplePath.Text = strFolderPath + @"\Genre\Artist\Album";
                }




            }
        }

        private void lnkInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("How to change the files name using Music Organizer?\n\n If you choose to change the files name using Music Organizer you can check the option \"Change Files Name\".\nWhen the option is checked you can write your pattern name in the text area below the option.\n\nWrite your pattern using these keywords:\n\nArtist = ar\nAlbum = al\nTrack = tr\nGenre = ge\nTitle = ti\nThe separators used shall be \"_\" or \"-\"\n\nThe option \"Use File Information\" will use the ID3 tags information saved on the files to create the files name.\n If any information is missing, it will leave a blank space in the information missing area.", "Managing Files Name");
        }

        private void cmdOrganize_Click(object sender, EventArgs e)
        {
            if (strFolderPath != "")
            {

            }
            else
            {
                MessageBox.Show("Please make sure to browse for a destination folder!", "Path not found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void trvFilesFolder_AfterCheck(object sender, TreeViewEventArgs e)
        {
            
            lock (jeton)
            {
                Monitor.Wait(jeton);
                trvFilesFolder.BeginUpdate();
                UpdateAllNodes(e.Node, e.Node.Checked);

                Monitor.Pulse(jeton);
                trvFilesFolder.EndUpdate();
                
            }
            //System.Threading.Thread.Sleep(1);
        }

        private void UpdateAllNodes(TreeNode childNode, bool boChecked) {
            lock (jeton)
            {
                foreach (TreeNode newNode in childNode.Nodes)
                {
                    if (newNode.Text)
                    if (childNode.Nodes.Count > 0)
                    {
                        newNode.Checked = boChecked;
                        Application.DoEvents();
                        UpdateAllNodes(newNode, boChecked);
                    }
                    else
                    {
                        newNode.Checked = boChecked;
                    }
                }
                
            }
        }

    }
}
