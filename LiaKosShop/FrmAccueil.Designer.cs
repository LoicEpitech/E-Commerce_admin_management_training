namespace LiaKosShop
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.panelChildFrm = new System.Windows.Forms.Panel();
            this.btnOpenMenuCommande = new System.Windows.Forms.Button();
            this.btnOpenMenuFournisseur = new System.Windows.Forms.Button();
            this.btnOpenMenuProduit = new System.Windows.Forms.Button();
            this.btnOpenMenuClient = new System.Windows.Forms.Button();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.panelChildFrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildFrm
            // 
            this.panelChildFrm.BackColor = System.Drawing.Color.SkyBlue;
            this.panelChildFrm.Controls.Add(this.lblBienvenue);
            this.panelChildFrm.Controls.Add(this.btnOpenMenuCommande);
            this.panelChildFrm.Controls.Add(this.btnOpenMenuFournisseur);
            this.panelChildFrm.Controls.Add(this.btnOpenMenuProduit);
            this.panelChildFrm.Controls.Add(this.btnOpenMenuClient);
            this.panelChildFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFrm.ForeColor = System.Drawing.Color.Black;
            this.panelChildFrm.Location = new System.Drawing.Point(0, 0);
            this.panelChildFrm.Margin = new System.Windows.Forms.Padding(1);
            this.panelChildFrm.Name = "panelChildFrm";
            this.panelChildFrm.Size = new System.Drawing.Size(1904, 1041);
            this.panelChildFrm.TabIndex = 1;
            // 
            // btnOpenMenuCommande
            // 
            this.btnOpenMenuCommande.Location = new System.Drawing.Point(1036, 595);
            this.btnOpenMenuCommande.Name = "btnOpenMenuCommande";
            this.btnOpenMenuCommande.Size = new System.Drawing.Size(521, 182);
            this.btnOpenMenuCommande.TabIndex = 3;
            this.btnOpenMenuCommande.Text = "Commandes";
            this.btnOpenMenuCommande.UseVisualStyleBackColor = true;
            this.btnOpenMenuCommande.Click += new System.EventHandler(this.btnOpenMenuCommande_Click);
            // 
            // btnOpenMenuFournisseur
            // 
            this.btnOpenMenuFournisseur.Location = new System.Drawing.Point(396, 595);
            this.btnOpenMenuFournisseur.Name = "btnOpenMenuFournisseur";
            this.btnOpenMenuFournisseur.Size = new System.Drawing.Size(521, 182);
            this.btnOpenMenuFournisseur.TabIndex = 2;
            this.btnOpenMenuFournisseur.Text = "Fournisseurs";
            this.btnOpenMenuFournisseur.UseVisualStyleBackColor = true;
            this.btnOpenMenuFournisseur.Click += new System.EventHandler(this.btnOpenMenuFournisseur_Click);
            // 
            // btnOpenMenuProduit
            // 
            this.btnOpenMenuProduit.Location = new System.Drawing.Point(396, 293);
            this.btnOpenMenuProduit.Name = "btnOpenMenuProduit";
            this.btnOpenMenuProduit.Size = new System.Drawing.Size(521, 182);
            this.btnOpenMenuProduit.TabIndex = 1;
            this.btnOpenMenuProduit.Text = "Produits";
            this.btnOpenMenuProduit.UseVisualStyleBackColor = true;
            this.btnOpenMenuProduit.Click += new System.EventHandler(this.btnOpenMenuProduit_Click);
            // 
            // btnOpenMenuClient
            // 
            this.btnOpenMenuClient.Location = new System.Drawing.Point(1036, 293);
            this.btnOpenMenuClient.Name = "btnOpenMenuClient";
            this.btnOpenMenuClient.Size = new System.Drawing.Size(521, 182);
            this.btnOpenMenuClient.TabIndex = 0;
            this.btnOpenMenuClient.Text = "Clients";
            this.btnOpenMenuClient.UseVisualStyleBackColor = true;
            this.btnOpenMenuClient.Click += new System.EventHandler(this.btnOpenMenuClient_Click);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Nirmala Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(559, 101);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(826, 86);
            this.lblBienvenue.TabIndex = 4;
            this.lblBienvenue.Text = "Bienvenue Administrateur";
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelChildFrm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAccueil";
            this.Text = "Logiciel de Gestion LiaKosShop";
            this.Load += new System.EventHandler(this.FrmAccueil_Load);
            this.panelChildFrm.ResumeLayout(false);
            this.panelChildFrm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelChildFrm;
        private System.Windows.Forms.Button btnOpenMenuClient;
        private System.Windows.Forms.Button btnOpenMenuCommande;
        private System.Windows.Forms.Button btnOpenMenuFournisseur;
        private System.Windows.Forms.Button btnOpenMenuProduit;
        private System.Windows.Forms.Label lblBienvenue;
    }
}

