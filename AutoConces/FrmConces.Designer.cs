
namespace AutoConces
{
    partial class FrmConces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConces));
            this.listViewBD = new System.Windows.Forms.ListView();
            this.idConces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodePostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblcri = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtaff = new System.Windows.Forms.TextBox();
            this.btnenvoyer = new System.Windows.Forms.Button();
            this.txtville = new System.Windows.Forms.TextBox();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtpren = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lblpren = new System.Windows.Forms.Label();
            this.lbladresse = new System.Windows.Forms.Label();
            this.lblcp = new System.Windows.Forms.Label();
            this.lblville = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btsuppr = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblnouvcons = new System.Windows.Forms.Label();
            this.lblsuppr = new System.Windows.Forms.Label();
            this.btnafct = new System.Windows.Forms.Button();
            this.panelSuppr = new System.Windows.Forms.Panel();
            this.panelAjouter = new System.Windows.Forms.Panel();
            this.panelSelection = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCritere = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panelmdp = new System.Windows.Forms.Panel();
            this.panelcreation = new System.Windows.Forms.Panel();
            this.btnconnection = new System.Windows.Forms.Button();
            this.lblmdpcreation = new System.Windows.Forms.Label();
            this.txtboxmdpcreation = new System.Windows.Forms.TextBox();
            this.lblidcreation = new System.Windows.Forms.Label();
            this.txtidcreation = new System.Windows.Forms.TextBox();
            this.btnseconnecter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxmdp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.panelSuppr.SuspendLayout();
            this.panelAjouter.SuspendLayout();
            this.panelSelection.SuspendLayout();
            this.panelmdp.SuspendLayout();
            this.panelcreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBD
            // 
            this.listViewBD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idConces,
            this.nom,
            this.prenom,
            this.Adresse,
            this.CodePostal,
            this.Ville});
            this.listViewBD.HideSelection = false;
            this.listViewBD.Location = new System.Drawing.Point(252, 84);
            this.listViewBD.Name = "listViewBD";
            this.listViewBD.Size = new System.Drawing.Size(607, 378);
            this.listViewBD.TabIndex = 0;
            this.listViewBD.UseCompatibleStateImageBehavior = false;
            this.listViewBD.View = System.Windows.Forms.View.Details;
           
            // 
            // idConces
            // 
            this.idConces.Tag = "";
            this.idConces.Text = "Id";
            this.idConces.Width = 77;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 85;
            // 
            // prenom
            // 
            this.prenom.Text = "Prenom";
            this.prenom.Width = 95;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 106;
            // 
            // CodePostal
            // 
            this.CodePostal.Text = "Code Postal";
            this.CodePostal.Width = 93;
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            this.Ville.Width = 315;
            // 
            // lblcri
            // 
            this.lblcri.AutoSize = true;
            this.lblcri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcri.ForeColor = System.Drawing.SystemColors.Info;
            this.lblcri.Location = new System.Drawing.Point(37, 70);
            this.lblcri.Name = "lblcri";
            this.lblcri.Size = new System.Drawing.Size(132, 13);
            this.lblcri.TabIndex = 1;
            this.lblcri.Text = "Sélectionner le critère";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ville",
            "Nom",
            "Code Postal"});
            this.comboBox1.Location = new System.Drawing.Point(188, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.UseWaitCursor = true;
            // 
            // txtaff
            // 
            this.txtaff.Location = new System.Drawing.Point(85, 110);
            this.txtaff.Name = "txtaff";
            this.txtaff.Size = new System.Drawing.Size(187, 20);
            this.txtaff.TabIndex = 3;
            // 
            // btnenvoyer
            // 
            this.btnenvoyer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnenvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnenvoyer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnenvoyer.Location = new System.Drawing.Point(120, 159);
            this.btnenvoyer.Name = "btnenvoyer";
            this.btnenvoyer.Size = new System.Drawing.Size(117, 39);
            this.btnenvoyer.TabIndex = 4;
            this.btnenvoyer.Text = "Envoyer";
            this.btnenvoyer.UseVisualStyleBackColor = false;
            this.btnenvoyer.Click += new System.EventHandler(this.btnenvoyer_Click);
            // 
            // txtville
            // 
            this.txtville.Location = new System.Drawing.Point(120, 222);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(187, 20);
            this.txtville.TabIndex = 5;
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(120, 184);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(187, 20);
            this.txtcp.TabIndex = 4;
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(120, 145);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(187, 20);
            this.txtadresse.TabIndex = 3;
            // 
            // txtpren
            // 
            this.txtpren.Location = new System.Drawing.Point(120, 106);
            this.txtpren.Name = "txtpren";
            this.txtpren.Size = new System.Drawing.Size(187, 20);
            this.txtpren.TabIndex = 2;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(120, 69);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(187, 20);
            this.txtnom.TabIndex = 1;
            // 
            // lblpren
            // 
            this.lblpren.AutoSize = true;
            this.lblpren.ForeColor = System.Drawing.SystemColors.Info;
            this.lblpren.Location = new System.Drawing.Point(62, 106);
            this.lblpren.Name = "lblpren";
            this.lblpren.Size = new System.Drawing.Size(52, 13);
            this.lblpren.TabIndex = 11;
            this.lblpren.Text = "Prénom : ";
            // 
            // lbladresse
            // 
            this.lbladresse.AutoSize = true;
            this.lbladresse.ForeColor = System.Drawing.SystemColors.Info;
            this.lbladresse.Location = new System.Drawing.Point(57, 145);
            this.lbladresse.Name = "lbladresse";
            this.lbladresse.Size = new System.Drawing.Size(51, 13);
            this.lbladresse.TabIndex = 12;
            this.lbladresse.Text = "Adresse :";
            // 
            // lblcp
            // 
            this.lblcp.AutoSize = true;
            this.lblcp.ForeColor = System.Drawing.SystemColors.Info;
            this.lblcp.Location = new System.Drawing.Point(41, 184);
            this.lblcp.Name = "lblcp";
            this.lblcp.Size = new System.Drawing.Size(73, 13);
            this.lblcp.TabIndex = 13;
            this.lblcp.Text = "Code Postal : ";
            // 
            // lblville
            // 
            this.lblville.AutoSize = true;
            this.lblville.ForeColor = System.Drawing.SystemColors.Info;
            this.lblville.Location = new System.Drawing.Point(79, 222);
            this.lblville.Name = "lblville";
            this.lblville.Size = new System.Drawing.Size(35, 13);
            this.lblville.TabIndex = 14;
            this.lblville.Text = "Ville : ";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.ForeColor = System.Drawing.SystemColors.Info;
            this.lblnom.Location = new System.Drawing.Point(76, 69);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(38, 13);
            this.lblnom.TabIndex = 15;
            this.lblnom.Text = "Nom : ";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btninsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btninsert.Location = new System.Drawing.Point(157, 275);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(117, 37);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Envoyer";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btsuppr
            // 
            this.btsuppr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btsuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btsuppr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btsuppr.Location = new System.Drawing.Point(97, 128);
            this.btsuppr.Name = "btsuppr";
            this.btsuppr.Size = new System.Drawing.Size(117, 37);
            this.btsuppr.TabIndex = 19;
            this.btsuppr.Text = "Supprimer";
            this.btsuppr.UseVisualStyleBackColor = false;
            this.btsuppr.Click += new System.EventHandler(this.btsuppr_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(76, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(187, 20);
            this.txtId.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.Info;
            this.lblId.Location = new System.Drawing.Point(45, 81);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 13);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Id : ";
            // 
            // lblnouvcons
            // 
            this.lblnouvcons.AutoSize = true;
            this.lblnouvcons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnouvcons.ForeColor = System.Drawing.SystemColors.Info;
            this.lblnouvcons.Location = new System.Drawing.Point(101, 17);
            this.lblnouvcons.Name = "lblnouvcons";
            this.lblnouvcons.Size = new System.Drawing.Size(218, 18);
            this.lblnouvcons.TabIndex = 20;
            this.lblnouvcons.Text = "Nouveau concessionnaire : ";
            // 
            // lblsuppr
            // 
            this.lblsuppr.AutoSize = true;
            this.lblsuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuppr.ForeColor = System.Drawing.SystemColors.Info;
            this.lblsuppr.Location = new System.Drawing.Point(28, 21);
            this.lblsuppr.Name = "lblsuppr";
            this.lblsuppr.Size = new System.Drawing.Size(282, 18);
            this.lblsuppr.TabIndex = 21;
            this.lblsuppr.Text = "Suppression d\'un concessionnaire : ";
            // 
            // btnafct
            // 
            this.btnafct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnafct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnafct.Location = new System.Drawing.Point(476, 488);
            this.btnafct.Name = "btnafct";
            this.btnafct.Size = new System.Drawing.Size(157, 46);
            this.btnafct.TabIndex = 23;
            this.btnafct.Text = "Afficher";
            this.btnafct.UseVisualStyleBackColor = false;
            this.btnafct.Click += new System.EventHandler(this.btnafct_Click);
            // 
            // panelSuppr
            // 
            this.panelSuppr.BackColor = System.Drawing.Color.Transparent;
            this.panelSuppr.Controls.Add(this.lblId);
            this.panelSuppr.Controls.Add(this.txtId);
            this.panelSuppr.Controls.Add(this.lblsuppr);
            this.panelSuppr.Controls.Add(this.btsuppr);
            this.panelSuppr.Location = new System.Drawing.Point(908, 84);
            this.panelSuppr.Name = "panelSuppr";
            this.panelSuppr.Size = new System.Drawing.Size(313, 186);
            this.panelSuppr.TabIndex = 24;
            this.panelSuppr.Visible = false;
            // 
            // panelAjouter
            // 
            this.panelAjouter.BackColor = System.Drawing.Color.Transparent;
            this.panelAjouter.Controls.Add(this.lblnouvcons);
            this.panelAjouter.Controls.Add(this.txtville);
            this.panelAjouter.Controls.Add(this.txtcp);
            this.panelAjouter.Controls.Add(this.txtadresse);
            this.panelAjouter.Controls.Add(this.btninsert);
            this.panelAjouter.Controls.Add(this.txtpren);
            this.panelAjouter.Controls.Add(this.lblnom);
            this.panelAjouter.Controls.Add(this.txtnom);
            this.panelAjouter.Controls.Add(this.lblville);
            this.panelAjouter.Controls.Add(this.lblpren);
            this.panelAjouter.Controls.Add(this.lblcp);
            this.panelAjouter.Controls.Add(this.lbladresse);
            this.panelAjouter.Location = new System.Drawing.Point(865, 93);
            this.panelAjouter.Name = "panelAjouter";
            this.panelAjouter.Size = new System.Drawing.Size(434, 315);
            this.panelAjouter.TabIndex = 25;
            this.panelAjouter.Visible = false;
            // 
            // panelSelection
            // 
            this.panelSelection.BackColor = System.Drawing.Color.Transparent;
            this.panelSelection.Controls.Add(this.label2);
            this.panelSelection.Controls.Add(this.label1);
            this.panelSelection.Controls.Add(this.btnenvoyer);
            this.panelSelection.Controls.Add(this.txtaff);
            this.panelSelection.Controls.Add(this.comboBox1);
            this.panelSelection.Controls.Add(this.lblcri);
            this.panelSelection.Location = new System.Drawing.Point(897, 84);
            this.panelSelection.Name = "panelSelection";
            this.panelSelection.Size = new System.Drawing.Size(362, 220);
            this.panelSelection.TabIndex = 26;
            this.panelSelection.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(93, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Critère de sélection : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 25;
            // 
            // btnCritere
            // 
            this.btnCritere.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCritere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCritere.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCritere.Location = new System.Drawing.Point(12, 8);
            this.btnCritere.Name = "btnCritere";
            this.btnCritere.Size = new System.Drawing.Size(113, 33);
            this.btnCritere.TabIndex = 27;
            this.btnCritere.Text = "Sélection";
            this.btnCritere.UseVisualStyleBackColor = false;
            this.btnCritere.Click += new System.EventHandler(this.btnCritere_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprimer.Location = new System.Drawing.Point(260, 8);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(113, 33);
            this.btnSupprimer.TabIndex = 28;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAjouter.Location = new System.Drawing.Point(141, 8);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 33);
            this.btnAjouter.TabIndex = 29;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuitter.Location = new System.Drawing.Point(379, 8);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(92, 33);
            this.btnQuitter.TabIndex = 30;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panelmdp
            // 
            this.panelmdp.Controls.Add(this.panelcreation);
            this.panelmdp.Controls.Add(this.btnseconnecter);
            this.panelmdp.Controls.Add(this.label4);
            this.panelmdp.Controls.Add(this.txtBoxmdp);
            this.panelmdp.Controls.Add(this.label3);
            this.panelmdp.Controls.Add(this.txtboxid);
            this.panelmdp.Location = new System.Drawing.Point(1274, 520);
            this.panelmdp.Name = "panelmdp";
            this.panelmdp.Size = new System.Drawing.Size(67, 51);
            this.panelmdp.TabIndex = 31;
            // 
            // panelcreation
            // 
            this.panelcreation.Controls.Add(this.btnconnection);
            this.panelcreation.Controls.Add(this.lblmdpcreation);
            this.panelcreation.Controls.Add(this.txtboxmdpcreation);
            this.panelcreation.Controls.Add(this.lblidcreation);
            this.panelcreation.Controls.Add(this.txtidcreation);
            this.panelcreation.Location = new System.Drawing.Point(647, 313);
            this.panelcreation.Name = "panelcreation";
            this.panelcreation.Size = new System.Drawing.Size(678, 242);
            this.panelcreation.TabIndex = 19;
          
            // 
            // btnconnection
            // 
            this.btnconnection.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnconnection.ForeColor = System.Drawing.SystemColors.Info;
            this.btnconnection.Location = new System.Drawing.Point(596, 333);
            this.btnconnection.Name = "btnconnection";
            this.btnconnection.Size = new System.Drawing.Size(129, 56);
            this.btnconnection.TabIndex = 23;
            this.btnconnection.Text = "crée un compte";
            this.btnconnection.UseVisualStyleBackColor = false;
           
            // 
            // lblmdpcreation
            // 
            this.lblmdpcreation.AutoSize = true;
            this.lblmdpcreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmdpcreation.ForeColor = System.Drawing.SystemColors.Info;
            this.lblmdpcreation.Location = new System.Drawing.Point(607, 248);
            this.lblmdpcreation.Name = "lblmdpcreation";
            this.lblmdpcreation.Size = new System.Drawing.Size(105, 20);
            this.lblmdpcreation.TabIndex = 22;
            this.lblmdpcreation.Text = "Mot de passe";
            // 
            // txtboxmdpcreation
            // 
            this.txtboxmdpcreation.Location = new System.Drawing.Point(582, 271);
            this.txtboxmdpcreation.Name = "txtboxmdpcreation";
            this.txtboxmdpcreation.Size = new System.Drawing.Size(158, 20);
            this.txtboxmdpcreation.TabIndex = 21;
          
            // 
            // lblidcreation
            // 
            this.lblidcreation.AutoSize = true;
            this.lblidcreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidcreation.ForeColor = System.Drawing.SystemColors.Info;
            this.lblidcreation.Location = new System.Drawing.Point(621, 164);
            this.lblidcreation.Name = "lblidcreation";
            this.lblidcreation.Size = new System.Drawing.Size(80, 20);
            this.lblidcreation.TabIndex = 20;
            this.lblidcreation.Text = "Identifiant";
            // 
            // txtidcreation
            // 
            this.txtidcreation.Location = new System.Drawing.Point(582, 187);
            this.txtidcreation.Name = "txtidcreation";
            this.txtidcreation.Size = new System.Drawing.Size(158, 20);
            this.txtidcreation.TabIndex = 19;
        
            // 
            // btnseconnecter
            // 
            this.btnseconnecter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnseconnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnseconnecter.ForeColor = System.Drawing.SystemColors.Info;
            this.btnseconnecter.Location = new System.Drawing.Point(568, 367);
            this.btnseconnecter.Name = "btnseconnecter";
            this.btnseconnecter.Size = new System.Drawing.Size(129, 56);
            this.btnseconnecter.TabIndex = 18;
            this.btnseconnecter.Text = "Se Connecter";
            this.btnseconnecter.UseVisualStyleBackColor = false;
          
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(579, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mot de passe";
            // 
            // txtBoxmdp
            // 
            this.txtBoxmdp.Location = new System.Drawing.Point(554, 305);
            this.txtBoxmdp.Name = "txtBoxmdp";
            this.txtBoxmdp.Size = new System.Drawing.Size(158, 20);
            this.txtBoxmdp.TabIndex = 16;
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(593, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Identifiant";
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(554, 221);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(158, 20);
            this.txtboxid.TabIndex = 0;
           
            // 
            // FrmConces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 569);
            this.Controls.Add(this.panelmdp);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnCritere);
            this.Controls.Add(this.panelSelection);
            this.Controls.Add(this.panelSuppr);
            this.Controls.Add(this.panelAjouter);
            this.Controls.Add(this.btnafct);
            this.Controls.Add(this.listViewBD);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Bisque;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConces";
            this.Text = "Liste de concessionnaires";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSuppr.ResumeLayout(false);
            this.panelSuppr.PerformLayout();
            this.panelAjouter.ResumeLayout(false);
            this.panelAjouter.PerformLayout();
            this.panelSelection.ResumeLayout(false);
            this.panelSelection.PerformLayout();
            this.panelmdp.ResumeLayout(false);
            this.panelmdp.PerformLayout();
            this.panelcreation.ResumeLayout(false);
            this.panelcreation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBD;
        private System.Windows.Forms.ColumnHeader idConces;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader CodePostal;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.Label lblcri;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtaff;
        private System.Windows.Forms.Button btnenvoyer;
        private System.Windows.Forms.TextBox txtville;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtpren;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label lblpren;
        private System.Windows.Forms.Label lbladresse;
        private System.Windows.Forms.Label lblcp;
        private System.Windows.Forms.Label lblville;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btsuppr;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblnouvcons;
        private System.Windows.Forms.Label lblsuppr;
        private System.Windows.Forms.Button btnafct;
        private System.Windows.Forms.Panel panelSuppr;
        private System.Windows.Forms.Panel panelAjouter;
        private System.Windows.Forms.Panel panelSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCritere;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panelmdp;
        private System.Windows.Forms.Button btnseconnecter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxmdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.Panel panelcreation;
        private System.Windows.Forms.Button btnconnection;
        private System.Windows.Forms.Label lblmdpcreation;
        private System.Windows.Forms.TextBox txtboxmdpcreation;
        private System.Windows.Forms.Label lblidcreation;
        private System.Windows.Forms.TextBox txtidcreation;
    }
}

