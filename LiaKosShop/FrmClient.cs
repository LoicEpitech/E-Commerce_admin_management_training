using GestionBD;
using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LiaKosShop
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
            GestionInterface.coloriserDataGrid(dgvListeClient);
            dgvListeClient.DataSource = GestionClients.getTuples();
        }

        private void btnCloseMenueClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {

        }

        //
        #region Panel Client

        // ######################################## ↧↧ Section CLIENT ↧↧ ########################################

        Dictionary<string, bool> verificationClient = new Dictionary<string, bool>
        {
          { "TxtbId", false },
          { "TxtbNom", false },
          { "TxtbPrenom", false },
          { "TxtbRue", false },
          { "TxtbCP", false },
          { "TxtbVille", false },
          { "TxtbTel", false },
          { "TxtbEmail", false },
          { "TxtbLogin", false },
          { "TxtbPermission", false },
          { "ValidationGlobal", false }
        };

        private void btnCrerClient_Click(object sender, EventArgs e)
        {
            gpbModifierClient.Enabled = false;
            gpbModifierClient.Visible = false;

            //GestionBoutique.addUserFS(); // just for test remove that
            //string testeString = 
            //GestionBoutique.appelerFonctionStockeeV2();


            // Sugestion d ID Disponible
            int newid = GestionClients.getNbTuples() + 1;
            txtbCreationClientId.Text = newid.ToString();
            txtbCreationClientPass.Text = "MotsDePasse";
            txtbCreationClientPermission.Text = "0";
            // Sugestion d ID Disponible

            gpbCrerClient.Enabled = true;
            gpbCrerClient.Visible = true;

        }

        private void btnGererClient_Click(object sender, EventArgs e)
        {
            gpbCrerClient.Enabled = false;
            gpbCrerClient.Visible = false;
            cbbModifClient.Refresh();

            GestionInterface.remplirComboBox(cbbModifClient, GestionClients.getPatronymes(), "Patronyme", "idUtilisateur");//Pour info, cbClients.SelectedValue contient la valeur de la clé primaire associé au clien

            gpbModifierClient.Enabled = true;
            gpbModifierClient.Visible = true;
        }

        private void cbbModifClient_SelectedIndexChanged(object sender, EventArgs e)
        {

            GestionInterface.activerTxtb(gpbModifierClient); //desactiverTxtb

            try
            {
                DataRow monClient = GestionClients.getTupleById(Convert.ToInt16(cbbModifClient.SelectedValue));
                                                                                                    
                                                                                              
                txtbGestionClientId.Text = monClient[0].ToString();                                
                txtbGestionClientNom.Text = monClient[3].ToString();                           
                txtbGestionClientPrenom.Text = monClient[4].ToString();                          
                txtbGestionClientRue.Text = monClient[7].ToString();                                
                txtbGestionClientCP.Text = monClient[8].ToString();                                
                txtbGestionClientVille.Text = monClient[9].ToString();                            
                txtbGestionClientTel.Text = monClient[6].ToString();                             
                txtbGestionClientEmail.Text = monClient[5].ToString();                          
                txtbGestionClientPass.Text = monClient[2].ToString(); 
                txtbGestionClientLogin.Text = monClient[1].ToString();                        
                txtbGestionClientPermission.Text = monClient[11].ToString();              
                


                verificationClient["TxtbId"] = false;
                verificationClient["TxtbNom"] = false;
                verificationClient["TxtbPrenom"] = false;
                verificationClient["TxtbRue"] = false;
                verificationClient["TxtbCP"] = false;
                verificationClient["TxtbVille"] = false;
                verificationClient["TxtbTel"] = false;
                verificationClient["TxtbEmail"] = false;
                verificationClient["TxtbLogin"] = false;
                verificationClient["TxtbPermission"] = false;
                verificationClient["ValidationGlobal"] = false;
                // Validation de securiter ↑\\

            }
            catch
            {
            }

        }

        private void txtbCreationClientEmail_TextChanged(object sender, EventArgs e) // actualise le login avec l'Email
        {
            txtbCreationClientLogin.Text = txtbCreationClientEmail.Text;
        }

        private void btnCreationClientValider_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtbCreationClientId.Text);
            string nom = txtbCreationClientNom.Text;
            string prenom = txtbCreationClientPrenom.Text;
            string codePostal = txtbCreationClientCP.Text;
            string rue = txtbCreationClientRue.Text;
            string ville = txtbCreationClientVille.Text;
            string tel = txtbCreationClientTel.Text;
            string email = txtbCreationClientEmail.Text;
            string passUtilisateur = GestionHachage.mdpHachage.HashPassword(txtbCreationClientPass.Text); 
            int isAdmin = Convert.ToInt32(txtbCreationClientPermission.Text);

            GestionClients.ajouter(id, nom, prenom, rue, codePostal, ville, tel, email, passUtilisateur, isAdmin);
            if(isAdmin == 1)
            {
                GestionPsFs.creatAndGrantUser_PS(id);
            }

            txtbCreationClientId.Text = "";
            txtbCreationClientNom.Text = "";
            txtbCreationClientPrenom.Text = "";
            txtbCreationClientCP.Text = "";
            txtbCreationClientRue.Text = "";
            txtbCreationClientVille.Text = "";
            txtbCreationClientTel.Text = "";
            txtbCreationClientEmail.Text = "";
            txtbCreationClientEmail.Text = "";
            dgvListeClient.DataSource = GestionClients.getTuples();
            MessageBox.Show("Le client " + nom + " - " + prenom + "a été ajouter avec succes.");
            gpbCrerClient.Enabled = false;
            gpbCrerClient.Visible = false;
        }

        private void btnModifierClientValider_Click(object sender, EventArgs e)
        {
            // Partie Verif Client
            int nbTableremplie = GestionInterface.verifTxtbNonVide(gpbModifierClient);
            if (nbTableremplie >= 10)
            {
                int id = Convert.ToInt32(txtbGestionClientId.Text);
                string nom = txtbGestionClientNom.Text;
                string prenom = txtbGestionClientPrenom.Text;
                string codePostal = txtbGestionClientCP.Text;
                string rue = txtbGestionClientRue.Text;
                string ville = txtbGestionClientVille.Text;
                string tel = txtbGestionClientTel.Text;
                string email = txtbGestionClientEmail.Text;
                string passUtilisateur = txtbGestionClientPass.Text;
                int isAdmin = Convert.ToInt32(txtbGestionClientPermission.Text);


                // -------- gestion bool regex -------------\\
                bool emailVerif = false;
                bool telVerif = false;
                bool cpVerif = false;
                bool idVerif = true;
                bool nomVerif = false;
                bool prenomVerif = false;
                bool villeVerif = false;
                // -------- gestion bool regex -------------\\

                if (isAdmin != 0 && isAdmin != 1) // verif la valeur de permission 0 = simple utilisateur et 1 = Administrateur
                {
                    isAdmin = 0;
                }

                // -------------------- Verif id

                // -------------------- Verif id

                // -------------------- Verif email
                if (email.Contains("@") && email.Contains("."))
                {
                    errorpClientModif1.SetError(txtbGestionClientEmail, "");
                    emailVerif = true;
                }
                else
                {
                    errorpClientModif1.SetError(txtbGestionClientEmail, "l Email doit contenire un @ et un . !");
                }
                // -------------------- Verif email

                // -------------------- Verif Nom 
                if (!string.IsNullOrWhiteSpace(nom))
                {
                    if(!nom.Any(char.IsDigit))
                    {
                        errorpClientModif1.SetError(txtbGestionClientNom, "");
                        nomVerif = true;
                    } else {
                        // texte nom contien autre chose que des letre
                        errorpClientModif1.SetError(txtbGestionClientNom, "le nom ne peut contenire de chiffre !");
                    }
                } else {
                    // text nom vide
                    errorpClientModif1.SetError(txtbGestionClientNom, "le nom ne peut etre vide !");
                }
                // -------------------- Verif Nom

                // -------------------- Verif Prenom
                if (!string.IsNullOrWhiteSpace(prenom))
                {
                    if (!prenom.Any(char.IsDigit))
                    {
                        errorpClientModif1.SetError(txtbGestionClientPrenom, "");
                        prenomVerif = true;
                    }
                    else
                    {
                        errorpClientModif1.SetError(txtbGestionClientPrenom, "le prenom ne peut contenire de chiffre !");
                    }
                }
                else
                {
                    errorpClientModif1.SetError(txtbGestionClientPrenom, "le prenom ne peut etre vide !");
                }
                // -------------------- Verif Prenom

                // -------------------- Verif Cp
                if (!string.IsNullOrWhiteSpace(codePostal))
                {

                    if(int.TryParse(codePostal, out _))
                    {
                        if(codePostal.Length == 5)
                        {
                            errorpClientModif1.SetError(txtbGestionClientCP, "");
                            cpVerif = true;
                        } else {
                            errorpClientModif1.SetError(txtbGestionClientCP, "le code postal ne peut etre composer que de 5 chiffre !");
                        }
                    } else {
                        errorpClientModif1.SetError(txtbGestionClientCP, "le code postal ne peut contenir que des chiffre !");
                    }
                }
                else
                {
                    errorpClientModif1.SetError(txtbGestionClientCP, "le code postal ne peut etre vide !");
                }
                // -------------------- Verif Cp


                // -------------------- Verif Ville
                if (!string.IsNullOrWhiteSpace(ville))
                {
                    if (!ville.Any(char.IsDigit))
                    {
                        errorpClientModif1.SetError(txtbGestionClientVille, "");
                        villeVerif = true;
                    }
                    else
                    {
                        // texte nom contien autre chose que des letre
                        errorpClientModif1.SetError(txtbGestionClientVille, "la ville ne peut contenire de chiffre !");
                    }
                }
                else
                {
                    // text nom vide
                    errorpClientModif1.SetError(txtbGestionClientVille, "la ville ne peut être vide !");
                }
                // -------------------- Verif Ville

                // -------------------- Verif Tel
                if (!string.IsNullOrWhiteSpace(tel))
                {

                    if (int.TryParse(tel, out _))
                    {
                        if (tel.Length == 10)
                        {
                            errorpClientModif1.SetError(txtbGestionClientTel, "");
                            telVerif = true;
                        }
                        else
                        {
                            errorpClientModif1.SetError(txtbGestionClientTel, "le numero de téléphone ne peut contenir que 10 chiffre !");
                        }
                    }
                    else
                    {
                        errorpClientModif1.SetError(txtbGestionClientTel, "le numero de téléphone ne peut contenir que des chiffre !");
                    }
                }
                else
                {
                    errorpClientModif1.SetError(txtbGestionClientTel, "le numero de téléphone ne peut etre vide !");
                }
                // -------------------- Verif Tel

                // ---------------- Validation final 
                if (emailVerif == true && telVerif == true && cpVerif == true && idVerif == true && nomVerif == true && prenomVerif == true && villeVerif == true)
                {
                    GestionPsFs.removeUser_PS(id); // permet de sassurer que lutilisateur n est pas de permission
                    Console.WriteLine(isAdmin);
                    GestionClients.modifier(id, nom, prenom, rue, codePostal, ville, tel, email, passUtilisateur, isAdmin); //add login aussi lol
                    if (isAdmin == 1)
                    {
                        GestionPsFs.creatAndGrantUser_PS(id);
                    }

                    dgvListeClient.DataSource = GestionClients.getTuples();
                    MessageBox.Show("Le client " + id + "a été modifier avec succes.");
                    gpbModifierClient.Enabled = false;
                    gpbModifierClient.Visible = false;
                }
            }
            else
            {

                errorpClientModif1.SetError(cbbModifClient, "Tout les Champ doive etre remplie !");
            }
        }

        private void btnGestionClientSupprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbGestionClientId.Text);
            string nom = txtbGestionClientNom.Text;
            string prenom = txtbGestionClientPrenom.Text;

            GestionPsFs.removeUser_PS(id); // verification complette coter serveur \\

            GestionClients.supprimer(id);

            dgvListeClient.DataSource = GestionClients.getTuples();
            MessageBox.Show("L'utilisateur " + id + " - ( " + nom + " " + prenom + " ) a été supprimer avec succes.");
            gpbModifierClient.Enabled = false;
            gpbModifierClient.Visible = false;
        }

        private void btnClientRecherche_Click(object sender, EventArgs e)
        {
            dgvListeClient.DataSource = GestionClients.getTuplesByNom(txtbClientRecherche.Text);
        }


        // ######################################## ↥↥ Fin Section CLIENT ↥↥  ########################################

        #endregion
        //
    }
}
