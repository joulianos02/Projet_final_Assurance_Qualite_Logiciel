using System;
using System.Collections.Generic;
using System.IO; //Pour StreamWriter
using System.Text;


namespace Exam_AQL
{
    class Cours
    {
        string FicherCours = @"C:\Users\Public\Cours.txt"; //Fichier pour les Cours
        public int NumeroEtudiant; //Variable pour le numéro étudiant
        public int NumeroCours; //Variable pour le numéro de cours
        public string TitreDuCours; //Variable pour le titre du cours


        public Cours( int Ne, int Nc, string T){

            NumeroEtudiant = Ne; //Rassignation des variables
            NumeroCours = Nc;        
            TitreDuCours = T;

            
            using StreamWriter swCours = new StreamWriter(FicherCours, true); //Écriture dans le fichier Cours
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


