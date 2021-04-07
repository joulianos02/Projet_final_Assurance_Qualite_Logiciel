/*Projet Final Assurance Qualitée Logiciel
 *Développé par : Julien Lemieux et Mathieu Labre  
 *Date : 2021-04-06 
 */
using System;

namespace Exam_AQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string Titre = "Gestion des notes des étudiants du Collège La Cité";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
            Console.WriteLine();
        }
    }
}
