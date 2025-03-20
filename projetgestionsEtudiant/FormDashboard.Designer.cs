namespace projetgestionsEtudiant
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnGestionClasses;
        private FontAwesome.Sharp.IconButton btnGestionProfesseurs;
        private FontAwesome.Sharp.IconButton btnGestionMatieres;
        private FontAwesome.Sharp.IconButton btnGestionNotes;
        private FontAwesome.Sharp.IconButton btnReleveNotes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnAssocierCours = new FontAwesome.Sharp.IconButton();
            this.btnAssocierClasse = new FontAwesome.Sharp.IconButton();
            this.btnListeEtudiants = new FontAwesome.Sharp.IconButton();
            this.btnReleveNotes = new FontAwesome.Sharp.IconButton();
            this.btnGestionNotes = new FontAwesome.Sharp.IconButton();
            this.btnGestionMatieres = new FontAwesome.Sharp.IconButton();
            this.btnGestionProfesseurs = new FontAwesome.Sharp.IconButton();
            this.btnGestionClasses = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new FontAwesome.Sharp.IconButton();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelSidebar.Controls.Add(this.btnDeconnexion);
            this.panelSidebar.Controls.Add(this.iconButton1);
            this.panelSidebar.Controls.Add(this.btnAssocierCours);
            this.panelSidebar.Controls.Add(this.btnAssocierClasse);
            this.panelSidebar.Controls.Add(this.btnListeEtudiants);
            this.panelSidebar.Controls.Add(this.btnReleveNotes);
            this.panelSidebar.Controls.Add(this.btnGestionNotes);
            this.panelSidebar.Controls.Add(this.btnGestionMatieres);
            this.panelSidebar.Controls.Add(this.btnGestionProfesseurs);
            this.panelSidebar.Controls.Add(this.btnGestionClasses);
            this.panelSidebar.Controls.Add(this.btnMenu);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.MaximumSize = new System.Drawing.Size(300, 634);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(300, 634);
            this.panelSidebar.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 460);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(300, 50);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Gestions Utilisateurs";
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnAssocierCours
            // 
            this.btnAssocierCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssocierCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssocierCours.ForeColor = System.Drawing.Color.White;
            this.btnAssocierCours.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnAssocierCours.IconColor = System.Drawing.Color.White;
            this.btnAssocierCours.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssocierCours.IconSize = 30;
            this.btnAssocierCours.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssocierCours.Location = new System.Drawing.Point(0, 410);
            this.btnAssocierCours.Name = "btnAssocierCours";
            this.btnAssocierCours.Size = new System.Drawing.Size(300, 50);
            this.btnAssocierCours.TabIndex = 5;
            this.btnAssocierCours.Text = "Associer Cours";
            this.btnAssocierCours.Click += new System.EventHandler(this.btnAssocierCours_Click);
            // 
            // btnAssocierClasse
            // 
            this.btnAssocierClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssocierClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssocierClasse.ForeColor = System.Drawing.Color.White;
            this.btnAssocierClasse.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            this.btnAssocierClasse.IconColor = System.Drawing.Color.White;
            this.btnAssocierClasse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssocierClasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssocierClasse.Location = new System.Drawing.Point(0, 360);
            this.btnAssocierClasse.Name = "btnAssocierClasse";
            this.btnAssocierClasse.Size = new System.Drawing.Size(300, 50);
            this.btnAssocierClasse.TabIndex = 4;
            this.btnAssocierClasse.Text = "Associer Classe";
            this.btnAssocierClasse.Click += new System.EventHandler(this.btnAssocierClasse_Click);
            // 
            // btnListeEtudiants
            // 
            this.btnListeEtudiants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListeEtudiants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeEtudiants.ForeColor = System.Drawing.Color.White;
            this.btnListeEtudiants.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnListeEtudiants.IconColor = System.Drawing.Color.White;
            this.btnListeEtudiants.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListeEtudiants.IconSize = 30;
            this.btnListeEtudiants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListeEtudiants.Location = new System.Drawing.Point(0, 310);
            this.btnListeEtudiants.Name = "btnListeEtudiants";
            this.btnListeEtudiants.Size = new System.Drawing.Size(300, 50);
            this.btnListeEtudiants.TabIndex = 3;
            this.btnListeEtudiants.Text = "Liste Etudiants";
            this.btnListeEtudiants.Click += new System.EventHandler(this.btnListeEtudiants_Click);
            // 
            // btnReleveNotes
            // 
            this.btnReleveNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReleveNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleveNotes.ForeColor = System.Drawing.Color.White;
            this.btnReleveNotes.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnReleveNotes.IconColor = System.Drawing.Color.White;
            this.btnReleveNotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReleveNotes.IconSize = 30;
            this.btnReleveNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleveNotes.Location = new System.Drawing.Point(0, 260);
            this.btnReleveNotes.Name = "btnReleveNotes";
            this.btnReleveNotes.Size = new System.Drawing.Size(300, 50);
            this.btnReleveNotes.TabIndex = 2;
            this.btnReleveNotes.Text = "Releve Notes";
            this.btnReleveNotes.Click += new System.EventHandler(this.BtnReleveNotes_Click);
            // 
            // btnGestionNotes
            // 
            this.btnGestionNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionNotes.ForeColor = System.Drawing.Color.White;
            this.btnGestionNotes.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btnGestionNotes.IconColor = System.Drawing.Color.White;
            this.btnGestionNotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionNotes.IconSize = 30;
            this.btnGestionNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionNotes.Location = new System.Drawing.Point(0, 210);
            this.btnGestionNotes.Name = "btnGestionNotes";
            this.btnGestionNotes.Size = new System.Drawing.Size(300, 50);
            this.btnGestionNotes.TabIndex = 2;
            this.btnGestionNotes.Text = "Gestions des Notes";
            this.btnGestionNotes.Click += new System.EventHandler(this.btnGestionMatieres_Click);
            // 
            // btnGestionMatieres
            // 
            this.btnGestionMatieres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionMatieres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionMatieres.ForeColor = System.Drawing.Color.White;
            this.btnGestionMatieres.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnGestionMatieres.IconColor = System.Drawing.Color.White;
            this.btnGestionMatieres.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionMatieres.IconSize = 30;
            this.btnGestionMatieres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionMatieres.Location = new System.Drawing.Point(0, 160);
            this.btnGestionMatieres.Name = "btnGestionMatieres";
            this.btnGestionMatieres.Size = new System.Drawing.Size(300, 50);
            this.btnGestionMatieres.TabIndex = 2;
            this.btnGestionMatieres.Text = "Gestions des Matieres";
            this.btnGestionMatieres.Click += new System.EventHandler(this.btnGestionMatieres_Click);
            // 
            // btnGestionProfesseurs
            // 
            this.btnGestionProfesseurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionProfesseurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProfesseurs.ForeColor = System.Drawing.Color.White;
            this.btnGestionProfesseurs.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnGestionProfesseurs.IconColor = System.Drawing.Color.White;
            this.btnGestionProfesseurs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionProfesseurs.IconSize = 30;
            this.btnGestionProfesseurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProfesseurs.Location = new System.Drawing.Point(0, 110);
            this.btnGestionProfesseurs.Name = "btnGestionProfesseurs";
            this.btnGestionProfesseurs.Size = new System.Drawing.Size(300, 50);
            this.btnGestionProfesseurs.TabIndex = 2;
            this.btnGestionProfesseurs.Text = "Gestions des Professeurs";
            this.btnGestionProfesseurs.Click += new System.EventHandler(this.btnGestionProfesseurs_Click);
            // 
            // btnGestionClasses
            // 
            this.btnGestionClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionClasses.ForeColor = System.Drawing.Color.White;
            this.btnGestionClasses.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnGestionClasses.IconColor = System.Drawing.Color.White;
            this.btnGestionClasses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionClasses.IconSize = 30;
            this.btnGestionClasses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionClasses.Location = new System.Drawing.Point(0, 60);
            this.btnGestionClasses.Name = "btnGestionClasses";
            this.btnGestionClasses.Size = new System.Drawing.Size(300, 50);
            this.btnGestionClasses.TabIndex = 1;
            this.btnGestionClasses.Text = "Gestions des Classes";
            this.btnGestionClasses.Click += new System.EventHandler(this.btnGestionClasses_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(300, 60);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panelMain.Location = new System.Drawing.Point(303, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(987, 634);
            this.panelMain.TabIndex = 1;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Red;
            this.btnDeconnexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.btnDeconnexion.IconColor = System.Drawing.Color.White;
            this.btnDeconnexion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeconnexion.IconSize = 30;
            this.btnDeconnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnexion.Location = new System.Drawing.Point(0, 510);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(300, 50);
            this.btnDeconnexion.TabIndex = 7;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // FormDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1290, 634);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.Resize += new System.EventHandler(this.FormDashboard_Resize);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private FontAwesome.Sharp.IconButton btnListeEtudiants;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAssocierCours;
        private FontAwesome.Sharp.IconButton btnAssocierClasse;
        private FontAwesome.Sharp.IconButton btnDeconnexion;
    }
}
