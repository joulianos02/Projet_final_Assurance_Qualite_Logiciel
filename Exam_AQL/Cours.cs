using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Exam_AQL
{
    class Cours
    {
        string FichierEtudiants = @"C:\Users\Public\Etudiants.txt";
        public int NumeroCours;
        public int NumeroEtudiant;
        public string TitreDuCours;


        public Cours( int Nc, int Ne, string T){
            NumeroCours = Nc;
            NumeroEtudiant = Ne;
            TitreDuCours = T;

            
            using StreamWriter swEtudiant = new StreamWriter(FichierEtudiants, true);
            {
                swEtudiant.Write(Nc);
                swEtudiant.Write(", " + Ne);
                swEtudiant.Write(", " + T);
                swEtudiant.WriteLine();
                swEtudiant.Flush();
            }
        }
    }

    }


