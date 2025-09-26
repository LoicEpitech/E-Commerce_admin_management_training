using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionFournisseur : GestionBoutique
    {
        
        /// <summary>
        /// Retourne la liste de tous les fournisseur
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return getTuplesRequeteSelect("select * FROM fournisseur", "TousLesFournisseur");    
        }

        /// <summary>
        /// Retourne la liste des nom des fournisseur : id et NOM )
        /// </summary>
        /// <returns></returns>
        public static DataTable getPatronymes()
        { 
            return getTuplesRequeteSelect("SELECT idFournisseur, CONCAT(NomFournisseur,' - ',idFournisseur) AS NomFournisseur FROM fournisseur", "TousNomLesFournisseur");
        }

        /// <summary>
        /// Retourne le nombre de fournisseur
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(getResultatRequeteScalaire("select count(*) from fournisseur"));
        }

        /// <summary>
        /// Ajoute un fournisseur
        /// </summary>
        /// <param name="idFournisseur">Nom du Fournisseur</param>
        /// <param name="NomFournisseur">Prénom du Fournisseur</param>
        /// <param name="VilleFournisseur">Rue du Fournisseur</param>
        /// <param name="CPFournisseur">Code postal du Fournisseur</param>
        public static void ajouter(int idFournisseur, string NomFournisseur, string VilleFournisseur, int CPFournisseur)
        {
            executerRequeteAction("INSERT INTO fournisseur (idFournisseur, NomFournisseur, VilleFournisseur, CPFournisseur) VALUES (" + idFournisseur + ",'" + NomFournisseur + "','" + VilleFournisseur + "',"+ CPFournisseur + ")");
        }

        /// <summary>
        /// Modifie les informations d'un fournisseur
        /// </summary>
        /// <param name="idFournisseur">Nom du Fournisseur</param>
        /// <param name="NomFournisseur">Prénom du Fournisseur</param>
        /// <param name="VilleFournisseur">Rue du Fournisseur</param>
        /// <param name="CPFournisseur">Code postal du Fournisseur</param>
        public static void modifier(int idFournisseur, string NomFournisseur, string VilleFournisseur, int CPFournisseur)
        {
            executerRequeteAction("UPDATE fournisseur SET NomFournisseur = '" + NomFournisseur + "',VilleFournisseur = '" + VilleFournisseur + "',CPFournisseur = " + CPFournisseur + " WHERE idFournisseur = " + idFournisseur) ;
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="idFournisseur">Identifiant du fournisseur à supprimer</param>
        public static void supprimer(int idFournisseur)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            executerRequeteAction("DELETE FROM fournisseur WHERE idFournisseur = " + idFournisseur);
        }
        

        /// <summary>
        /// Retourne la liste de tous les fournisseur :  id et nom
        /// </summary>
        /// <returns></returns>
        public static DataTable getFournisseur()
        {
            return getTuplesRequeteSelect("SELECT idFournisseur, NomFournisseur AS Nom FROM fournisseur", "TousLesFournisseur");
        }

    }
}
