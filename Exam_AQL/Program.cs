/*Projet Final Assurance Qualitée Logiciel
 *Développé par : Julien Lemieux et Mathieu Labre  
 *Date : 2021-04-06 
 */
using System;
using System.IO;//Afin d'utiliser le Stream
using System.Threading;//Pour permettre à l'utilisateur de lire le texte inscrit avant de continuer

namespace Exam_AQL
{

    class Program
    {
        
        static void Main(string[] args)
        {
            //Création du fichier texte pour les Étudiants
            string FichierEtudiants = @"C:\Users\Public\Etudiants.txt"; //Fichier contenant les étudiants
            string FichierNotes = @"C:\Users\Public\Notes.txt"; //Fichier contenant toutes les notes
            string FichierCours = @"C:\Users\Public\Cours.txt"; //Fichier contenant les cours
            String SupressionEtudiant = ""; //Variable String pour vérifier la suppression du fichier Etudiant.txt
            String SupressionNotes = ""; //Variable String pour vérifier la suppression du fichier Note.txt
            String SupressionCours = ""; //Variable String pour vérifier la suppression du fichier Cours.txt
            int CompteurNote = 0; //Compteur pour l'affichage de plusieurs notes lors de la sélection d'un Étudiant.
            int deuxSecondes = 2000; //Variable utilisée pour arrêter le programme pendant 2000 millisecondes.
            var yes = "o"; //Variable utilisée pour faciliter la lecture et la répétition.

            /**********************************************************************************************************/
            /*Le début du programme consiste à vérifier si les fichiers utilisés dans le programme existent dans      */
            /*l'ordianteur de l'utilisateur. Si ils existent, le programme demande à l'utilisateur s'il il souhaite en*/
            /*créer de nouveaux. Sinon, le programme en crée pour l'utilisateur dans C:\Users\Public\ et informe      */
            /*l'utilisateur des changements apportées.                                                                */
            /**********************************************************************************************************/
            if (File.Exists(FichierEtudiants)) //Vérification de l'existence du fichier Etudiant.txt
            {
                while (SupressionEtudiant != yes) //Boucle si l'utilisateur fait une faute de frappe, le programme 
                {                                 //Recommence cette partie du code
                    Console.WriteLine();
                    Console.WriteLine(" Le fichier Etudiant.txt existe déjà. Souhaitez-vous le supprimer ?");
                    Console.WriteLine();
                    Console.WriteLine(" O - Oui");
                    Console.WriteLine(" N - Non");
                    Console.WriteLine();
                    Console.Write(" Votre réponse : ");
                    SupressionEtudiant = Console.ReadLine();
                    if (SupressionEtudiant.ToLower() == yes)                   
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
                        SupressionEtudiant = yes; //Puisque le C# ne compare pas les string avec || 
                                                  //SupressionEtudiant est égal à "o"
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
                Console.WriteLine(" Un nouveau fichier Etudiant.txt a été créer avec succès.");
                Console.WriteLine();
                Thread.Sleep(deuxSecondes);
            }
            if (File.Exists(FichierNotes))
            {
                //Supression du fichier note//
                while (SupressionNotes != yes)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le fichier AjouterNote.txt existe déjà. Souhaitez-vous le supprimer ?");
                    Console.WriteLine();
                    Console.WriteLine(" O - Oui");
                    Console.WriteLine(" N - Non");
                    Console.WriteLine();
                    Console.Write(" Votre réponse : ");
                    SupressionNotes = Console.ReadLine();
                    if (SupressionNotes.ToLower() == yes)
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
                        SupressionNotes = yes;
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
                File.Move(FichierEtudiants, FichierNotes);
                Console.WriteLine();
                using (StreamWriter swNotes = File.CreateText(FichierNotes))
                {
                    swNotes.WriteLine("Identifiant | Numéro d'étudiant | Numéro de cours | Note |");
                }
                Console.WriteLine(" Un nouveau fichier Notes.txt a été créer avec succès.");
                Console.WriteLine();
                Thread.Sleep(deuxSecondes);
            }
            if (File.Exists(FichierCours)) // Si le fichier AjouterCours.txt existe, aficher des options à l'utilisateur
            { 
                // Supression du ficher AjouterCours//
                while (SupressionCours != yes)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le fichier AjouterCours.txt existe déjà. Souhaitez-vous le supprimer ?");
                    Console.WriteLine();
                    Console.WriteLine(" O - Oui");
                    Console.WriteLine(" N - Non");
                    Console.WriteLine();
                    Console.Write(" Votre réponse : ");
                    SupressionCours = Console.ReadLine();
                    if (SupressionCours.ToLower() == yes)
                    {

                        File.Delete(FichierCours);
                        using (StreamWriter swCours = File.CreateText(FichierCours))
                        {
                            swCours.WriteLine("Numéro Etudiant |  Numero du cours  |  Titre du cours  |");                          
                        }
                        Console.WriteLine("Le fichier Cours.txt a été supprimé avec succès.");
                        Console.WriteLine("Un nouveau fichier Cours.txt a été créer avec succès.");
                        Console.WriteLine();
                        Thread.Sleep(deuxSecondes);
                    }
                    else if (SupressionCours.ToLower() == "n")
                    {
                        SupressionCours = yes;
                        Console.WriteLine("Parfait, le programme continura avec votre fichier AjouterCours.txt.");
                        Console.WriteLine();
                        Thread.Sleep(deuxSecondes);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" La réponse entrée est invalide. Veuillez entrer O pour oui ou N pour non.");
                    }

                }
            }
            else //Si le fichier AjouterCours.txt n'existe pas, le programme en crée un nouveau
            {
                Console.WriteLine();
                using (StreamWriter swCours = File.CreateText(FichierCours))
                {
                    swCours.WriteLine("Numéro Etudiant |  Numero du cours |  Titre du cours  |");
                }
                Console.WriteLine(" Un nouveau fichier AjouterCours.txt a été créer avec succès.");
                Console.WriteLine();
                Thread.Sleep(deuxSecondes);

            }

            String Selection = ""; //La variable Selection stocke ce que l'utilisateur entre dans la console.
            //Puisque les titres sont utilisé à plusieurs reprises, une variable string leur est assignée.
            String Titre = "Gestion des notes des étudiants du Collège La Cité";
            String AfficherEtudiants = "Affichage de tous les étudiants";
            String AfficherNotes = "Affichage de toutes le notes";
            String AfficherCours = "Affichage de tous les cours";
            String CreerEtudiant = "Créer un étudiant";
            String AjouterNote = "Ajouter une note à un étudiant";
            String AjouterCours = "Ajouter un cours";
            String Selectionner = "Selection d'un étudiant";

            while (Selection.ToLower() != "X") //Boucle while afin de permettre l'éxecution du programme j'usqu'a ce que                        
            {                        //l'utilisateur entre x.
                //affichage des commande danns la console//
                Console.Clear();
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("Voici les commandes pour cette application : ");
                Console.WriteLine();
                Console.WriteLine("AE - Affiche tous les Étudiants");
                Console.WriteLine("AN - Affiche toutes les notes");
                Console.WriteLine("AC - Affiche toutes les cours");
                Console.WriteLine(" C - Ajouter un Cours ");
                Console.WriteLine(" E - Créer un étudiant");
                Console.WriteLine(" S - Sélectionner un étudiant");
                Console.WriteLine(" N - Ajouter une note à l'étudiant ");

                Console.WriteLine(" X - Quitter le programme");
                Console.WriteLine();
                Console.Write("Veuillez entrer votre commande : ");
                Selection = Console.ReadLine();
                /*************************************************************************************************************************************************/
                /*Afficher tous les étudiants*/
                if (Selection.ToLower() == "ae")
                {

                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (AfficherEtudiants.Length / 2)) + "}", AfficherEtudiants));
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
                /*************************************************************************************************************************************************/
                /*Afficher toutes les notes*/
                else if (Selection.ToLower() == "an")
                {

                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (AfficherNotes.Length / 2)) + "}", AfficherNotes));
                    Console.WriteLine();
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    using (StreamReader sr = File.OpenText(FichierNotes))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    Console.WriteLine();
                }
                /*************************************************************************************************************************************************/
                /*Afficher tous les cours*/
                else if (Selection.ToLower() == "ac")
                {

                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (AfficherCours.Length / 2)) + "}", AfficherCours));
                    Console.WriteLine();
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    using (StreamReader sr = File.OpenText(FichierCours))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    Console.WriteLine();
                }
                /*************************************************************************************************************************************************/
                /*Création d'un étudiant*/
                else if (Selection.ToLower() == "e")
                {
                    //inisialise les variable de la class etudiant//
                    String Prenom;
                    String Nom;
                    int Numero = 0;
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (CreerEtudiant.Length / 2)) + "}", CreerEtudiant));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.Write("Prénom : ");
                    Prenom = Console.ReadLine();
                    if (string.IsNullOrEmpty(Prenom))
                    {
                        Console.WriteLine("Le prénom ne peux pas être vide.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Nom : ");
                        Nom = Console.ReadLine();
                        if (string.IsNullOrEmpty(Nom))
                        {
                            Console.WriteLine("Le prénom ne peux pas être vide.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("Numéro Étudiant : ");
                            //utilisation de try pour s'assurer lors de l'execution du code suceptible d'erreur de l'enfermer dans le block try//
                            try
                            {
                                Numero = int.Parse(Console.ReadLine());

                                if (Numero > 9999999 || Numero < 1000000)
                                {
                                    Console.WriteLine("Le numéro étudiant doir être de 7 chiffres");
                                }
                                else if (Numero <= 9999999 || Numero >= 1000000)
                                {
                                    Console.WriteLine();
                                    Etudiant etudiant = new Etudiant(Numero, Prenom, Nom);
                                    Console.WriteLine("Étudiant Sauvegardé");
                                    Thread.Sleep(deuxSecondes);
                                }

                            }
                            //utilisation de catch pour intercepter l'exception avec catch
                            catch
                            {
                                Console.WriteLine("Veuiller entrer un numéro d'étudiant valide.");
                            }
                        }
                    }

                }
                /*************************************************************************************************************************************************/
                /*Selection de toutes les informations d'un étudiant*/
                else if (Selection.ToLower() == "s")
                {

                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Selectionner.Length / 2)) + "}", Selectionner));
                    Console.WriteLine("________________________________________________________________________________________________________________________");

                    Console.WriteLine("Vous pouvez selectionner un étudiant avec son  numéro d'étudiant");
                    Console.WriteLine();
                    Console.Write("Veuillez entrer le numéro d'étudiant : ");
                    //utilisation de try pour s'assurer lors de l'execution du code suceptible d'erreur de l'enfermer dans le block try//
                    try
                    {
                        int numEtudiant = int.Parse(Console.ReadLine()?? FichierEtudiants);
                    /*utilisation du if else Pour ne pas avoir un chiffre plus haut que 7 quannd on entre le NumeroEtudiant */
                        if (numEtudiant > 9999999 || numEtudiant < 1000000)
                        {
                            Console.WriteLine("Le numéro étudiant doir être de 7 chiffres");
                        }
                        else if (numEtudiant <= 9999999 || numEtudiant >= 1000000)
                        {
                            using (var srEtudiant = new StreamReader(FichierEtudiants))
                            {
                                while (!srEtudiant.EndOfStream)
                                {
                                    var line = srEtudiant.ReadLine();
                                    if (line.IndexOf(numEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Étudiant Sélectionné : ");
                                        Console.Write(line);
                                        Console.WriteLine();


                                    }
                                    else if (srEtudiant.EndOfStream)
                                    {
                                        Console.WriteLine("L'étudiant n'a pas été trouvé.");
                                    }
                                }
                            }
                            /* utiliser pour aller chercher et afficher les information des etudiant dans le ficherNote*/
                            using (var srNote = new StreamReader(FichierNotes))

                            {
                                while (!srNote.EndOfStream)
                                {
                                    var lineNote = srNote.ReadLine();
                                    if (lineNote.IndexOf(numEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Note :");
                                        Console.WriteLine(lineNote);
                                        Console.WriteLine();


                                    }
                                    else if (srNote.EndOfStream)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Note :");
                                        Console.WriteLine("L'étudiant n'a pas de note attribuée.");

                                    }

                                }
                            }
                            /* utiliser pour aller chercher et afficher les information des etudiant dans le ficherCours*/
                            using (var srCours = new StreamReader(FichierCours))

                            {
                                while (!srCours.EndOfStream)
                                {
                                    var line2 = srCours.ReadLine();
                                    if (line2.IndexOf(numEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Cours :");
                                        Console.WriteLine(line2);
                                        numEtudiant = int.Parse(Console.ReadLine() ?? FichierCours);

                                    }
                                    else if (srCours.EndOfStream)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Cours :");
                                        Console.WriteLine("L'étudiant n'a pas de Cours attribuée.");

                                    }
                                }
                            }                           
                        }
                        else
                        /*Affiche un message d'erreur quand le numero d'etudiant est incorect*/
                        {
                            Console.WriteLine("Error le numero d'etudiant est incorect");
                        }
                    }
                    //utilisation de catch pour intercepter l'exception avec catch 
                    catch
                    {
                            Console.WriteLine("Erreur. Ceci n'est pas un numéro d'étudiant");
                        }
                    
                }
                /*************************************************************************************************************************************************/
                /*Ajouter une note à un étudiant*/
                else if (Selection.ToLower() == "n")
                {
                    string identifiant;
                    int numEtudiant;
                    int NumeroCours;
                    int noteCours;
                    string SelectionEtudiant = "f";
                    string SelectionCours = "f";
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (AjouterNote.Length / 2)) + "}", AjouterNote));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.Write("Veuillez entrer le numéro de l'étudiant auquel vous souhaitez assigner une note : ");
                    try
                    /*utilisation du if else Pour ne pas avoir un chiffre plus haut que 7 quannd on entre le NumeroEtudiant */
                    {
                        numEtudiant = int.Parse(Console.ReadLine());
                    if (numEtudiant > 9999999 || numEtudiant < 1000000)
                    {
                        Console.WriteLine("Le numéro étudiant doir être de 7 chiffres");
                    }
                    else if (numEtudiant <= 9999999 || numEtudiant >= 1000000)
                    {
                        using (var srEtudiant = new StreamReader(FichierEtudiants))
                        {
                        while (!srEtudiant.EndOfStream)
                        {
                            var line = srEtudiant.ReadLine();
                            if (line.IndexOf(numEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                            {
                                Console.WriteLine();
                                Console.Write("Étudiant Sélectionné : ");
                                Console.Write(line);
                                Console.WriteLine();
                                SelectionEtudiant = "t";
                            }
                            else if (srEtudiant.EndOfStream)
                            {
                                Console.WriteLine("L'étudiant n'a pas été trouvé.");
                            }
                        }
                        }
                        if (SelectionEtudiant == "t")
                        {
                        
                            Console.WriteLine();
                            Console.Write("Numero de Cours : ");
                            NumeroCours = int.Parse(Console.ReadLine()?? FichierCours);
                            using (var srCours = new StreamReader(FichierCours))
                            {
                                while (!srCours.EndOfStream)
                                {
                                    var line = srCours.ReadLine();
                                    if (line.IndexOf(numEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Cours Sélectionné : ");
                                        Console.Write(line);
                                        Console.WriteLine();
                                        SelectionCours = "t";
                                    }
                                    else if (srCours.EndOfStream)
                                    {
                                        Console.WriteLine("Le cours n'existe pas. Veuillez créer un nouveau cours ou entrer un cours qui existe.");
                                    }
                                }
                            }
                            if (SelectionCours == "t")
                            {
                                Console.Write("Note de l'étudiant : ");
                                noteCours = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                            
                                ++(CompteurNote);
                                identifiant = "Cours" + NumeroCours + "_Note"+CompteurNote+"_" + numEtudiant;
                                
                                Note note = new Note(identifiant, numEtudiant, NumeroCours, noteCours);
                                if (note.identifient != "Erreur")
                                {
                                    Console.WriteLine("La note a été attribuée à l'étudiant et est sauvegardée dans le fichier : " + identifiant + ".");
                                }
                                else
                                {
                                Thread.Sleep(deuxSecondes);
                                }
                                
                            }
                            else
                            {
                                Thread.Sleep(deuxSecondes);
                            }
                        }
                        else
                        {
                            Thread.Sleep(deuxSecondes);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erreur dans l'assignation du numéro étudiant. Veuillez réessayer");
                        Thread.Sleep(deuxSecondes);
                    }
                    }
                    catch
                    {
                        Console.WriteLine("Le numéro d'étuidant est invalide.");
                    }
                    
                }
                /*************************************************************************************************************************************************/
                /*Ajouter un Cours à un étudiant*/
                else if (Selection.ToLower() == "c")
                {
                    int NumeroEtudiant;
                    int NumeroCours;
                    string TitreDuCours;
                    string EtudiantSelectionne = "";
                    string SelectionEtudiant = "f";
                    string SelectionCours = "";

                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (AjouterCours.Length / 2)) + "}", AjouterCours));
                    Console.WriteLine("________________________________________________________________________________________________________________________");

                    Console.WriteLine();
                    Console.Write("Numero Etudiant: ");
                    try
                    {

                        NumeroEtudiant = int.Parse(Console.ReadLine());
                        if (NumeroEtudiant > 9999999 || NumeroEtudiant < 1000000)
                        {
                            Console.WriteLine("Le numéro étudiant doir être de 7 chiffres");
                        }
                        else if (NumeroEtudiant <= 9999999 || NumeroEtudiant >= 1000000)
                        {
                            /* utiliser pour aller chercher et afficher les information des etudiant dans le ficherEtudiant*/
                            using (var srEtudiant = new StreamReader(FichierEtudiants))
                            {
                                while (!srEtudiant.EndOfStream)
                                {
                                    var line = srEtudiant.ReadLine();
                                    if (line.IndexOf(NumeroEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Étudiant Sélectionné : ");
                                        Console.Write(line);
                                        EtudiantSelectionne = line;
                                        Console.WriteLine();
                                        SelectionEtudiant = "t";

                                    }
                                    else if (srEtudiant.EndOfStream)
                                    {
                                        Console.WriteLine("L'étudiant n'a pas été trouvé.");
                                    }
                                }
                            }
                            if (SelectionEtudiant == "t")
                            {
                                Console.Write("Numéro du cours : ");
                                try
                                {
                                    NumeroCours = int.Parse(Console.ReadLine()?? FichierCours);
                                    using (var srCours = new StreamReader(FichierCours))
                                    {
                                        while (!srCours.EndOfStream)
                                        {
                                            var line = srCours.ReadLine();
                                            if (line.IndexOf(NumeroEtudiant.ToString() + ", " + NumeroCours.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Le cours " + NumeroCours + " pour l'étudiant " + EtudiantSelectionne + " existe déjà.");
                                                Console.WriteLine("Veuillez créer un autre cours");
                                                SelectionCours = "f";
                                            }
                                            else if (srCours.EndOfStream)
                                            {
                                                SelectionCours = "t";
                                            }
                                        }
                                    }
                                    if (SelectionCours == "t")
                                    {
                                        Console.WriteLine();
                                        Console.Write("Titre du cours : ");
                                        TitreDuCours = (Console.ReadLine());
                                        Console.WriteLine();
                                        Cours cours = new Cours(NumeroEtudiant, NumeroCours, TitreDuCours);
                                        Console.WriteLine("Le cours a été sauvegardé avec succès.");
                                    }

                                }
                                catch
                                {
                                    Console.WriteLine("Le numéro du cours doit être des chiffres.");
                                }
                            
                            }
                        
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Veuillez entrer un numéro d'étudiant valide.");
                    }

                }
                /*************************************************************************************************************************************************/
                /*Quitter le programme*/
                else if (Selection.ToLower() == "x")
                {
                    break;
                }
                /*************************************************************************************************************************************************/
                /*Message affiché lorsqu'une commande est incorrecte*/
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("La commande entrée est incorrecte. Veuillez vérifier la syntaxe et réessayer.");
                }
                Console.WriteLine();
                Console.WriteLine("Appuyer sur n'importe quelle touche pour continuer...");
                Console.ReadLine();

            }

        }


    }
}