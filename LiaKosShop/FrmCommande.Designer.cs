namespace LiaKosShop
{
    partial class FrmCommande
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
            this.gpbModifierCommande = new System.Windows.Forms.GroupBox();
            this.btnAnulerSupprimerCommande = new System.Windows.Forms.Button();
            this.btnSupprimerCommande = new System.Windows.Forms.Button();
            this.flpModifierCommande = new System.Windows.Forms.FlowLayoutPanel();
            this.txtbModifCommandeDate = new System.Windows.Forms.TextBox();
            this.btnModifCommandeSupLigne = new System.Windows.Forms.Button();
            this.btnModifCommandeAddLigne = new System.Windows.Forms.Button();
            this.cbbModifCommandeSP1 = new System.Windows.Forms.ComboBox();
            this.cbbModifCommandeClient = new System.Windows.Forms.ComboBox();
            this.txtbModifCommandeId = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.lblModifCommandeSP1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblModifCommandeQtP1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtbModifCommandeQtP1 = new System.Windows.Forms.TextBox();
            this.btnModifCommandeValider = new System.Windows.Forms.Button();
            this.cbbModifCommandeSelectCommande = new System.Windows.Forms.ComboBox();
            this.gpbCreerCommande = new System.Windows.Forms.GroupBox();
            this.lblExeptionCreationCmd = new System.Windows.Forms.Label();
            this.flpCreationCommande = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCreationCommandeProduit1 = new System.Windows.Forms.Label();
            this.cbbCreationCommandeProduit1 = new System.Windows.Forms.ComboBox();
            this.lblCreationCommandeQuantite1 = new System.Windows.Forms.Label();
            this.txtbCreationCommandeQtP1 = new System.Windows.Forms.TextBox();
            this.dtpCreationCommandeDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreationCommandeRetirerProduitSup1 = new System.Windows.Forms.Button();
            this.btnCreationCommandeAddProduitPlusUn = new System.Windows.Forms.Button();
            this.cbbCreationCommandeClient = new System.Windows.Forms.ComboBox();
            this.txtbCreationCommandeId = new System.Windows.Forms.TextBox();
            this.lblCreationCommandeId = new System.Windows.Forms.Label();
            this.lblCreationCommandeDate = new System.Windows.Forms.Label();
            this.lblCreationCommandeClient = new System.Windows.Forms.Label();
            this.btnCreationCommandeValider = new System.Windows.Forms.Button();
            this.dgvListeCom = new System.Windows.Forms.DataGridView();
            this.lblTitreTabPComande = new System.Windows.Forms.Label();
            this.erpCreationCommande = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCloseMenueClient = new System.Windows.Forms.Button();
            this.btnGererCommande = new System.Windows.Forms.Button();
            this.btnCreerCommande = new System.Windows.Forms.Button();
            this.gpbModifierCommande.SuspendLayout();
            this.gpbCreerCommande.SuspendLayout();
            this.flpCreationCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCreationCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbModifierCommande
            // 
            this.gpbModifierCommande.Controls.Add(this.btnAnulerSupprimerCommande);
            this.gpbModifierCommande.Controls.Add(this.btnSupprimerCommande);
            this.gpbModifierCommande.Controls.Add(this.flpModifierCommande);
            this.gpbModifierCommande.Controls.Add(this.txtbModifCommandeDate);
            this.gpbModifierCommande.Controls.Add(this.btnModifCommandeSupLigne);
            this.gpbModifierCommande.Controls.Add(this.btnModifCommandeAddLigne);
            this.gpbModifierCommande.Controls.Add(this.cbbModifCommandeSP1);
            this.gpbModifierCommande.Controls.Add(this.cbbModifCommandeClient);
            this.gpbModifierCommande.Controls.Add(this.txtbModifCommandeId);
            this.gpbModifierCommande.Controls.Add(this.label27);
            this.gpbModifierCommande.Controls.Add(this.lblModifCommandeSP1);
            this.gpbModifierCommande.Controls.Add(this.label29);
            this.gpbModifierCommande.Controls.Add(this.lblModifCommandeQtP1);
            this.gpbModifierCommande.Controls.Add(this.label31);
            this.gpbModifierCommande.Controls.Add(this.txtbModifCommandeQtP1);
            this.gpbModifierCommande.Controls.Add(this.btnModifCommandeValider);
            this.gpbModifierCommande.Controls.Add(this.cbbModifCommandeSelectCommande);
            this.gpbModifierCommande.Enabled = false;
            this.gpbModifierCommande.Location = new System.Drawing.Point(12, 424);
            this.gpbModifierCommande.Name = "gpbModifierCommande";
            this.gpbModifierCommande.Size = new System.Drawing.Size(1622, 376);
            this.gpbModifierCommande.TabIndex = 44;
            this.gpbModifierCommande.TabStop = false;
            this.gpbModifierCommande.Text = "modif commande";
            this.gpbModifierCommande.Visible = false;
            // 
            // btnAnulerSupprimerCommande
            // 
            this.btnAnulerSupprimerCommande.Location = new System.Drawing.Point(1088, 299);
            this.btnAnulerSupprimerCommande.Name = "btnAnulerSupprimerCommande";
            this.btnAnulerSupprimerCommande.Size = new System.Drawing.Size(156, 34);
            this.btnAnulerSupprimerCommande.TabIndex = 146;
            this.btnAnulerSupprimerCommande.Text = "Annuler";
            this.btnAnulerSupprimerCommande.UseVisualStyleBackColor = true;
            this.btnAnulerSupprimerCommande.Visible = false;
            this.btnAnulerSupprimerCommande.Click += new System.EventHandler(this.btnAnulerSupprimerCommande_Click);
            // 
            // btnSupprimerCommande
            // 
            this.btnSupprimerCommande.Location = new System.Drawing.Point(926, 299);
            this.btnSupprimerCommande.Name = "btnSupprimerCommande";
            this.btnSupprimerCommande.Size = new System.Drawing.Size(156, 34);
            this.btnSupprimerCommande.TabIndex = 145;
            this.btnSupprimerCommande.Text = "Supprimer";
            this.btnSupprimerCommande.UseVisualStyleBackColor = true;
            this.btnSupprimerCommande.Click += new System.EventHandler(this.btnSupprimerCommande_Click);
            // 
            // flpModifierCommande
            // 
            this.flpModifierCommande.AutoScroll = true;
            this.flpModifierCommande.Location = new System.Drawing.Point(358, 67);
            this.flpModifierCommande.Name = "flpModifierCommande";
            this.flpModifierCommande.Size = new System.Drawing.Size(516, 266);
            this.flpModifierCommande.TabIndex = 144;
            // 
            // txtbModifCommandeDate
            // 
            this.txtbModifCommandeDate.Location = new System.Drawing.Point(120, 196);
            this.txtbModifCommandeDate.Name = "txtbModifCommandeDate";
            this.txtbModifCommandeDate.Size = new System.Drawing.Size(156, 20);
            this.txtbModifCommandeDate.TabIndex = 142;
            // 
            // btnModifCommandeSupLigne
            // 
            this.btnModifCommandeSupLigne.Location = new System.Drawing.Point(926, 227);
            this.btnModifCommandeSupLigne.Name = "btnModifCommandeSupLigne";
            this.btnModifCommandeSupLigne.Size = new System.Drawing.Size(156, 34);
            this.btnModifCommandeSupLigne.TabIndex = 141;
            this.btnModifCommandeSupLigne.Text = "Retirer une ligne";
            this.btnModifCommandeSupLigne.UseVisualStyleBackColor = true;
            this.btnModifCommandeSupLigne.Visible = false;
            this.btnModifCommandeSupLigne.Click += new System.EventHandler(this.btnModifCommandeSupLigne_Click);
            // 
            // btnModifCommandeAddLigne
            // 
            this.btnModifCommandeAddLigne.Location = new System.Drawing.Point(926, 190);
            this.btnModifCommandeAddLigne.Name = "btnModifCommandeAddLigne";
            this.btnModifCommandeAddLigne.Size = new System.Drawing.Size(156, 34);
            this.btnModifCommandeAddLigne.TabIndex = 104;
            this.btnModifCommandeAddLigne.Text = "Ajouter un segond Produit";
            this.btnModifCommandeAddLigne.UseVisualStyleBackColor = true;
            this.btnModifCommandeAddLigne.Click += new System.EventHandler(this.btnModifCommandeAddLigne_Click);
            // 
            // cbbModifCommandeSP1
            // 
            this.cbbModifCommandeSP1.Location = new System.Drawing.Point(391, 92);
            this.cbbModifCommandeSP1.Name = "cbbModifCommandeSP1";
            this.cbbModifCommandeSP1.Size = new System.Drawing.Size(156, 21);
            this.cbbModifCommandeSP1.TabIndex = 103;
            this.cbbModifCommandeSP1.Visible = false;
            // 
            // cbbModifCommandeClient
            // 
            this.cbbModifCommandeClient.FormattingEnabled = true;
            this.cbbModifCommandeClient.Location = new System.Drawing.Point(120, 143);
            this.cbbModifCommandeClient.Name = "cbbModifCommandeClient";
            this.cbbModifCommandeClient.Size = new System.Drawing.Size(156, 21);
            this.cbbModifCommandeClient.TabIndex = 102;
            // 
            // txtbModifCommandeId
            // 
            this.txtbModifCommandeId.Enabled = false;
            this.txtbModifCommandeId.Location = new System.Drawing.Point(120, 95);
            this.txtbModifCommandeId.Name = "txtbModifCommandeId";
            this.txtbModifCommandeId.Size = new System.Drawing.Size(65, 20);
            this.txtbModifCommandeId.TabIndex = 101;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.label27.Location = new System.Drawing.Point(95, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 13);
            this.label27.TabIndex = 100;
            this.label27.Text = "Id:";
            // 
            // lblModifCommandeSP1
            // 
            this.lblModifCommandeSP1.AutoSize = true;
            this.lblModifCommandeSP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblModifCommandeSP1.Location = new System.Drawing.Point(310, 98);
            this.lblModifCommandeSP1.Name = "lblModifCommandeSP1";
            this.lblModifCommandeSP1.Size = new System.Drawing.Size(64, 13);
            this.lblModifCommandeSP1.TabIndex = 99;
            this.lblModifCommandeSP1.Text = "Produit N°1:";
            this.lblModifCommandeSP1.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.label29.Location = new System.Drawing.Point(10, 196);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(104, 13);
            this.label29.TabIndex = 98;
            this.label29.Text = "Date de Commande:";
            // 
            // lblModifCommandeQtP1
            // 
            this.lblModifCommandeQtP1.AutoSize = true;
            this.lblModifCommandeQtP1.Location = new System.Drawing.Point(613, 98);
            this.lblModifCommandeQtP1.Name = "lblModifCommandeQtP1";
            this.lblModifCommandeQtP1.Size = new System.Drawing.Size(50, 13);
            this.lblModifCommandeQtP1.TabIndex = 97;
            this.lblModifCommandeQtP1.Text = "Quantite:";
            this.lblModifCommandeQtP1.Visible = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.label31.Location = new System.Drawing.Point(78, 146);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 13);
            this.label31.TabIndex = 96;
            this.label31.Text = "Client:";
            // 
            // txtbModifCommandeQtP1
            // 
            this.txtbModifCommandeQtP1.Location = new System.Drawing.Point(680, 95);
            this.txtbModifCommandeQtP1.Name = "txtbModifCommandeQtP1";
            this.txtbModifCommandeQtP1.Size = new System.Drawing.Size(156, 20);
            this.txtbModifCommandeQtP1.TabIndex = 95;
            this.txtbModifCommandeQtP1.Visible = false;
            // 
            // btnModifCommandeValider
            // 
            this.btnModifCommandeValider.Location = new System.Drawing.Point(926, 92);
            this.btnModifCommandeValider.Name = "btnModifCommandeValider";
            this.btnModifCommandeValider.Size = new System.Drawing.Size(156, 34);
            this.btnModifCommandeValider.TabIndex = 94;
            this.btnModifCommandeValider.Text = "Valider";
            this.btnModifCommandeValider.UseVisualStyleBackColor = true;
            this.btnModifCommandeValider.Click += new System.EventHandler(this.btnModifCommandeValider_Click);
            // 
            // cbbModifCommandeSelectCommande
            // 
            this.cbbModifCommandeSelectCommande.FormattingEnabled = true;
            this.cbbModifCommandeSelectCommande.Location = new System.Drawing.Point(503, 27);
            this.cbbModifCommandeSelectCommande.Name = "cbbModifCommandeSelectCommande";
            this.cbbModifCommandeSelectCommande.Size = new System.Drawing.Size(232, 21);
            this.cbbModifCommandeSelectCommande.TabIndex = 53;
            this.cbbModifCommandeSelectCommande.SelectedIndexChanged += new System.EventHandler(this.cbbModifCommandeSelectCommande_SelectedIndexChanged);
            // 
            // gpbCreerCommande
            // 
            this.gpbCreerCommande.Controls.Add(this.lblExeptionCreationCmd);
            this.gpbCreerCommande.Controls.Add(this.flpCreationCommande);
            this.gpbCreerCommande.Controls.Add(this.dtpCreationCommandeDate);
            this.gpbCreerCommande.Controls.Add(this.btnCreationCommandeRetirerProduitSup1);
            this.gpbCreerCommande.Controls.Add(this.btnCreationCommandeAddProduitPlusUn);
            this.gpbCreerCommande.Controls.Add(this.cbbCreationCommandeClient);
            this.gpbCreerCommande.Controls.Add(this.txtbCreationCommandeId);
            this.gpbCreerCommande.Controls.Add(this.lblCreationCommandeId);
            this.gpbCreerCommande.Controls.Add(this.lblCreationCommandeDate);
            this.gpbCreerCommande.Controls.Add(this.lblCreationCommandeClient);
            this.gpbCreerCommande.Controls.Add(this.btnCreationCommandeValider);
            this.gpbCreerCommande.Enabled = false;
            this.gpbCreerCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCreerCommande.Location = new System.Drawing.Point(12, 418);
            this.gpbCreerCommande.Name = "gpbCreerCommande";
            this.gpbCreerCommande.Size = new System.Drawing.Size(1616, 376);
            this.gpbCreerCommande.TabIndex = 43;
            this.gpbCreerCommande.TabStop = false;
            this.gpbCreerCommande.Text = "Créer";
            this.gpbCreerCommande.Visible = false;
            // 
            // lblExeptionCreationCmd
            // 
            this.lblExeptionCreationCmd.AutoSize = true;
            this.lblExeptionCreationCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExeptionCreationCmd.ForeColor = System.Drawing.Color.Red;
            this.lblExeptionCreationCmd.Location = new System.Drawing.Point(788, 61);
            this.lblExeptionCreationCmd.Name = "lblExeptionCreationCmd";
            this.lblExeptionCreationCmd.Size = new System.Drawing.Size(11, 16);
            this.lblExeptionCreationCmd.TabIndex = 144;
            this.lblExeptionCreationCmd.Text = ".";
            this.lblExeptionCreationCmd.Visible = false;
            // 
            // flpCreationCommande
            // 
            this.flpCreationCommande.AutoScroll = true;
            this.flpCreationCommande.Controls.Add(this.lblCreationCommandeProduit1);
            this.flpCreationCommande.Controls.Add(this.cbbCreationCommandeProduit1);
            this.flpCreationCommande.Controls.Add(this.lblCreationCommandeQuantite1);
            this.flpCreationCommande.Controls.Add(this.txtbCreationCommandeQtP1);
            this.flpCreationCommande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.flpCreationCommande.Location = new System.Drawing.Point(123, 76);
            this.flpCreationCommande.Name = "flpCreationCommande";
            this.flpCreationCommande.Size = new System.Drawing.Size(478, 280);
            this.flpCreationCommande.TabIndex = 143;
            // 
            // lblCreationCommandeProduit1
            // 
            this.lblCreationCommandeProduit1.AutoSize = true;
            this.lblCreationCommandeProduit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblCreationCommandeProduit1.Location = new System.Drawing.Point(3, 0);
            this.lblCreationCommandeProduit1.Name = "lblCreationCommandeProduit1";
            this.lblCreationCommandeProduit1.Size = new System.Drawing.Size(75, 13);
            this.lblCreationCommandeProduit1.TabIndex = 50;
            this.lblCreationCommandeProduit1.Text = "Produit N-1:";
            // 
            // cbbCreationCommandeProduit1
            // 
            this.cbbCreationCommandeProduit1.Location = new System.Drawing.Point(84, 3);
            this.cbbCreationCommandeProduit1.Name = "cbbCreationCommandeProduit1";
            this.cbbCreationCommandeProduit1.Size = new System.Drawing.Size(156, 21);
            this.cbbCreationCommandeProduit1.TabIndex = 54;
            // 
            // lblCreationCommandeQuantite1
            // 
            this.lblCreationCommandeQuantite1.AutoSize = true;
            this.lblCreationCommandeQuantite1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblCreationCommandeQuantite1.Location = new System.Drawing.Point(246, 0);
            this.lblCreationCommandeQuantite1.Name = "lblCreationCommandeQuantite1";
            this.lblCreationCommandeQuantite1.Size = new System.Drawing.Size(59, 13);
            this.lblCreationCommandeQuantite1.TabIndex = 46;
            this.lblCreationCommandeQuantite1.Text = "Quantite:";
            // 
            // txtbCreationCommandeQtP1
            // 
            this.txtbCreationCommandeQtP1.Location = new System.Drawing.Point(311, 3);
            this.txtbCreationCommandeQtP1.Name = "txtbCreationCommandeQtP1";
            this.txtbCreationCommandeQtP1.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationCommandeQtP1.TabIndex = 39;
            // 
            // dtpCreationCommandeDate
            // 
            this.dtpCreationCommandeDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpCreationCommandeDate.Location = new System.Drawing.Point(507, 31);
            this.dtpCreationCommandeDate.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpCreationCommandeDate.MinDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpCreationCommandeDate.Name = "dtpCreationCommandeDate";
            this.dtpCreationCommandeDate.Size = new System.Drawing.Size(189, 20);
            this.dtpCreationCommandeDate.TabIndex = 93;
            // 
            // btnCreationCommandeRetirerProduitSup1
            // 
            this.btnCreationCommandeRetirerProduitSup1.Location = new System.Drawing.Point(791, 140);
            this.btnCreationCommandeRetirerProduitSup1.Name = "btnCreationCommandeRetirerProduitSup1";
            this.btnCreationCommandeRetirerProduitSup1.Size = new System.Drawing.Size(156, 34);
            this.btnCreationCommandeRetirerProduitSup1.TabIndex = 92;
            this.btnCreationCommandeRetirerProduitSup1.Text = "Retirer une ligne";
            this.btnCreationCommandeRetirerProduitSup1.UseVisualStyleBackColor = true;
            this.btnCreationCommandeRetirerProduitSup1.Visible = false;
            this.btnCreationCommandeRetirerProduitSup1.Click += new System.EventHandler(this.btnCreationCommandeRetirerProduitSup1_Click);
            // 
            // btnCreationCommandeAddProduitPlusUn
            // 
            this.btnCreationCommandeAddProduitPlusUn.Location = new System.Drawing.Point(791, 103);
            this.btnCreationCommandeAddProduitPlusUn.Name = "btnCreationCommandeAddProduitPlusUn";
            this.btnCreationCommandeAddProduitPlusUn.Size = new System.Drawing.Size(156, 34);
            this.btnCreationCommandeAddProduitPlusUn.TabIndex = 55;
            this.btnCreationCommandeAddProduitPlusUn.Text = "Ajouter un segond Produit";
            this.btnCreationCommandeAddProduitPlusUn.UseVisualStyleBackColor = true;
            this.btnCreationCommandeAddProduitPlusUn.Click += new System.EventHandler(this.btnCreationCommandeAddProduitPlusUn_Click);
            // 
            // cbbCreationCommandeClient
            // 
            this.cbbCreationCommandeClient.FormattingEnabled = true;
            this.cbbCreationCommandeClient.Location = new System.Drawing.Point(206, 31);
            this.cbbCreationCommandeClient.Name = "cbbCreationCommandeClient";
            this.cbbCreationCommandeClient.Size = new System.Drawing.Size(156, 21);
            this.cbbCreationCommandeClient.TabIndex = 53;
            // 
            // txtbCreationCommandeId
            // 
            this.txtbCreationCommandeId.Enabled = false;
            this.txtbCreationCommandeId.Location = new System.Drawing.Point(44, 31);
            this.txtbCreationCommandeId.Name = "txtbCreationCommandeId";
            this.txtbCreationCommandeId.Size = new System.Drawing.Size(65, 20);
            this.txtbCreationCommandeId.TabIndex = 52;
            // 
            // lblCreationCommandeId
            // 
            this.lblCreationCommandeId.AutoSize = true;
            this.lblCreationCommandeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblCreationCommandeId.Location = new System.Drawing.Point(16, 34);
            this.lblCreationCommandeId.Name = "lblCreationCommandeId";
            this.lblCreationCommandeId.Size = new System.Drawing.Size(22, 13);
            this.lblCreationCommandeId.TabIndex = 51;
            this.lblCreationCommandeId.Text = "Id:";
            // 
            // lblCreationCommandeDate
            // 
            this.lblCreationCommandeDate.AutoSize = true;
            this.lblCreationCommandeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblCreationCommandeDate.Location = new System.Drawing.Point(380, 34);
            this.lblCreationCommandeDate.Name = "lblCreationCommandeDate";
            this.lblCreationCommandeDate.Size = new System.Drawing.Size(121, 13);
            this.lblCreationCommandeDate.TabIndex = 47;
            this.lblCreationCommandeDate.Text = "Date de Commande:";
            // 
            // lblCreationCommandeClient
            // 
            this.lblCreationCommandeClient.AutoSize = true;
            this.lblCreationCommandeClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblCreationCommandeClient.Location = new System.Drawing.Point(156, 34);
            this.lblCreationCommandeClient.Name = "lblCreationCommandeClient";
            this.lblCreationCommandeClient.Size = new System.Drawing.Size(43, 13);
            this.lblCreationCommandeClient.TabIndex = 44;
            this.lblCreationCommandeClient.Text = "Client:";
            // 
            // btnCreationCommandeValider
            // 
            this.btnCreationCommandeValider.Location = new System.Drawing.Point(791, 251);
            this.btnCreationCommandeValider.Name = "btnCreationCommandeValider";
            this.btnCreationCommandeValider.Size = new System.Drawing.Size(156, 34);
            this.btnCreationCommandeValider.TabIndex = 36;
            this.btnCreationCommandeValider.Text = "Valider";
            this.btnCreationCommandeValider.UseVisualStyleBackColor = true;
            this.btnCreationCommandeValider.Click += new System.EventHandler(this.btnCreationCommandeValider_Click);
            // 
            // dgvListeCom
            // 
            this.dgvListeCom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeCom.Location = new System.Drawing.Point(208, 82);
            this.dgvListeCom.Name = "dgvListeCom";
            this.dgvListeCom.Size = new System.Drawing.Size(927, 329);
            this.dgvListeCom.TabIndex = 40;
            // 
            // lblTitreTabPComande
            // 
            this.lblTitreTabPComande.AutoSize = true;
            this.lblTitreTabPComande.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreTabPComande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblTitreTabPComande.Location = new System.Drawing.Point(655, 9);
            this.lblTitreTabPComande.Name = "lblTitreTabPComande";
            this.lblTitreTabPComande.Size = new System.Drawing.Size(161, 31);
            this.lblTitreTabPComande.TabIndex = 39;
            this.lblTitreTabPComande.Text = "Commande";
            this.lblTitreTabPComande.Click += new System.EventHandler(this.lblTitreTabPComande_Click);
            // 
            // erpCreationCommande
            // 
            this.erpCreationCommande.ContainerControl = this;
            // 
            // btnCloseMenueClient
            // 
            this.btnCloseMenueClient.Location = new System.Drawing.Point(97, 51);
            this.btnCloseMenueClient.Name = "btnCloseMenueClient";
            this.btnCloseMenueClient.Size = new System.Drawing.Size(63, 23);
            this.btnCloseMenueClient.TabIndex = 45;
            this.btnCloseMenueClient.Text = "X";
            this.btnCloseMenueClient.UseVisualStyleBackColor = true;
            this.btnCloseMenueClient.Click += new System.EventHandler(this.btnCloseMenueClient_Click);
            // 
            // btnGererCommande
            // 
            this.btnGererCommande.Location = new System.Drawing.Point(1186, 276);
            this.btnGererCommande.Name = "btnGererCommande";
            this.btnGererCommande.Size = new System.Drawing.Size(168, 36);
            this.btnGererCommande.TabIndex = 47;
            this.btnGererCommande.Text = "Modifier";
            this.btnGererCommande.UseVisualStyleBackColor = true;
            this.btnGererCommande.Click += new System.EventHandler(this.btnGererClient_Click);
            // 
            // btnCreerCommande
            // 
            this.btnCreerCommande.Location = new System.Drawing.Point(1186, 217);
            this.btnCreerCommande.Name = "btnCreerCommande";
            this.btnCreerCommande.Size = new System.Drawing.Size(168, 36);
            this.btnCreerCommande.TabIndex = 46;
            this.btnCreerCommande.Text = "Créer";
            this.btnCreerCommande.UseVisualStyleBackColor = true;
            this.btnCreerCommande.Click += new System.EventHandler(this.btnCrerClient_Click);
            // 
            // FrmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1654, 1041);
            this.Controls.Add(this.btnGererCommande);
            this.Controls.Add(this.btnCreerCommande);
            this.Controls.Add(this.gpbCreerCommande);
            this.Controls.Add(this.btnCloseMenueClient);
            this.Controls.Add(this.gpbModifierCommande);
            this.Controls.Add(this.dgvListeCom);
            this.Controls.Add(this.lblTitreTabPComande);
            this.Name = "FrmCommande";
            this.Text = "/";
            this.gpbModifierCommande.ResumeLayout(false);
            this.gpbModifierCommande.PerformLayout();
            this.gpbCreerCommande.ResumeLayout(false);
            this.gpbCreerCommande.PerformLayout();
            this.flpCreationCommande.ResumeLayout(false);
            this.flpCreationCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCreationCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbModifierCommande;
        private System.Windows.Forms.Button btnAnulerSupprimerCommande;
        private System.Windows.Forms.Button btnSupprimerCommande;
        private System.Windows.Forms.FlowLayoutPanel flpModifierCommande;
        private System.Windows.Forms.TextBox txtbModifCommandeDate;
        private System.Windows.Forms.Button btnModifCommandeSupLigne;
        private System.Windows.Forms.Button btnModifCommandeAddLigne;
        private System.Windows.Forms.ComboBox cbbModifCommandeSP1;
        private System.Windows.Forms.ComboBox cbbModifCommandeClient;
        private System.Windows.Forms.TextBox txtbModifCommandeId;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblModifCommandeSP1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblModifCommandeQtP1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtbModifCommandeQtP1;
        private System.Windows.Forms.Button btnModifCommandeValider;
        private System.Windows.Forms.ComboBox cbbModifCommandeSelectCommande;
        private System.Windows.Forms.GroupBox gpbCreerCommande;
        private System.Windows.Forms.FlowLayoutPanel flpCreationCommande;
        private System.Windows.Forms.Label lblCreationCommandeProduit1;
        private System.Windows.Forms.ComboBox cbbCreationCommandeProduit1;
        private System.Windows.Forms.Label lblCreationCommandeQuantite1;
        private System.Windows.Forms.TextBox txtbCreationCommandeQtP1;
        private System.Windows.Forms.DateTimePicker dtpCreationCommandeDate;
        private System.Windows.Forms.Button btnCreationCommandeRetirerProduitSup1;
        private System.Windows.Forms.Button btnCreationCommandeAddProduitPlusUn;
        private System.Windows.Forms.ComboBox cbbCreationCommandeClient;
        private System.Windows.Forms.TextBox txtbCreationCommandeId;
        private System.Windows.Forms.Label lblCreationCommandeId;
        private System.Windows.Forms.Label lblCreationCommandeDate;
        private System.Windows.Forms.Label lblCreationCommandeClient;
        private System.Windows.Forms.Button btnCreationCommandeValider;
        private System.Windows.Forms.DataGridView dgvListeCom;
        private System.Windows.Forms.Label lblTitreTabPComande;
        private System.Windows.Forms.ErrorProvider erpCreationCommande;
        private System.Windows.Forms.Label lblExeptionCreationCmd;
        private System.Windows.Forms.Button btnCloseMenueClient;
        private System.Windows.Forms.Button btnGererCommande;
        private System.Windows.Forms.Button btnCreerCommande;
    }
}