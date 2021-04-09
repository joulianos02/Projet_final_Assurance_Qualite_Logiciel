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
            String Selection = "";
            String Titre = "Gestion des notes des étudiants du Collège La Cité";
            String Afficher = "Affichage de tous les étudiants";
            String Creer = "Créer un étudiant";
            while (Selection != "x")

            {
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
                Console.WriteLine("X - Quitter le programme");
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
                else if (Selection.ToLower() == "c")
                {
                    int Numero;
                    String Prenom;
                    String Nom;
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Creer.Length / 2)) + "}", Creer));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.Write("Numéro Étudiant : ");

                    Numero = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Prenom : ");
                    Prenom = Console.ReadLine();
                    Console.Write("Nom : ");
                    Nom = Console.ReadLine();
                    Console.WriteLine();
                    Etudiant etudiant = new Etudiant(Numero, Prenom, Nom);
                    Console.WriteLine("Étudiant Sauvegardé");
                }

                else if (Selection.ToLower() == "n")
                {
                    string identifient;
                    int numEtudiant;
                    int NumeroCours;
                    int noteCours;
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Creer.Length / 2)) + "}", Creer));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.Write("Indentifient : ");
                    identifient = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Numero Etudiant : ");
                    numEtudiant = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Numero de Cours : ");
                    NumeroCours = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Note : ");
                    noteCours = int.Parse(Console.ReadLine());
                  
                    Note note = new Note(identifient,numEtudiant,NumeroCours, noteCours);
                    Console.WriteLine("Étudiant Sauvegardé");



                }


                else
                {
                    Console.WriteLine("commande Incorrecte");
                }
                Console.WriteLine("Appuyer sur Enter pour continuer...");
                Console.ReadLine();
                Console.Clear();

            }

        }
    }
}
