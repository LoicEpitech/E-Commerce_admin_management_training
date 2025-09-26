using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace LiaKosShop
{
    public partial class FrmCommande : Form
    {
        // Zone d'initialisation \\
        int NbControle = 1;
        int NbControleM = 1;
        int positionY = 10;

        public FrmCommande()
        {
            InitializeComponent();
            GestionInterface.coloriserDataGrid(dgvListeCom);
            dgvListeCom.DataSource = GestionCommande.getTuples();
        }


        // ######################################## ↧↧ Section Commande ↧↧ ########################################


        public void btnCreationCommandeAddProduitPlusUn_Click(object sender, EventArgs e)
        {
            positionY += 30;
            NbControle++;

            // Creation Du Label produit Numero de ligne 
            Label lblCreationCommandeP = new System.Windows.Forms.Label();
            lblCreationCommandeP.Name = "lblCreationCommandeP" + NbControle.ToString();
            lblCreationCommandeP.Location = new System.Drawing.Point(lblCreationCommandeProduit1.Location.X, lblCreationCommandeProduit1.Location.Y + positionY);
            lblCreationCommandeP.Size = new System.Drawing.Size(lblCreationCommandeProduit1.Size.Width, lblCreationCommandeProduit1.Size.Height);
            lblCreationCommandeP.Text = "Produit N-" + NbControle.ToString() + ":";
            lblCreationCommandeP.TabIndex = 100;
            lblCreationCommandeP.Visible = true;
            this.Controls.Add(lblCreationCommandeP);
            flpCreationCommande.Controls.Add(lblCreationCommandeP);
            Console.WriteLine(lblCreationCommandeP.Name);

            // Creation De la ComboBox Destiner a Saisire le produit
            System.Windows.Forms.ComboBox cbbCreationCommandeProduit = new System.Windows.Forms.ComboBox();
            cbbCreationCommandeProduit.Name = "cbbCreationCommandeProduit" + NbControle.ToString();
            cbbCreationCommandeProduit.Location = new System.Drawing.Point(cbbCreationCommandeProduit1.Location.X, cbbCreationCommandeProduit1.Location.Y + positionY);
            cbbCreationCommandeProduit.Size = new System.Drawing.Size(cbbCreationCommandeProduit1.Size.Width, cbbCreationCommandeProduit1.Size.Height);
            cbbCreationCommandeProduit.TabIndex = 101;
            cbbCreationCommandeProduit.Visible = true;
            this.Controls.Add(cbbCreationCommandeProduit);
            flpCreationCommande.Controls.Add(cbbCreationCommandeProduit);
            GestionInterface.remplirComboBox(cbbCreationCommandeProduit, GestionCommande.getProduit(), "libelProduit", "idProduit"); // Replie la combo Box Crer a la vollé
            Console.WriteLine(cbbCreationCommandeProduit.Name);


            // Creation De la Labelle Cantiter
            Label lblCreationCommandeQtP = new System.Windows.Forms.Label();
            lblCreationCommandeQtP.Name = "lbCreationCommandeQtp" + NbControle.ToString();
            lblCreationCommandeQtP.Location = new System.Drawing.Point(lblCreationCommandeProduit1.Location.X, lblCreationCommandeProduit1.Location.Y + positionY);
            lblCreationCommandeQtP.Size = new System.Drawing.Size(lblCreationCommandeProduit1.Size.Width, lblCreationCommandeProduit1.Size.Height);
            lblCreationCommandeQtP.Text = "Quantite:";
            lblCreationCommandeQtP.TabIndex = 102;
            lblCreationCommandeQtP.Visible = true;
            this.Controls.Add(lblCreationCommandeQtP);
            flpCreationCommande.Controls.Add(lblCreationCommandeQtP);
            Console.WriteLine(lblCreationCommandeQtP.Name);

            // Creation De la texte Box Pour Saisir la Cantiter
            System.Windows.Forms.TextBox txtbCreationCommandeQtP = new System.Windows.Forms.TextBox();
            txtbCreationCommandeQtP.Name = "txtbCreationCommandeQtP" + NbControle.ToString();
            txtbCreationCommandeQtP.Location = new System.Drawing.Point(txtbModifCommandeQtP1.Location.X, txtbModifCommandeQtP1.Location.Y + positionY);
            txtbCreationCommandeQtP.Size = new System.Drawing.Size(txtbModifCommandeQtP1.Size.Width, txtbModifCommandeQtP1.Size.Height);
            txtbCreationCommandeQtP.TabIndex = 103;
            txtbCreationCommandeQtP.Visible = true;
            this.Controls.Add(txtbCreationCommandeQtP);
            flpCreationCommande.Controls.Add(txtbCreationCommandeQtP);
            Console.WriteLine(txtbCreationCommandeQtP.Name);

            if (NbControle > 1)
            {
                btnCreationCommandeRetirerProduitSup1.Visible = true;
            }
            else
            {
                btnCreationCommandeRetirerProduitSup1.Visible = false;
            }
        }

        public void btnCreationCommandeRetirerProduitSup1_Click(object sender, EventArgs e)
        {
            if (NbControle > 1) // securiter suplementaire pour eviter un crash potentiel
            {
                // instruction pour repeter 4 fois l instruction (car a chaque coup il suprime le dernier crer comme j en est 4 a suprimer a chaque coup je le repette 4 fois)
                for (int i = 0; i < 4; i++)
                {
                    Control controlToRemove = flpCreationCommande.Controls[flpCreationCommande.Controls.Count - 1];
                    flpCreationCommande.Controls.Remove(controlToRemove);
                }

                NbControle--;

                if (NbControle <= 1) // afficher ou cacher le btn suprimer en fonction du NbControle
                {
                    btnCreationCommandeRetirerProduitSup1.Visible = false;
                }
                else
                {
                    btnCreationCommandeRetirerProduitSup1.Visible = true;
                }
            }
        }

        private void btnCreationCommandeValider_Click(object sender, EventArgs e)
        {
            //AjouterCommande

            checkGlobal_CantiterBox("creation");

            try
            {
                lblExeptionCreationCmd.Visible = false;

                if (!string.IsNullOrEmpty(txtbCreationCommandeId.Text))
                {
                    if (!string.IsNullOrEmpty(cbbCreationCommandeClient.Text))
                    {
                        if (!string.IsNullOrEmpty(txtbCreationCommandeQtP1.Text))
                        {
                            int idCommande = int.Parse(txtbCreationCommandeId.Text);
                            int idClient;
                            bool idtemporaire = int.TryParse(cbbCreationCommandeClient.SelectedValue.ToString(), out idClient);

                            string dateCommande = dtpCreationCommandeDate.Value.ToString();
                            GestionCommande.ajouterCommande(idCommande, idClient, dateCommande);

                            // compte le nombre de ligne produit que l on crée
                            int nbLigneCree = 0;
                            int nbLignePDFCree = 1;

                            var dicLigneCommande = new Dictionary<string, (int, int)> { }; // dictionaire pour PDF

                            // Parcours des contrôles dans flpCreationCommande
                            foreach (Control control in flpCreationCommande.Controls)
                            {
                                // Vérification si le contrôle est une combobox
                                if (control is System.Windows.Forms.ComboBox comboBox)
                                {
                                    // Récupération de l'ID produit sélectionné dans la combobox
                                    int idProduit;
                                    if (int.TryParse(comboBox.SelectedValue?.ToString(), out idProduit))
                                    {
                                        // Récupération de la quantité correspondante dans la textbox associée
                                        string nomTextBox = "txtbCreationCommandeQtP" + comboBox.Name.Substring(comboBox.Name.Length - 1);
                                        System.Windows.Forms.TextBox textBox = flpCreationCommande.Controls.Find(nomTextBox, true).FirstOrDefault() as System.Windows.Forms.TextBox;

                                        int idProd = Convert.ToInt16(comboBox.SelectedValue.ToString());

                                        int qteProd = Convert.ToInt16(textBox.Text);
                                        GestionCommande.ajouterLigneCommande(idCommande, idProd, qteProd);
                                        dicLigneCommande.Add("ligneCommande" + nbLignePDFCree, (idProd, qteProd));
                                        nbLigneCree++;
                                        nbLignePDFCree++;
                                    }
                                }
                            }

                            MessageBox.Show("Vous venez de crer une commande Id: " + idCommande + " Contenent: " + nbLigneCree + " !");

                            dgvListeCom.DataSource = GestionCommande.getTuples(); // actialise la data grid view

                            // teste creation PDF \\
                            PdfGestion.CreationPDF(dicLigneCommande, idClient, dateCommande, idCommande);
                            // teste creation PDF \\

                            gpbCreerCommande.Enabled = false;
                            gpbCreerCommande.Visible = false;
                        }
                        else
                        {
                            erpCreationCommande.SetError(txtbCreationCommandeQtP1, "Vous navez pas remplie le champ convenablement !");
                            erpCreationCommande.SetError(cbbCreationCommandeProduit1, "Vous navez pas remplie le champ convenablement !");
                            //error providor vous n aver pas saisi de d article dans la commande
                        }
                    }
                    else
                    {
                        erpCreationCommande.SetError(cbbCreationCommandeClient, "Vous navez pas saisi de client !");
                        //error providor vous n aver pas saisi de client
                    }
                }
                else
                {
                    erpCreationCommande.SetError(txtbCreationCommandeId, "Vous navez pas saisi d'identifiant !");
                    //error providor vous n aver pas saisi d id 
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                lblExeptionCreationCmd.Visible = true;
                lblExeptionCreationCmd.Text = ex.Message;
            }

        }

        // ############################################################################################################################################################################################
        // ################################################################################# Mofifier Commande ########################################################################################
        // ############################################################################################################################################################################################

        private void btnModifierCommande_Click(object sender, EventArgs e)
        {
            GestionInterface.remplirComboBox(cbbModifCommandeSelectCommande, GestionCommande.getCommandes(), "patronymeClientEtDateCommande", "idCommande");// Pour info, cbbModifCommandeSelectCommande.SelectedValue contient la valeur de la clé primaire associé au commande (idCommande)(patronymeClientEtDateCommande)
            GestionInterface.remplirComboBox(cbbModifCommandeClient, GestionClients.getPatronymes(), "Patronyme", "idUtilisateur");// Pour info, cbbModifCommandeClient.SelectedValue contient la valeur de la clé primaire associé au clien
        }
        private void cbbModifCommandeSelectCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            NbControleM = 0;
            flpModifierCommande.Controls.Clear();// suprime en cas de deuxieme changement d index les box crer au préalable

            try
            {
                if (GestionCommande.getCommandeById(Convert.ToInt16(cbbModifCommandeSelectCommande.SelectedValue)) != null)
                {



                    // Reception des information sur la commande
                    DataRow laCommande = GestionCommande.getCommandeById(Convert.ToInt16(cbbModifCommandeSelectCommande.SelectedValue.ToString()));
                    txtbModifCommandeId.Text = laCommande[0].ToString();                  
                    txtbModifCommandeDate.Text = laCommande[1].ToString();              
                    cbbModifCommandeClient.SelectedValue = laCommande[2];              
                    try
                    {
                        // Reception de la composition de la commande
                        int nbLigneNecessaireBase = 1;
                        DataRow nbProduitCommande = GestionCommande.getNbProduitInCommandeById(Convert.ToInt16(cbbModifCommandeSelectCommande.SelectedValue.ToString()));
                        nbLigneNecessaireBase = Convert.ToInt16(nbProduitCommande[0]);
                        for (int i = 0; i <= nbLigneNecessaireBase - 1; i++)
                        {
                            CreeUneLigneModificationProduit(1, i, Convert.ToInt16(cbbModifCommandeSelectCommande.SelectedValue.ToString())); // crer des nouvelle ligne vierge suplémentaire
                        }

                    }
                    catch
                    {
                    }

                }

            }
            catch
            {
            }


        }

        private void btnModifCommandeAddLigne_Click(object sender, EventArgs e)
        {
            CreeUneLigneModificationProduit(0, 0, Convert.ToInt16(cbbModifCommandeSelectCommande.SelectedValue.ToString()));
        }

        private void btnModifCommandeSupLigne_Click(object sender, EventArgs e)
        {
            if (NbControleM > 1) // securiter suplementaire pour eviter un crash potentiel
            {
                // instruction pour repeter 4 fois l instruction (car a chaque coup il suprime le dernier crer comme j en est 4 a suprimer a chaque coup je le repette 4 fois)
                for (int i = 0; i < 4; i++)
                {
                    Control controlToRemove = flpModifierCommande.Controls[flpModifierCommande.Controls.Count - 1];
                    flpModifierCommande.Controls.Remove(controlToRemove);
                }

                NbControleM--;

            }
        }

        private void CreeUneLigneModificationProduit(int TypeDeTraitement, int nbCase, int idCommande)
        {
            positionY += 30;
            NbControleM++;

            DataTable LesProduit = GestionCommande.getCompositionProduitInCommandeById(idCommande);

            // Creation Du Label produit Numero de ligne 
            Label lblModifCommandeSP = new System.Windows.Forms.Label();
            lblModifCommandeSP.Name = "lblModifCommandeP" + NbControleM.ToString();
            lblModifCommandeSP.Location = new System.Drawing.Point(lblModifCommandeSP1.Location.X, lblModifCommandeSP1.Location.Y + positionY);
            if(NbControleM < 10)
            {
                lblModifCommandeSP.Text = "Produit N-" + NbControleM.ToString() + ":";
            } else {
                lblModifCommandeSP.Text = "Produit N" + NbControleM.ToString();
            }
            // lblModifCommandeSP.Text = "Produit N-" + NbControleM.ToString() + ":"; //LOc 310; 98 SIZE 63; 13   // avec 2 chifre  70; 13
            lblModifCommandeSP.TabIndex = 200;
            lblModifCommandeSP.Visible = true;
            this.Controls.Add(lblModifCommandeSP);
            flpModifierCommande.Controls.Add(lblModifCommandeSP);
            Console.WriteLine("Produit N-" + NbControleM.ToString() + ":"); // Anomali ici a partirede 10 ça ne safiche pas (apres les test on remarque apres un certain nombre de char une partie du texte n est plus visible)???

            // Creation De la ComboBox Destiner a Saisire le produit
            System.Windows.Forms.ComboBox cbbModifCommandeSP = new System.Windows.Forms.ComboBox();
            cbbModifCommandeSP.Name = "cbbModifCommandeProduit" + NbControleM.ToString();
            cbbModifCommandeSP.Location = new System.Drawing.Point(cbbModifCommandeSP1.Location.X, cbbModifCommandeSP1.Location.Y + positionY);
            cbbModifCommandeSP.Size = new System.Drawing.Size(cbbModifCommandeSP1.Size.Width, cbbModifCommandeSP1.Size.Height);
            cbbModifCommandeSP.TabIndex = 201;
            cbbModifCommandeSP.Visible = true;
            this.Controls.Add(cbbModifCommandeSP);
            flpModifierCommande.Controls.Add(cbbModifCommandeSP);
            GestionInterface.remplirComboBox(cbbModifCommandeSP, GestionCommande.getProduit(), "libelProduit", "idProduit"); // Replie la combo Box Crer a la vollé
            if (TypeDeTraitement != 0)
            {
                cbbModifCommandeSP.SelectedValue = Convert.ToInt16(LesProduit.Rows[nbCase][0].ToString());
            }
            //Console.WriteLine("cbbModifCommandeProduit" + NbControleM.ToString());

            // Creation De la Labelle Cantiter
            Label lblModifCommandeQtP = new System.Windows.Forms.Label();
            lblModifCommandeQtP.Name = "lbModifCommandeQtp" + NbControleM.ToString();
            lblModifCommandeQtP.Location = new System.Drawing.Point(lblModifCommandeSP1.Location.X, lblModifCommandeSP1.Location.Y + positionY);
            lblModifCommandeQtP.Size = new System.Drawing.Size(lblModifCommandeSP1.Size.Width, lblModifCommandeSP1.Size.Height);
            lblModifCommandeQtP.Text = "Quantite:";
            lblModifCommandeQtP.TabIndex = 202;
            lblModifCommandeQtP.Visible = true;
            this.Controls.Add(lblModifCommandeQtP);
            flpModifierCommande.Controls.Add(lblModifCommandeQtP);
            //Console.WriteLine("lbModifCommandeQtp" + NbControleM.ToString());

            // Creation De la texte Box Pour Saisir la Cantiter
            System.Windows.Forms.TextBox txtbModifCommandeQtP = new System.Windows.Forms.TextBox();
            txtbModifCommandeQtP.Name = "txtbModifCommandeQtP" + NbControleM.ToString();
            txtbModifCommandeQtP.Location = new System.Drawing.Point(txtbCreationCommandeQtP1.Location.X, txtbCreationCommandeQtP1.Location.Y + positionY);
            txtbModifCommandeQtP.Size = new System.Drawing.Size(txtbCreationCommandeQtP1.Size.Width, txtbCreationCommandeQtP1.Size.Height);
            txtbModifCommandeQtP.TabIndex = 203;
            txtbModifCommandeQtP.Visible = true;
            this.Controls.Add(txtbModifCommandeQtP);
            flpModifierCommande.Controls.Add(txtbModifCommandeQtP);
            if (TypeDeTraitement != 0)
            {
                txtbModifCommandeQtP.Text = LesProduit.Rows[nbCase][1].ToString();
            }
            //Console.WriteLine("txtbModifCommandeQtP" + NbControleM.ToString());


            if (NbControleM > 1)
            {
                btnModifCommandeSupLigne.Visible = true;
            }
            else
            {
                btnModifCommandeSupLigne.Visible = false;
            }
        }

        private void btnModifCommandeValider_Click(object sender, EventArgs e) // intervention ici ! + add foctionaliter pour refaire la facture !
        {
            // Modifier Commande               
            // Supression Ligne
            
            GestionCommande.supprimer(Convert.ToUInt16(txtbModifCommandeId.Text)); // on suprime la commande initiale pour la recrer apres avec les nouvelle information

            int idCommande = int.Parse(txtbModifCommandeId.Text);
            int idClient;
            bool idtemporaire = int.TryParse(cbbModifCommandeClient.SelectedValue.ToString(), out idClient);
            string dateCommande = txtbModifCommandeDate.Text;

            // Recréation de la comande selon les modification
            try
            {
                GestionCommande.ajouterCommande(idCommande, idClient, dateCommande);
            } catch(Exception ex) { 

                // obtien le regex \\
            }

            // compte le nombre de ligne produit que l on crée
            int nbLigneCree = 0;

            // Parcours des contrôles dans flpCreationCommande
            foreach (Control control in flpModifierCommande.Controls)
            {
                if (control is System.Windows.Forms.ComboBox comboBox)// Vérification si le contrôle est une combobox
                {
                    // Récupération de l'ID produit sélectionné dans la combobox
                    int idProduit;
                    Console.WriteLine("txtbModifCommandeQtP" + comboBox.Name.Substring(comboBox.Name.Length - 1)); // retourne uniquement la valeur de cbb1
                    Console.WriteLine(comboBox.Name.Length - 1);
                    if (int.TryParse(comboBox.SelectedValue?.ToString(), out idProduit))
                    {
                        // Récupération de la quantité correspondante dans la textbox associée
                        string nomTextBox = "txtbModifCommandeQtP" + comboBox.Name.Substring(comboBox.Name.Length - 1);
                        System.Windows.Forms.TextBox textBox = flpModifierCommande.Controls.Find(nomTextBox, true).FirstOrDefault() as System.Windows.Forms.TextBox;

                        int idProd = Convert.ToInt16(comboBox.SelectedValue.ToString());
                        int qteProd = Convert.ToInt16(textBox.Text);
                        GestionCommande.ajouterLigneCommande(idCommande, idProd, qteProd);
                        nbLigneCree++;
                    }
                }
            }

            MessageBox.Show("Vous venez Modifier avec succes la commande Id: " + idCommande + " Contenent: " + nbLigneCree + " !");

            dgvListeCom.DataSource = GestionCommande.getTuples(); // actialise la data grid view
        }

        private void btnSupprimerCommande_Click(object sender, EventArgs e)
        {
            // Suprimer une commande et ses ligne de commande \\
            if (btnSupprimerCommande.Text == "Confirmer la suppression")
            {
                GestionCommande.supprimer(Convert.ToUInt16(txtbModifCommandeId.Text));
                btnAnulerSupprimerCommande.Visible = false;
                btnSupprimerCommande.Text = "Supprimer";
                dgvListeCom.DataSource = GestionCommande.getTuples(); // actialise la data grid view
                MessageBox.Show("Vous venez de supprimer la commande Id: " + txtbModifCommandeId.Text + " !");
            }
            else
            {
                btnSupprimerCommande.Text = "Confirmer la suppression";
                btnAnulerSupprimerCommande.Visible = true;
            }
        }

        private void btnAnulerSupprimerCommande_Click(object sender, EventArgs e)
        {
            btnAnulerSupprimerCommande.Visible = false;
            btnSupprimerCommande.Text = "Supprimer";
        }

        // Zone Cotrole regex \\
        private void checkGlobal_CantiterBox(string typeElement)
        {
            if(typeElement == "création2")
            {

            } else {
                foreach (Control control in flpCreationCommande.Controls)
                {
                    if (control is System.Windows.Forms.ComboBox comboBox)// Vérification si le contrôle est une combobox
                    {
                        // Récupération de l'ID produit sélectionné dans la combobox
                        int idProduit;
                        if (int.TryParse(comboBox.SelectedValue?.ToString(), out idProduit))
                        {
                            // Récupération de la quantité correspondante dans la textbox associée
                            string nomTextBox = "txtbCreationCommandeQtP" + comboBox.Name.Substring(comboBox.Name.Length - 1);
                            System.Windows.Forms.TextBox textBox = flpCreationCommande.Controls.Find(nomTextBox, true).FirstOrDefault() as System.Windows.Forms.TextBox;

                            //int idProd = Convert.ToInt16(comboBox.SelectedValue.ToString());
                            int qteProd = Convert.ToInt16(textBox.Text);
                            if(Regex.IsMatch(qteProd.ToString(), @"\d"))
                            {
                                if (qteProd < 0 && qteProd > 100)
                                {
                                    erpCreationCommande.SetError(textBox, "la qte produit ne peut etre inferieur a 0 ou superieur a 100.");
                                }
                            }
                        }
                    }
                }
            }

        }

        private void lblTitreTabPComande_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseMenueClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrerClient_Click(object sender, EventArgs e)
        {
            NbControle = 1;


            GestionInterface.remplirComboBox(cbbCreationCommandeClient, GestionClients.getPatronymes(), "Patronyme", "idUtilisateur");//Pour info, cbClients.SelectedValue contient la valeur de la clé primaire associé au clien

            GestionInterface.remplirComboBox(cbbCreationCommandeProduit1, GestionCommande.getProduit(), "libelProduit", "idProduit");//Pour info, cbbCreationCommandeProduit1.SelectedValue contient la valeur de la clé primaire associé au clien


            int newidCommande = GestionCommande.getNbTuplesCommande() + 1;
            dtpCreationCommandeDate.Value = DateTime.Today;

            gpbCreerCommande.Visible = true;
            gpbCreerCommande.Enabled = true;
            gpbModifierCommande.Visible = false;
            gpbModifierCommande.Enabled = false;
            GestionInterface.remplirComboBox(cbbCreationCommandeClient, GestionCommande.getCommandes(), "patronymeClientEtDateCommande", "idCommande");// Pour info, cbbModifCommandeSelectCommande.SelectedValue contient la valeur de la clé primaire associé au commande (idCommande)(patronymeClientEtDateCommande)
            GestionInterface.remplirComboBox(cbbCreationCommandeProduit1, GestionCommande.getProduit(), "libelProduit", "idProduit");// Pour info, cbbCreationCommandeProduit1.SelectedValue contient la valeur de la clé primaire associé au clien
            txtbCreationCommandeId.Text = newidCommande.ToString();
        }

        private void btnGererClient_Click(object sender, EventArgs e)
        {
            gpbCreerCommande.Visible = false;
            gpbCreerCommande.Enabled = false;
            gpbModifierCommande.Visible = true;
            gpbModifierCommande.Enabled = true;
            GestionInterface.remplirComboBox(cbbModifCommandeSelectCommande, GestionCommande.getCommandes(), "patronymeClientEtDateCommande", "idCommande");// Pour info, cbbModifCommandeSelectCommande.SelectedValue contient la valeur de la clé primaire associé au commande (idCommande)(patronymeClientEtDateCommande)
            GestionInterface.remplirComboBox(cbbModifCommandeClient, GestionClients.getPatronymes(), "Patronyme", "idUtilisateur");// Pour info, cbbModifCommandeClient.SelectedValue contient la valeur de la clé primaire associé au clien
        }


        // ######################################## ↥↥ Fin Section Commande ↥↥ ########################################
        // -->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    }
}
