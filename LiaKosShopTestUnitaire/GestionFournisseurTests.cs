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
    public class GestionFournisseurTests
    {
        private int idTest = 999;
        private string nomTest = "Test Fournisseur";
        private string villeTest = "Paris";
        private int cpTest = 75000;

        [TestInitialize]
        public void Setup()
        {
            GestionBoutique.seConnecter();
        }

        [TestMethod]
        public void GetTuples_RetourneDesFournisseurs()
        {
            DataTable dt = GestionFournisseur.getTuples();
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void GetPatronymes_RetourneDesPatronymes()
        {
            DataTable dt = GestionFournisseur.getPatronymes();
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [TestMethod]
        public void AjouterModifierEtSupprimerFournisseur_FonctionneCorrectement()
        {
            // Ajout
            GestionFournisseur.ajouter(idTest, nomTest, villeTest, cpTest);

            DataTable dt = GestionFournisseur.getTuples();
            DataRow[] rows = dt.Select($"idFournisseur = {idTest}");
            Assert.AreEqual(1, rows.Length);
            Assert.AreEqual(nomTest, rows[0]["NomFournisseur"]);

            // Modification
            string nouveauNom = "Fournisseur Modifié";
            string nouvelleVille = "Lyon";
            int nouveauCP = 69000;

            GestionFournisseur.modifier(idTest, nouveauNom, nouvelleVille, nouveauCP);

            DataTable dtModif = GestionFournisseur.getTuples();
            DataRow[] modifRows = dtModif.Select($"idFournisseur = {idTest}");
            Assert.AreEqual(1, modifRows.Length);
            Assert.AreEqual(nouveauNom, modifRows[0]["NomFournisseur"]);
            Assert.AreEqual(nouvelleVille, modifRows[0]["VilleFournisseur"]);
            Assert.AreEqual(nouveauCP, Convert.ToInt32(modifRows[0]["CPFournisseur"]));

            // Suppression
            GestionFournisseur.supprimer(idTest);
            DataTable dtFinal = GestionFournisseur.getTuples();
            DataRow[] finalRows = dtFinal.Select($"idFournisseur = {idTest}");
            Assert.AreEqual(0, finalRows.Length);
        }

        [TestMethod]
        public void GetNbTuples_RetourneNombrePositif()
        {
            int nb = GestionFournisseur.getNbTuples();
            Assert.IsTrue(nb >= 0);
        }

        [TestMethod]
        public void GetFournisseur_RetourneListeAvecIdEtNom()
        {
            DataTable dt = GestionFournisseur.getFournisseur();
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Columns.Contains("idFournisseur"));
            Assert.IsTrue(dt.Columns.Contains("Nom"));
        }
    }
}
