/*Projet Final Assurance Qualitée Logiciel
 *Développé par : Julien Lemieux et Mathieu Labre  
 *Date : 2021-04-06 
 */
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Exam_AQL
{

    class Program
    {
        
        static void Main(string[] args)
        {
            //Création du fichier texte pour les Étudiants
            string FichierEtudiants = @"C:\Users\Public\Etudiants.txt";
            string FichierNote = @"C:\Users\Public\Notes.txt";
            string FichierCours = @"C:\Users\Public\Cours.txt";


            String Selection = "";        
            String Titre = "Gestion des notes des étudiants du Collège La Cité";
            String Afficher = "Affichage de tous les étudiants";
            String Creer = "Créer un étudiant";
            String Note = "Ajouter une note à un étudiant";
            String Selectionner = "Selection d'un étudiant";

            while (Selection != "X")

            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("Voici les commandes pour cette application : ");
                Console.WriteLine("A - Afficher les Étudiants");
                Console.WriteLine("C - Créer un étudiant");
                Console.WriteLine("S - Sélectionner un étudiant");
                Console.WriteLine("X - Quitter le programme");
                Console.WriteLine();
                Console.Write("Veuillez entrer votre commande : ");
                Selection = Console.ReadLine();
                
                if (Selection.ToLower() == "c")
                {
                    String Prenom;
                    String Nom;
                    int Numero;
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Creer.Length / 2)) + "}", Creer));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.Write("Prénom : ");
                    try
                    {
                        Prenom = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Nom : ");
                            try
                            {
                                Nom = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Numéro Étudiant : ");
                                try
                                {
                                    Numero = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Etudiant etudiant = new Etudiant(Numero, Prenom, Nom);
                                    Console.WriteLine("Étudiant Sauvegardé");
                                }
                                catch
                                {
                                    Console.WriteLine("Veuiller entrer un nom de famille valide.");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Veuiller entrer un prénom valide.");
                            }
                    }
                    catch
                    {
                        Console.WriteLine("Veuiller entrer un numéro d'étudiant valide.");
                    }

                }
                else if (Selection.ToLower() == "a")
                {

                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Afficher.Length / 2)) + "}", Afficher));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    using (StreamReader sr = File.OpenText(FichierEtudiants))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    Console.WriteLine();
                }
                else if (Selection.ToLower() == "s")
                {

                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Selectionner.Length / 2)) + "}", Selectionner));
                    Console.WriteLine("________________________________________________________________________________________________________________________");

                    Console.WriteLine("Vous pouvez selectionner un étudiant avec son  numéro d'étudiant");
                    Console.WriteLine();
                    Console.WriteLine("Une fois qu'un étudiant est selectionné, vous pouvez : ");
                    Console.WriteLine("N - Ajouter une note à l'étudiant");
                    Console.WriteLine("S - Sélectionner un autre étudiant");
                    Console.WriteLine("R - Retourner au menu précédent");
                    Console.WriteLine();
                    Console.Write("Veuillez entrer le numéro d'étudiant : ");
                    try
                    {
                        int numEtudiant = int.Parse(Console.ReadLine()?? FichierEtudiants);
                        using (var sr = new StreamReader(FichierEtudiants))
                        {
                            while (!sr.EndOfStream)
                            {
                                var line = sr.ReadLine();
                                if (line.IndexOf(numEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                {
                                    Console.Write("Étudiant Sélectionné : ");
                                    Console.Write(line);

                                }
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erreur. Ceci n'est pas un numéro d'étudiant");
                    }
                }
                else if (Selection.ToLower() == "n")
                {
                    string identifiant;
                    int numEtudiant;
                    int NumeroCours;
                    int noteCours;
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Note.Length / 2)) + "}", Note));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.Write("Identifiant : ");
                    identifiant = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Numero Etudiant : ");
                    numEtudiant = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Numero de Cours : ");
                    NumeroCours = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Note : ");
                    noteCours = int.Parse(Console.ReadLine());

                    Note note = new Note(identifiant, numEtudiant, NumeroCours, noteCours);
                    Console.WriteLine("Étudiant Sauvegardé");
                }
                
                else if (Selection.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Commande Incorrecte");
                }
                Console.WriteLine();
                Console.WriteLine("Appuyer sur Enter pour continuer...");
                Console.ReadLine();

            }

        }


    }
}