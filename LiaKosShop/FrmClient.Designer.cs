namespace LiaKosShop
{
    partial class FrmClient
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
            this.btnCloseMenueClient = new System.Windows.Forms.Button();
            this.btnGererClient = new System.Windows.Forms.Button();
            this.btnCrerClient = new System.Windows.Forms.Button();
            this.lblTitreTabPClient = new System.Windows.Forms.Label();
            this.dgvListeClient = new System.Windows.Forms.DataGridView();
            this.gpbModifierClient = new System.Windows.Forms.GroupBox();
            this.txtbGestionClientPermission = new System.Windows.Forms.TextBox();
            this.lblModifUtilisateurPermission = new System.Windows.Forms.Label();
            this.txtbGestionClientLogin = new System.Windows.Forms.TextBox();
            this.lblModifUtilisateurLogin = new System.Windows.Forms.Label();
            this.txtbGestionClientPass = new System.Windows.Forms.TextBox();
            this.lblModifUtilisateurPass = new System.Windows.Forms.Label();
            this.btnGestionClientSupprimer = new System.Windows.Forms.Button();
            this.cbbModifClient = new System.Windows.Forms.ComboBox();
            this.txtbGestionClientId = new System.Windows.Forms.TextBox();
            this.lblModifUtilisateurID = new System.Windows.Forms.Label();
            this.lblModifUtilisateurEmail = new System.Windows.Forms.Label();
            this.lblModifUtilisateurTel = new System.Windows.Forms.Label();
            this.lblModifUtilisateurVille = new System.Windows.Forms.Label();
            this.lblModifUtilisateurCp = new System.Windows.Forms.Label();
            this.lblModifUtilisateurRue = new System.Windows.Forms.Label();
            this.lblModifUtilisateurPrenom = new System.Windows.Forms.Label();
            this.lblModifUtilisateurNom = new System.Windows.Forms.Label();
            this.txtbGestionClientEmail = new System.Windows.Forms.TextBox();
            this.txtbGestionClientTel = new System.Windows.Forms.TextBox();
            this.txtbGestionClientVille = new System.Windows.Forms.TextBox();
            this.txtbGestionClientCP = new System.Windows.Forms.TextBox();
            this.txtbGestionClientRue = new System.Windows.Forms.TextBox();
            this.txtbGestionClientPrenom = new System.Windows.Forms.TextBox();
            this.txtbGestionClientNom = new System.Windows.Forms.TextBox();
            this.btnModifierClientValider = new System.Windows.Forms.Button();
            this.gpbCrerClient = new System.Windows.Forms.GroupBox();
            this.txtbCreationClientPermission = new System.Windows.Forms.TextBox();
            this.lblCreationClientPermission = new System.Windows.Forms.Label();
            this.txtbCreationClientLogin = new System.Windows.Forms.TextBox();
            this.lblCreationClientLogin = new System.Windows.Forms.Label();
            this.txtbCreationClientPass = new System.Windows.Forms.TextBox();
            this.lblCreationClientPass = new System.Windows.Forms.Label();
            this.txtbCreationClientId = new System.Windows.Forms.TextBox();
            this.lblCreationClientId = new System.Windows.Forms.Label();
            this.lblCreationClientEmail = new System.Windows.Forms.Label();
            this.lblCreationClientTel = new System.Windows.Forms.Label();
            this.lblCreationClientVille = new System.Windows.Forms.Label();
            this.lblCreationClientCP = new System.Windows.Forms.Label();
            this.lblCreationClientRue = new System.Windows.Forms.Label();
            this.lblCreationClientPrenom = new System.Windows.Forms.Label();
            this.lblCreationClientNom = new System.Windows.Forms.Label();
            this.txtbCreationClientEmail = new System.Windows.Forms.TextBox();
            this.txtbCreationClientTel = new System.Windows.Forms.TextBox();
            this.txtbCreationClientVille = new System.Windows.Forms.TextBox();
            this.txtbCreationClientCP = new System.Windows.Forms.TextBox();
            this.txtbCreationClientRue = new System.Windows.Forms.TextBox();
            this.txtbCreationClientPrenom = new System.Windows.Forms.TextBox();
            this.txtbCreationClientNom = new System.Windows.Forms.TextBox();
            this.btnCreationClientValider = new System.Windows.Forms.Button();
            this.errorpClientModif1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClientRecherche = new System.Windows.Forms.Button();
            this.txtbClientRecherche = new ReaLTaiizor.Controls.HopeTextBox();
            this.panelMenuRechercheClient = new ReaLTaiizor.Controls.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClient)).BeginInit();
            this.gpbModifierClient.SuspendLayout();
            this.gpbCrerClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorpClientModif1)).BeginInit();
            this.panelMenuRechercheClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseMenueClient
            // 
            this.btnCloseMenueClient.Location = new System.Drawing.Point(97, 51);
            this.btnCloseMenueClient.Name = "btnCloseMenueClient";
            this.btnCloseMenueClient.Size = new System.Drawing.Size(63, 23);
            this.btnCloseMenueClient.TabIndex = 1;
            this.btnCloseMenueClient.Text = "X";
            this.btnCloseMenueClient.UseVisualStyleBackColor = true;
            this.btnCloseMenueClient.Click += new System.EventHandler(this.btnCloseMenueClient_Click);
            // 
            // btnGererClient
            // 
            this.btnGererClient.Location = new System.Drawing.Point(1230, 369);
            this.btnGererClient.Name = "btnGererClient";
            this.btnGererClient.Size = new System.Drawing.Size(168, 36);
            this.btnGererClient.TabIndex = 20;
            this.btnGererClient.Text = "Modifier";
            this.btnGererClient.UseVisualStyleBackColor = true;
            this.btnGererClient.Click += new System.EventHandler(this.btnGererClient_Click);
            // 
            // btnCrerClient
            // 
            this.btnCrerClient.Location = new System.Drawing.Point(1230, 310);
            this.btnCrerClient.Name = "btnCrerClient";
            this.btnCrerClient.Size = new System.Drawing.Size(168, 36);
            this.btnCrerClient.TabIndex = 19;
            this.btnCrerClient.Text = "Créer";
            this.btnCrerClient.UseVisualStyleBackColor = true;
            this.btnCrerClient.Click += new System.EventHandler(this.btnCrerClient_Click);
            // 
            // lblTitreTabPClient
            // 
            this.lblTitreTabPClient.AutoSize = true;
            this.lblTitreTabPClient.Font = new System.Drawing.Font("Noto Naskh Arabic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreTabPClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.lblTitreTabPClient.Location = new System.Drawing.Point(655, 9);
            this.lblTitreTabPClient.Name = "lblTitreTabPClient";
            this.lblTitreTabPClient.Size = new System.Drawing.Size(123, 65);
            this.lblTitreTabPClient.TabIndex = 18;
            this.lblTitreTabPClient.Text = "Client";
            // 
            // dgvListeClient
            // 
            this.dgvListeClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeClient.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvListeClient.Location = new System.Drawing.Point(97, 159);
            this.dgvListeClient.Name = "dgvListeClient";
            this.dgvListeClient.Size = new System.Drawing.Size(1080, 301);
            this.dgvListeClient.TabIndex = 17;
            // 
            // gpbModifierClient
            // 
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientPermission);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurPermission);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientLogin);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurLogin);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientPass);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurPass);
            this.gpbModifierClient.Controls.Add(this.btnGestionClientSupprimer);
            this.gpbModifierClient.Controls.Add(this.cbbModifClient);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientId);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurID);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurEmail);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurTel);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurVille);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurCp);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurRue);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurPrenom);
            this.gpbModifierClient.Controls.Add(this.lblModifUtilisateurNom);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientEmail);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientTel);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientVille);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientCP);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientRue);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientPrenom);
            this.gpbModifierClient.Controls.Add(this.txtbGestionClientNom);
            this.gpbModifierClient.Controls.Add(this.btnModifierClientValider);
            this.gpbModifierClient.Enabled = false;
            this.gpbModifierClient.Location = new System.Drawing.Point(26, 485);
            this.gpbModifierClient.Name = "gpbModifierClient";
            this.gpbModifierClient.Size = new System.Drawing.Size(1298, 376);
            this.gpbModifierClient.TabIndex = 26;
            this.gpbModifierClient.TabStop = false;
            this.gpbModifierClient.Text = "Modif";
            this.gpbModifierClient.Visible = false;
            // 
            // txtbGestionClientPermission
            // 
            this.txtbGestionClientPermission.Location = new System.Drawing.Point(186, 176);
            this.txtbGestionClientPermission.Name = "txtbGestionClientPermission";
            this.txtbGestionClientPermission.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientPermission.TabIndex = 41;
            // 
            // lblModifUtilisateurPermission
            // 
            this.lblModifUtilisateurPermission.AutoSize = true;
            this.lblModifUtilisateurPermission.Location = new System.Drawing.Point(120, 179);
            this.lblModifUtilisateurPermission.Name = "lblModifUtilisateurPermission";
            this.lblModifUtilisateurPermission.Size = new System.Drawing.Size(60, 13);
            this.lblModifUtilisateurPermission.TabIndex = 40;
            this.lblModifUtilisateurPermission.Text = "Permission:";
            // 
            // txtbGestionClientLogin
            // 
            this.txtbGestionClientLogin.Enabled = false;
            this.txtbGestionClientLogin.Location = new System.Drawing.Point(439, 176);
            this.txtbGestionClientLogin.Name = "txtbGestionClientLogin";
            this.txtbGestionClientLogin.ReadOnly = true;
            this.txtbGestionClientLogin.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientLogin.TabIndex = 39;
            // 
            // lblModifUtilisateurLogin
            // 
            this.lblModifUtilisateurLogin.AutoSize = true;
            this.lblModifUtilisateurLogin.Location = new System.Drawing.Point(396, 179);
            this.lblModifUtilisateurLogin.Name = "lblModifUtilisateurLogin";
            this.lblModifUtilisateurLogin.Size = new System.Drawing.Size(36, 13);
            this.lblModifUtilisateurLogin.TabIndex = 38;
            this.lblModifUtilisateurLogin.Text = "Login:";
            // 
            // txtbGestionClientPass
            // 
            this.txtbGestionClientPass.Location = new System.Drawing.Point(740, 176);
            this.txtbGestionClientPass.Name = "txtbGestionClientPass";
            this.txtbGestionClientPass.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientPass.TabIndex = 37;
            this.txtbGestionClientPass.UseSystemPasswordChar = true;
            // 
            // lblModifUtilisateurPass
            // 
            this.lblModifUtilisateurPass.AutoSize = true;
            this.lblModifUtilisateurPass.Location = new System.Drawing.Point(660, 179);
            this.lblModifUtilisateurPass.Name = "lblModifUtilisateurPass";
            this.lblModifUtilisateurPass.Size = new System.Drawing.Size(80, 13);
            this.lblModifUtilisateurPass.TabIndex = 36;
            this.lblModifUtilisateurPass.Text = "Mots de Passe:";
            // 
            // btnGestionClientSupprimer
            // 
            this.btnGestionClientSupprimer.Location = new System.Drawing.Point(1019, 243);
            this.btnGestionClientSupprimer.Name = "btnGestionClientSupprimer";
            this.btnGestionClientSupprimer.Size = new System.Drawing.Size(156, 34);
            this.btnGestionClientSupprimer.TabIndex = 35;
            this.btnGestionClientSupprimer.Text = "Supprimer";
            this.btnGestionClientSupprimer.UseVisualStyleBackColor = true;
            this.btnGestionClientSupprimer.Click += new System.EventHandler(this.btnGestionClientSupprimer_Click);
            // 
            // cbbModifClient
            // 
            this.cbbModifClient.FormattingEnabled = true;
            this.cbbModifClient.Location = new System.Drawing.Point(637, 38);
            this.cbbModifClient.Name = "cbbModifClient";
            this.cbbModifClient.Size = new System.Drawing.Size(232, 21);
            this.cbbModifClient.TabIndex = 34;
            this.cbbModifClient.SelectedIndexChanged += new System.EventHandler(this.cbbModifClient_SelectedIndexChanged);
            // 
            // txtbGestionClientId
            // 
            this.txtbGestionClientId.Enabled = false;
            this.txtbGestionClientId.Location = new System.Drawing.Point(36, 176);
            this.txtbGestionClientId.Name = "txtbGestionClientId";
            this.txtbGestionClientId.Size = new System.Drawing.Size(65, 20);
            this.txtbGestionClientId.TabIndex = 33;
            // 
            // lblModifUtilisateurID
            // 
            this.lblModifUtilisateurID.AutoSize = true;
            this.lblModifUtilisateurID.Location = new System.Drawing.Point(11, 179);
            this.lblModifUtilisateurID.Name = "lblModifUtilisateurID";
            this.lblModifUtilisateurID.Size = new System.Drawing.Size(19, 13);
            this.lblModifUtilisateurID.TabIndex = 32;
            this.lblModifUtilisateurID.Text = "Id:";
            // 
            // lblModifUtilisateurEmail
            // 
            this.lblModifUtilisateurEmail.AutoSize = true;
            this.lblModifUtilisateurEmail.Location = new System.Drawing.Point(977, 133);
            this.lblModifUtilisateurEmail.Name = "lblModifUtilisateurEmail";
            this.lblModifUtilisateurEmail.Size = new System.Drawing.Size(35, 13);
            this.lblModifUtilisateurEmail.TabIndex = 31;
            this.lblModifUtilisateurEmail.Text = "Email:";
            // 
            // lblModifUtilisateurTel
            // 
            this.lblModifUtilisateurTel.AutoSize = true;
            this.lblModifUtilisateurTel.Location = new System.Drawing.Point(623, 254);
            this.lblModifUtilisateurTel.Name = "lblModifUtilisateurTel";
            this.lblModifUtilisateurTel.Size = new System.Drawing.Size(116, 13);
            this.lblModifUtilisateurTel.TabIndex = 30;
            this.lblModifUtilisateurTel.Text = "Numéro de Téléphone:";
            // 
            // lblModifUtilisateurVille
            // 
            this.lblModifUtilisateurVille.AutoSize = true;
            this.lblModifUtilisateurVille.Location = new System.Drawing.Point(403, 254);
            this.lblModifUtilisateurVille.Name = "lblModifUtilisateurVille";
            this.lblModifUtilisateurVille.Size = new System.Drawing.Size(29, 13);
            this.lblModifUtilisateurVille.TabIndex = 29;
            this.lblModifUtilisateurVille.Text = "Ville:";
            // 
            // lblModifUtilisateurCp
            // 
            this.lblModifUtilisateurCp.AutoSize = true;
            this.lblModifUtilisateurCp.Location = new System.Drawing.Point(368, 133);
            this.lblModifUtilisateurCp.Name = "lblModifUtilisateurCp";
            this.lblModifUtilisateurCp.Size = new System.Drawing.Size(67, 13);
            this.lblModifUtilisateurCp.TabIndex = 28;
            this.lblModifUtilisateurCp.Text = "Code Postal:";
            // 
            // lblModifUtilisateurRue
            // 
            this.lblModifUtilisateurRue.AutoSize = true;
            this.lblModifUtilisateurRue.Location = new System.Drawing.Point(706, 133);
            this.lblModifUtilisateurRue.Name = "lblModifUtilisateurRue";
            this.lblModifUtilisateurRue.Size = new System.Drawing.Size(30, 13);
            this.lblModifUtilisateurRue.TabIndex = 27;
            this.lblModifUtilisateurRue.Text = "Rue:";
            // 
            // lblModifUtilisateurPrenom
            // 
            this.lblModifUtilisateurPrenom.AutoSize = true;
            this.lblModifUtilisateurPrenom.Location = new System.Drawing.Point(134, 254);
            this.lblModifUtilisateurPrenom.Name = "lblModifUtilisateurPrenom";
            this.lblModifUtilisateurPrenom.Size = new System.Drawing.Size(46, 13);
            this.lblModifUtilisateurPrenom.TabIndex = 26;
            this.lblModifUtilisateurPrenom.Text = "Prenom:";
            // 
            // lblModifUtilisateurNom
            // 
            this.lblModifUtilisateurNom.AutoSize = true;
            this.lblModifUtilisateurNom.Location = new System.Drawing.Point(148, 133);
            this.lblModifUtilisateurNom.Name = "lblModifUtilisateurNom";
            this.lblModifUtilisateurNom.Size = new System.Drawing.Size(32, 13);
            this.lblModifUtilisateurNom.TabIndex = 25;
            this.lblModifUtilisateurNom.Text = "Nom:";
            // 
            // txtbGestionClientEmail
            // 
            this.txtbGestionClientEmail.Enabled = false;
            this.txtbGestionClientEmail.Location = new System.Drawing.Point(1019, 130);
            this.txtbGestionClientEmail.Name = "txtbGestionClientEmail";
            this.txtbGestionClientEmail.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientEmail.TabIndex = 24;
            // 
            // txtbGestionClientTel
            // 
            this.txtbGestionClientTel.Enabled = false;
            this.txtbGestionClientTel.Location = new System.Drawing.Point(740, 251);
            this.txtbGestionClientTel.Name = "txtbGestionClientTel";
            this.txtbGestionClientTel.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientTel.TabIndex = 23;
            // 
            // txtbGestionClientVille
            // 
            this.txtbGestionClientVille.Enabled = false;
            this.txtbGestionClientVille.Location = new System.Drawing.Point(439, 251);
            this.txtbGestionClientVille.Name = "txtbGestionClientVille";
            this.txtbGestionClientVille.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientVille.TabIndex = 22;
            // 
            // txtbGestionClientCP
            // 
            this.txtbGestionClientCP.Enabled = false;
            this.txtbGestionClientCP.Location = new System.Drawing.Point(439, 130);
            this.txtbGestionClientCP.Name = "txtbGestionClientCP";
            this.txtbGestionClientCP.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientCP.TabIndex = 21;
            // 
            // txtbGestionClientRue
            // 
            this.txtbGestionClientRue.Enabled = false;
            this.txtbGestionClientRue.Location = new System.Drawing.Point(740, 130);
            this.txtbGestionClientRue.Name = "txtbGestionClientRue";
            this.txtbGestionClientRue.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientRue.TabIndex = 20;
            // 
            // txtbGestionClientPrenom
            // 
            this.txtbGestionClientPrenom.Enabled = false;
            this.txtbGestionClientPrenom.Location = new System.Drawing.Point(186, 251);
            this.txtbGestionClientPrenom.Name = "txtbGestionClientPrenom";
            this.txtbGestionClientPrenom.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientPrenom.TabIndex = 19;
            // 
            // txtbGestionClientNom
            // 
            this.txtbGestionClientNom.Enabled = false;
            this.txtbGestionClientNom.Location = new System.Drawing.Point(186, 130);
            this.txtbGestionClientNom.Name = "txtbGestionClientNom";
            this.txtbGestionClientNom.Size = new System.Drawing.Size(156, 20);
            this.txtbGestionClientNom.TabIndex = 18;
            // 
            // btnModifierClientValider
            // 
            this.btnModifierClientValider.Location = new System.Drawing.Point(1019, 196);
            this.btnModifierClientValider.Name = "btnModifierClientValider";
            this.btnModifierClientValider.Size = new System.Drawing.Size(156, 34);
            this.btnModifierClientValider.TabIndex = 0;
            this.btnModifierClientValider.Text = "Valider";
            this.btnModifierClientValider.UseVisualStyleBackColor = true;
            this.btnModifierClientValider.Click += new System.EventHandler(this.btnModifierClientValider_Click);
            // 
            // gpbCrerClient
            // 
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientPermission);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientPermission);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientLogin);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientLogin);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientPass);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientPass);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientId);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientId);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientEmail);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientTel);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientVille);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientCP);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientRue);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientPrenom);
            this.gpbCrerClient.Controls.Add(this.lblCreationClientNom);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientEmail);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientTel);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientVille);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientCP);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientRue);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientPrenom);
            this.gpbCrerClient.Controls.Add(this.txtbCreationClientNom);
            this.gpbCrerClient.Controls.Add(this.btnCreationClientValider);
            this.gpbCrerClient.Enabled = false;
            this.gpbCrerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCrerClient.Location = new System.Drawing.Point(26, 485);
            this.gpbCrerClient.Name = "gpbCrerClient";
            this.gpbCrerClient.Size = new System.Drawing.Size(1317, 376);
            this.gpbCrerClient.TabIndex = 25;
            this.gpbCrerClient.TabStop = false;
            this.gpbCrerClient.Text = "Créer";
            this.gpbCrerClient.Visible = false;
            // 
            // txtbCreationClientPermission
            // 
            this.txtbCreationClientPermission.Location = new System.Drawing.Point(192, 169);
            this.txtbCreationClientPermission.Name = "txtbCreationClientPermission";
            this.txtbCreationClientPermission.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientPermission.TabIndex = 49;
            // 
            // lblCreationClientPermission
            // 
            this.lblCreationClientPermission.AutoSize = true;
            this.lblCreationClientPermission.Location = new System.Drawing.Point(115, 172);
            this.lblCreationClientPermission.Name = "lblCreationClientPermission";
            this.lblCreationClientPermission.Size = new System.Drawing.Size(71, 13);
            this.lblCreationClientPermission.TabIndex = 48;
            this.lblCreationClientPermission.Text = "Permission:";
            // 
            // txtbCreationClientLogin
            // 
            this.txtbCreationClientLogin.Enabled = false;
            this.txtbCreationClientLogin.Location = new System.Drawing.Point(449, 169);
            this.txtbCreationClientLogin.Name = "txtbCreationClientLogin";
            this.txtbCreationClientLogin.ReadOnly = true;
            this.txtbCreationClientLogin.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientLogin.TabIndex = 47;
            // 
            // lblCreationClientLogin
            // 
            this.lblCreationClientLogin.AutoSize = true;
            this.lblCreationClientLogin.Location = new System.Drawing.Point(402, 172);
            this.lblCreationClientLogin.Name = "lblCreationClientLogin";
            this.lblCreationClientLogin.Size = new System.Drawing.Size(42, 13);
            this.lblCreationClientLogin.TabIndex = 46;
            this.lblCreationClientLogin.Text = "Login:";
            // 
            // txtbCreationClientPass
            // 
            this.txtbCreationClientPass.Location = new System.Drawing.Point(740, 169);
            this.txtbCreationClientPass.Name = "txtbCreationClientPass";
            this.txtbCreationClientPass.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientPass.TabIndex = 45;
            this.txtbCreationClientPass.UseSystemPasswordChar = true;
            // 
            // lblCreationClientPass
            // 
            this.lblCreationClientPass.AutoSize = true;
            this.lblCreationClientPass.Location = new System.Drawing.Point(646, 172);
            this.lblCreationClientPass.Name = "lblCreationClientPass";
            this.lblCreationClientPass.Size = new System.Drawing.Size(94, 13);
            this.lblCreationClientPass.TabIndex = 44;
            this.lblCreationClientPass.Text = "Mots de Passe:";
            // 
            // txtbCreationClientId
            // 
            this.txtbCreationClientId.Enabled = false;
            this.txtbCreationClientId.Location = new System.Drawing.Point(42, 169);
            this.txtbCreationClientId.Name = "txtbCreationClientId";
            this.txtbCreationClientId.Size = new System.Drawing.Size(65, 20);
            this.txtbCreationClientId.TabIndex = 43;
            // 
            // lblCreationClientId
            // 
            this.lblCreationClientId.AutoSize = true;
            this.lblCreationClientId.Location = new System.Drawing.Point(17, 172);
            this.lblCreationClientId.Name = "lblCreationClientId";
            this.lblCreationClientId.Size = new System.Drawing.Size(22, 13);
            this.lblCreationClientId.TabIndex = 42;
            this.lblCreationClientId.Text = "Id:";
            // 
            // lblCreationClientEmail
            // 
            this.lblCreationClientEmail.AutoSize = true;
            this.lblCreationClientEmail.Location = new System.Drawing.Point(977, 119);
            this.lblCreationClientEmail.Name = "lblCreationClientEmail";
            this.lblCreationClientEmail.Size = new System.Drawing.Size(41, 13);
            this.lblCreationClientEmail.TabIndex = 14;
            this.lblCreationClientEmail.Text = "Email:";
            // 
            // lblCreationClientTel
            // 
            this.lblCreationClientTel.AutoSize = true;
            this.lblCreationClientTel.Location = new System.Drawing.Point(623, 240);
            this.lblCreationClientTel.Name = "lblCreationClientTel";
            this.lblCreationClientTel.Size = new System.Drawing.Size(136, 13);
            this.lblCreationClientTel.TabIndex = 13;
            this.lblCreationClientTel.Text = "Numéro de Téléphone:";
            // 
            // lblCreationClientVille
            // 
            this.lblCreationClientVille.AutoSize = true;
            this.lblCreationClientVille.Location = new System.Drawing.Point(409, 240);
            this.lblCreationClientVille.Name = "lblCreationClientVille";
            this.lblCreationClientVille.Size = new System.Drawing.Size(35, 13);
            this.lblCreationClientVille.TabIndex = 12;
            this.lblCreationClientVille.Text = "Ville:";
            // 
            // lblCreationClientCP
            // 
            this.lblCreationClientCP.AutoSize = true;
            this.lblCreationClientCP.Location = new System.Drawing.Point(368, 119);
            this.lblCreationClientCP.Name = "lblCreationClientCP";
            this.lblCreationClientCP.Size = new System.Drawing.Size(79, 13);
            this.lblCreationClientCP.TabIndex = 11;
            this.lblCreationClientCP.Text = "Code Postal:";
            // 
            // lblCreationClientRue
            // 
            this.lblCreationClientRue.AutoSize = true;
            this.lblCreationClientRue.Location = new System.Drawing.Point(706, 119);
            this.lblCreationClientRue.Name = "lblCreationClientRue";
            this.lblCreationClientRue.Size = new System.Drawing.Size(34, 13);
            this.lblCreationClientRue.TabIndex = 10;
            this.lblCreationClientRue.Text = "Rue:";
            // 
            // lblCreationClientPrenom
            // 
            this.lblCreationClientPrenom.AutoSize = true;
            this.lblCreationClientPrenom.Location = new System.Drawing.Point(131, 237);
            this.lblCreationClientPrenom.Name = "lblCreationClientPrenom";
            this.lblCreationClientPrenom.Size = new System.Drawing.Size(53, 13);
            this.lblCreationClientPrenom.TabIndex = 9;
            this.lblCreationClientPrenom.Text = "Prenom:";
            // 
            // lblCreationClientNom
            // 
            this.lblCreationClientNom.AutoSize = true;
            this.lblCreationClientNom.Location = new System.Drawing.Point(148, 119);
            this.lblCreationClientNom.Name = "lblCreationClientNom";
            this.lblCreationClientNom.Size = new System.Drawing.Size(36, 13);
            this.lblCreationClientNom.TabIndex = 8;
            this.lblCreationClientNom.Text = "Nom:";
            // 
            // txtbCreationClientEmail
            // 
            this.txtbCreationClientEmail.Location = new System.Drawing.Point(1019, 116);
            this.txtbCreationClientEmail.Name = "txtbCreationClientEmail";
            this.txtbCreationClientEmail.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientEmail.TabIndex = 7;
            // 
            // txtbCreationClientTel
            // 
            this.txtbCreationClientTel.Location = new System.Drawing.Point(765, 237);
            this.txtbCreationClientTel.Name = "txtbCreationClientTel";
            this.txtbCreationClientTel.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientTel.TabIndex = 6;
            // 
            // txtbCreationClientVille
            // 
            this.txtbCreationClientVille.Location = new System.Drawing.Point(449, 237);
            this.txtbCreationClientVille.Name = "txtbCreationClientVille";
            this.txtbCreationClientVille.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientVille.TabIndex = 5;
            // 
            // txtbCreationClientCP
            // 
            this.txtbCreationClientCP.Location = new System.Drawing.Point(449, 116);
            this.txtbCreationClientCP.Name = "txtbCreationClientCP";
            this.txtbCreationClientCP.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientCP.TabIndex = 4;
            // 
            // txtbCreationClientRue
            // 
            this.txtbCreationClientRue.Location = new System.Drawing.Point(740, 116);
            this.txtbCreationClientRue.Name = "txtbCreationClientRue";
            this.txtbCreationClientRue.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientRue.TabIndex = 3;
            // 
            // txtbCreationClientPrenom
            // 
            this.txtbCreationClientPrenom.Location = new System.Drawing.Point(192, 237);
            this.txtbCreationClientPrenom.Name = "txtbCreationClientPrenom";
            this.txtbCreationClientPrenom.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientPrenom.TabIndex = 2;
            // 
            // txtbCreationClientNom
            // 
            this.txtbCreationClientNom.Location = new System.Drawing.Point(186, 116);
            this.txtbCreationClientNom.Name = "txtbCreationClientNom";
            this.txtbCreationClientNom.Size = new System.Drawing.Size(156, 20);
            this.txtbCreationClientNom.TabIndex = 1;
            // 
            // btnCreationClientValider
            // 
            this.btnCreationClientValider.Location = new System.Drawing.Point(1019, 182);
            this.btnCreationClientValider.Name = "btnCreationClientValider";
            this.btnCreationClientValider.Size = new System.Drawing.Size(156, 34);
            this.btnCreationClientValider.TabIndex = 0;
            this.btnCreationClientValider.Text = "Valider";
            this.btnCreationClientValider.UseVisualStyleBackColor = true;
            this.btnCreationClientValider.Click += new System.EventHandler(this.btnCreationClientValider_Click);
            // 
            // errorpClientModif1
            // 
            this.errorpClientModif1.ContainerControl = this;
            // 
            // btnClientRecherche
            // 
            this.btnClientRecherche.BackColor = System.Drawing.Color.Silver;
            this.btnClientRecherche.FlatAppearance.BorderSize = 0;
            this.btnClientRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientRecherche.Location = new System.Drawing.Point(606, 5);
            this.btnClientRecherche.Name = "btnClientRecherche";
            this.btnClientRecherche.Size = new System.Drawing.Size(73, 39);
            this.btnClientRecherche.TabIndex = 23;
            this.btnClientRecherche.Text = "Recherche";
            this.btnClientRecherche.UseVisualStyleBackColor = false;
            this.btnClientRecherche.Click += new System.EventHandler(this.btnClientRecherche_Click);
            // 
            // txtbClientRecherche
            // 
            this.txtbClientRecherche.BackColor = System.Drawing.Color.Silver;
            this.txtbClientRecherche.BaseColor = System.Drawing.Color.Transparent;
            this.txtbClientRecherche.BorderColorA = System.Drawing.Color.Transparent;
            this.txtbClientRecherche.BorderColorB = System.Drawing.Color.Transparent;
            this.txtbClientRecherche.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbClientRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtbClientRecherche.Hint = "";
            this.txtbClientRecherche.Location = new System.Drawing.Point(156, 8);
            this.txtbClientRecherche.MaxLength = 32767;
            this.txtbClientRecherche.Multiline = false;
            this.txtbClientRecherche.Name = "txtbClientRecherche";
            this.txtbClientRecherche.PasswordChar = '\0';
            this.txtbClientRecherche.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbClientRecherche.SelectedText = "";
            this.txtbClientRecherche.SelectionLength = 0;
            this.txtbClientRecherche.SelectionStart = 0;
            this.txtbClientRecherche.Size = new System.Drawing.Size(390, 38);
            this.txtbClientRecherche.TabIndex = 25;
            this.txtbClientRecherche.TabStop = false;
            this.txtbClientRecherche.Text = "Recherche...";
            this.txtbClientRecherche.UseSystemPasswordChar = false;
            // 
            // panelMenuRechercheClient
            // 
            this.panelMenuRechercheClient.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenuRechercheClient.Controls.Add(this.txtbClientRecherche);
            this.panelMenuRechercheClient.Controls.Add(this.btnClientRecherche);
            this.panelMenuRechercheClient.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panelMenuRechercheClient.Location = new System.Drawing.Point(97, 101);
            this.panelMenuRechercheClient.Name = "panelMenuRechercheClient";
            this.panelMenuRechercheClient.Padding = new System.Windows.Forms.Padding(5);
            this.panelMenuRechercheClient.Size = new System.Drawing.Size(1080, 52);
            this.panelMenuRechercheClient.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelMenuRechercheClient.TabIndex = 28;
            this.panelMenuRechercheClient.Text = "panel1";
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(716, 238);
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1637, 1024);
            this.Controls.Add(this.panelMenuRechercheClient);
            this.Controls.Add(this.gpbCrerClient);
            this.Controls.Add(this.gpbModifierClient);
            this.Controls.Add(this.btnGererClient);
            this.Controls.Add(this.btnCrerClient);
            this.Controls.Add(this.lblTitreTabPClient);
            this.Controls.Add(this.dgvListeClient);
            this.Controls.Add(this.btnCloseMenueClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClient";
            this.Text = "Administration Client";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.FrmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClient)).EndInit();
            this.gpbModifierClient.ResumeLayout(false);
            this.gpbModifierClient.PerformLayout();
            this.gpbCrerClient.ResumeLayout(false);
            this.gpbCrerClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorpClientModif1)).EndInit();
            this.panelMenuRechercheClient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseMenueClient;
        private System.Windows.Forms.Button btnGererClient;
        private System.Windows.Forms.Button btnCrerClient;
        private System.Windows.Forms.Label lblTitreTabPClient;
        private System.Windows.Forms.DataGridView dgvListeClient;
        private System.Windows.Forms.GroupBox gpbModifierClient;
        private System.Windows.Forms.TextBox txtbGestionClientPermission;
        private System.Windows.Forms.Label lblModifUtilisateurPermission;
        private System.Windows.Forms.TextBox txtbGestionClientLogin;
        private System.Windows.Forms.Label lblModifUtilisateurLogin;
        private System.Windows.Forms.TextBox txtbGestionClientPass;
        private System.Windows.Forms.Label lblModifUtilisateurPass;
        private System.Windows.Forms.Button btnGestionClientSupprimer;
        private System.Windows.Forms.ComboBox cbbModifClient;
        private System.Windows.Forms.TextBox txtbGestionClientId;
        private System.Windows.Forms.Label lblModifUtilisateurID;
        private System.Windows.Forms.Label lblModifUtilisateurEmail;
        private System.Windows.Forms.Label lblModifUtilisateurTel;
        private System.Windows.Forms.Label lblModifUtilisateurVille;
        private System.Windows.Forms.Label lblModifUtilisateurCp;
        private System.Windows.Forms.Label lblModifUtilisateurRue;
        private System.Windows.Forms.Label lblModifUtilisateurPrenom;
        private System.Windows.Forms.Label lblModifUtilisateurNom;
        private System.Windows.Forms.TextBox txtbGestionClientEmail;
        private System.Windows.Forms.TextBox txtbGestionClientTel;
        private System.Windows.Forms.TextBox txtbGestionClientVille;
        private System.Windows.Forms.TextBox txtbGestionClientCP;
        private System.Windows.Forms.TextBox txtbGestionClientRue;
        private System.Windows.Forms.TextBox txtbGestionClientPrenom;
        private System.Windows.Forms.TextBox txtbGestionClientNom;
        private System.Windows.Forms.Button btnModifierClientValider;
        private System.Windows.Forms.GroupBox gpbCrerClient;
        private System.Windows.Forms.TextBox txtbCreationClientPermission;
        private System.Windows.Forms.Label lblCreationClientPermission;
        private System.Windows.Forms.TextBox txtbCreationClientLogin;
        private System.Windows.Forms.Label lblCreationClientLogin;
        private System.Windows.Forms.Label lblCreationClientPass;
        private System.Windows.Forms.TextBox txtbCreationClientId;
        private System.Windows.Forms.Label lblCreationClientId;
        private System.Windows.Forms.Label lblCreationClientEmail;
        private System.Windows.Forms.Label lblCreationClientTel;
        private System.Windows.Forms.Label lblCreationClientVille;
        private System.Windows.Forms.Label lblCreationClientCP;
        private System.Windows.Forms.Label lblCreationClientRue;
        private System.Windows.Forms.Label lblCreationClientPrenom;
        private System.Windows.Forms.Label lblCreationClientNom;
        private System.Windows.Forms.TextBox txtbCreationClientEmail;
        private System.Windows.Forms.TextBox txtbCreationClientTel;
        private System.Windows.Forms.TextBox txtbCreationClientVille;
        private System.Windows.Forms.TextBox txtbCreationClientCP;
        private System.Windows.Forms.TextBox txtbCreationClientRue;
        private System.Windows.Forms.TextBox txtbCreationClientPrenom;
        private System.Windows.Forms.TextBox txtbCreationClientNom;
        private System.Windows.Forms.Button btnCreationClientValider;
        private System.Windows.Forms.ErrorProvider errorpClientModif1;
        public System.Windows.Forms.TextBox txtbCreationClientPass;
        private ReaLTaiizor.Controls.Panel panelMenuRechercheClient;
        private ReaLTaiizor.Controls.HopeTextBox txtbClientRecherche;
        private System.Windows.Forms.Button btnClientRecherche;
    }
}