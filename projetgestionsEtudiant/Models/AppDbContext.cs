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
        internal object ClasseCours;
        private DbSet<ClasseCours> classeCours;
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public AppDbContext() : base("GestionEtudiantsDB") { }

        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<ProfesseurMatiere> ProfesseursMatieres { get; set; }
        public DbSet<ProfesseurClasse> ProfesseursClasses { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Note> Notes { get; set; }
       

        public DbSet<ClasseCours> GetClasseCours()
        {
            return classeCours;
        }

        public void SetClasseCours(DbSet<ClasseCours> value)
        {
            classeCours = value;
        }

        public DbSet<ClasseMatiere> ClasseMatiere { get; set; }

     

      
    }
}
