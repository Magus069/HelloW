using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Security.AccessControl;

namespace C_Sharp_Music_Organizer
{
    public partial class MusicOrganizer : Form
    {
        //Chemin du dossier parent
        #region Variables
        string strPath = "";
        List<string> lstError = new List<string>();
        //Instance d'objet
        FileManager myFileManager = new FileManager();

        //Liste de fichier de musique
        List<TagLib.File> lstMusicFile = new List<TagLib.File>();
        int intCount = 0;
        int intIndex = 0;
        #endregion

        public MusicOrganizer()
        {
            InitializeComponent();
            if (strPath == "")
            {
                lnkPath.Text = "Path...";
            }
            else
            {
                if (Directory.Exists(strPath))
                {
                    lnkPath.Text = strPath;
                }
            }
        }

        #region Click_Event

        private void cmdSelectFolder_Click(object sender, EventArgs e)
        {
            cmdSelectFolder.Enabled = false;
            cmdAddFolder.Enabled = false;
            cmdEdit.Enabled = false;
            cmdManage.Enabled = false;
            intIndex = 0;
            FolderBrowserDialog fbdFolder = new FolderBrowserDialog();
            fbdFolder.ShowNewFolderButton = false;
            fbdFolder.ShowDialog();
            strPath = fbdFolder.SelectedPath.ToString();
            if (strPath != "")
            {
                Waiting frmWaitBox = new Waiting();
                frmWaitBox.Show();
                frmWaitBox.Location = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height / 2);
                lstMusic.Items.Clear();
                lstMusicFile.Clear();
                lnkPath.Text = strPath;
                lnkPath.Enabled = true;
                myFileManager.setPath(strPath);
                this.CreateList();
                Application.DoEvents();
                intCount = lstMusicFile.Count();

                if (lstMusicFile.Count > 0)
                {
                    cmdEdit.Enabled = true;
                }
                else
                {
                    cmdEdit.Enabled = false;
                }
                //if (lstError.Count() > 0)
                //{
                //    using (StreamWriter sw = File.CreateText("ErrorReport.txt"))
                //    {

                //        foreach (string strError in lstError)
                //        {
                //            sw.WriteLine(strError);
                //        }
                //    }
                //    MessageBox.Show("Some errors have been reported! Details are shown in the ErrorReport.txt");
                //    lnkErrorReport.Enabled = true;
                //    lnkErrorReport.Visible = true;
                //}
                frmWaitBox.Close();
            }
            cmdSelectFolder.Enabled = true;
            cmdAddFolder.Enabled = true;
            if (lstMusic.Items.Count > 0)
            {
                cmdEdit.Enabled = true;
                cmdManage.Enabled = true;
            }

        }

        private void cmdAddFolder_Click(object sender, EventArgs e)
        {

            cmdSelectFolder.Enabled = false;
            cmdAddFolder.Enabled = false;
            cmdEdit.Enabled = false;
            cmdManage.Enabled = false;
            FolderBrowserDialog fbdFolder = new FolderBrowserDialog();
            fbdFolder.ShowNewFolderButton = false;
            fbdFolder.ShowDialog();
            strPath = fbdFolder.SelectedPath.ToString();
            if (strPath != "")
            {
                Waiting frmWaitBox = new Waiting();
                frmWaitBox.Show();
                frmWaitBox.Location = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height / 2);
                lnkPath.Text += @"_&_" + fbdFolder.SelectedPath.ToString();
                lnkPath.Enabled = false;
                myFileManager.addPath(strPath);
                this.CreateList();
                frmWaitBox.Close();
            }
            cmdSelectFolder.Enabled = true;
            cmdAddFolder.Enabled = true;
            if (lstMusic.Items.Count > 0)
            {
                cmdEdit.Enabled = true;
                cmdManage.Enabled = true;
            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            EditForm frmEdit = new EditForm();
            myFileManager.setList(lstMusicFile);
            frmEdit.setList(myFileManager);
            frmEdit.ShowDialog();
        }

        private void cmdManage_Click(object sender, EventArgs e)
        {
            Manager frmManager = new Manager();
            myFileManager.setList(lstMusicFile);
            frmManager.setList(myFileManager);
            frmManager.ShowDialog();
        }

        #region LinkClick
        private void lnkErrorReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("ErrorReport.txt");
        }

        private void lnkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lnkPath.Text);
        }
        #endregion

        #endregion

        #region Methods

        public void CreateList()
        {
            //Créer la liste des dossiers à parcourir
            if (Directory.GetDirectories(strPath).GetLength(0) > 0)
            {

                SearchFolder(strPath);
            }

            foreach (string strFile in Directory.GetFiles(strPath))
            {//Retient le chemin de chaque fichier de musique
                if (strFile.ToLower().EndsWith(".flac") || strFile.ToLower().EndsWith(".mp3") || strFile.ToLower().EndsWith(".wma"))
                {
                    if (getFile(strFile) != null)
                    {//Ajoute le fichier de musique à la liste
                        lstMusic.Items.Add(strFile);
                        lstMusicFile.Add(getFile(strFile));
                        intCount = lstMusicFile.Count();
                        lblCount.Text = intCount.ToString() + " / " + intCount.ToString();
                        Application.DoEvents();
                    }
                }
                //if (strFile.ToLower().EndsWith(".wav"))
                //{
                //    if (getWaveFile(strFile) != null)
                //    {
                //        lstMusic.Items.Add(strFile);
                //        lstMusicFile.Add(getWaveFile(strFile));
                //        intCount = lstMusicFile.Count();
                //        lblCount.Text = intCount.ToString() + " / " + intCount.ToString();
                //        Application.DoEvents();
                //    }
                //}
            }
        }

        public TagLib.File getFile(string strFile)
        {
            //Préparation à la recherche d'information
            TagLib.File tlfFile;
            try
            {//Recherche d'information du fichier de musique
                tlfFile = TagLib.File.Create(strFile);
                return tlfFile;
            }
            catch (Exception e)
            {
                //Enregistre l'erreur
                lstError.Add(e.Message + " ___ " + strFile);
                return null;
            }
        }

        //public TagLib.File getWaveFile(string strFile) {
        //    TagLib.File tlrFile;
        //    try
        //    {
        //        tlrFile = TagLib.Riff.File.Create(strFile);
        //        return tlrFile;
        //    }
        //    catch (Exception e) { 
        //        lstError.Add(e.Message + " ___ " + strFile);
        //    }
        //    return null;
        //}

        public void SearchFolder(string strFolderPath)
        {
            //Méthode récursive pour rechercher chaque répertoire
            try
            {
                foreach (string strFolder in Directory.GetDirectories(strFolderPath))
                {//Recherche chaque répertoire
                    if (!strFolder.Contains("$RECYCLE.BIN") && Directory.GetDirectories(strFolder).GetLength(0) > 0)
                    {//Rappel de la méthode récursive
                        SearchFolder(strFolder);
                    }

                    try
                    {
                        foreach (string strFile in Directory.GetFiles(strFolder))
                        {//Retient les fichiers de musique
                            if (strFile.EndsWith(".flac") || strFile.EndsWith(".mp3") || strFile.EndsWith(".wma") || strFile.EndsWith(".FLAC") || strFile.EndsWith(".MP3") || strFile.EndsWith(".WMA"))
                            {
                                if (getFile(strFile) != null)
                                {//Ajoute le fichier de musique à la liste
                                    lstMusic.Items.Add(strFile);
                                    lstMusicFile.Add(getFile(strFile));
                                    intCount = lstMusicFile.Count();
                                    lblCount.Text = intCount.ToString() + " / " + intCount.ToString();
                                    Application.DoEvents();
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        //Enregistre l'erreur
                        lstError.Add(e.Message + " ___ " + strFolder);
                    }
                }
            }
            catch (Exception e)
            {
                //Enregistre l'erreur
                lstError.Add(e.Message + " ___ " + strFolderPath);
            }

        }

        #endregion

    }
}
