using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_AQL
{
    class Note
    {
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
        }

    }
}
