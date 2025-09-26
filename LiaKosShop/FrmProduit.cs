using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiaKosShop
{
    public partial class FrmProduit : Form
    {
        public FrmProduit()
        {
            InitializeComponent();
            GestionInterface.coloriserDataGrid(dgvListeProduit);
            dgvListeProduit.DataSource = GestionProduit.getTuples();
        }

        // ######################################## ↧↧ Section PRODUIT ↧↧ ########################################

        private void btnCrerProduit_Click(object sender, EventArgs e)
        {
            gpbModifierProduit.Enabled = false;
            gpbModifierProduit.Visible = false;

            // Remplire les Combo Box
            GestionInterface.remplirComboBox(cbbCreationProduitCategorie, GestionProduit.getCategories(), "Libelle", "idCategorie");
            GestionInterface.remplirComboBox(cbbCreationProduitFournisseur, GestionFournisseur.getFournisseur(), "Nom", "idFournisseur");

            // Géneration id valid Automatique
            int newid = GestionProduit.getNbTuples() + 1;
            txtbCreationProduitId.Text = newid.ToString();

            gpbCrerProduit.Enabled = true;
            gpbCrerProduit.Visible = true;

        }

        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            gpbCrerProduit.Enabled = false;
            gpbCrerProduit.Visible = false;
            gpbModifierProduit.Enabled = true;
            gpbModifierProduit.Visible = true;

        }

        private void btnCloseMenueClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreationProduitValider_Click(object sender, EventArgs e)
        {
            int idProduit = Convert.ToInt16(txtbCreationProduitId.Text);
            string libelProduit = txtbCreationProduitLibel.Text;
            string descriptionProduit = txtbCreationProduitDescription.Text;
            int prixProduit = Convert.ToInt16(txtbCreationProduitPrix.Text);
            string imgProduit = txtbCreationProduitImg.Text;
            int idCategorieProduit = Convert.ToInt16(cbbCreationProduitCategorie.SelectedValue);
            int idFournisseurProduit = Convert.ToInt16(cbbCreationProduitFournisseur.SelectedValue);
            float PrixHTProduit = 0; 
            int QteStockProduit = 0; 

            if (!string.IsNullOrEmpty(txtbCreationProduitId.Text))
            {
                if (!string.IsNullOrEmpty(txtbCreationProduitLibel.Text))
                {
                    if (!string.IsNullOrEmpty(txtbCreationProduitDescription.Text))
                    {
                        //if (string.IsNullOrEmpty(txtbCreationProduitPrix.Text) || !GestionInterface.ContainsLetters(txtbCreationProduitPrix.Text)) // verification si des lettre sont presente dans le champ de saisie 
                        //{
                        if (!string.IsNullOrEmpty(txtbCreationProduitImg.Text))
                        {
                            GestionProduit.ajouter(idProduit, libelProduit, PrixHTProduit, QteStockProduit, idFournisseurProduit, idCategorieProduit, imgProduit);
                        }
                        // }
                    }
                }
            }
            MessageBox.Show("Vous venez de crer le produit Id: " + idProduit + "  Libel: " + libelProduit + "!");
            dgvListeProduit.DataSource = GestionProduit.getTuples(); // Actialise la data grid view (dgv)
            gpbCrerProduit.Enabled = false;
            gpbCrerProduit.Visible = false;
        }

        #region Gestion Img

        // ############################################################################################################################################################################################
        // ###################################################################################### Gestion Images  #####################################################################################
        // ############################################################################################################################################################################################

        private void btnChoixImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Déclaration de openFileDialog
            // Définition des filtres pour les types de fichiers à afficher
            openFileDialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tous les fichiers|*.*";

            // Afficher la boîte de dialogue
            DialogResult result = openFileDialog.ShowDialog();

            // Vérifier si l'utilisateur a appuyé sur le bouton OK dans la boîte de dialogue
            /*if (result == DialogResult.OK)}*/


        }

       


        #endregion

        // ######################################## ↥↥ Fin Section Produit ↥↥ ########################################
        //-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


    }
}
