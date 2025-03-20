using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using projetgestionsEtudiant.Models;

namespace projetgestionsEtudiant
{
    public partial class FormReleveNotes : Form
    {
        private readonly AppDbContext db = new AppDbContext(); // ✅ Vérifie cette ligne


        public FormReleveNotes()
        {
            InitializeComponent();
            cmbEtudiants.SelectedIndexChanged += cmbEtudiants_SelectedIndexChanged;
            ChargerEtudiants();
        }

        private void ChargerEtudiants()
        {
            using (var db = new AppDbContext())
            {
                var etudiants = db.Etudiants.ToList();

                if (etudiants.Count == 0)
                {
                    MessageBox.Show("Aucun étudiant trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                cmbEtudiants.DataSource = etudiants;
                cmbEtudiants.DisplayMember = "Nom";
                cmbEtudiants.ValueMember = "Id";
            }
        }

        private void ChargerNotes(int etudiantId)
        {
            using (var db = new AppDbContext())
            {
                var notes = db.Notes
                    .Where(n => n.EtudiantId == etudiantId)
                    .Select(n => new { Matière = n.Matiere.NomMatiere, Note = n.Valeur })
                    .ToList();

                dgvNotes.DataSource = notes;

                var etudiant = db.Etudiants.Find(etudiantId);
                lblMoyenne.Text = etudiant != null ? $"Moyenne Générale : {etudiant.MoyenneGenerale:F2}" : "Moyenne Générale : N/A";
            }
        }

        private void cmbEtudiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEtudiants.SelectedValue != null && int.TryParse(cmbEtudiants.SelectedValue.ToString(), out int etudiantId))
            {
                ChargerNotes(etudiantId);
            }
        }

        private void btnGenererPDF_Click(object sender, EventArgs e)
        {
            if (cmbEtudiants.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.FileName = $"Releve_Notes_{cmbEtudiants.Text}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExporterRelevePDF(sfd.FileName);
                }
            }
        }

        private void ExporterRelevePDF(string filePath)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    PdfFont italicFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_OBLIQUE);
                    PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                    // Titre
                    document.Add(new Paragraph("Relevé de Notes")
                        .SetFont(boldFont)
                        .SetFontSize(18)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                    document.Add(new Paragraph("\n"));

                    // Ligne de séparation
                    document.Add(new Paragraph("---------------------------------------------------"));

                    // Moyenne Générale
                    document.Add(new Paragraph(lblMoyenne.Text)
                        .SetFont(italicFont)
                        .SetFontSize(12));

                    document.Add(new Paragraph("\nNotes :")
                        .SetFont(boldFont)
                        .SetFontSize(14));

                    foreach (DataGridViewRow row in dgvNotes.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                        {
                            string matiere = row.Cells[0].Value.ToString();
                            string note = row.Cells[1].Value.ToString();
                            document.Add(new Paragraph($"{matiere} : {note}").SetFont(normalFont));
                        }
                    }

                    MessageBox.Show("Exportation réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'exportation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblMoyenne_Click(object sender, EventArgs e)
        {
            // ✅ Laisse vide si aucune action n'est prévue
        }


        private void FormReleveNotes_Load(object sender, EventArgs e)
        {
            ChargerEtudiants(); // ✅ Charge les étudiants au démarrage
        }


        private void CalculerEtEnregistrerMoyenne(int etudiantId)
        {
            using (var db = new AppDbContext())
            {
                var notes = db.Notes.Where(n => n.EtudiantId == etudiantId).Select(n => n.Valeur).ToList();

                if (notes.Any())
                {
                    float moyenne = notes.Average();

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
