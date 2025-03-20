using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using projetgestionsEtudiant.Models;

namespace projetgestionsEtudiant
{
    public partial class FormListeEtudiants : Form
    {
        private AppDbContext db = new AppDbContext();
        public FormListeEtudiants()
        {
            InitializeComponent();
            ChargerClasses();
        }

        private void FormListeEtudiants_Load(object sender, EventArgs e)
        {

        }

        private void ChargerClasses()
        {
            using (var db = new AppDbContext())
            {
                cmbClasses.DataSource = db.Classes.ToList();
                cmbClasses.DisplayMember = "NomClasse";  // Afficher le nom de la classe
                cmbClasses.ValueMember = "Id";  // Stocke l'ID de la classe
            }
        }

        private void ChargerEtudiants(int classeId)
        {
            using (var db = new AppDbContext())
            {
                var etudiants = db.Etudiants.Where(e => e.ClasseId == classeId)
                                            .Select(e => new { e.Matricule, e.Nom, e.Prenom, e.Telephone, e.Email })
                                            .ToList();

                dgvEtudiants.DataSource = etudiants;
            }
        }

        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasses.SelectedValue != null && int.TryParse(cmbClasses.SelectedValue.ToString(), out int classeId))
            {
                ChargerEtudiants(classeId);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

            if (dgvEtudiants.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à exporter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = "Liste_Etudiants.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add("Liste Etudiants");

                            // Ajouter les en-têtes
                            for (int i = 0; i < dgvEtudiants.Columns.Count; i++)
                            {
                                ws.Cell(1, i + 1).Value = dgvEtudiants.Columns[i].HeaderText;
                            }

                            // Ajouter les données
                            for (int i = 0; i < dgvEtudiants.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvEtudiants.Columns.Count; j++)
                                {
                                    ws.Cell(i + 2, j + 1).Value = dgvEtudiants.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            // Sauvegarder le fichier
                            wb.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show($"Export réussi : {sfd.FileName}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = sfd.FileName,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de l'export : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExporterExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier Excel|*.xlsx";
            saveFileDialog.Title = "Enregistrer le fichier Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Meilleurs Étudiants");
                    worksheet.Cell(1, 1).Value = "Nom";
                    worksheet.Cell(1, 2).Value = "Prénom";
                    worksheet.Cell(1, 3).Value = "Moyenne Générale";

                    int row = 2;
                    foreach (var etudiant in ObtenirMeilleursEtudiants(5))
                    {
                        worksheet.Cell(row, 1).Value = etudiant.Nom;
                        worksheet.Cell(row, 2).Value = etudiant.Prenom;
                        worksheet.Cell(row, 3).Value = etudiant.MoyenneGenerale;
                        row++;
                    }

                    workbook.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Exportation réussie en Excel !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private IEnumerable<Etudiant> ObtenirMeilleursEtudiants(int nombre)
        {
            using (var db = new AppDbContext())
            {
                return db.Etudiants.OrderByDescending(e => e.MoyenneGenerale).Take(nombre).ToList();
            }
        }
    }
}
