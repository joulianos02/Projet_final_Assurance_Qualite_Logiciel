using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_AQL
{
    class Etudiant {
        public int NumeroEtudiant;
        public string Prenom;
        public string Nom;

        public Etudiant(int NE, string P, string N)
        {
            NumeroEtudiant = NE;
            Prenom = P;
            Nom = N;
        }
        Etudiant e1 = new Etudiant(2689658,"Julien","Lemieux");
        Etudiant e2 = new Etudiant(2746463, "Mathieu", "Labre");
        Etudiant e3 = new Etudiant(2258654, "Yvan Philippe", "Kengne Ponka");

    }

}
