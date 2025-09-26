using LiaKosShop;
using GestionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace LiaKosShop
{
    public partial class FrmConnexion : MaterialForm
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string login = boxId.Text;
            string mdp = boxMdp.Text;
            if (GestionConnexion.VerifConnexion(login, mdp))
            {
                // Si la connexion est réussie, on ouvre le formulaire d'accueil
                FrmAccueil formulaire = new FrmAccueil();
                formulaire.Show();
                this.Hide();
            }
            else
            {
                erp.SetError(lblErreur, "Login ou mot de passe incorrect !");
                lblErreur.Visible = true;
            }
        }

        private void boxMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnOk.PerformClick();
        }


    }
}
