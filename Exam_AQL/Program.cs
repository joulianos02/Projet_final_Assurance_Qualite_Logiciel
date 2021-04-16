/*Projet Final Assurance Qualitée Logiciel
 *Développé par : Julien Lemieux et Mathieu Labre  
 *Date : 2021-04-15 
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
                    Console.Clear();
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
                        Thread.Sleep(deuxSecondes);
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
                    Console.Clear();
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
                        Thread.Sleep(deuxSecondes);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" La réponse entrée est invalide. Veuillez entrer O pour oui ou N pour non.");
                        Thread.Sleep(deuxSecondes);
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
                Console.WriteLine(" Un nouveau fichier Notes.txt a été créer avec succès.");
                Console.WriteLine();
                Thread.Sleep(deuxSecondes);
            }
            if (File.Exists(FichierCours)) // Si le fichier AjouterCours.txt existe, aficher des options à l'utilisateur
            { 
                // Supression du ficher AjouterCours//
                while (SupressionCours != yes)
                {
                    Console.Clear();
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
                        Thread.Sleep(deuxSecondes);
                    }

                }
            }
            else //Si le fichier Cours.txt n'existe pas, le programme en crée un nouveau
            {
                Console.WriteLine();
                using (StreamWriter swCours = File.CreateText(FichierCours))
                {
                    swCours.WriteLine("Numéro Etudiant |  Numero du cours |  Titre du cours  |");
                }
                Console.WriteLine(" Un nouveau fichier Cours.txt a été créer avec succès.");
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
            {                                  //l'utilisateur entre x.
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
                    //Mise en page de l'application
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
                            Console.WriteLine(s); //Lecture du fichier 
                        }
                    }
                    Console.WriteLine();
                }
                /*************************************************************************************************************************************************/
                /*Afficher toutes les notes*/
                else if (Selection.ToLower() == "an")
                {
                    //Mise en page de l'application
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
                            Console.WriteLine(s); //lecture du fichier
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
                            Console.WriteLine(s); //Lecture du fichier
                        }
                    }
                    Console.WriteLine();
                }
                /*************************************************************************************************************************************************/
                /*Création d'un étudiant*/
                else if (Selection.ToLower() == "e")
                {
                    String Prenom; //Variable contenant le prénom
                    String Nom; //Variable contenant le nom
                    int Numero = 0; //Variable contenant le numéro étudiant
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (CreerEtudiant.Length / 2)) + "}", CreerEtudiant));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.Write("Prénom : ");
                    Prenom = Console.ReadLine();
                    if (string.IsNullOrEmpty(Prenom)) //Si le prénom est vide
                    {
                        Console.WriteLine("Le prénom ne peux pas être vide.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Nom : ");
                        Nom = Console.ReadLine();
                        if (string.IsNullOrEmpty(Nom)) //Si le nom est vide
                        {
                            Console.WriteLine("Le nom ne peux pas être vide.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("Numéro Étudiant : ");
                            try //Si l'utilisateur entre des lettres, le programme ira au catch
                            {
                                Numero = int.Parse(Console.ReadLine());

                                if (Numero > 9999999 || Numero < 1000000) //Verification du numéro étudiant
                                {
                                    Console.WriteLine("Le numéro étudiant doir être de 7 chiffres");
                                }
                                else if (Numero <= 9999999 || Numero >= 1000000)
                                {
                                    var EtudiantNonTrouve = "t"; //Variable si l'étudiant n'est pas trouvé 
                                    using (var srEtudiant = new StreamReader(FichierEtudiants))
                                    {
                                        while (!srEtudiant.EndOfStream)
                                        {
                                            var line = srEtudiant.ReadLine();
                                            if (line.IndexOf(Numero.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                            {
                                                Console.WriteLine();
                                                Console.Write("Le numéro d'étudiant est déjà assigné à l'étudiant : ");
                                                Console.Write(line);
                                                Console.WriteLine();
                                                Console.WriteLine("Veuillez créer un autre étudiant.");
                                                Thread.Sleep(deuxSecondes);
                                                EtudiantNonTrouve = "f";
                                            }
                                        }
                                    }
                                    if (EtudiantNonTrouve == "t") 
                                    {
                                        Console.WriteLine();
                                        Etudiant etudiant = new Etudiant(Numero, Prenom, Nom);
                                        Console.WriteLine("Étudiant Sauvegardé");
                                        Thread.Sleep(deuxSecondes);
                                    }
                                    
                                }

                            }
                            catch //Si l'utilisateur entre des lettres
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
                    //Mise en page de l'application
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Selectionner.Length / 2)) + "}", Selectionner));
                    Console.WriteLine("________________________________________________________________________________________________________________________");

                    Console.WriteLine("Vous pouvez sélectionner un étudiant avec son numéro d'étudiant");
                    Console.WriteLine();
                    Console.Write("Veuillez entrer le numéro d'étudiant : ");
                    
                    try
                    {
                        int numEtudiant = int.Parse(Console.ReadLine()?? FichierEtudiants);

                        if (numEtudiant > 9999999 || numEtudiant < 1000000) //Vérification du numéro étudiant.
                        {
                            Console.WriteLine("Le numéro étudiant doir être de 7 chiffres");
                        }
                        else if (numEtudiant <= 9999999 || numEtudiant >= 1000000)
                        {
                            var EtudiantNonTrouve = "t"; //Variable si l'étudiant n'est pas trouvé
                            var NoteNonTrouve = "t"; //Variable si la note n'est pas trouvée
                            var CoursNonTrouve = "t"; //Variable si le cours n'est pas trouvé
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
                                        EtudiantNonTrouve = "f";
                                    }
                                }
                            }
                            if (EtudiantNonTrouve == "t")
                            {
                                Console.WriteLine("L'étudiant n'a pas été trouvé.");
                            }
                            else if (EtudiantNonTrouve == "f")
                            {
                                using (var srCours = new StreamReader(FichierCours))
                                {
                                    while (!srCours.EndOfStream)
                                    {
                                        var line2 = srCours.ReadLine();
                                        if (line2.IndexOf(numEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Cours :");
                                            Console.WriteLine("Numéro Etudiant |  Numero du cours |  Titre du cours  |");
                                            Console.WriteLine(line2);
                                            CoursNonTrouve = "f";
                                        }
                                    }
                                }
                                if (CoursNonTrouve == "t")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Cours :");
                                    Console.WriteLine("L'étudiant n'a pas de Cours attribuée.");
                                }
                                else if (CoursNonTrouve == "f")
                                {
                                    using (var srNote = new StreamReader(FichierNotes))
                                    {
                                        while (!srNote.EndOfStream)
                                        {
                                            var lineNote = srNote.ReadLine();
                                            if (lineNote.IndexOf(numEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Note :");
                                                Console.WriteLine("Identifiant | Numéro d'étudiant | Numéro de cours | Note |");
                                                Console.WriteLine(lineNote);
                                                Console.WriteLine();
                                                NoteNonTrouve = "f";
                                            }
                                        }
                                    }
                                    if (NoteNonTrouve == "t")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Note :");
                                        Console.WriteLine("L'étudiant n'a pas de note attribuée.");
                                    }
                                }
                            }
                          
                        }
                        else
                        {
                            Console.WriteLine("Le numéro d'étudiant est incorect.");
                        }
                    }     
                    catch
                    {
                        Console.WriteLine("Erreur. Ceci n'est pas un numéro d'étudiant");
                    }
                }
                /*************************************************************************************************************************************************/
                /*Ajouter une note à un étudiant*/
                else if (Selection.ToLower() == "n")
                {
                    string identifiant; //Variable Nom du fichier (Sera modifié plus tard)
                    int numEtudiant; //Variable pour Numéro Étudiant
                    int NumeroCours; //Variable pour numéro du cours
                    int noteCours; //Variable pour note de cours
                    string SelectionEtudiant = "f"; //Variable pour s'assurer qu'un Etudiant a été sélectionné
                    string SelectionCours = "f"; //Variable pour confirmer qu'un cours a été sélectionner
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (AjouterNote.Length / 2)) + "}", AjouterNote));
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.Write("Veuillez entrer le numéro de l'étudiant auquel vous souhaitez assigner une note : ");
                    try //Verification de l'entrée de l'utilisateur
                    {
                        numEtudiant = int.Parse(Console.ReadLine());
                        if (numEtudiant > 9999999 || numEtudiant < 1000000) //Verification du numéro étudiant
                        {
                            Console.WriteLine("Le numéro étudiant doit être de 7 chiffres");
                        }
                        else if (numEtudiant <= 9999999 || numEtudiant >= 1000000)
                        {
                            using (var srEtudiant = new StreamReader(FichierEtudiants))
                            {
                            while (!srEtudiant.EndOfStream) //Recherche dans le fichier étudiant
                            {
                                var line = srEtudiant.ReadLine();
                                if (line.IndexOf(numEtudiant.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                {
                                    Console.WriteLine();
                                    Console.Write("Étudiant Sélectionné : ");
                                    Console.Write(line);
                                    Console.WriteLine();
                                    SelectionEtudiant = "t"; //Si un étudiant est sélectionné (t = true)
                                }

                            }
                            }
                            if (SelectionEtudiant == "t") //Si un étudiant est sélectionné (t = true)
                            {
                                Console.WriteLine();
                                Console.Write("Numero de Cours : ");
                                NumeroCours = int.Parse(Console.ReadLine()?? FichierCours);
                                using (var srCours = new StreamReader(FichierCours))
                                {
                                    while (!srCours.EndOfStream) //Recherche du numéro de cours
                                    {
                                        var line = srCours.ReadLine();
                                        if (line.IndexOf(numEtudiant.ToString()+ ", " + NumeroCours, StringComparison.CurrentCultureIgnoreCase) >= 0)
                                        {
                                            Console.WriteLine();
                                            Console.Write("Cours Sélectionné : ");
                                            Console.Write(line);
                                            Console.WriteLine();
                                            SelectionCours = "t";
                                        }

                                    }
                                }
                                if (SelectionCours == "t") // t = true
                                {
                                    Console.Write("Note de l'étudiant : ");
                                    noteCours = int.Parse(Console.ReadLine());
                                    if (noteCours > 100 || noteCours <0) //Vérification de la note
                                    {
                                        Console.WriteLine("La note dois être entre 0 et 100.");
                                        Thread.Sleep(deuxSecondes);
                                    }
                                    else if (noteCours <= 100 || noteCours >= 0)
                                    {
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
                                            //Un message d'erreur sera affiché de la classe Étudiant
                                            Thread.Sleep(deuxSecondes);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("La note dois être un chifffre entre 0 et 100.");
                                    }

                                
                                }
                                else if (SelectionCours == "f") // false
                                {
                                    Console.WriteLine("Le cours n'existe pas. Veuillez créer un nouveau cours ou entrer un cours qui existe.");
                                    Thread.Sleep(deuxSecondes);
                                }
                            }
                            else if (SelectionEtudiant == "f") //false
                            {
                                Console.WriteLine("L'étudiant n'a pas été trouvé.");
                                Thread.Sleep(deuxSecondes);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Le numéro d'étudiant est invalide.");
                        Thread.Sleep(deuxSecondes);
                    }
                    
                }
                /*************************************************************************************************************************************************/
                /*Ajouter un Cours à un étudiant*/
                else if (Selection.ToLower() == "c")
                {
                    int NumeroEtudiant; //Variable Numéro Étudiant
                    int NumeroCours; //Variable Numéro Cours
                    string TitreDuCours; //Variable Titre du cours
                    string EtudiantSelectionne = ""; //Variable qui sauvegarde quel étudiant est sélectionné par l'utilisateur
                    string SelectionEtudiant = "f"; //Variable qui check si un étudiant est sélectionné (vrai ou faux)
                    string SelectionCours = "t"; //Variable qui check si un cours est sélectionné (t or f)

                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Titre.Length / 2)) + "}", Titre));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (AjouterCours.Length / 2)) + "}", AjouterCours));
                    Console.WriteLine("________________________________________________________________________________________________________________________");

                    Console.WriteLine();
                    Console.Write("Numero Etudiant: ");
                    try
                    {
                        NumeroEtudiant = int.Parse(Console.ReadLine());
                        if (NumeroEtudiant > 9999999 || NumeroEtudiant < 1000000) //Vérification du numéro étudiant
                        {
                            Console.WriteLine("Le numéro étudiant doir être de 7 chiffres");
                        }
                        else if (NumeroEtudiant <= 9999999 || NumeroEtudiant >= 1000000)
                        {

                            using (var srEtudiant = new StreamReader(FichierEtudiants))
                            {
                                while (!srEtudiant.EndOfStream) //Recherche du Numéro Étudiant
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
                                }
                            }
                            if (SelectionEtudiant == "t") // true
                            {
                                Console.Write("Numéro du cours : ");
                                try
                                {
                                    NumeroCours = int.Parse(Console.ReadLine()?? FichierCours);
                                    using (var srCours = new StreamReader(FichierCours))
                                    {
                                        while (!srCours.EndOfStream) //Recherche du cours associé a l'étudiant
                                        {
                                            var line = srCours.ReadLine();
                                            if (line.IndexOf(NumeroEtudiant.ToString() + ", " + NumeroCours.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Le cours " + NumeroCours + " pour l'étudiant " + EtudiantSelectionne + " existe déjà.");
                                                Console.WriteLine("Veuillez créer un autre cours");
                                                Thread.Sleep(deuxSecondes);
                                                SelectionCours = "f";
                                            }
                                        }
                                    }
                                    if (SelectionCours == "t") //true
                                    {
                                        Console.WriteLine();
                                        Console.Write("Titre du cours : ");
                                        TitreDuCours = (Console.ReadLine());
                                        Console.WriteLine();
                                        Cours cours = new Cours(NumeroEtudiant, NumeroCours, TitreDuCours);
                                        Console.WriteLine("Le cours a été sauvegardé avec succès.");
                                    }

                                }
                                catch //Si l'utilisateur entre des lettres
                                {
                                    Console.WriteLine("Le numéro du cours doit être des chiffres.");
                                }
                            
                            }
                            else if (SelectionEtudiant == "f") //Si l'étudiant n'existe pas
                            {
                                Console.WriteLine("L'étudiant n'a pas été trouvé.");
                            }
                        
                        }
                    }
                    catch //Si l'utilisateur entre des lettres
                    {
                        Console.WriteLine("Veuillez entrer un numéro d'étudiant valide.");
                    }

                }
                /*************************************************************************************************************************************************/
                /*Quitter le programme*/
                else if (Selection.ToLower() == "x")
                {
                    break; //Afin de quitter la boucle
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
    } //Fin de la classe Programme
} // Fin de namespace Exam_AQL