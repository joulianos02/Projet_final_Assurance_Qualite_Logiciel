using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam_AQL
{
    
    class Note
    {
        string FichierNotes = @"C:\Users\Public\Notes.txt";
        string FichierEtudiant_Note = @"C:\Users\Public\Cours0_Note0_0000000.txt";
        public string renameNote = "true";
        public string identifient;
        public int NumeroEtudiant;
        public int NumeroCours;
        public int note;

        
        public Note(string Id, int NE, int Nc, int N)
        {
            using (StreamWriter swFile = File.CreateText(FichierEtudiant_Note))
            {
                swFile.WriteLine("Numéro d'étudiant | Numéro de cours | Note");
            }
            identifient = Id + ".txt";
            NumeroEtudiant = NE;
            NumeroCours = Nc;
            note = N;

            using StreamWriter swEtudiant_Note = new StreamWriter(FichierEtudiant_Note, true);
            {
                swEtudiant_Note.Write(NE);
                swEtudiant_Note.Write(", " + Nc);
                swEtudiant_Note.Write(", " + N);
                swEtudiant_Note.WriteLine();
                swEtudiant_Note.Close();
            }
            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(FichierEtudiant_Note, identifient);
            }
            catch
            {
                Console.WriteLine("Erreur : Le fichier " + identifient + " existe déja.");
                File.Delete(identifient);
                identifient = "Erreur";
            }
            

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