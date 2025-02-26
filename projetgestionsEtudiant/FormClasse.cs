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
    public partial class FormClasse : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = 0;
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
            if (!string.IsNullOrEmpty(txtNomClasse.Text))
    {
        var classe = new Classe { NomClasse = txtNomClasse.Text };
        db.Classes.Add(classe);
        db.SaveChanges();
        ChargerClasses();
        txtNomClasse.Clear();
        MessageBox.Show("Ajout effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    else
    {
        MessageBox.Show("Veuillez entrer un nom de classe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvClasses.Rows[e.RowIndex].Cells["Id"].Value);
                txtNomClasse.Text = dgvClasses.Rows[e.RowIndex].Cells["NomClasse"].Value.ToString();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedId != 0 && !string.IsNullOrEmpty(txtNomClasse.Text))
            {
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
    }
}
