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
    public partial class FormAssocierProfesseur : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = 0;
        public FormAssocierProfesseur()
        {
            InitializeComponent();
            ChargerListes(); // Appel de la méthode ChargerListes pour corriger l'erreur IDE0051
        }

        private void FormAssocierProfesseur_Load(object sender, EventArgs e)
        {

        }
        private void ChargerListes()
        {
            using (var db = new AppDbContext())
            {
                // Charger les professeurs dans la ComboBox
                cmbProfesseurs.DataSource = db.Professeurs.ToList();
                cmbProfesseurs.DisplayMember = "Nom";  // Assurez-vous que "Nom" est bien un attribut existant
                cmbProfesseurs.ValueMember = "Id";

                // Charger les matières dans la CheckedListBox
                clbMatieres.Items.Clear();
                foreach (var matiere in db.Matieres.ToList())
                {
                    clbMatieres.Items.Add(matiere, false);
                }

                // Charger les classes dans la CheckedListBox
                clbClasses.Items.Clear();
                foreach (var classe in db.Classes.ToList())
                {
                    clbClasses.Items.Add(classe, false);
                }
            }
        }




        private void btnAssocier_Click(object sender, EventArgs e)
        {
            if (cmbProfesseurs.SelectedItem != null)
            {
                int profId = (int)cmbProfesseurs.SelectedValue;

                // Associer les matières sélectionnées
                foreach (var item in clbMatieres.CheckedItems)
                {
                    var matiere = (Matiere)item;
                    var associationMatiere = new ProfesseurMatiere { ProfesseurId = profId, MatiereId = matiere.Id };
                    db.ProfesseursMatieres.Add(associationMatiere);
                }

                // Associer les classes sélectionnées
                foreach (var item in clbClasses.CheckedItems)
                {
                    var classe = (Classe)item;
                    var associationClasse = new ProfesseurClasse { ProfesseurId = profId, ClasseId = classe.Id };
                    db.ProfesseursClasses.Add(associationClasse);
                }

                db.SaveChanges();
                MessageBox.Show("Association effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clbMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
