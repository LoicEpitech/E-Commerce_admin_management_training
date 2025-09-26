namespace LiaKosShop
{
    partial class FrmConnexion
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
            this.components = new System.ComponentModel.Container();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.boxMdp = new System.Windows.Forms.TextBox();
            this.boxId = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(342, 269);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(174, 24);
            this.lblErreur.TabIndex = 14;
            this.lblErreur.Text = "Veuillez réessayer !";
            this.lblErreur.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(360, 316);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 37);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Valider";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // boxMdp
            // 
            this.boxMdp.Location = new System.Drawing.Point(385, 228);
            this.boxMdp.Name = "boxMdp";
            this.boxMdp.PasswordChar = '*';
            this.boxMdp.Size = new System.Drawing.Size(134, 20);
            this.boxMdp.TabIndex = 12;
            this.boxMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxMdp_KeyPress);
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(385, 181);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(134, 20);
            this.boxId.TabIndex = 11;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(281, 228);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(95, 16);
            this.lblMdp.TabIndex = 10;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(281, 181);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(69, 16);
            this.lblIdentifiant.TabIndex = 9;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.boxMdp);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblIdentifiant);
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox boxMdp;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.ErrorProvider erp;
    }
}