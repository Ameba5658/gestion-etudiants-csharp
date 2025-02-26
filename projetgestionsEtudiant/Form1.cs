using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetgestionsEtudiant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGestionClasses_Click(object sender, EventArgs e)
        {
            FormClasse form = new FormClasse();
            form.Show();
        }

        private void btnGestionClasses_Click_1(object sender, EventArgs e)
        {
            FormClasse form = new FormClasse();
            form.Show();
        }

        private void btnGestionMatieres_Click(object sender, EventArgs e)
        {
            FormMatiere form = new FormMatiere();
            form.Show();
        }

        private void btnGestionProfesseurs_Click(object sender, EventArgs e)
        {
            FormProfesseur form = new FormProfesseur();
            form.Show();
        }

        private void btnAssocierProfesseurs_Click(object sender, EventArgs e)
        {
            FormAssocierProfesseur form = new FormAssocierProfesseur();
            form.Show();
        }
    }
}
