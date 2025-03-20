using System;
using System.Linq;
using System.Windows.Forms;
using projetgestionsEtudiant.Models;

namespace projetgestionsEtudiant
{
    public partial class FormClasse : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = 0;

        // Ajout de l'ErrorProvider
        private ErrorProvider errorProvider = new ErrorProvider();

        public FormClasse()
        {
            InitializeComponent();
            ChargerClasses();
        }

        private void ChargerClasses()
        {
            dgvClasses.DataSource = db.Classes.Select(c => new { c.Id, c.NomClasse }).ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Validation du champ de texte avec ErrorProvider
            if (string.IsNullOrEmpty(txtNomClasse.Text))
            {
                errorProvider.SetError(txtNomClasse, "Le nom de la classe ne peut pas être vide.");
            }
            else
            {
                errorProvider.Clear();  // Effacer l'erreur si le champ est valide
                var classe = new Classe { NomClasse = txtNomClasse.Text };
                db.Classes.Add(classe);
                db.SaveChanges();
                ChargerClasses();
                txtNomClasse.Clear();
                MessageBox.Show("Ajout effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvClasses.Rows[e.RowIndex].Cells["Id"].Value);
                txtNomClasse.Text = dgvClasses.Rows[e.RowIndex].Cells["NomClasse"].Value.ToString();
                errorProvider.Clear(); // Effacer les erreurs quand une classe est sélectionnée
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                if (string.IsNullOrEmpty(txtNomClasse.Text))
                {
                    errorProvider.SetError(txtNomClasse, "Le nom de la classe ne peut pas être vide.");
                }
                else
                {
                    errorProvider.Clear(); // Effacer l'erreur si le champ est valide
                    var classe = db.Classes.Find(selectedId);
                    if (classe != null)
                    {
                        classe.NomClasse = txtNomClasse.Text;
                        db.SaveChanges();
                        ChargerClasses();
                        txtNomClasse.Clear();
                        selectedId = 0;
                        MessageBox.Show("Modification effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une classe à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette classe ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var classe = db.Classes.Find(selectedId);
                    if (classe != null)
                    {
                        db.Classes.Remove(classe);
                        db.SaveChanges();
                        ChargerClasses();
                        txtNomClasse.Clear();
                        selectedId = 0;
                        MessageBox.Show("Suppression effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une classe à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {
            // Vous pouvez également ajouter d'autres configurations au chargement du formulaire
        }
    }
}
