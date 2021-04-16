using System;
using System.Collections.Generic;
using System.IO; //Pour StremWriter
using System.Text;

namespace Exam_AQL
{
    class Etudiant {
        string FichierEtudiants = @"C:\Users\Public\Etudiants.txt"; //Fichier contenant les Étudiants
        public int NumeroEtudiant; //Variable contenant le numéro Étudiant
        public string Prenom; //Vairable contenant le Prénom
        public string Nom; //Variable contenant le nom

        public Etudiant(int NE, string P, string N) //Classe Étudiant
        {
            NumeroEtudiant = NE;
            Prenom = P;
            Nom = N;
            using StreamWriter swEtudiant = new StreamWriter(FichierEtudiants, true); //Écriture dans le fichier Étudiant
            {
                swEtudiant.Write(P);
                swEtudiant.Write(", " + N);
                swEtudiant.Write(", " + NE);
                swEtudiant.WriteLine();
                swEtudiant.Flush();
            }
        }


    }

}
