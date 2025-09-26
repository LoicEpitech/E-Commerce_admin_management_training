using LiaKosShop;
using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LiaKosShop
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {
            GestionInterface.coloriserButton(btnOpenMenuClient);
            GestionInterface.coloriserButton(btnOpenMenuProduit);
            GestionInterface.coloriserButton(btnOpenMenuFournisseur);
            GestionInterface.coloriserButton(btnOpenMenuCommande);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFrm.Controls.Add(childForm);
            panelChildFrm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        #region BTN ON SUB MENU GESTION

        private void btnOpenMenuClient_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmClient());
        }

        private void btnOpenMenuProduit_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProduit());
        }

        private void btnOpenMenuFournisseur_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmFournisseurs());
        }

        private void btnOpenMenuCommande_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCommande());
        }

        #endregion

      
    }
}

