using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBD.MySQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace egryHugoTestUnitaire
{
    [TestClass]
    public class GestionProduitTests
    {
        [TestMethod]
        public void TestGetNbTuples()
        {
            int count = GestionProduit.getNbTuples();
            Assert.IsTrue(count >= 0, "Le nombre de produits devrait être positif ou nul.");
        }

        [TestMethod]
        public void TestAjoutEtSuppressionProduit()
        {
            int idProduit = 9999;
            string libelle = "TestProduit";
            float prix = 99.99f;
            int stock = 10;
            int idFourn = 1; // Assurez-vous qu'il existe
            int idCat = 1;   // Assurez-vous qu'il existe
            string image = "test.jpg";

            GestionProduit.ajouter(idProduit, libelle, prix, stock, idFourn, idCat, image);

            DataRow produit = GestionProduit.getProduitById(idProduit);
            Assert.AreEqual(libelle, produit["LibelleProduit"].ToString());
            Assert.AreEqual(prix, float.Parse(produit["PrixHTProduit"].ToString()));
            Assert.AreEqual(stock, int.Parse(produit["QteStockProduit"].ToString()));

            GestionProduit.supprimer(idProduit);

            try
            {
                var p = GestionProduit.getProduitById(idProduit);
                Assert.Fail("Le produit devrait avoir été supprimé.");
            }
            catch
            {
                Assert.IsTrue(true); // Succès attendu
            }
        }

        [TestMethod]
        public void TestModifierProduit()
        {
            int idProduit = 9998;
            GestionProduit.ajouter(idProduit, "AncienNom", 10.0f, 5, 1, 1, "img.png");

            GestionProduit.modifier(idProduit, "NouveauNom", 20.5f, 15, 1, 1, "'nouvelleimg.jpg'");
            DataRow modifie = GestionProduit.getProduitById(idProduit);

            Assert.AreEqual("NouveauNom", modifie["LibelleProduit"].ToString());
            Assert.AreEqual(20.5f, float.Parse(modifie["PrixHTProduit"].ToString()));
            Assert.AreEqual(15, int.Parse(modifie["QteStockProduit"].ToString()));

            GestionProduit.supprimer(idProduit);
        }

        [TestMethod]
        public void TestGetCategories()
        {
            DataTable categories = GestionProduit.getCategories();
            Assert.IsTrue(categories.Rows.Count > 0, "Il devrait y avoir au moins une catégorie.");
            Assert.IsTrue(categories.Columns.Contains("Libelle"), "La colonne 'Libelle' devrait exister.");
        }

        [TestMethod]
        public void TestGetTuples()
        {
            DataTable produits = GestionProduit.getTuples();
            Assert.IsNotNull(produits);
            Assert.IsTrue(produits.Columns.Contains("LibelleProduit"));
        }
    }
}
