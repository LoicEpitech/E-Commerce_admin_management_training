using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionCommande : GestionBoutique
    {

        private static int numDataTable = 0;
        
        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return getTuplesRequeteSelect("SELECT commande.idCommande AS Id_de_la_Commande,  CONCAT(UPPER(utilisateur.nomUtilisateur),' ',utilisateur.prenomUtilisateur) AS Nom_du_Client, produit.idProduit AS Id_du_Produit, produit.LibelleProduit AS Nom_du_Produit, lignedecommande.QuantiteCom AS Quantiter, commande.DateCommande AS Date_de_Commande, produit.PrixHTProduit  AS Prix_du_Produit FROM produit, lignedecommande, commande ,utilisateur WHERE produit.idProduit = lignedecommande.idProduit AND lignedecommande.idCommande = commande.idCommande AND commande.idUtilisateur = utilisateur.idUtilisateur ORDER BY Id_de_la_Commande DESC", "TouteLesCommandes");    
        }


        /// <summary>
        /// Retourne la liste des Commande : id et Date)
        /// </summary>
        /// <returns></returns>
        public static DataTable getCommandes()
        {
            return getTuplesRequeteSelect("SELECT commande.idCommande AS idCommande, CONCAT(UPPER(utilisateur.nomUtilisateur),' ',utilisateur.prenomUtilisateur,' - ',commande.DateCommande) AS patronymeClientEtDateCommande FROM commande, utilisateur WHERE utilisateur.idUtilisateur = commande.idUtilisateur GROUP BY idCommande; ", "TouteLesCommandes2");
        }

        /// <summary>
        /// Retourne la liste des Commande : id et Date)
        /// </summary>
        /// <returns></returns>
        public static DataRow getCommandeById(int idCommande)
        {
            return getTuplesRequeteSelect("SELECT commande.idCommande AS idCommande, commande.DateCommande AS dateDeCommande, commande.idUtilisateur AS idDuClient, lignedecommande.idProduit AS idDuProduit, lignedecommande.QuantiteCom AS quantiterProduit FROM commande, lignedecommande WHERE lignedecommande.idCommande = commande.idCommande AND commande.idCommande = " + idCommande+";", "LesCommandeByLeurId").Rows[0];
        }

        /// <summary>
        /// Retourne le nombre de produit present dans une Commande by id)
        /// </summary>
        /// <returns></returns>
        public static DataRow getNbProduitInCommandeById(int idCommande)
        {
            return getTuplesRequeteSelect("SELECT count(idCommande) FROM lignedecommande WHERE idCommande = " + idCommande + ";", "LeNombreDeProduitDansUneCommandeById").Rows[0];
        }

        /// <summary>
        /// Retourne le nombre de produit present dans une Commande by id)
        /// </summary>
        /// <returns></returns>
        public static DataTable getCompositionProduitInCommandeById(int idCommande)
        {
            return getTuplesRequeteSelect("SELECT lignedecommande.idProduit AS idDuProduit, lignedecommande.QuantiteCom AS quantiterProduit FROM commande, lignedecommande WHERE lignedecommande.idCommande = commande.idCommande AND commande.idCommande = " + idCommande + ";", "laCompositionDuneCommandeById");
        }

        /// <summary>
        /// Retourne la liste des libel des Produits : id et libelle + prix)
        /// </summary>
        /// <returns></returns>
        public static DataTable getProduit()
        {
            GestionCommande.numDataTable++;
            return getTuplesRequeteSelect("SELECT idProduit, CONCAT(LibelleProduit,' ',PrixHTProduit,' €') AS libelProduit FROM produit", "TousLesProduit" + GestionCommande.numDataTable);
           
        }

        /// <summary>
        /// Retourne le nombre de commande
        /// </summary>
        /// <returns></returns>
        public static int getNbTuplesCommande()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select max(idCommande) from commande"));
        }

        /// <summary>
        /// Retourne le nombre de ligne de commande
        /// </summary>
        /// <returns></returns>
        public static int getNbTupleslignedecommande()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from lignedecommande"));
        }//lignedecommande



        /// <summary>
        /// Ajoute une commande
        /// </summary>
        /// <param name="idCommande">Identifiant de la commande</param>
        /// <param name="IdUtilisateur">Identifiant du client</param>
        /// <param name="DateCommande">Date de la commande</param>
        public static void ajouterCommande(int idCommande, int IdUtilisateur, string DateCommande)
        {
            executerRequeteAction("INSERT INTO commande (idCommande, DateCommande, idUtilisateur) VALUES (" + idCommande + ",'" + DateCommande + "'," + IdUtilisateur + ")");               
        }

        /// <summary>
        /// Ajoute une ligne de commande
        /// </summary>
        /// <param name="idCommande">Identifiant de la commande</param>
        /// <param name="idProduit">Identifiant du produit</param>
        /// <param name="quantiteeProduit">Quantiter du produit</param>
        public static void ajouterLigneCommande(int idCommande, int idProduit, int quantiteeProduit)
        {
            executerRequeteAction("INSERT INTO lignedecommande (idCommande, idProduit, QuantiteCom) VALUES (" + idCommande + "," + idProduit + "," + quantiteeProduit + ")");
        }


        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="id">Identifiant du client à supprimer</param>
        public static void supprimer(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"
            executerRequeteAction("DELETE FROM lignedecommande WHERE idCommande = " + id);
            executerRequeteAction("DELETE FROM commande WHERE idCommande = " + id);
        }

    }
}
