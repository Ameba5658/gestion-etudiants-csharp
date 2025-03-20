using System;
using System.Linq;
using System.Windows.Forms;
using projetgestionsEtudiant.Models;

namespace projetgestionsEtudiant
{
    public partial class FormEtudiants : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = 0;
        private ErrorProvider errorProvider;

        public FormEtudiants()
        {
            InitializeComponent();
            ChargerClasses();
            ChargerEtudiants();
            txtMatricule.Text = GenererMatricule();
            errorProvider = new ErrorProvider();
        }

        private void ChargerClasses()
        {
            using (var db = new AppDbContext())
            {
                cmbClasse.DataSource = db.Classes.ToList();
                cmbClasse.DisplayMember = "NomClasse";
                cmbClasse.ValueMember = "Id";
            }
        }

        private void ChargerEtudiants()
        {
            dgvEtudiants.DataSource = db.Etudiants
                .Select(e => new
                {
                    e.Id,
                    e.Matricule,
                    e.Nom,
                    e.Prenom,
                    e.DateNaissance,
                    e.Sexe,
                    e.Adresse,
                    e.Telephone,
                    e.Email,
                    Classe = e.Classe.NomClasse
                }).ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            errorProvider.Clear(); // Réinitialiser les erreurs

            // Validation des champs
            if (string.IsNullOrEmpty(txtMatricule.Text))
            {
                errorProvider.SetError(txtMatricule, "Le matricule est requis.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtNom.Text))
            {
                errorProvider.SetError(txtNom, "Le nom est requis.");
                isValid = false;
            }

            // Vérifier si un élément est sélectionné dans le ComboBox
            if (cmbClasse.SelectedItem == null)
            {
                errorProvider.SetError(cmbClasse, "Veuillez sélectionner une classe.");
                isValid = false;
            }

            if (isValid)
            {
                var etudiant = new Etudiant
                {
                    Matricule = GenererMatricule(),
                    Nom = txtNom.Text,
                    Prenom = txtPrenom.Text,
                    DateNaissance = dtpDateNaissance.Value,
                    Sexe = cmbSexe.SelectedItem?.ToString(),  // Vérification de null pour éviter l'exception
                    Adresse = txtAdresse.Text,
                    Telephone = txtTelephone.Text,
                    Email = txtEmail.Text,
                    ClasseId = (int)cmbClasse.SelectedValue // Vous pouvez également vérifier la valeur avant
                };

                db.Etudiants.Add(etudiant);
                db.SaveChanges();
                ChargerEtudiants();
                MessageBox.Show("Étudiant ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez corriger les erreurs avant de soumettre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvEtudiants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Récupérer l'ID sélectionné
                selectedId = Convert.ToInt32(dgvEtudiants.Rows[e.RowIndex].Cells["Id"].Value);

                // Vérification et affectation des valeurs des cellules, avec gestion des valeurs nulles
                txtMatricule.Text = dgvEtudiants.Rows[e.RowIndex].Cells["Matricule"].Value?.ToString() ?? string.Empty;
                txtNom.Text = dgvEtudiants.Rows[e.RowIndex].Cells["Nom"].Value?.ToString() ?? string.Empty;
                txtPrenom.Text = dgvEtudiants.Rows[e.RowIndex].Cells["Prenom"].Value?.ToString() ?? string.Empty;
                dtpDateNaissance.Value = dgvEtudiants.Rows[e.RowIndex].Cells["DateNaissance"].Value != DBNull.Value
                    ? Convert.ToDateTime(dgvEtudiants.Rows[e.RowIndex].Cells["DateNaissance"].Value)
                    : DateTime.Now; // Valeur par défaut si la date est null
                cmbSexe.Text = dgvEtudiants.Rows[e.RowIndex].Cells["Sexe"].Value?.ToString() ?? string.Empty;
                txtAdresse.Text = dgvEtudiants.Rows[e.RowIndex].Cells["Adresse"].Value?.ToString() ?? string.Empty;
                txtTelephone.Text = dgvEtudiants.Rows[e.RowIndex].Cells["Telephone"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = dgvEtudiants.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? string.Empty;
                cmbClasse.Text = dgvEtudiants.Rows[e.RowIndex].Cells["Classe"].Value?.ToString() ?? string.Empty;
            }
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            errorProvider.Clear(); // Réinitialiser les erreurs

            if (selectedId == 0)
            {
                errorProvider.SetError(dgvEtudiants, "Sélectionnez un étudiant à modifier.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtMatricule.Text))
            {
                errorProvider.SetError(txtMatricule, "Le matricule est requis.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtNom.Text))
            {
                errorProvider.SetError(txtNom, "Le nom est requis.");
                isValid = false;
            }

            if (cmbClasse.SelectedItem == null)
            {
                errorProvider.SetError(cmbClasse, "Veuillez sélectionner une classe.");
                isValid = false;
            }

            if (isValid)
            {
                var etudiant = db.Etudiants.Find(selectedId);
                if (etudiant != null)
                {
                    etudiant.Matricule = txtMatricule.Text;
                    etudiant.Nom = txtNom.Text;
                    etudiant.Prenom = txtPrenom.Text;
                    etudiant.DateNaissance = dtpDateNaissance.Value;
                    etudiant.Sexe = cmbSexe.SelectedItem.ToString();
                    etudiant.Adresse = txtAdresse.Text;
                    etudiant.Telephone = txtTelephone.Text;
                    etudiant.Email = txtEmail.Text;
                    etudiant.ClasseId = (int)cmbClasse.SelectedValue;

                    db.SaveChanges();
                    ChargerEtudiants();
                    MessageBox.Show("Modification effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez corriger les erreurs avant de soumettre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet étudiant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var etudiant = db.Etudiants.Find(selectedId);
                    if (etudiant != null)
                    {
                        db.Etudiants.Remove(etudiant);
                        db.SaveChanges();
                        ChargerEtudiants();
                        MessageBox.Show("Suppression effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private string GenererMatricule()
        {
            using (var db = new AppDbContext())
            {
                int dernierId = db.Etudiants.Any() ? db.Etudiants.Max(e => e.Id) + 1 : 1;
                return $"ETU{DateTime.Now.Year}{dernierId:D4}";  // Exemple : ETU20250001
            }
        }

        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
