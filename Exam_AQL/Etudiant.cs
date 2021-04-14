using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam_AQL
{
    class Etudiant {
        string FichierEtudiants = @"C:\Users\Public\Etudiants.txt";
        public int NumeroEtudiant;
        public string Prenom;
        public string Nom;

        public Etudiant(int NE, string P, string N)
        {
            NumeroEtudiant = NE;
            Prenom = P;
            Nom = N;
            using StreamWriter swEtudiant = new StreamWriter(FichierEtudiants, true);
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
