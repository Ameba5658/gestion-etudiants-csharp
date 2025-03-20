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
    public partial class FormAssocierClasse : Form
    {
        private AppDbContext db = new AppDbContext();
        public FormAssocierClasse()
        {
            InitializeComponent();
            ChargerClasses();
            ChargerCours();
            ChargerMatieres();

        }

        private void ChargerClasses()
        {
            cmbClasses.DataSource = db.Classes.ToList();
            cmbClasses.DisplayMember = "NomClasse";
            cmbClasses.ValueMember = "Id";
        }


        private void ChargerCours()
        {
            clbCours.DataSource = db.Cours.ToList();
            clbCours.DisplayMember = "NomCours";
            clbCours.ValueMember = "Id";
        }

        private void ChargerMatieres()
        {
            clbMatieres.DataSource = db.Matieres.ToList();
            clbMatieres.DisplayMember = "NomMatiere";
            clbMatieres.ValueMember = "Id";
        }

        private void FormAssocierClasse_Load(object sender, EventArgs e)
        {

        }

        private void btnAssocier_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClasses.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner une classe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int classeId;
                if (!int.TryParse(cmbClasses.SelectedValue.ToString(), out classeId))
                {
                    MessageBox.Show("Erreur lors de la récupération de l'ID de la classe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new AppDbContext())
                {
                    // 📌 Associer les cours à la classe
                    foreach (var item in clbCours.CheckedItems)
                    {
                        if (item is Cours selectedCours) // ✅ Vérification correcte du type
                        {
                            int coursId = selectedCours.Id;

                            // 📌 Vérifier si l'association existe déjà
                            bool exists = db.GetClasseCours().Any(cc => cc.ClasseId == classeId && cc.CoursId == coursId);
                            if (!exists)
                            {
                                db.GetClasseCours().Add(new ClasseCours { ClasseId = classeId, CoursId = coursId });
                            }
                        }
                    }

                    // 📌 Associer les matières à la classe
                    foreach (var item in clbMatieres.CheckedItems)
                    {
                        if (item is Matiere selectedMatiere) // ✅ Vérification correcte du type
                        {
                            int matiereId = selectedMatiere.Id;

                            // 📌 Vérifier si l'association existe déjà
                            bool exists = db.ClasseMatiere.Any(cm => cm.ClasseId == classeId && cm.MatiereId == matiereId);
                            if (!exists)
                            {
                                db.ClasseMatiere.Add(new ClasseMatiere { ClasseId = classeId, MatiereId = matiereId });
                            }
                        }
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Association effectuée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'association : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerCoursClasse(int classeId)
        {
           
        }

        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
