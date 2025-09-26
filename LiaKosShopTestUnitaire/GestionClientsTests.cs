using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiaKosShop;
using GestionBD;
using GestionBD.MySQL;
using System.Data;
using System.Threading.Tasks;

namespace egryHugoTestUnitaire
{
    [TestClass]
    public class GestionClientsTests
    {
        private int clientTestId = 90000;

        [TestInitialize]
        public void Setup()
        {
            GestionBoutique.seConnecter();
        }

        [TestMethod]
        public void AjouterEtGetTupleById_FonctionneCorrectement()
        {
            // Ajouter un client de test
            GestionClients.ajouter(clientTestId, "Dupont", "Jean", "12 rue de la paix", "75000", "Paris", "0102030405", "test@test.com", "password", 0);
            DataRow row = GestionClients.getTupleById(clientTestId);

            Assert.IsNotNull(row, "L\'élement de verification retourner est NULL");
            Assert.AreEqual("Dupont", row["nomUtilisateur"], "Le nom d\'utilisateur retourner n est pas identique a celui de l\'insertion");
            Assert.AreEqual("Jean", row["prenomUtilisateur"], "Le prénom d'utilisateur retourner n est pas identique a celui de l'insertion");
        }

        [TestMethod]
        public void ModifierClient_ModifieLesChamps()
        {
            GestionClients.ajouter(clientTestId, "Test", "Initial", "1 rue A", "75000", "Paris", "0101010101", "init@test.com", "1234", 0);

            GestionClients.modifier(clientTestId, "Modifié", "Nom", "2 rue B", "69000", "Lyon", "0202020202", "modif@test.com", "abcd", 1);
            DataRow row = GestionClients.getTupleById(clientTestId);

            Assert.AreEqual("Modifié", row["nomUtilisateur"]);
            Assert.AreEqual("Lyon", row["adresseVilleUtilisateur"]);
        }

        [TestMethod]
        public void SupprimerClient_RendLeTupleInexistant()
        {
            GestionClients.ajouter(clientTestId, "ToDelete", "User", "1 rue C", "75000", "Paris", "0102030405", "delete@test.com", "motdepasse", 0);

            GestionClients.supprimer(clientTestId);

            Assert.ThrowsException<IndexOutOfRangeException>(() => GestionClients.getTupleById(clientTestId));
        }

        [TestMethod]
        public void GetNbTuples_RetourneValeurPositive()
        {
            int count = GestionClients.getNbTuples();
            Assert.IsTrue(count >= 0);
        }

        [TestMethod]
        public void GetTuplesByNom_RetourneDesResultats()
        {
            DataTable table = GestionClients.getTuplesByNom("Dupont");
            Assert.IsNotNull(table);
            Assert.IsInstanceOfType(table, typeof(DataTable));
        }

        [TestMethod]
        public void GetPatronymes_ColonneExiste()
        {
            DataTable table = GestionClients.getPatronymes();
            Assert.IsTrue(table.Columns.Contains("Patronyme"));
        }

        [TestMethod]
        public void GetIdExist2_CompteCorrect()
        {
            GestionClients.ajouter(clientTestId, "Compteur", "Test", "rue", "75000", "Paris", "0102030405", "count@test.com", "pass", 0);
            int result = GestionClients.getIdExist2(clientTestId.ToString());
            Assert.AreEqual(1, result);
        }

        [TestCleanup]
        public void Cleanup()
        {
            try {
                GestionClients.supprimer(clientTestId);
            } catch {
                // Ignore les erreurs si déjà supprimé
            }
        }
    }
}
