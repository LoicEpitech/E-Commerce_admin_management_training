using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
//Ajout des namespaces nécessaires pour les classes utiles avec la gestion de BD
//using MySql.Data.MySqlConnector; Ne marche pas dans mon cas réson inconue
using MySqlConnector;
using GestionBD.MySQL;


namespace GestionBD.MySQL
{

    public class GestionBoutique
    {
        #region champs statiques

        private static MySqlConnection maConnexion = new MySqlConnection();
        private static MySqlCommand maCommandeSpecialRequete = new MySqlCommand();
        private static MySqlDataAdapter monRemplisseur = new MySqlDataAdapter();
        private static DataSet monJeuDeDonnees = new DataSet();
        private static string maRequete;

        #endregion

        #region Méthodes statiques
        
        /// <summary>
        /// Permet de se connecter avec les infos de connexions de la classe MysqlConfig
        /// </summary>
        public static void seConnecter()
        {
            if (maConnexion.State == ConnectionState.Closed)
            {
                string maChaine = "Server=" + MysqlConfig.SERVEUR + ";Database=" + MysqlConfig.BASE + ";Uid=" + MysqlConfig.UTILISATEUR + ";Pwd=" + MysqlConfig.MOT_DE_PASSE + ";";
                //string maChaine = "Server=" + MysqlConfig.SERVEUR + ";Port=" + MysqlConfig.PORT + ";Database=" + MysqlConfig.BASE + ";Uid=" + MysqlConfig.UTILISATEUR + ";Pwd=" + MysqlConfig.MOT_DE_PASSE + ";";
                //Exemple de valeur correspondante pour maChaine : "Server=localhost;Database=votrenom_boutique;Uid=root;Pwd=;";
                //Site de référence pour toutes les chaines de connexion : http://www.connectionstrings.com/

                maConnexion.ConnectionString = maChaine;

                try
                {
                    maConnexion.Open();
                    Console.WriteLine("Connexion ouverte avec succès.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                    throw; // Relance l'exception pour permettre un traitement éventuel
                }

                monJeuDeDonnees = new DataSet("dsBoutique"); //On  nomme le DataSet
                monJeuDeDonnees.Clear();
                maCommandeSpecialRequete.CommandType = CommandType.Text;
                maCommandeSpecialRequete.Connection = maConnexion;

            }
        }


        /// <summary>
        /// Permet de se connecter à partir des infos fournies en paramètres user name  et pasW
        /// (provenant d'un formulaire de Connexion par exemple...)
        /// </summary>
        /// <param name="nomUtilisateur">Nom de l'utilisateur</param>
        /// <param name="motDePasse">Mot de passe</param>
        public static bool seConnecter(string nomUtilisateur, string motDePasse)
        {
            if (maConnexion.State == ConnectionState.Closed)
            {
                // Construction de la chaîne de connexion.
                string maChaine = $"Server={MysqlConfig.SERVEUR};Database={MysqlConfig.BASE};Uid={nomUtilisateur};Pwd={motDePasse};";
                // Exemple : "Server=localhost;Database=boutique;Uid=root;Pwd=;"

                maConnexion.ConnectionString = maChaine;

                try
                {
                    // Tentative d'ouverture de la connexion.
                    maConnexion.Open();
                    Console.WriteLine("Connexion ouverte avec succès.");
                }
                catch (Exception ex)
                {
                    // Gestion des erreurs lors de l'ouverture de la connexion.
                    Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                    maConnexion.Close();
                    return false;
                }

                // Initialisation du DataSet et de la commande SQL.
                try
                {
                    monJeuDeDonnees = new DataSet("dsBoutique"); // Nom du DataSet
                    monJeuDeDonnees.Clear();

                    maCommandeSpecialRequete.CommandType = CommandType.Text;
                    maCommandeSpecialRequete.Connection = maConnexion;
                    Console.WriteLine("DataSet et commande initialisés.");
                    return true;
                }
                catch (Exception ex)
                {
                    // Gestion des erreurs lors de la configuration du DataSet ou de la commande.
                    Console.WriteLine("Erreur lors de l'initialisation du DataSet ou de la commande : " + ex.Message);
                    return false;
                }
            }

            Console.WriteLine("La connexion est déjà ouverte.");
            return false;
        }

        /// <summary>
        /// Permet de se connecter à partir des infos fournies en paramètres
        /// (provenant d'un formulaire de Connexion par exemple...)
        /// </summary>
        /// <param name="nomServeur">Nom du serveur</param>
        /// <param name="nomBase">Nom de la base de données</param>
        /// <param name="nomUtilisateur">Nom de l'utilisateur</param>
        /// <param name="motDePasse">Mot de passe</param>
        public static void seConnecter(string nomServeur, string nomBase, string nomUtilisateur, string motDePasse)
        {
            if (maConnexion.State == ConnectionState.Closed)
            {
                string maChaine = "Server=" + nomServeur + ";Database=" + nomBase + "; Uid=" + nomUtilisateur + "; Pwd=" + motDePasse + ";";
                //Exemple de valeur correspondante pour maChaine : "Server=localhost;Database=votrenom_boutique;Uid=root;Pwd=;";
                //Site de référence pour toutes les chaines de connexion : http://www.connectionstrings.com/

                maConnexion.ConnectionString = maChaine;

                try
                {
                    maConnexion.Open(); // Ouvre la connexion
                    Console.WriteLine("Connexion ouverte avec succès.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                    throw; // Relance l'exception pour permettre un traitement éventuel
                }

                monJeuDeDonnees = new DataSet("dsBoutique");//On  nomme le DataSet
                monJeuDeDonnees.Clear();
                maCommandeSpecialRequete.CommandType = CommandType.Text;
                maCommandeSpecialRequete.Connection = maConnexion;

            }
        }
       

        /// <summary>
        /// Permet de vider le DataSet en mémoire
        /// </summary>
        public static void viderJeuDonnees()
        {
            monJeuDeDonnees.Clear();
        }


        #region FACTORISATION pour les requêtes de CONSULTATION, requêtes SCALAIRES et d'ACTION

        /// <summary>
        /// Récupère le résultat d'une requête SELECT
        /// </summary>
        /// <param name="texteRequete">Texte de la requête SQL</param>
        /// <param name="nomDataTable">Nom de la DataTable contenue dans le DataSet</param>
        /// <returns>DataTable retournée avec les tuples renvoyés par le SELECT</returns>
        public static DataTable getTuplesRequeteSelect(string texteRequete, string nomDataTable)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.monRemplisseur.SelectCommand = GestionBoutique.maCommandeSpecialRequete;
            if (GestionBoutique.monJeuDeDonnees.Tables.Contains(nomDataTable))
            {
                monJeuDeDonnees.Tables[nomDataTable].Clear();
            }
            GestionBoutique.monRemplisseur.Fill(GestionBoutique.monJeuDeDonnees, nomDataTable);
            return GestionBoutique.monJeuDeDonnees.Tables[nomDataTable];
        }

        /// <summary>
        /// Récupère le résultat d'une requête scalaire
        /// (Contenant un agrégat de type COUNT, SUM, AVG, MIN, MAX...
        /// </summary>
        /// <param name="texteRequete">Texte de la requête SQL</param>
        /// <returns>Résultat retourné de type DOUBLE</returns>
        protected static double getResultatRequeteScalaire(string texteRequete)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            return Convert.ToDouble(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
        }

        /// <summary>
        /// Exécute une requête de type ACTION
        /// (c'est à dire de type INSERT, UPDATE, DELETE)
        /// </summary>
        /// <param name="texteRequete">Texte de la requête SQL</param>
        protected static void executerRequeteAction(string texteRequete)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        #endregion



        #region Autres méthodes utiles
        /// <summary>
        /// Permet de générer une valeur de clé primaire pour une table donnée en paramètre
        /// (sorte d'AUTO-INCREMENT pour une table créé sans) 
        /// La clé primaire est nommée id dans toutes les tables
        /// (sinon ajouter un paramètre contenant le nom de la clé)
        /// </summary>
        /// <param name="nomTable">Nom de la table</param>
        /// <returns>Valeur de clé primaire généré</returns>
        protected static int getNouvelleClePrimaire(string nomTable)
        {
            int Cle = Convert.ToInt32(getResultatRequeteScalaire("SELECT Max(id) FROM " + nomTable));
            return (Cle + 1);
        }




        #endregion

        #region utilisation Procedur Stoquer
        // Retourne rien

        /// <summary>
        /// Exécute une Procedure Stockée
        /// </summary>
        /// <param name="nomProcedure">nom de la procedure stoquer avec la quelle on souhaite interagire</param>
        /// /// <param name="elements">Dictionaire d element qui sera utiliser comme parametre pour la procedure stockée</param>
        public static void appelerProcedureStocke(string nomProcedure, Dictionary<string, object> elements)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(nomProcedure, maConnexion);
                command.CommandType = CommandType.StoredProcedure;
                foreach (var unElement in elements)
                {   // Ajouter les paramètres à la commande \\
                    command.Parameters.AddWithValue(unElement.Key, unElement.Value);
                }
                command.ExecuteNonQuery(); // Exécuter la commande \\
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de l'exécution de la <procédure Stockée : " + ex.Message);
            }
        }

        public static void appelerFonctionStockeeV1()
        {
            try
            {
                // Créer une commande pour la procédure stockée \\
                MySqlCommand command = new MySqlCommand("addUserIfNotExists", maConnexion);
                command.CommandType = CommandType.StoredProcedure;
                // Ajouter les paramètres à la commande \\
                command.Parameters.AddWithValue("@loginUtilisateur", "loginTesteee");
                command.Parameters.AddWithValue("@passUtilisateur", "monMotsDePassTest");
                command.Parameters.AddWithValue("@nomUtilisateur", "testNomTest");
                command.Parameters.AddWithValue("@prenomUtilisateur", "testPrenomTest");
                command.Parameters.AddWithValue("@emailUtilisateur", "email@test.com");
                command.Parameters.AddWithValue("@telUtilisateur", "0111111111");
                command.Parameters.AddWithValue("@adresseRueUtilisateur", "rue test");
                command.Parameters.AddWithValue("@adresseCpUtilisateur", 34500);
                command.Parameters.AddWithValue("@adresseVilleUtilisateur", "villeTest");
                command.Parameters.AddWithValue("@isAdmin", 0);
                command.ExecuteNonQuery(); // Exécuter la commande \\
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de l'exécution de la procédure stockée : " + ex.Message);
            }
        }

        public static void appelerFonctionStockeeV2()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("GetNomUtilisateur", maConnexion);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@loginUtilisateur", "noro1");

                MySqlParameter outputParameter = new MySqlParameter("@nomUtilisateur", MySqlDbType.VarChar);
                outputParameter.Size = 250;  // Spécifier la taille de la chaîne
                outputParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParameter);
                command.ExecuteNonQuery();
                string nomUtilisateur = outputParameter.Value.ToString();
                Console.WriteLine("Nom d'utilisateur récupéré : " + nomUtilisateur);
            } catch (Exception ex) {
                Console.WriteLine("Erreur lors de l'exécution de la fonction stockée : " + ex.Message);
            }
        }

        #endregion

        #endregion

    }
}



