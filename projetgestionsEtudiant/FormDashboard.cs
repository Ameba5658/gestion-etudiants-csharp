using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using projetgestionsEtudiant.Models;

namespace projetgestionsEtudiant
{
    public partial class FormDashboard : Form
    {
        private bool sidebarExpand = true; // Indique si la sidebar est ouverte ou fermée
        private Form activeForm = null;
        private Utilisateur utilisateurConnecte; // Stocke l'utilisateur connecté
        private Button btnAssocierProfesseurs; // Change object to Button
        private Button btnGestionEtudiants; // Change object to Button
        private Button btnGestionUtilisateurs; // Change object to Button

        public FormDashboard(Utilisateur utilisateur)
        {
            InitializeComponent();
            utilisateurConnecte = utilisateur; // Assigner l'utilisateur connecté
            btnAssocierProfesseurs = new Button(); // Initialize the button
            btnGestionEtudiants = new Button(); // Initialize the button
            btnGestionUtilisateurs = new Button(); // Initialize the button
            GérerAccèsParRôle();
        }

        private void GérerAccèsParRôle()
        {
            // Désactiver tous les boutons par défaut
            btnGestionClasses.Enabled = false;
            btnGestionMatieres.Enabled = false;
            btnGestionProfesseurs.Enabled = false;
            btnAssocierProfesseurs.Enabled = false;
            btnGestionNotes.Enabled = false;
            btnGestionEtudiants.Enabled = false;
            btnReleveNotes.Enabled = false;
            btnListeEtudiants.Enabled = false;
            btnGestionUtilisateurs.Enabled = false;
            btnAssocierCours.Enabled = false;
            btnAssocierClasse.Enabled = false;

            switch (utilisateurConnecte.Role)
            {
                case "Administrateur":
                    btnGestionClasses.Enabled = true;
                    btnGestionMatieres.Enabled = true;
                    btnGestionProfesseurs.Enabled = true;
                    btnAssocierProfesseurs.Enabled = true;
                    btnGestionNotes.Enabled = true;
                    btnGestionEtudiants.Enabled = true;
                    btnReleveNotes.Enabled = true;
                    btnListeEtudiants.Enabled = true;
                    btnAssocierClasse.Enabled = true;
                    btnAssocierCours.Enabled = true;
                    btnGestionUtilisateurs.Enabled = true; // Seul l'Admin gère les utilisateurs
                    break;

                case "Directeur d'Études":
                    btnGestionClasses.Enabled = true;
                    btnGestionMatieres.Enabled = true;
                    btnGestionProfesseurs.Enabled = true;
                    //    btnAssocierProfesseurs.Enabled = true;
                    btnReleveNotes.Enabled = true;
                    btnListeEtudiants.Enabled = true;
                    break;

                case "Agent":
                    btnGestionNotes.Enabled = true;
                    btnGestionEtudiants.Enabled = true;
                    btnReleveNotes.Enabled = true;
                    break;

                case "Professeur":
                    btnGestionNotes.Enabled = true;
                    btnAssocierClasse.Enabled = false;
                    break;

                default:
                    MessageBox.Show("Rôle inconnu. Accès restreint.", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        public FormDashboard()
        {
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelSidebar.Width = 60; // Rétrécir la sidebar
                btnMenu.IconChar = IconChar.Bars; // Changer l'icône du menu
            }
            else
            {
                panelSidebar.Width = 250; // Agrandir la sidebar
                btnMenu.IconChar = IconChar.Times; // Changer l'icône du menu
            }
            sidebarExpand = !sidebarExpand; // Inverser l'état de la sidebar
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnGestionClasses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClasse());
        }
        private void FormDashboard_Resize(object sender, EventArgs e)
        {
            panelSidebar.Height = this.Height - 20; // Ajuste la hauteur du Sidebar
            panelMain.Width = this.Width - panelSidebar.Width - 20; // Ajuste la largeur du panel principal
            panelMain.Height = this.Height - 40; // Ajuste la hauteur du panel principal
        }



        private void btnGestionProfesseurs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProfesseur());
        }

        private void btnGestionMatieres_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNotes());
        }

        private void btnGestionNotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNotes());
        }

        private void BtnReleveNotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEtudiants());
        }

        private void btnListeEtudiants_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormListeEtudiants());
        }

        private void btnAssocierClasse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAssocierClasse());
        }

        private void btnAssocierCours_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAssocierProfesseur());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGestionUtilisateurs());
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Fermer le Dashboard
                this.Hide();

                // Ouvrir la page de connexion
                FormConnexion formConnexion = new FormConnexion();
                formConnexion.Show();
            }
        }
    }
}
