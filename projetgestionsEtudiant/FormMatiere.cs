using System;
using System.Linq;
using System.Windows.Forms;
using projetgestionsEtudiant.Models;

namespace projetgestionsEtudiant
{
    public partial class FormMatiere : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = 0;

        // Ajout de l'ErrorProvider
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormMatiere()
        {
            InitializeComponent();
        }

        private void FormMatiere_Load(object sender, EventArgs e)
        {
            ChargerMatieres();
        }

        private void ChargerMatieres()
        {
            dgvMatieres.DataSource = db.Matieres.Select(m => new { m.Id, m.NomMatiere }).ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Validation du champ de texte avec ErrorProvider
            if (string.IsNullOrEmpty(txtNomMatiere.Text))
            {
                errorProvider.SetError(txtNomMatiere, "Le nom de la matière ne peut pas être vide.");
            }
            else
            {
                errorProvider.Clear();  // Effacer l'erreur si le champ est valide
                var matiere = new Matiere { NomMatiere = txtNomMatiere.Text };
                db.Matieres.Add(matiere);
                db.SaveChanges();
                ChargerMatieres();
                txtNomMatiere.Clear();
                MessageBox.Show("Ajout effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvMatieres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvMatieres.Rows[e.RowIndex].Cells["Id"].Value);
                txtNomMatiere.Text = dgvMatieres.Rows[e.RowIndex].Cells["NomMatiere"].Value.ToString();
                errorProvider.Clear(); // Effacer les erreurs quand une matière est sélectionnée
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                if (string.IsNullOrEmpty(txtNomMatiere.Text))
                {
                    errorProvider.SetError(txtNomMatiere, "Le nom de la matière ne peut pas être vide.");
                }
                else
                {
                    errorProvider.Clear(); // Effacer l'erreur si le champ est valide
                    var matiere = db.Matieres.Find(selectedId);
                    if (matiere != null)
                    {
                        matiere.NomMatiere = txtNomMatiere.Text;
                        db.SaveChanges();
                        ChargerMatieres();
                        txtNomMatiere.Clear();
                        selectedId = 0;
                        MessageBox.Show("Modification effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une matière à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette matière ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var matiere = db.Matieres.Find(selectedId);
                    if (matiere != null)
                    {
                        db.Matieres.Remove(matiere);
                        db.SaveChanges();
                        ChargerMatieres();
                        txtNomMatiere.Clear();
                        selectedId = 0;
                        MessageBox.Show("Suppression effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une matière à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
