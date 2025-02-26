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
    public partial class FormMatiere : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = 0;
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
            if (!string.IsNullOrEmpty(txtNomMatiere.Text))
            {
                var matiere = new Matiere { NomMatiere = txtNomMatiere.Text };
                db.Matieres.Add(matiere);
                db.SaveChanges();
                ChargerMatieres();
                txtNomMatiere.Clear();
                MessageBox.Show("Ajout effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom de matière.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvMatieres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvMatieres.Rows[e.RowIndex].Cells["Id"].Value);
                txtNomMatiere.Text = dgvMatieres.Rows[e.RowIndex].Cells["NomMatiere"].Value.ToString();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedId != 0 && !string.IsNullOrEmpty(txtNomMatiere.Text))
            {
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
