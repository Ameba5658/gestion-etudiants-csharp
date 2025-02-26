using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetgestionsEtudiant.Models
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base("GestionEtudiantsDB") { }

        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<ProfesseurMatiere> ProfesseursMatieres { get; set; }
        public DbSet<ProfesseurClasse> ProfesseursClasses { get; set; }

    }
}
