using System;
using System.Linq;
using System.Windows.Forms;
using Gestion_Etudiant.Donnes;
using Gestion_Etudiant.Forms;
using Gestion_Etudiant.Models;
using Gestion_Etudiant.Services; // Importer le service OTP
using BCrypt.Net;

namespace Gestion_Etudiant
{
    public partial class loginForm : Form
    {
        private readonly DbGestionContext _context;
        private readonly OtpService _otpService;
        private string generatedOTP;
        private string userPhoneNumber;

        public loginForm()
        {
            InitializeComponent();
            _context = new DbGestionContext();
            _otpService = new OtpService(); // Initialiser le service OTP

            textBox2.PasswordChar = '*'; // Masquer le mot de passe
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = textBox1.Text;
            string motDePasse = textBox2.Text;

            if (string.IsNullOrEmpty(nomUtilisateur) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var user = _context.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == nomUtilisateur);

                if (user != null && BCrypt.Net.BCrypt.Verify(motDePasse, user.MotDePasse))
                {
                    userPhoneNumber = user.Telephone; // Récupérer le numéro de téléphone
                    generatedOTP = _otpService.GenerateOtp(); // Générer un OTP
                    _otpService.SendOtp(userPhoneNumber, generatedOTP); // Envoyer l'OTP par SMS

                    MessageBox.Show("Un code de vérification a été envoyé à votre téléphone.", "Vérification OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Activer la saisie OTP
                    textBox3.Enabled = true;
                    verifyOtpButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verifyOtpButton_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == generatedOTP)
            {
                MessageBox.Show("Connexion réussie", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Code OTP incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
