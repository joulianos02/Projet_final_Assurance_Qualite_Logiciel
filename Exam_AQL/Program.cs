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
            string FichierNotes = @"C:\Users\Public\Notes.txt";
            string FichierCours = @"C:\Users\Public\Cours.txt";
            String SupressionEtudiant = "";
            String SupressionNotes = "";
            String SupressionCours = "";
            String IndicateurSupressionCours = "";
            String IndicateurCreationEtudiant = "f";
            String IndicateurCreationNotes = "f";
            String IndicateurCreationCours = "f";

            var yes = "o";
            if (File.Exists(FichierEtudiants))
            {
                while (SupressionEtudiant != yes)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le fichier Etudiant.txt existe déjà. Souhaitez-vous le supprimer ?");
                    Console.WriteLine();
                    Console.WriteLine(" O - Oui");
                    Console.WriteLine(" N - Non");
                    Console.WriteLine();
                    Console.Write(" Votre réponse : ");
                    SupressionEtudiant = Console.ReadLine();
                    if (SupressionEtudiant.ToLower() == "o")                   
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Le fichier Etudiant.txt a été supprimé avec succès.");
                        Console.WriteLine();
                        Console.WriteLine(" Le nouveau fichier Etudiant.txt a été créer avec succès.");

                        File.Delete(FichierEtudiants);
                        using (StreamWriter swEtudiant = File.CreateText(FichierEtudiants))
                        {
                            swEtudiant.WriteLine("Prénom |  Nom  |  Numéro d'étudiant  |");
                        }
                    }
                    else if (SupressionEtudiant.ToLower() == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Parfait, le programme continura avec votre fichier Etudiant.txt.");
                        SupressionEtudiant = "o";
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" La réponse entrée est invalide. Veuillez entrer O pour oui ou N pour non.");
                    }

                }
            }
            else //Si le fichier Etudiant.txt n'existe pas, le programme en crée un nouveau
            {
                Console.WriteLine();
                
                using (StreamWriter swEtudiant = File.CreateText(FichierEtudiants))
                {
                    swEtudiant.WriteLine("Prénom |  Nom  |  Numéro d'étudiant  |");
                }
                IndicateurCreationEtudiant = "t";
            }
            if (File.Exists(FichierNotes))
            {
                //Supression du fichier note//
                while (SupressionNotes != yes)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le fichier Note.txt existe déjà. Souhaitez-vous le supprimer ?");
                    Console.WriteLine();
                    Console.WriteLine(" O - Oui");
                    Console.WriteLine(" N - Non");
                    Console.WriteLine();
                    Console.Write(" Votre réponse : ");
                    SupressionNotes = Console.ReadLine();
                    if (SupressionNotes.ToLower() == "o")
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Le fichier Notes.txt a été supprimé avec succès.");
                        Console.WriteLine();
                        Console.WriteLine(" Le nouveau fichier Notes.txt a été créer avec succès.");
                        File.Delete(FichierNotes);
                        using (StreamWriter swNote = File.CreateText(FichierNotes))
                        {
                            swNote.WriteLine("Identifiant | Numéro d'étudiant | Numéro de cours | Note");
                            Console.WriteLine();
                        }
                    }
                    else if (SupressionNotes.ToLower() == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Parfait, le programme continura avec votre fichier Notes.txt.");
                        SupressionNotes = "o";
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" La réponse entrée est invalide. Veuillez entrer O pour oui ou N pour non.");
                    }

                }
            }
            else //Si le fichier Notes.txt n'existe pas, le programme en crée un nouveau
            {
                Console.WriteLine();
                using (StreamWriter swNotes = File.CreateText(FichierNotes))
                {
                    swNotes.WriteLine("Identifiant | Numéro d'étudiant | Numéro de cours | Note |");
                }
                IndicateurCreationNotes = "t";
            }
            if (File.Exists(FichierCours)) // Si le fichier Cours.txt existe, aficher des options à l'utilisateur
            { 
                // Supression du ficher Cours//
                while (SupressionCours != yes)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le fichier Cours.txt existe déjà. Souhaitez-vous le supprimer ?");
                    Console.WriteLine();
                    Console.WriteLine(" O - Oui");
                    Console.WriteLine(" N - Non");
                    Console.WriteLine();
                    Console.Write(" Votre réponse : ");
                    SupressionCours = Console.ReadLine();
                    if (SupressionCours.ToLower() == "o")
                    {

                        File.Delete(FichierCours);
                        using (StreamWriter swCours = File.CreateText(FichierCours))
                        {
                            swCours.WriteLine("Numéro de cours |  Code  |  Titre  |");                          
                        }
                        IndicateurSupressionCours = "o";
                    }
                    else if (SupressionCours.ToLower() == "n")
                    {
                        SupressionCours = "o";
                        IndicateurSupressionCours = "n";
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" La réponse entrée est invalide. Veuillez entrer O pour oui ou N pour non.");
                    }

                }
            }
            else //Si le fichier Cours.txt n'existe pas, le programme en crée un nouveau
            {
                Console.WriteLine();
                using (StreamWriter swCours = File.CreateText(FichierCours))
                {
                    swCours.WriteLine("Numéro de cours |  Code  |  Titre  |");
                }
                IndicateurCreationCours = "t";
            }

            String Selection = "";        
            String Titre = "Gestion des notes des étudiants du Collège La Cité";
            String Afficher = "Affichage de tous les étudiants";
            String Creer = "Créer un étudiant";
            String Note = "Ajouter une note à un étudiant";
            String Cours = "Ajouter un cours";
            String Selectionner = "Selection d'un étudiant";

            while (Selection != "X")

            {
                Console.Clear();
                if (IndicateurCreationEtudiant == "t")
                {
                    Console.WriteLine(" Un nouveau fichier Etudiant.txt a été créer avec succès.");
                    IndicateurCreationEtudiant = "f";  
                    Console.WriteLine();
                }
                if (IndicateurCreationNotes == "t")
                {
                    Console.WriteLine(" Un nouveau fichier Notes.txt a été créer avec succès.");
                    IndicateurCreationNotes = "f";
                    Console.WriteLine();
                }
                if (IndicateurCreationCours == "t")
                {
                    Console.WriteLine(" Un nouveau fichier Cours.txt a été créer avec succès.");
                    Console.WriteLine();
                    IndicateurCreationCours = "";
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                }
                if (IndicateurSupressionCours == "o")
                {
                    Console.WriteLine("Le fichier Cours.Txt a été supprimé avec succès.");
                    Console.WriteLine("Un nouveau fichier a été créer avec succès.");
                    Console.WriteLine();
                    IndicateurSupressionCours = "";
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                }
                else if (IndicateurSupressionCours == "n")
                {
                    Console.WriteLine("Parfait, le programme continura avec votre fichier Cours.txt.");
                    IndicateurSupressionCours = "";
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                }
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("Voici les commandes pour cette application : ");
                Console.WriteLine();
                Console.WriteLine("A - Afficher les Étudiants");
                Console.WriteLine("e - Créer un étudiant");
                Console.WriteLine("S - Sélectionner un étudiant");
                Console.WriteLine("N - Ajouter une note à l'étudiant ");
                Console.WriteLine(" - Ajouter un Cours ");
                Console.WriteLine("X - Quitter le programme");
                Console.WriteLine();
                Console.Write("Veuillez entrer votre commande : ");
                Selection = Console.ReadLine();
                
                if (Selection.ToLower() == "e")
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
                    Console.WriteLine();
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
                else if (Selection.ToLower() == "c")
                {
                    int NumeroEtudiant;
                    int NumeroCours;
                    string TitreDuCours;

                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Note.Length / 2)) + "}", Note));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.Write("Numero du cour : ");
                    NumeroCours = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Mots de pass : ");
                    NumeroEtudiant= int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write("Numero de Cours : ");
                    TitreDuCours = (Console.ReadLine());

                    Cours cours= new Cours(NumeroEtudiant,NumeroCours, TitreDuCours);
                    Console.WriteLine("Cours Sauvegardé");
                }

                else if (Selection.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("La commande entrée est incorrecte. Veuillez vérifier la syntaxe et rééssayer.");
                }
                Console.WriteLine();
                Console.WriteLine("Appuyer sur n'importe quelle touche pour continuer...");
                Console.ReadLine();

            }

        }


    }
}