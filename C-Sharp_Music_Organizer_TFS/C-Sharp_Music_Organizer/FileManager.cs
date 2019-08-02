using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace C_Sharp_Music_Organizer
{
    public class FileManager
    {
        //Chemin du dossier parent
        List<string> strPath = new List<string>();

        //Liste des fichiers de musique utilisant Tag Library
        public List<TagLib.File> lstFile = new List<TagLib.File>();

        //Liste d'erreur survenue lors de la recherche d'information de fichiers
        List<string> lstError = new List<string>();

        public FileManager() { 
            //Constructeur par défaut
        }

        public FileManager(string strPath) {
            //Constructeur par paramètre
            this.strPath.Add(strPath);
        }

        public List<string> getPath() {
            return strPath;
        }

        public void addPath(string strPath) { 
            //Ajoute un dossier parent
            this.strPath.Add(strPath);
            AddToList(strPath);
        }

        public void setPath(string strPath) {
            //Définit un dossier parent
            this.strPath.Clear();
            this.strPath.Add(strPath);
        }

        public List<string> getErrorList() {
            //Renvoie la liste d'erreur
            return lstError;
        }

        private void AddToList(string strChemin) {
            if (Directory.GetDirectories(strChemin).GetLength(0) > 0)
            {
                SearchFolder(strChemin);
            }

            foreach (string strFile in Directory.GetFiles(strChemin))
            {//Retient le chemin de chaque fichier de musique
                if (strFile.ToLower().EndsWith(".flac") || strFile.ToLower().EndsWith(".mp3") || strFile.ToLower().EndsWith(".wma"))
                {
                    if (getFile(strFile) != null)
                    {//Ajoute le fichier de musique à la liste
                        lstFile.Add(getFile(strFile));
                    }
                }
            }
        }

        public void CreateList() {
            //Créer la liste des dossiers à parcourir
            foreach (string unChemin in strPath)
            {
                if (Directory.GetDirectories(unChemin).GetLength(0) > 0)
                {
                    SearchFolder(unChemin);
                }

                foreach (string strFile in Directory.GetFiles(unChemin))
                {//Retient le chemin de chaque fichier de musique
                    if (strFile.ToLower().EndsWith(".flac") || strFile.ToLower().EndsWith(".mp3") || strFile.ToLower().EndsWith(".wma"))
                    {
                        if (getFile(strFile) != null)
                        {//Ajoute le fichier de musique à la liste
                            lstFile.Add(getFile(strFile));
                        }
                    }
                }
            }
        }

        public List<TagLib.File> getList(){
            //Retourne la liste des fichiers recherchées
            return lstFile;
        }

        public void setList(List<TagLib.File> lstFile) { 
            //Reçois les paramètres pour la liste
            foreach (TagLib.File oneFile in lstFile) {
                this.lstFile.Add(oneFile);
            }
        }

        public void SearchFolder(string strFolderPath) {
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
                                    lstFile.Add(getFile(strFile));
                                }
                            }
                        }
                    }
                    catch (Exception e) {
                        //Enregistre l'erreur
                        lstError.Add(e.Message + " ___ " + strFolder);
                    }
                }
            }
            catch (Exception e) {
                //Enregistre l'erreur
                lstError.Add(e.Message + " ___ " + strFolderPath);
            }

        }

        public TagLib.File getFile(string strFile) {
            //Préparation à la recherche d'information
            TagLib.File tlfFile;
            try
            {//Recherche d'information du fichier de musique
                tlfFile = TagLib.File.Create(strFile);
                return tlfFile;
            }
            catch (Exception e) {
                //Enregistre l'erreur
                lstError.Add(e.Message + " ___ " + strFile);
                return null;
            }
            
        }

        public bool OrganiseFiles(string strOrganisation, string strPattern, bool boOldFiles, bool boOldFolders, bool boFilesName) 
        {

            return true;
        }

    }
}
