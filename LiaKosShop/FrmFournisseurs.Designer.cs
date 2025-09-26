namespace LiaKosShop
{
    partial class FrmFournisseurs
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
            this.gpbModifierFournisseur = new System.Windows.Forms.GroupBox();
            this.gpbCrerFournisseur = new System.Windows.Forms.GroupBox();
            this.btnModifierFournisseur = new System.Windows.Forms.Button();
            this.btnCrerFournisseur = new System.Windows.Forms.Button();
            this.dgvListeFournisseur = new System.Windows.Forms.DataGridView();
            this.lblTitreTabPFournisseur = new System.Windows.Forms.Label();
            this.btnCloseMenueClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbModifierFournisseur
            // 
            this.gpbModifierFournisseur.Enabled = false;
            this.gpbModifierFournisseur.Location = new System.Drawing.Point(12, 365);
            this.gpbModifierFournisseur.Name = "gpbModifierFournisseur";
            this.gpbModifierFournisseur.Size = new System.Drawing.Size(1624, 376);
            this.gpbModifierFournisseur.TabIndex = 44;
            this.gpbModifierFournisseur.TabStop = false;
            this.gpbModifierFournisseur.Text = "modif fourni";
            this.gpbModifierFournisseur.Visible = false;
            // 
            // gpbCrerFournisseur
            // 
            this.gpbCrerFournisseur.Enabled = false;
            this.gpbCrerFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCrerFournisseur.Location = new System.Drawing.Point(12, 365);
            this.gpbCrerFournisseur.Name = "gpbCrerFournisseur";
            this.gpbCrerFournisseur.Size = new System.Drawing.Size(1630, 376);
            this.gpbCrerFournisseur.TabIndex = 43;
            this.gpbCrerFournisseur.TabStop = false;
            this.gpbCrerFournisseur.Text = "Créer";
            this.gpbCrerFournisseur.Visible = false;
            // 
            // btnModifierFournisseur
            // 
            this.btnModifierFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierFournisseur.Location = new System.Drawing.Point(1078, 306);
            this.btnModifierFournisseur.Name = "btnModifierFournisseur";
            this.btnModifierFournisseur.Size = new System.Drawing.Size(168, 36);
            this.btnModifierFournisseur.TabIndex = 42;
            this.btnModifierFournisseur.Text = "Modifier";
            this.btnModifierFournisseur.UseVisualStyleBackColor = true;
            this.btnModifierFournisseur.Click += new System.EventHandler(this.btnModifierFournisseur_Click);
            // 
            // btnCrerFournisseur
            // 
            this.btnCrerFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrerFournisseur.Location = new System.Drawing.Point(1078, 229);
            this.btnCrerFournisseur.Name = "btnCrerFournisseur";
            this.btnCrerFournisseur.Size = new System.Drawing.Size(168, 36);
            this.btnCrerFournisseur.TabIndex = 41;
            this.btnCrerFournisseur.Text = "Créer";
            this.btnCrerFournisseur.UseVisualStyleBackColor = true;
            this.btnCrerFournisseur.Click += new System.EventHandler(this.btnCrerFournisseur_Click);
            // 
            // dgvListeFournisseur
            // 
            this.dgvListeFournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeFournisseur.Location = new System.Drawing.Point(235, 73);
            this.dgvListeFournisseur.Name = "dgvListeFournisseur";
            this.dgvListeFournisseur.Size = new System.Drawing.Size(818, 269);
            this.dgvListeFournisseur.TabIndex = 40;
            // 
            // lblTitreTabPFournisseur
            // 
            this.lblTitreTabPFournisseur.AutoSize = true;
            this.lblTitreTabPFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreTabPFournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblTitreTabPFournisseur.Location = new System.Drawing.Point(655, 9);
            this.lblTitreTabPFournisseur.Name = "lblTitreTabPFournisseur";
            this.lblTitreTabPFournisseur.Size = new System.Drawing.Size(169, 31);
            this.lblTitreTabPFournisseur.TabIndex = 39;
            this.lblTitreTabPFournisseur.Text = "Fournisseur";
            // 
            // btnCloseMenueClient
            // 
            this.btnCloseMenueClient.Location = new System.Drawing.Point(97, 51);
            this.btnCloseMenueClient.Name = "btnCloseMenueClient";
            this.btnCloseMenueClient.Size = new System.Drawing.Size(63, 23);
            this.btnCloseMenueClient.TabIndex = 46;
            this.btnCloseMenueClient.Text = "X";
            this.btnCloseMenueClient.UseVisualStyleBackColor = true;
            this.btnCloseMenueClient.Click += new System.EventHandler(this.btnCloseMenueClient_Click);
            // 
            // FrmFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1654, 1041);
            this.Controls.Add(this.btnCloseMenueClient);
            this.Controls.Add(this.gpbCrerFournisseur);
            this.Controls.Add(this.gpbModifierFournisseur);
            this.Controls.Add(this.btnModifierFournisseur);
            this.Controls.Add(this.btnCrerFournisseur);
            this.Controls.Add(this.dgvListeFournisseur);
            this.Controls.Add(this.lblTitreTabPFournisseur);
            this.Name = "FrmFournisseurs";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbModifierFournisseur;
        private System.Windows.Forms.GroupBox gpbCrerFournisseur;
        private System.Windows.Forms.Button btnModifierFournisseur;
        private System.Windows.Forms.Button btnCrerFournisseur;
        private System.Windows.Forms.DataGridView dgvListeFournisseur;
        private System.Windows.Forms.Label lblTitreTabPFournisseur;
        private System.Windows.Forms.Button btnCloseMenueClient;
    }
}