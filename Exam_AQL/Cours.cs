using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Exam_AQL
{
    class Cours
    {
        string FicherCours = @"C:\Users\Public\Cours.txt";
        public int NumeroEtudiant;
        public int NumeroCours;
        public string TitreDuCours;


        public Cours( int Ne, int Nc, string T){

            NumeroEtudiant = Ne; 
            NumeroCours = Nc;        
            TitreDuCours = T;

            
            using StreamWriter swCours = new StreamWriter(FicherCours, true);
            {
                swCours.Write(Ne);
                swCours.Write(", " + Nc);
                swCours.Write(", " + T);
                swCours.WriteLine();
                swCours.Flush();
            }
        }
    }

    }


