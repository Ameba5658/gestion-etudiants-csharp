using System;
using System.Linq;
using System.Windows.Forms;
using projetgestionsEtudiant.Models;

namespace projetgestionsEtudiant
{
    public partial class FormProfesseur : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = 0;

        // Ajout de l'ErrorProvider
        private ErrorProvider errorProvider = new ErrorProvider();

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
            // Validation des champs avec l'ErrorProvider
            if (string.IsNullOrEmpty(txtNomProf.Text))
            {
                errorProvider.SetError(txtNomProf, "Le nom du professeur est requis.");
            }
            else if (string.IsNullOrEmpty(txtPrenomProf.Text))
            {
                errorProvider.SetError(txtPrenomProf, "Le prénom du professeur est requis.");
            }
            else if (string.IsNullOrEmpty(txtEmailProf.Text))
            {
                errorProvider.SetError(txtEmailProf, "L'email du professeur est requis.");
            }
            else if (string.IsNullOrEmpty(txtTelephoneProf.Text))
            {
                errorProvider.SetError(txtTelephoneProf, "Le téléphone du professeur est requis.");
            }
            else
            {
                errorProvider.Clear(); // Efface les erreurs si tout est valide

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

                errorProvider.Clear(); // Effacer l'erreur lors de la sélection d'un professeur
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                // Validation des champs avec l'ErrorProvider
                if (string.IsNullOrEmpty(txtNomProf.Text))
                {
                    errorProvider.SetError(txtNomProf, "Le nom du professeur est requis.");
                }
                else if (string.IsNullOrEmpty(txtPrenomProf.Text))
                {
                    errorProvider.SetError(txtPrenomProf, "Le prénom du professeur est requis.");
                }
                else if (string.IsNullOrEmpty(txtEmailProf.Text))
                {
                    errorProvider.SetError(txtEmailProf, "L'email du professeur est requis.");
                }
                else if (string.IsNullOrEmpty(txtTelephoneProf.Text))
                {
                    errorProvider.SetError(txtTelephoneProf, "Le téléphone du professeur est requis.");
                }
                else
                {
                    errorProvider.Clear(); // Efface les erreurs si tout est valide

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
