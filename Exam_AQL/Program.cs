﻿/*Projet Final Assurance Qualitée Logiciel
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
            String Selection;
            String Titre = "Gestion des notes des étudiants du Collège La Cité";
            String Afficher = "Affichage de tous les étudiants";
            String Creer = "Créer un étudiant";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Voici les commandes pour cette application : ");
            Console.WriteLine("A - Afficher les Étudiants");
            Console.WriteLine("C - Créer un étudiant");
            Console.WriteLine("S - Sélectionner un étudiant");
            Console.WriteLine();
            Console.WriteLine("Une fois qu'un étudiant est selectionné, vous pouvez : ");
            Console.WriteLine("N - Ajouter une note à l'étudiant");
            Console.WriteLine("E - Enregistrer les données de l'étudiant dans un fichier texte");
            Console.WriteLine("S - Sélectionner un autre étudiant");
            Console.WriteLine("R - Retourner au menu précédent");
            Console.WriteLine();
            Console.Write("Veuillez entrer votre commande : ");
            Selection = Console.ReadLine();
            if (Selection == "A")
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Afficher.Length / 2)) + "}", Afficher));
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("     Numéro Étudiant     |     Prénom     |     Nom     ");
                Console.WriteLine("        2689659          |     Julien     |   Lemieux   ");

            }
            else if (Selection == "C")
            {
                int Numero;
                String Prenom;
                String Nom;
                Console.Clear();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Creer.Length / 2)) + "}", Creer));
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.Write("Numéro Étudiant : ");
                Numero = Console.Read();
                Console.WriteLine();
                Console.Write("Prenom : ");
                Prenom = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Nom : ");
                Nom = Console.ReadLine();
                Console.WriteLine();
               
                Console.WriteLine("Étudiant Sauvegardé");
            }
            else
            {
                Console.WriteLine("commande Incorrecte");
            }


        }
    }
}
