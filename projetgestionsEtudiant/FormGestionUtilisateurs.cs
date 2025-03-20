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
    public partial class FormGestionUtilisateurs : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedUserId = 0;
        private readonly Button btnAssocierProfesseurs;
        private readonly Button btnGestionNotes;
        private readonly Button btnGestionClasses;
        private readonly Button btnGestionMatieres;
        private readonly Button btnGestionProfesseurs;
        private readonly Button btnGestionEtudiants;
        private readonly Button btnReleveNotes;
        private readonly Button btnListeEtudiants;
        private readonly Button btnGestionUsers;

        public FormGestionUtilisateurs()
        {
            InitializeComponent();
            ChargerUtilisateurs();
            cmbRole.Items.AddRange(new string[] { "Administrateur", "Directeur d'Études (DE)", "Agent", "Professeur" });
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtMotDePasse.Text) || cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var utilisateur = new Utilisateur
            {
                Nom = txtNom.Text,
                Email = txtEmail.Text,
                MotDePasse = BCrypt.Net.BCrypt.HashPassword(txtMotDePasse.Text),
                Role = cmbRole.SelectedItem.ToString()
            };

            db.Utilisateurs.Add(utilisateur);
            db.SaveChanges();
            ChargerUtilisateurs();
            MessageBox.Show("Utilisateur ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViderChamps();
        }
        private void ChargerUtilisateurs()
        {
            dgvUtilisateurs.DataSource = db.Utilisateurs
                .Select(u => new { u.Id, u.Nom, u.Email, u.Role })
                .ToList();
        }

        private void ViderChamps()
        {
            txtNom.Clear();
            txtEmail.Clear();
            txtMotDePasse.Clear();
            cmbRole.SelectedIndex = -1;
            selectedUserId = 0;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var utilisateur = db.Utilisateurs.Find(selectedUserId);
                if (utilisateur != null)
                {
                    db.Utilisateurs.Remove(utilisateur);
                    db.SaveChanges();
                    ChargerUtilisateurs();
                    MessageBox.Show("Utilisateur supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViderChamps();
                }
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var utilisateur = db.Utilisateurs.Find(selectedUserId);
            if (utilisateur != null)
            {
                utilisateur.Nom = txtNom.Text;
                utilisateur.Email = txtEmail.Text;
                utilisateur.Role = cmbRole.SelectedItem.ToString();

                db.SaveChanges();
                ChargerUtilisateurs();
                MessageBox.Show("Modification réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViderChamps();
            }
        }

        private void dgvUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = Convert.ToInt32(dgvUtilisateurs.Rows[e.RowIndex].Cells["Id"].Value);
                txtNom.Text = dgvUtilisateurs.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                txtEmail.Text = dgvUtilisateurs.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                cmbRole.SelectedItem = dgvUtilisateurs.Rows[e.RowIndex].Cells["Role"].Value.ToString();
            }
        }

       


        private void dgvUtilisateurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifie si une ligne est bien sélectionnée
            {
                selectedUserId = Convert.ToInt32(dgvUtilisateurs.Rows[e.RowIndex].Cells["Id"].Value);
                txtNom.Text = dgvUtilisateurs.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                txtEmail.Text = dgvUtilisateurs.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                cmbRole.SelectedItem = dgvUtilisateurs.Rows[e.RowIndex].Cells["Role"].Value.ToString();

                // Désactive le champ Email car on ne doit pas modifier l'email
                txtEmail.Enabled = false;
            }
        }
    }
}
