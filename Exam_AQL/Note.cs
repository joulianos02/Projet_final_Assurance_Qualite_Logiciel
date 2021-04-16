using System;
using System.Collections.Generic;
using System.IO; //Pour le StreamWriter
using System.Text;

namespace Exam_AQL
{
    
    class Note
    {
        string FichierNotes = @"C:\Users\Public\Notes.txt"; //Fichier pour toutes les notes
        string FichierEtudiant_Note = @"C:\Users\Public\Cours0_Note0_0000000.txt"; //Fichier pour les notes individuelles
        public string identifient; //Variable pour Nom du fichier note pour chaque étudiant
        public int NumeroEtudiant; //Variable pour Numéro Étudiant
        public int NumeroCours;//Variable pour numéro de cours
        public int note; //variable pour note

        
        public Note(string Id, int NE, int Nc, int N) 
        {
            using (StreamWriter swFile = File.CreateText(FichierEtudiant_Note)) //Création du fichier
            {
                swFile.WriteLine("Numéro d'étudiant | Numéro de cours | Note");
            }
            identifient = Id + ".txt"; //Assignation des variables
            NumeroEtudiant = NE;
            NumeroCours = Nc;
            note = N;

            using StreamWriter swEtudiant_Note = new StreamWriter(FichierEtudiant_Note, true); //Écriture des notes
            {
                swEtudiant_Note.Write(NE);
                swEtudiant_Note.Write(", " + Nc);
                swEtudiant_Note.Write(", " + N);
                swEtudiant_Note.WriteLine();
                swEtudiant_Note.Close();
            }
            try //Le fichier est renommé et l'ancien est supprimé à la création du prochain fichier
            {
                Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(FichierEtudiant_Note, identifient);
            }
            catch //Si le fichier existe déja, le catch le fait savoir à l'utilisateur.
            {
                Console.WriteLine("Erreur : Le fichier " + identifient + " existe déja.");
                File.Delete(identifient);
                identifient = "Erreur";
            }
            
            //Les notes sont aussi ajoutées dans le fichier de notes pricipal
            using StreamWriter swEtudiant = new StreamWriter(FichierNotes, true);
            {
                swEtudiant.Write(Id);
                swEtudiant.Write(", " + NE);
                swEtudiant.Write(", " + Nc);
                swEtudiant.Write(", " + N);
                swEtudiant.WriteLine();
                swEtudiant.Flush();

            }
           
         
     
        }   
    }

} 