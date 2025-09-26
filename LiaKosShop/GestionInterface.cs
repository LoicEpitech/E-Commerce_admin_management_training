using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiaKosShop
{
    internal class GestionInterface
    {
        public static void remplirComboBox(ComboBox maComboBox, DataTable maDataTable, string displayMember, string valueMember)
        {
            maComboBox.DataSource = maDataTable;
            maComboBox.DisplayMember = displayMember;
            maComboBox.ValueMember = valueMember;
        }
        public static void coloriserButton(Button monButton)
        {
            monButton.FlatStyle = FlatStyle.Flat;
            monButton.FlatAppearance.BorderSize = 0;
            monButton.BackColor = Color.FromArgb(100, 149, 237); // CornflowerBlue
            monButton.ForeColor = Color.White;
            monButton.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Texte plus gros
            monButton.Cursor = Cursors.Hand;

            // Coins arrondis
            monButton.Paint += (s, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                int radius = 15;
                Rectangle bounds = new Rectangle(0, 0, monButton.Width, monButton.Height);
                path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
                path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                monButton.Region = new Region(path);
            };

            // Agrandissement au survol
            int normalWidth = monButton.Width;
            int normalHeight = monButton.Height;

            monButton.MouseEnter += (s, e) =>
            {
                monButton.BackColor = Color.FromArgb(65, 105, 225); // RoyalBlue
                monButton.Size = new Size(normalWidth + 10, normalHeight + 5); // agrandit le bouton
            };

            monButton.MouseLeave += (s, e) =>
            {
                monButton.BackColor = Color.FromArgb(100, 149, 237); // CornflowerBlue
                monButton.Size = new Size(normalWidth, normalHeight); // revient à la taille normale
            };
        }


        public static void coloriserDataGrid(DataGridView monDataDridView)
        {
            monDataDridView.BackgroundColor = Color.FromArgb(245, 245, 245); // Gris très clair
            monDataDridView.BorderStyle = BorderStyle.None;

            // En-têtes de colonnes
            monDataDridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            monDataDridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 149, 237); // Bleu clair (CornflowerBlue)
            monDataDridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            monDataDridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            monDataDridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            monDataDridView.EnableHeadersVisualStyles = false;

            // En-têtes de lignes
            monDataDridView.RowHeadersVisible = false;
            monDataDridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            monDataDridView.RowHeadersWidth = 10;

            // Lignes
            monDataDridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Blanc
            monDataDridView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40); // Gris foncé
            monDataDridView.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            monDataDridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 60, 90); // Bleu foncé
            monDataDridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            monDataDridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            monDataDridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }


        public static bool isChaineValide(string chaine)
        {
            Regex myRegex;
            myRegex = new Regex("[a-zA-Z]");

            return myRegex.IsMatch(chaine); // retourne true ou false selon la vérification
        }



        public static void activerDesactiverTxtbBtn(GroupBox grb)
        {
            foreach (Control unControle in grb.Controls)
            {
                if (unControle is TextBox)
                    unControle.Enabled = !unControle.Enabled;
            }
        }
        public static void desactiverTxtb(GroupBox grb)
        {
            foreach (Control unControle in grb.Controls)
            {
                if (unControle is TextBox)
                    unControle.Enabled = false;
            }
        }

        public static void activerTxtb(GroupBox grb)
        {
            foreach (Control unControle in grb.Controls)
            {
                if (unControle is TextBox)
                    unControle.Enabled = true;
            }
        }
        public static int verifTxtbNonVide(GroupBox grb)
        {
            int nbControle = 0;

            foreach (Control unControle in grb.Controls)
            {
                if (unControle is TextBox)
                {
                    if (!string.IsNullOrWhiteSpace(((TextBox)unControle).Text))
                    {
                        nbControle = nbControle + 1;
                    }
                }

            }
            return nbControle;
        }

        internal static bool ContainsLetters(string text)
        {
            // Utiliser une expression régulière pour vérifier si le texte contient des lettres
            return Regex.IsMatch(text, "[a-zA-Z]");
        }
    }
}
