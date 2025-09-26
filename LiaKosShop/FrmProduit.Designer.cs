namespace LiaKosShop
{
    partial class FrmProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbModifierProduit = new System.Windows.Forms.GroupBox();
            this.gpbCrerProduit = new System.Windows.Forms.GroupBox();
            this.txtbCreationProduitImg = new System.Windows.Forms.TextBox();
            this.lblCreationProduitDescription = new System.Windows.Forms.Label();
            this.lblCreationProduitFournisseur = new System.Windows.Forms.Label();
            this.lblCreationProduitCategorieProduit = new System.Windows.Forms.Label();
            this.lblCreationProduitPrix = new System.Windows.Forms.Label();
            this.lblCreationProduitLibel = new System.Windows.Forms.Label();
            this.lblCreationProduitId = new System.Windows.Forms.Label();
            this.cbbCreationProduitFournisseur = new System.Windows.Forms.ComboBox();
            this.cbbCreationProduitCategorie = new System.Windows.Forms.ComboBox();
            this.txtbCreationProduitPrix = new System.Windows.Forms.TextBox();
            this.txtbCreationProduitDescription = new System.Windows.Forms.TextBox();
            this.txtbCreationProduitLibel = new System.Windows.Forms.TextBox();
            this.txtbCreationProduitId = new System.Windows.Forms.TextBox();
            this.btnCreationProduitValider = new System.Windows.Forms.Button();
            this.btnChoixImage = new System.Windows.Forms.Button();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.btnCrerProduit = new System.Windows.Forms.Button();
            this.dgvListeProduit = new System.Windows.Forms.DataGridView();
            this.lblTitreTabPProduit = new System.Windows.Forms.Label();
            this.btnCloseMenueClient = new System.Windows.Forms.Button();
            this.gpbModifierProduit.SuspendLayout();
            this.gpbCrerProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbModifierProduit
            // 
            this.gpbModifierProduit.Controls.Add(this.gpbCrerProduit);
            this.gpbModifierProduit.Enabled = false;
            this.gpbModifierProduit.Location = new System.Drawing.Point(12, 441);
            this.gpbModifierProduit.Name = "gpbModifierProduit";
            this.gpbModifierProduit.Size = new System.Drawing.Size(1630, 376);
            this.gpbModifierProduit.TabIndex = 39;
            this.gpbModifierProduit.TabStop = false;
            this.gpbModifierProduit.Text = "modif produit";
            this.gpbModifierProduit.Visible = false;
            // 
            // gpbCrerProduit
            // 
            this.gpbCrerProduit.Controls.Add(this.txtbCreationProduitImg);
            this.gpbCrerProduit.Controls.Add(this.lblCreationProduitDescription);
            this.gpbCrerProduit.Controls.Add(this.lblCreationProduitFournisseur);
            this.gpbCrerProduit.Controls.Add(this.lblCreationProduitCategorieProduit);
            this.gpbCrerProduit.Controls.Add(this.lblCreationProduitPrix);
            this.gpbCrerProduit.Controls.Add(this.lblCreationProduitLibel);
            this.gpbCrerProduit.Controls.Add(this.lblCreationProduitId);
            this.gpbCrerProduit.Controls.Add(this.cbbCreationProduitFournisseur);
            this.gpbCrerProduit.Controls.Add(this.cbbCreationProduitCategorie);
            this.gpbCrerProduit.Controls.Add(this.txtbCreationProduitPrix);
            this.gpbCrerProduit.Controls.Add(this.txtbCreationProduitDescription);
            this.gpbCrerProduit.Controls.Add(this.txtbCreationProduitLibel);
            this.gpbCrerProduit.Controls.Add(this.txtbCreationProduitId);
            this.gpbCrerProduit.Controls.Add(this.btnCreationProduitValider);
            this.gpbCrerProduit.Controls.Add(this.btnChoixImage);
            this.gpbCrerProduit.Enabled = false;
            this.gpbCrerProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCrerProduit.Location = new System.Drawing.Point(0, -10);
            this.gpbCrerProduit.Name = "gpbCrerProduit";
            this.gpbCrerProduit.Size = new System.Drawing.Size(1638, 396);
            this.gpbCrerProduit.TabIndex = 38;
            this.gpbCrerProduit.TabStop = false;
            this.gpbCrerProduit.Text = "Créer";
            this.gpbCrerProduit.Visible = false;
            // 
            // txtbCreationProduitImg
            // 
            this.txtbCreationProduitImg.Location = new System.Drawing.Point(537, 230);
            this.txtbCreationProduitImg.Name = "txtbCreationProduitImg";
            this.txtbCreationProduitImg.ReadOnly = true;
            this.txtbCreationProduitImg.Size = new System.Drawing.Size(490, 20);
            this.txtbCreationProduitImg.TabIndex = 15;
            // 
            // lblCreationProduitDescription
            // 
            this.lblCreationProduitDescription.AutoSize = true;
            this.lblCreationProduitDescription.Location = new System.Drawing.Point(406, 192);
            this.lblCreationProduitDescription.Name = "lblCreationProduitDescription";
            this.lblCreationProduitDescription.Size = new System.Drawing.Size(75, 13);
            this.lblCreationProduitDescription.TabIndex = 14;
            this.lblCreationProduitDescription.Text = "Description:";
            // 
            // lblCreationProduitFournisseur
            // 
            this.lblCreationProduitFournisseur.AutoSize = true;
            this.lblCreationProduitFournisseur.Location = new System.Drawing.Point(824, 111);
            this.lblCreationProduitFournisseur.Name = "lblCreationProduitFournisseur";
            this.lblCreationProduitFournisseur.Size = new System.Drawing.Size(76, 13);
            this.lblCreationProduitFournisseur.TabIndex = 13;
            this.lblCreationProduitFournisseur.Text = "Fournisseur:";
            // 
            // lblCreationProduitCategorieProduit
            // 
            this.lblCreationProduitCategorieProduit.AutoSize = true;
            this.lblCreationProduitCategorieProduit.Location = new System.Drawing.Point(615, 111);
            this.lblCreationProduitCategorieProduit.Name = "lblCreationProduitCategorieProduit";
            this.lblCreationProduitCategorieProduit.Size = new System.Drawing.Size(65, 13);
            this.lblCreationProduitCategorieProduit.TabIndex = 12;
            this.lblCreationProduitCategorieProduit.Text = "Categorie:";
            // 
            // lblCreationProduitPrix
            // 
            this.lblCreationProduitPrix.AutoSize = true;
            this.lblCreationProduitPrix.Location = new System.Drawing.Point(948, 155);
            this.lblCreationProduitPrix.Name = "lblCreationProduitPrix";
            this.lblCreationProduitPrix.Size = new System.Drawing.Size(32, 13);
            this.lblCreationProduitPrix.TabIndex = 11;
            this.lblCreationProduitPrix.Text = "Prix:";
            // 
            // lblCreationProduitLibel
            // 
            this.lblCreationProduitLibel.AutoSize = true;
            this.lblCreationProduitLibel.Location = new System.Drawing.Point(443, 110);
            this.lblCreationProduitLibel.Name = "lblCreationProduitLibel";
            this.lblCreationProduitLibel.Size = new System.Drawing.Size(38, 13);
            this.lblCreationProduitLibel.TabIndex = 10;
            this.lblCreationProduitLibel.Text = "Libel:";
            // 
            // lblCreationProduitId
            // 
            this.lblCreationProduitId.AutoSize = true;
            this.lblCreationProduitId.Location = new System.Drawing.Point(386, 155);
            this.lblCreationProduitId.Name = "lblCreationProduitId";
            this.lblCreationProduitId.Size = new System.Drawing.Size(22, 13);
            this.lblCreationProduitId.TabIndex = 9;
            this.lblCreationProduitId.Text = "Id:";
            // 
            // cbbCreationProduitFournisseur
            // 
            this.cbbCreationProduitFournisseur.FormattingEnabled = true;
            this.cbbCreationProduitFournisseur.Location = new System.Drawing.Point(906, 107);
            this.cbbCreationProduitFournisseur.Name = "cbbCreationProduitFournisseur";
            this.cbbCreationProduitFournisseur.Size = new System.Drawing.Size(121, 21);
            this.cbbCreationProduitFournisseur.TabIndex = 8;
            // 
            // cbbCreationProduitCategorie
            // 
            this.cbbCreationProduitCategorie.FormattingEnabled = true;
            this.cbbCreationProduitCategorie.Location = new System.Drawing.Point(686, 107);
            this.cbbCreationProduitCategorie.Name = "cbbCreationProduitCategorie";
            this.cbbCreationProduitCategorie.Size = new System.Drawing.Size(121, 21);
            this.cbbCreationProduitCategorie.TabIndex = 7;
            // 
            // txtbCreationProduitPrix
            // 
            this.txtbCreationProduitPrix.Location = new System.Drawing.Point(986, 152);
            this.txtbCreationProduitPrix.Name = "txtbCreationProduitPrix";
            this.txtbCreationProduitPrix.Size = new System.Drawing.Size(41, 20);
            this.txtbCreationProduitPrix.TabIndex = 6;
            // 
            // txtbCreationProduitDescription
            // 
            this.txtbCreationProduitDescription.Location = new System.Drawing.Point(487, 189);
            this.txtbCreationProduitDescription.Name = "txtbCreationProduitDescription";
            this.txtbCreationProduitDescription.Size = new System.Drawing.Size(540, 20);
            this.txtbCreationProduitDescription.TabIndex = 5;
            // 
            // txtbCreationProduitLibel
            // 
            this.txtbCreationProduitLibel.Location = new System.Drawing.Point(487, 108);
            this.txtbCreationProduitLibel.Name = "txtbCreationProduitLibel";
            this.txtbCreationProduitLibel.Size = new System.Drawing.Size(100, 20);
            this.txtbCreationProduitLibel.TabIndex = 4;
            // 
            // txtbCreationProduitId
            // 
            this.txtbCreationProduitId.Location = new System.Drawing.Point(409, 152);
            this.txtbCreationProduitId.Name = "txtbCreationProduitId";
            this.txtbCreationProduitId.ReadOnly = true;
            this.txtbCreationProduitId.Size = new System.Drawing.Size(41, 20);
            this.txtbCreationProduitId.TabIndex = 3;
            // 
            // btnCreationProduitValider
            // 
            this.btnCreationProduitValider.Location = new System.Drawing.Point(1156, 108);
            this.btnCreationProduitValider.Name = "btnCreationProduitValider";
            this.btnCreationProduitValider.Size = new System.Drawing.Size(169, 42);
            this.btnCreationProduitValider.TabIndex = 1;
            this.btnCreationProduitValider.Text = "Valider";
            this.btnCreationProduitValider.UseVisualStyleBackColor = true;
            this.btnCreationProduitValider.Click += new System.EventHandler(this.btnCreationProduitValider_Click);
            // 
            // btnChoixImage
            // 
            this.btnChoixImage.Location = new System.Drawing.Point(402, 227);
            this.btnChoixImage.Name = "btnChoixImage";
            this.btnChoixImage.Size = new System.Drawing.Size(129, 23);
            this.btnChoixImage.TabIndex = 0;
            this.btnChoixImage.Text = "choix image";
            this.btnChoixImage.UseVisualStyleBackColor = true;
            this.btnChoixImage.Click += new System.EventHandler(this.btnChoixImage_Click);
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Location = new System.Drawing.Point(1162, 286);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(168, 36);
            this.btnModifierProduit.TabIndex = 37;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = true;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // btnCrerProduit
            // 
            this.btnCrerProduit.Location = new System.Drawing.Point(1162, 216);
            this.btnCrerProduit.Name = "btnCrerProduit";
            this.btnCrerProduit.Size = new System.Drawing.Size(168, 36);
            this.btnCrerProduit.TabIndex = 36;
            this.btnCrerProduit.Text = "Créer";
            this.btnCrerProduit.UseVisualStyleBackColor = true;
            this.btnCrerProduit.Click += new System.EventHandler(this.btnCrerProduit_Click);
            // 
            // dgvListeProduit
            // 
            this.dgvListeProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeProduit.Location = new System.Drawing.Point(151, 108);
            this.dgvListeProduit.Name = "dgvListeProduit";
            this.dgvListeProduit.Size = new System.Drawing.Size(984, 317);
            this.dgvListeProduit.TabIndex = 35;
            // 
            // lblTitreTabPProduit
            // 
            this.lblTitreTabPProduit.AutoSize = true;
            this.lblTitreTabPProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreTabPProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblTitreTabPProduit.Location = new System.Drawing.Point(624, 41);
            this.lblTitreTabPProduit.Name = "lblTitreTabPProduit";
            this.lblTitreTabPProduit.Size = new System.Drawing.Size(107, 31);
            this.lblTitreTabPProduit.TabIndex = 34;
            this.lblTitreTabPProduit.Text = "Produit";
            // 
            // btnCloseMenueClient
            // 
            this.btnCloseMenueClient.Location = new System.Drawing.Point(91, 51);
            this.btnCloseMenueClient.Name = "btnCloseMenueClient";
            this.btnCloseMenueClient.Size = new System.Drawing.Size(63, 23);
            this.btnCloseMenueClient.TabIndex = 40;
            this.btnCloseMenueClient.Text = "X";
            this.btnCloseMenueClient.UseVisualStyleBackColor = true;
            this.btnCloseMenueClient.Click += new System.EventHandler(this.btnCloseMenueClient_Click);
            // 
            // FrmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1654, 1041);
            this.Controls.Add(this.btnCloseMenueClient);
            this.Controls.Add(this.gpbModifierProduit);
            this.Controls.Add(this.btnModifierProduit);
            this.Controls.Add(this.btnCrerProduit);
            this.Controls.Add(this.dgvListeProduit);
            this.Controls.Add(this.lblTitreTabPProduit);
            this.Name = "FrmProduit";
            this.Text = "Form1";
            this.gpbModifierProduit.ResumeLayout(false);
            this.gpbCrerProduit.ResumeLayout(false);
            this.gpbCrerProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbModifierProduit;
        private System.Windows.Forms.GroupBox gpbCrerProduit;
        private System.Windows.Forms.TextBox txtbCreationProduitImg;
        private System.Windows.Forms.Label lblCreationProduitDescription;
        private System.Windows.Forms.Label lblCreationProduitFournisseur;
        private System.Windows.Forms.Label lblCreationProduitCategorieProduit;
        private System.Windows.Forms.Label lblCreationProduitPrix;
        private System.Windows.Forms.Label lblCreationProduitLibel;
        private System.Windows.Forms.Label lblCreationProduitId;
        private System.Windows.Forms.ComboBox cbbCreationProduitFournisseur;
        private System.Windows.Forms.ComboBox cbbCreationProduitCategorie;
        private System.Windows.Forms.TextBox txtbCreationProduitPrix;
        private System.Windows.Forms.TextBox txtbCreationProduitDescription;
        private System.Windows.Forms.TextBox txtbCreationProduitLibel;
        private System.Windows.Forms.TextBox txtbCreationProduitId;
        private System.Windows.Forms.Button btnCreationProduitValider;
        private System.Windows.Forms.Button btnChoixImage;
        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.Button btnCrerProduit;
        private System.Windows.Forms.DataGridView dgvListeProduit;
        private System.Windows.Forms.Label lblTitreTabPProduit;
        private System.Windows.Forms.Button btnCloseMenueClient;
    }
}