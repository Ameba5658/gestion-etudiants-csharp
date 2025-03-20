using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Generators;
using projetgestionsEtudiant.Models;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace projetgestionsEtudiant
{
    public partial class FormInscription : Form
    {
        private readonly AppDbContext db = new AppDbContext();
    
        public FormInscription()
        {
            InitializeComponent();
        }

        private void FormInscription_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtMotDePasse.Text) ||
                string.IsNullOrWhiteSpace(txtTelephone.Text) ||
                cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifier si l'email existe déjà
            if (db.Utilisateurs.Any(u => u.Email == txtEmail.Text))
            {
                MessageBox.Show("Cet email est déjà utilisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hachage du mot de passe
            string motDePasseHache = BCrypt.Net.BCrypt.HashPassword(txtMotDePasse.Text);

            // Enregistrer l'utilisateur dans la base de données
            var utilisateur = new Models.Utilisateur
            {
                Nom = txtNom.Text,
                Email = txtEmail.Text,
                MotDePasse = motDePasseHache,
                NumeroTelephone = txtTelephone.Text,
                Role = cmbRole.SelectedItem.ToString(),
                EstActive = true // L'utilisateur est actif dès l'inscription
            };

            db.Utilisateurs.Add(utilisateur);
            db.SaveChanges();

            MessageBox.Show("Inscription réussie ! Vous pouvez maintenant vous connecter.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ouvrir la page de connexion
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.Show();
            this.Hide();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
