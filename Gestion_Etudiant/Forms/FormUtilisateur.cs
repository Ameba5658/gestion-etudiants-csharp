using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Etudiant.Models;
using Gestion_Etudiant.Services;

namespace Gestion_Etudiant.Forms
{
    public partial class FormUtilisateur : Form
    {
        private UtilisateurService _utilisateurService;
        public FormUtilisateur()
        {
            InitializeComponent();
            _utilisateurService = new UtilisateurService();
            ChargerUtilisateurs();
        }
        private void ChargerUtilisateurs()
        {
            var utilisateurs = _utilisateurService.ListerUtilisateurs();
            dataGridView1.DataSource = utilisateurs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            var utilisateur = new Utilisateur
            {
                NomUtilisateur = txtNomUtilisateur.Text,
                MotDePasse = txtMotDePasse.Text,  // Assurez-vous de hasher le mot de passe avant de le sauvegarder
                Role = comboBox1.SelectedItem.ToString(),
                Telephone = txtTelephone.Text,
                //  Active = chkActive.Checked
            };

            _utilisateurService.AjouterUtilisateur(utilisateur);
            ChargerUtilisateurs(); // Rafraîchir la liste

        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            var utilisateur = new Utilisateur
            {
                NomUtilisateur = txtNomUtilisateur.Text,
                MotDePasse = txtMotDePasse.Text,  // Assurez-vous de hasher le mot de passe avant de le sauvegarder
                Role = comboBox1.SelectedItem.ToString(),
                Telephone = txtTelephone.Text,
                //  Active = chkActive.Checked
            };
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value); // L'ID de l'utilisateur à modifier
            _utilisateurService.ModifierUtilisateur(id, utilisateur);
            ChargerUtilisateurs(); // Rafraîchir la liste
        }

        private void buttS_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value); // L'ID de l'utilisateur à supprimer
            _utilisateurService.SupprimerUtilisateur(id);
            ChargerUtilisateurs(); // Rafraîchir la liste
        }
    }
}    
    

