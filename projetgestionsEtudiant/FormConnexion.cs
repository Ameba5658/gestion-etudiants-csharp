using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetgestionsEtudiant.Models;

namespace projetgestionsEtudiant
{
    public partial class FormConnexion : Form
    {
        private AppDbContext db = new AppDbContext();

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string motDePasse = txtMotDePasse.Text;

            var utilisateur = db.Utilisateurs.FirstOrDefault(u => u.Email == email);

            if (utilisateur == null || !BCrypt.Net.BCrypt.Verify(motDePasse, utilisateur.MotDePasse))
            {
                MessageBox.Show("Email ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Bienvenue {utilisateur.Nom}, vous êtes connecté en tant que {utilisateur.Role}.",
                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            FormDashboard dashboard = new FormDashboard(utilisateur);
            dashboard.Show();

            // Vérifier que le formulaire est bien affiché
            MessageBox.Show("FormDashboard a bien été ouvert !");
        }
        private void lblCreerCompte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInscription formInscription = new FormInscription();
            formInscription.Show();
            this.Show();
        }
    }
}
