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
    public class GestionCommandeTests
    {
        [TestInitialize]
        public void Setup()
        {
            GestionBoutique.seConnecter();
        }

        [TestMethod]
        public void GetTuples_RetourneDesCommandes()
        {
            DataTable dt = GestionCommande.getTuples();
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void GetCommandes_RetourneListeCommandes()
        {
            DataTable dt = GestionCommande.getCommandes();
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void AjouterEtSupprimerCommande_FonctionneCorrectement()
        {
            int idCommandeTest = 999;
            int idUtilisateurTest = 1;
            string dateCommande = DateTime.Now.ToString("yyyy-MM-dd");

            GestionCommande.ajouterCommande(idCommandeTest, idUtilisateurTest, dateCommande);
            DataRow commande = GestionCommande.getCommandeById(idCommandeTest);
            Assert.AreEqual(idCommandeTest, Convert.ToInt32(commande["idCommande"]));
            Assert.AreEqual(idUtilisateurTest, Convert.ToInt32(commande["idDuClient"]));

            GestionCommande.supprimer(idCommandeTest);
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                _ = GestionCommande.getCommandeById(idCommandeTest);
            });
        }

        [TestMethod]
        public void AjouterLigneCommande_FonctionneCorrectement()
        {
            int idCommandeTest = 998;
            int idUtilisateurTest = 1;
            int idProduitTest = 1;
            int quantite = 2;
            string dateCommande = DateTime.Now.ToString("yyyy-MM-dd");

            GestionCommande.ajouterCommande(idCommandeTest, idUtilisateurTest, dateCommande);
            GestionCommande.ajouterLigneCommande(idCommandeTest, idProduitTest, quantite);

            DataRow row = GestionCommande.getNbProduitInCommandeById(idCommandeTest);
            Assert.IsNotNull(row);
            Assert.AreEqual("1", row[0].ToString());

            GestionCommande.supprimer(idCommandeTest);
        }

        [TestMethod]
        public void GetProduit_RetourneListeProduits()
        {
            DataTable dt = GestionCommande.getProduit();
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void GetNbTuplesCommandeEtLigneCommande_RetourneValeursPositives()
        {
            int nbCommandes = GestionCommande.getNbTuplesCommande();
            int nbLignes = GestionCommande.getNbTupleslignedecommande();

            Assert.IsTrue(nbCommandes >= 0);
            Assert.IsTrue(nbLignes >= 0);
        }

        [TestCleanup]
        public void Cleanup()
        {
            
        }
    }
}
