using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam_AQL
{
    class Note
    {
        

        string FichierEtudiants = @"C:\Users\Public\Etudiants.txt";
        public string identifient;
        public int NumeroEtudiant;
        public int NumeroCours;
        public int note;

        public Note(string Id, int NE, int Nc, int N)
        {
            identifient = Id;
            NumeroEtudiant = NE;
            NumeroCours = Nc;
            note = N;

            using StreamWriter swEtudiant = new StreamWriter(FichierEtudiants, true);
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

