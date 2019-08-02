using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;

namespace C_Sharp_Music_Organizer
{
    public partial class EditForm : Form
    {
        #region Variables
        FileManager myFileManager = new FileManager();

        DialogResult dlrPlayBack = new DialogResult();

        List<TagLib.File> lstMusicFiles = new List<TagLib.File>();
        List<TagLib.File> lstMusicFileSearch = new List<TagLib.File>();
        //List<TagLib.File> lstMusicFilesEdit = new List<TagLib.File>();

        bool boSearch = false;
        bool boEdit = false;
        bool boNavigate = false;

        int intIndex = 0;
        int intCount = 0;
        #endregion

        #region Form_Event
        public EditForm()
        {
            InitializeComponent();
            txtSearch.Focus();
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (boEdit == true)
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Would you like to save modifications before leaving?", "Save?", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFiles();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Methods
        public void setList(FileManager myFileManager)
        {
            this.myFileManager = myFileManager;
            foreach (TagLib.File oneFile in myFileManager.getList())
            {
                lstMusicFiles.Add(oneFile);
            }
            //lstMusicFiles = myFileManager.getList();
            intCount = lstMusicFiles.Count();
            ShowDetails();
        }

        private void ShowDetails()
        {
            boNavigate = true;
            lblIndex.Text = (intIndex + 1).ToString() + " / " + (intCount).ToString();
            int intName = 0;
            int intNameIndex = 0;
            foreach (char oneChar in lstMusicFiles.ElementAt(intIndex).Name)
            {
                intNameIndex += 1;
                if (oneChar.ToString() == @"\")
                {
                    intName = intNameIndex;
                }
            }
            string strName = lstMusicFiles.ElementAt(intIndex).Name.Substring(intName, lstMusicFiles.ElementAt(intIndex).Name.Length - intName);
            lblFileName.Text = strName;
            if (lstMusicFiles.ElementAt(intIndex).Tag.Title != null)
            {
                txtTitle.Text = lstMusicFiles.ElementAt(intIndex).Tag.Title;
            }
            else
            {
                txtTitle.Text = "";
            }
            if (lstMusicFiles.ElementAt(intIndex).Tag.AlbumArtists.Count() > 0)
            {
                TagLib.File theFile = lstMusicFiles.ElementAt(intIndex);
                txtArtist.Text = theFile.Tag.AlbumArtists[0];
            }
            else
            {
                txtArtist.Text = "";
            }
            if (lstMusicFiles.ElementAt(intIndex).Tag.Album != null)
            {
                txtAlbum.Text = lstMusicFiles.ElementAt(intIndex).Tag.Album;
            }
            else
            {
                txtAlbum.Text = "";
            }
            if (lstMusicFiles.ElementAt(intIndex).Tag.Genres.Count() > 0)
            {
                txtGenre.Text = lstMusicFiles.ElementAt(intIndex).Tag.Genres[0];
            }
            else
            {
                txtGenre.Text = "";
            }
            txtTrack.Text = lstMusicFiles.ElementAt(intIndex).Tag.Track.ToString();
            if (lstMusicFiles.ElementAt(intIndex).Tag.Comment != null)
            {
                txtComment.Text = lstMusicFiles.ElementAt(intIndex).Tag.Comment;
            }
            else
            {
                txtComment.Text = "";
            }
            txtYear.Text = lstMusicFiles.ElementAt(intIndex).Tag.Year.ToString();
            txtTrackCount.Text = lstMusicFiles.ElementAt(intIndex).Tag.TrackCount.ToString();
            TagLib.IPicture[] imgPicture = lstMusicFiles.ElementAt(intIndex).Tag.Pictures;
            if (imgPicture.Length >= 1)
            {
                try
                {
                    var bin = (byte[])(imgPicture[0].Data.Data);
                    imgBox.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(350, 350, null, IntPtr.Zero);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + @"\nName : " + lstMusicFiles.ElementAt(intIndex).Name + @"\nTitle : " + lstMusicFiles.ElementAt(intIndex).Tag.Title + @"\nArtist : " + lstMusicFiles.ElementAt(intIndex).Tag.Album + @"\n\nPicture Error!!! :\n" + lstMusicFiles.ElementAt(intIndex).Tag.Pictures.Length + @"\n\nA problem has been unhandled with the picture, sorry for the inconvenient.\nPlease try to save another picture!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                imgBox.Image = null;
            }
            boNavigate = false;
        }

        private bool SaveFiles()
        { //Saving File using the ListFile
            bool boError = false;
            foreach (TagLib.File myFile in lstMusicFiles)
            {
                //myFile = SaveList();
                try
                {
                    myFile.Save();
                }
                catch (Exception e)
                {
                    boError = true;
                    MessageBox.Show("This file : " + myFile.Name + "\ncould not be saved because it might be in use by another program.\nI strongly recommend to close any pogram using or playing music files and save again!\n\n" + e.Message);
                }
            }
            if (!boError)
            {
                boEdit = false;
            }
            return boError;
        }

        private TagLib.File SaveList()
        { //Saving file into List            
            uint intTrack;
            uint intYear;
            uint intTrackCount;
            lstMusicFiles.ElementAt(intIndex).Tag.Title = txtTitle.Text;
            lstMusicFiles.ElementAt(intIndex).Tag.AlbumArtists = new string[] { txtArtist.Text };
            lstMusicFiles.ElementAt(intIndex).Tag.Album = txtAlbum.Text;
            lstMusicFiles.ElementAt(intIndex).Tag.Genres = new string[] { txtGenre.Text };
            if (UInt32.TryParse(txtTrack.Text, out intTrack))
            {
                lstMusicFiles.ElementAt(intIndex).Tag.Track = intTrack;
            }
            lstMusicFiles.ElementAt(intIndex).Tag.Comment = txtComment.Text;
            if (UInt32.TryParse(txtYear.Text, out intYear))
            {
                lstMusicFiles.ElementAt(intIndex).Tag.Year = intYear;
            }
            if (UInt32.TryParse(txtTrackCount.Text, out intTrackCount))
            {
                lstMusicFiles.ElementAt(intIndex).Tag.TrackCount = intTrackCount;
            }
            lstMusicFiles.ElementAt(intIndex).Tag.Pictures = lstMusicFiles.ElementAt(intIndex).Tag.Pictures;
            return lstMusicFiles.ElementAt(intIndex);
        }

        #endregion

        #region Click_Event

        private void cmdPrevious_Click(object sender, EventArgs e)
        {
            boNavigate = true;
            SaveList();
            if (intIndex == 0)
            {
                intIndex = intCount - 1;
            }
            else
            {
                intIndex -= 1;
            }
            ShowDetails();
            boNavigate = false;
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            boNavigate = true;
            SaveList();
            if (intIndex == intCount - 1)
            {
                intIndex = 0;
            }
            else
            {
                intIndex += 1;
            }
            ShowDetails();
            boNavigate = false;
        }

        private void cmdChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofdImage.ShowDialog();
            if (ofdImage.FileName != "")
            {
                boEdit = true;
                string strPath = ofdImage.FileName;
                imgBox.Image = Image.FromFile(strPath).GetThumbnailImage(350, 350, null, IntPtr.Zero);
                TagLib.IPicture myPicture = new TagLib.Picture(strPath);
                lstMusicFiles.ElementAt(intIndex).Tag.Pictures = new TagLib.IPicture[1] { myPicture };
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Are you sure you want to save all information in the files?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!SaveFiles())
                {
                    MessageBox.Show("All files have been saved successfully!");
                }
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Abort;
            if (boSearch == false && txtSearch.Text != "")
            {
                boSearch = true;
                if (boEdit == true)
                {
                    result = MessageBox.Show("Do you want to save your modifications?", "Save?", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        if (SaveFiles())
                        {
                            if (MessageBox.Show("An error occured while saving some files, do you want to cancel the search and save again?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                return;
                            }
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            else if (boSearch == true && txtSearch.Text == "")
            {
                boSearch = false;
                if (boEdit == true)
                {
                    result = MessageBox.Show("Do you want to save your modifications?", "Save?", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        if (SaveFiles())
                        {
                            if (MessageBox.Show("An error occured while saving some files, do you want to cancel the search and save again?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                return;
                            }
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                lstMusicFiles.Clear();
                foreach (TagLib.File oneFile in myFileManager.getList())
                {
                    lstMusicFiles.Add(oneFile);
                }
                intIndex = 0;
                intCount = lstMusicFiles.Count;
                lblIndex.Text = (intIndex + 1).ToString() + " / " + intCount.ToString();
                ShowDetails();
                return;
            }
            else if (boSearch == true && txtSearch.Text != "")
            {
                if (boEdit == true)
                {
                    result = MessageBox.Show("Do you want to save your modifications?", "Save?", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        if (SaveFiles())
                        {
                            if (MessageBox.Show("An error occured while saving some files, do you want to cancel the search and save again?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                return;
                            }
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            else if (boSearch == false && txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a keyword to search through the list!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lstMusicFiles.Clear();
            foreach (TagLib.File myFile in myFileManager.getList())
            {
                string strName = myFile.Name;
                string strTitle = "";
                //Vérifier les tags et les stockées dans une variable
                if (myFile.Tag.Title != null)
                {
                    strTitle = myFile.Tag.Title;
                }
                string strAlbum = "";
                if (myFile.Tag.Album != null)
                {
                    strAlbum = myFile.Tag.Album;
                }
                string strArtist = "";
                if (myFile.Tag.AlbumArtists.Count() > 0)
                {
                    strArtist = myFile.Tag.AlbumArtists[0];
                }
                string strGenre = "";
                if (myFile.Tag.Genres.Count() > 0)
                {
                    strGenre = myFile.Tag.Genres[0];
                }
                if (optNone.Checked)
                {
                    //Comparer la recherche pour ajouter dans la liste
                    if (strName.ToLower().Contains(txtSearch.Text.ToLower()) || strTitle.ToLower().Contains(txtSearch.Text.ToLower()) || strAlbum.ToLower().Contains(txtSearch.Text.ToLower()) || strArtist.ToLower().Contains(txtSearch.Text.ToLower()) || strGenre.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        lstMusicFiles.Add(myFile);
                    }
                }
                else if (optAlbum.Checked)
                {
                    if (strAlbum.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        lstMusicFiles.Add(myFile);
                    }
                }
                else if (optArtist.Checked)
                {
                    if (strArtist.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        lstMusicFiles.Add(myFile);
                    }
                }
                else if (optGenre.Checked)
                {
                    if (strGenre.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        lstMusicFiles.Add(myFile);
                    }
                }
                else if (optTitle.Checked)
                {
                    if (strTitle.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        lstMusicFiles.Add(myFile);
                    }
                }

            }
            if (lstMusicFiles.Count > 0)
            {
                intIndex = 0;
                intCount = lstMusicFiles.Count;
                ShowDetails();
            }
            else
            {
                boSearch = false;
                intIndex = 0;
                intCount = myFileManager.getList().Count;
                foreach (TagLib.File myFile in myFileManager.getList())
                {
                    lstMusicFiles.Add(myFile);
                }
                MessageBox.Show("There is no file(s) corresponding to : \"" + txtSearch.Text + "\"");
                ShowDetails();
            }

        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            if (dlrPlayBack != DialogResult.OK)
            {
                MessageBox.Show("Before using the playback button you should be aware to never save while another program is playing a song!\nAn error will occur when saving. To prevent this, you simply can edit all your files and save when your done,\nmaking sure you closed any application using music files! Thanks!");
                dlrPlayBack = DialogResult.OK;
            }
            Process.Start(lstMusicFiles[intIndex].Name);
        }
        #endregion

        #region Text_Changed
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (!boNavigate)
            {
                boEdit = true;
            }
        }

        private void txtArtist_TextChanged(object sender, EventArgs e)
        {
            if (!boNavigate)
            {
                boEdit = true;
            }
        }

        private void txtAlbum_TextChanged(object sender, EventArgs e)
        {
            if (!boNavigate)
            {
                boEdit = true;
            }
        }

        private void txtGenre_TextChanged(object sender, EventArgs e)
        {
            if (!boNavigate)
            {
                boEdit = true;
            }
        }

        private void txtTrack_TextChanged(object sender, EventArgs e)
        {
            if (!boNavigate)
            {
                boEdit = true;
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (!boNavigate)
            {
                boEdit = true;
            }
        }

        private void txtTrackCount_TextChanged(object sender, EventArgs e)
        {
            if (!boNavigate)
            {
                boEdit = true;
            }
        }
        #endregion
    }
}
