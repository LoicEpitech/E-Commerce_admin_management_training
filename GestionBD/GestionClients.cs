using Mysqlx.Crud;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionClients : GestionBoutique
    {
        
        /// <summary>
        /// Retourne la liste de tous les utilisateur
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return getTuplesRequeteSelect("select idUtilisateur, loginUtilisateur, nomUtilisateur, prenomUtilisateur, emailUtilisateur, telUtilisateur, adresseRueUtilisateur, adresseCpUtilisateur, adresseVilleUtilisateur,isAdmin AS Permission_De_Lutilisateur from utilisateur", "TousLesClients");    
        }

        /// <summary>
        /// Retourne les information d un utilisateur par sont Id
        /// </summary>
        /// <returns></returns>
        public static DataRow getTupleById(int idUtilisateur)
        {
            return getTuplesRequeteSelect("SELECT * FROM utilisateur WHERE idUtilisateur = " + idUtilisateur, "LeClientParId").Rows[0];
        }

        /// <summary>
        /// Retourne la liste des Patronymes de l Utilisateur : id et NOM prenom)
        /// </summary>
        /// <returns></returns>
        public static DataTable getPatronymes()
        { 
            return getTuplesRequeteSelect("SELECT idUtilisateur, CONCAT(UPPER(nomUtilisateur),' ',prenomUtilisateur) AS Patronyme FROM utilisateur", "TousLesPatronymesClients");
        }

        public static DataTable getPatro()
        {
            return getTuplesRequeteSelect("SELECT idUtilisateur, CONCAT(UPPER(nomUtilisateur),' ',prenomUtilisateur) AS Patronyme FROM utilisateur", "TousLesPatronymesClientsAvecId");
        }

        /// <summary>
        /// Retourne le nombre d utilisateur
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(getResultatRequeteScalaire("select count(*) from utilisateur"));
        }

        /// <summary>
        /// Ajoute un client
        /// </summary>
        /// <param name="idUtilisateur">Id de l Utilisateur</param>
        /// <param name="nomUtilisateur">Nom de l Utilisateur</param>
        /// <param name="prenomUtilisateur">Prénom de l Utilisateur</param>
        /// <param name="adresseRueUtilisateur">Rue de l Utilisateur</param>
        /// <param name="adresseCpUtilisateur">Code postal de l Utilisateur</param>
        /// <param name="adresseVilleUtilisateur">Ville de l Utilisateur</param>
        /// <param name="telUtilisateur">Téléphone de l Utilisateur</param>
        /// <param name="emailUtilisateur">Email de l Utilisateur</param>
        /// <param name="passUtilisateur">Passe de l Utilisateur</param>
        /// <param name="isAdmin">Email de l Utilisateur</param>
        public static void ajouter(int idUtilisateur, string nomUtilisateur, string prenomUtilisateur, string adresseRueUtilisateur, string adresseCpUtilisateur, string adresseVilleUtilisateur, string telUtilisateur, string emailUtilisateur,string passUtilisateur, int isAdmin)
        {
            string loginUtilisateur = emailUtilisateur;
            string adresseIpUtilisateur = "1111";
            int otpCode = 0;
            executerRequeteAction("INSERT INTO utilisateur (idUtilisateur, loginUtilisateur, passUtilisateur, nomUtilisateur, prenomUtilisateur, emailUtilisateur, telUtilisateur,adresseRueUtilisateur, adresseCpUtilisateur, adresseVilleUtilisateur, adresseIpUtilisateur, isAdmin, otpCode) VALUES (" + idUtilisateur + ",'" + loginUtilisateur + "','"+ passUtilisateur + "','" + nomUtilisateur + "', '" + prenomUtilisateur + "', '" + emailUtilisateur + "' , '" + telUtilisateur + "', '" + adresseRueUtilisateur + "', " + adresseCpUtilisateur + ",'"+adresseVilleUtilisateur+"',"+ adresseIpUtilisateur + ","+isAdmin+","+otpCode+")");
        }

        /// <summary>
        /// Modifie les informations d'un client
        /// </summary>
        /// <param name="idUtilisateur">Id de l Utilisateur</param>
        /// <param name="nomUtilisateur">Nom de l Utilisateur</param>
        /// <param name="prenomUtilisateur">Prénom de l Utilisateur</param>
        /// <param name="adresseRueUtilisateur">Rue de l Utilisateur</param>
        /// <param name="adresseCpUtilisateur">Code postal de l Utilisateur</param>
        /// <param name="adresseVilleUtilisateur">Ville de l Utilisateur</param>
        /// <param name="telUtilisateur">Téléphone de l Utilisateur</param>
        /// <param name="emailUtilisateur">Email de l Utilisateur</param>
        /// <param name="passUtilisateur">Passe de l Utilisateur</param>
        /// <param name="isAdmin">Permission de l Utilisateur</param>
        public static void modifier(int idUtilisateur, string nomUtilisateur, string prenomUtilisateur, string adresseRueUtilisateur, string adresseCpUtilisateur, string adresseVilleUtilisateur, string telUtilisateur, string emailUtilisateur, string passUtilisateur, int isAdmin)
        {
            string loginUtilisateur = emailUtilisateur;
            executerRequeteAction("UPDATE utilisateur SET idUtilisateur = " + idUtilisateur + ",loginUtilisateur = '"+loginUtilisateur+"', passUtilisateur = '"+passUtilisateur+"', nomUtilisateur = '" + nomUtilisateur + "', prenomUtilisateur = '" + prenomUtilisateur + "', emailUtilisateur = '" + emailUtilisateur + "', telUtilisateur = '" + telUtilisateur + "', adresseRueUtilisateur = '" + adresseRueUtilisateur + "', adresseCpUtilisateur = '" + adresseCpUtilisateur + "', adresseVilleUtilisateur = '" + adresseVilleUtilisateur + "', isAdmin = "+isAdmin+ " WHERE idUtilisateur = " + idUtilisateur + ";");
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="idUtilisateur">Identifiant du client à supprimer</param>
        public static void supprimer(int idUtilisateur)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            executerRequeteAction("DELETE FROM utilisateur WHERE idUtilisateur = " + idUtilisateur);
        }

        #region Recherche Client

        /// <summary>
        /// Retourne les information d un utilisateur par sont Nom , prenom , couriel/login, numéro de téléphone ou id de l utilisateur (Like %recherche%)
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesByNom(string recherche)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT * FROM utilisateur WHERE nomUtilisateur LIKE '%"+recherche+"%' OR prenomUtilisateur LIKE '%"+recherche+"%' OR adresseVilleUtilisateur LIKE '%"+recherche+"%' OR telUtilisateur LIKE '%"+recherche+"%' OR emailUtilisateur LIKE '%"+recherche+"%' OR idUtilisateur LIKE '%"+recherche+"%'", "Le(s)ClientParRecherche");
        }



        /// <summary>
        /// Retourne si un ID utilisateur existe
        /// </summary>
        /// <returns></returns>
        public static int getIdExist2(string idRecherche)
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("SELECT COUNT(*) AS nbUtilisateur FROM utilisateur WHERE idUtilisateur = " + idRecherche));
        }



        #endregion
    }

}
