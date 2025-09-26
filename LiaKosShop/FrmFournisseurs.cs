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
    public partial class FrmFournisseurs : Form
    {
        public FrmFournisseurs()
        {
            InitializeComponent();
            GestionInterface.coloriserDataGrid(dgvListeFournisseur);
            dgvListeFournisseur.DataSource = GestionFournisseur.getTuples();
        }

        // ######################################## ↧↧ Section Fournisseur ↧↧ ########################################

        private void btnCrerFournisseur_Click(object sender, EventArgs e)
        {
            gpbModifierFournisseur.Enabled = false;
            gpbModifierFournisseur.Visible = false;
            gpbCrerFournisseur.Enabled = true;
            gpbCrerFournisseur.Visible = true;

        }

        private void btnModifierFournisseur_Click(object sender, EventArgs e)
        {
            gpbCrerFournisseur.Enabled = false; 
            gpbCrerFournisseur.Visible = false;
            gpbModifierFournisseur.Enabled = true;
            gpbModifierFournisseur.Visible = true;

        }

        private void btnCloseMenueClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ######################################## ↥↥ Fin Section Fournisseur ↥↥ ########################################


    }
}
