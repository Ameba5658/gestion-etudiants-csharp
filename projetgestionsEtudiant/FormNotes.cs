using System;
using System.Linq;
using System.Windows.Forms;
using projetgestionsEtudiant.Models;

namespace projetgestionsEtudiant
{
    public partial class FormNotes : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = 0;
        private int etudiantId;
        private int id;

        // Ajout de l'ErrorProvider
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormNotes()
        {
            InitializeComponent();
            ChargerListes();
            ChargerNotes();
            this.etudiantId = id; // ✅ Assignation correcte
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {

        }

        private void ChargerListes()
        {
            using (var db = new AppDbContext())
            {
                // Charger les étudiants
                cmbEtudiants.DataSource = db.Etudiants.ToList();
                cmbEtudiants.DisplayMember = "Nom"; // Assure-toi que "Nom" est une colonne existante
                cmbEtudiants.ValueMember = "Id";

                // Charger les matières
                cmbMatieres.DataSource = db.Matieres.ToList();
                cmbMatieres.DisplayMember = "NomMatiere";
                cmbMatieres.ValueMember = "Id";
            }
        }

        private void ChargerNotes()
        {
            dgvNotes.DataSource = db.Notes
                .Select(n => new
                {
                    n.Id,
                    Etudiant = n.Etudiant.Nom,
                    Matiere = n.Matiere.NomMatiere,
                    n.Valeur
                }).ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            errorProvider.Clear(); // Effacer les erreurs précédentes

            bool isValid = true;
            float valeur = 0; // Initialisation de la variable

            // Vérification des champs
            if (cmbEtudiants.SelectedItem == null)
            {
                errorProvider.SetError(cmbEtudiants, "Veuillez sélectionner un étudiant.");
                isValid = false;
            }

            if (cmbMatieres.SelectedItem == null)
            {
                errorProvider.SetError(cmbMatieres, "Veuillez sélectionner une matière.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtNote.Text) || !float.TryParse(txtNote.Text, out valeur) || valeur < 0 || valeur > 20)
            {
                errorProvider.SetError(txtNote, "Veuillez entrer une note valide entre 0 et 20.");
                isValid = false;
            }

            if (isValid)
            {
                int etudiantId = (int)cmbEtudiants.SelectedValue;
                int matiereId = (int)cmbMatieres.SelectedValue;

                var note = new Note { EtudiantId = etudiantId, MatiereId = matiereId, Valeur = valeur };
                db.Notes.Add(note);
                db.SaveChanges();
                CalculerEtEnregistrerMoyenne(etudiantId);
                ChargerNotes();
                txtNote.Clear();
                MessageBox.Show("Note ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez corriger les erreurs avant de soumettre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            errorProvider.Clear(); // Effacer les erreurs précédentes

            bool isValid = true;
            float valeur = 0; // Initialisation de la variable

            // Vérification des champs
            if (selectedId == 0)
            {
                MessageBox.Show("Sélectionnez une note à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtNote.Text) || !float.TryParse(txtNote.Text, out valeur) || valeur < 0 || valeur > 20)
            {
                errorProvider.SetError(txtNote, "Veuillez entrer une note valide entre 0 et 20.");
                isValid = false;
            }

            if (isValid)
            {
                var note = db.Notes.Find(selectedId);
                if (note != null)
                {
                    note.Valeur = valeur;
                    db.SaveChanges();
                    CalculerEtEnregistrerMoyenne(etudiantId);
                    ChargerNotes();
                    txtNote.Clear();
                    selectedId = 0;
                    MessageBox.Show("Modification effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette note ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var note = db.Notes.Find(selectedId);
                    if (note != null)
                    {
                        db.Notes.Remove(note);
                        db.SaveChanges();
                        ChargerNotes();
                        txtNote.Clear();
                        selectedId = 0;
                        MessageBox.Show("Suppression effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une note à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvNotes.Rows[e.RowIndex].Cells["Id"].Value);
                txtNote.Text = dgvNotes.Rows[e.RowIndex].Cells["Valeur"].Value.ToString();
                cmbEtudiants.Text = dgvNotes.Rows[e.RowIndex].Cells["Etudiant"].Value.ToString();
                cmbMatieres.Text = dgvNotes.Rows[e.RowIndex].Cells["Matiere"].Value.ToString();
            }
        }

        private void CalculerEtEnregistrerMoyenne(int etudiantId)
        {
            using (var db = new AppDbContext())
            {
                var notes = db.Notes.Where(n => n.EtudiantId == etudiantId).Select(n => n.Valeur).ToList();

                if (notes.Any())
                {
                    float moyenne = notes.Average();

                    // Mettre à jour la moyenne de l'étudiant
                    var etudiant = db.Etudiants.Find(etudiantId);
                    if (etudiant != null)
                    {
                        etudiant.MoyenneGenerale = moyenne;
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
