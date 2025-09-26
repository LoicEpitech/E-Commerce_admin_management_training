using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionProduit : GestionBoutique
    {
        
        /// <summary>
        /// Retourne la liste de tous les produit
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return getTuplesRequeteSelect("select produit.idProduit, produit.LibelleProduit , produit.PrixHTProduit, produit.QteStockProduit, fournisseur.NomFournisseur, categorie.LibelleCategorie, produit.ImageProduit , produit.nbVenteProduit FROM produit, fournisseur, categorie WHERE produit.idFourn = fournisseur.idFournisseur AND produit.idCat = categorie.idCategorie ORDER BY produit.idProduit", "TousLesProduits");    
        }

        /// <summary>
        /// Retourne un produit by sont id
        /// </summary>
        /// <returns></returns>
        public static DataRow getProduitById(int idProduit)
        {
            return getTuplesRequeteSelect("select produit.idProduit, produit.LibelleProduit , produit.PrixHTProduit, produit.QteStockProduit, fournisseur.NomFournisseur, categorie.LibelleCategorie, produit.ImageProduit , produit.nbVenteProduit FROM produit, fournisseur, categorie WHERE produit.idFourn = fournisseur.idFournisseur AND produit.idCat = categorie.idCategorie AND produit.idProduit = " + idProduit, "LeProduits").Rows[0];
        }

        /// <summary>
        /// Retourne le nombre de produit
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(getResultatRequeteScalaire("select count(*) from produit"));
        }

        /// <summary>
        /// Ajoute un produit
        /// </summary>
        /// <param name="idProduit">Id du produit</param>
        /// <param name="LibelleProduit">Libéllé du produit</param>
        /// <param name="PrixHTProduit">Prix Hors Taxe du produit</param>
        /// <param name="QteStockProduit">Quantiter en stoque du produit</param>
        /// <param name="idFourn">Id du fournisseur du produit</param>
        /// <param name="idCat">Id de la catégorie du produit</param>
        /// <param name="ImageProduit">Image du produit</param>
        public static void ajouter(int idProduit, string LibelleProduit, float PrixHTProduit, int QteStockProduit, int idFourn, int idCat, string ImageProduit)
        {
            executerRequeteAction("INSERT INTO produit (idProduit, LibelleProduit, PrixHTProduit, QteStockProduit, idFourn, idCat, ImageProduit) VALUES (" + idProduit +",'" + LibelleProduit + "', " + PrixHTProduit + "," + QteStockProduit + ","+ idFourn + ","+ idCat + ",'"+ImageProduit+"')");
        }


        /// <summary>
        /// Modifie les informations d'un produit
        /// </summary>
        /// <param name="idProduit">Id du produit</param>
        /// <param name="LibelleProduit">Libéllé du produit</param>
        /// <param name="PrixHTProduit">Prix Hors Taxe du produit</param>
        /// <param name="QteStockProduit">Quantiter en stoque du produit</param>
        /// <param name="idFourn">Id du fournisseur du produit</param>
        /// <param name="idCat">Id de la catégorie du produit</param>
        /// <param name="ImageProduit">Image du produit</para
        public static void modifier(int idProduit, string LibelleProduit, float PrixHTProduit, int QteStockProduit, int idFourn, int idCat, string ImageProduit)
        {
            executerRequeteAction("UPDATE produit SET LibelleProduit = '" + LibelleProduit + "',PrixHTProduit = " + PrixHTProduit + ",QteStockProduit = " + QteStockProduit + ",idFourn =" + idFourn + ",idCat =" + idCat + ", ImageProduit = " + ImageProduit + " WHERE idProduit = " + idProduit) ;
        }

        /// <summary>
        /// Supprime un produit
        /// </summary>
        /// <param name="idProduit">Identifiant du produit à supprimer</param>
        public static void supprimer(int idProduit)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            executerRequeteAction("DELETE FROM produit WHERE idProduit = " + idProduit);
        }


        /// <summary>
        /// Retourne la liste des Categorie de produit : id et libel de la categorie)
        /// </summary>
        /// <returns></returns>
        public static DataTable getCategories()
        {
            return getTuplesRequeteSelect("SELECT idCategorie, LibelleCategorie AS Libelle FROM categorie", "ToutLesCategorieDeProduit");
        }
        

    }
}
