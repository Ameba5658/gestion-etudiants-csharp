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
    public partial class FormProfesseur : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = 0;
        public FormProfesseur()
        {
            InitializeComponent();
            ChargerProfesseurs();
        }

        private void FormProfesseur_Load(object sender, EventArgs e)
        {

        }

        private void ChargerProfesseurs()
        {
            dgvProfesseurs.DataSource = db.Professeurs.Select(p => new { p.Id, p.Nom, p.Prenom, p.Email, p.Telephone }).ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomProf.Text) && !string.IsNullOrEmpty(txtPrenomProf.Text) &&
        !string.IsNullOrEmpty(txtEmailProf.Text) && !string.IsNullOrEmpty(txtTelephoneProf.Text))
            {
                var professeur = new Professeur
                {
                    Nom = txtNomProf.Text,
                    Prenom = txtPrenomProf.Text,
                    Email = txtEmailProf.Text,
                    Telephone = txtTelephoneProf.Text
                };

                db.Professeurs.Add(professeur);
                db.SaveChanges();
                ChargerProfesseurs();
                txtNomProf.Clear();
                txtPrenomProf.Clear();
                txtEmailProf.Clear();
                txtTelephoneProf.Clear();
                MessageBox.Show("Ajout effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProfesseurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvProfesseurs.Rows[e.RowIndex].Cells["Id"].Value);
                txtNomProf.Text = dgvProfesseurs.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                txtPrenomProf.Text = dgvProfesseurs.Rows[e.RowIndex].Cells["Prenom"].Value.ToString();
                txtEmailProf.Text = dgvProfesseurs.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtTelephoneProf.Text = dgvProfesseurs.Rows[e.RowIndex].Cells["Telephone"].Value.ToString();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedId != 0 && !string.IsNullOrEmpty(txtNomProf.Text) && !string.IsNullOrEmpty(txtPrenomProf.Text) &&
       !string.IsNullOrEmpty(txtEmailProf.Text) && !string.IsNullOrEmpty(txtTelephoneProf.Text))
            {
                var professeur = db.Professeurs.Find(selectedId);
                if (professeur != null)
                {
                    professeur.Nom = txtNomProf.Text;
                    professeur.Prenom = txtPrenomProf.Text;
                    professeur.Email = txtEmailProf.Text;
                    professeur.Telephone = txtTelephoneProf.Text;
                    db.SaveChanges();
                    ChargerProfesseurs();
                    txtNomProf.Clear();
                    txtPrenomProf.Clear();
                    txtEmailProf.Clear();
                    txtTelephoneProf.Clear();
                    selectedId = 0;
                    MessageBox.Show("Modification effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un professeur à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce professeur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var professeur = db.Professeurs.Find(selectedId);
                    if (professeur != null)
                    {
                        db.Professeurs.Remove(professeur);
                        db.SaveChanges();
                        ChargerProfesseurs();
                        txtNomProf.Clear();
                        txtPrenomProf.Clear();
                        txtEmailProf.Clear();
                        txtTelephoneProf.Clear();
                        selectedId = 0;
                        MessageBox.Show("Suppression effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un professeur à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
