using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Etudiant.Models;

namespace Gestion_Etudiant.Donnes
{
    internal class DbGestionContext : DbContext
    {
        public DbGestionContext() : base("systeme")
        {
        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<OTPCode> OTPCodes { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Relation N:N entre Classe et Cours
            modelBuilder.Entity<Classe>()
                .HasMany(c => c.Cours)
                .WithMany(cr => cr.Classes)
                .Map(m =>
                {
                    m.ToTable("ClassesCours");
                    m.MapLeftKey("ClasseId");
                    m.MapRightKey("CoursId");
                });

            // Relation N:N entre Cours et Matiere
            modelBuilder.Entity<Cours>()
                .HasMany(cr => cr.Matieres)
                .WithMany(m => m.Cours)
                .Map(m =>
                {
                    m.ToTable("CoursMatieres");
                    m.MapLeftKey("CoursId");
                    m.MapRightKey("MatiereId");
                });

            // Relation N:N entre Professeur et Matiere
            modelBuilder.Entity<Professeur>()
                .HasMany(p => p.Matieres)
                .WithMany(m => m.Professeurs)
                .Map(m =>
                {
                    m.ToTable("ProfesseursMatieres");
                    m.MapLeftKey("ProfesseurId");
                    m.MapRightKey("MatiereId");
                });

            // Relation N:N entre Professeur et Classe
            modelBuilder.Entity<Professeur>()
                .HasMany(p => p.Classes)
                .WithMany(c => c.Professeurs)
                .Map(m =>
                {
                    m.ToTable("ProfesseursClasses");
                    m.MapLeftKey("ProfesseurId");
                    m.MapRightKey("ClasseId");
                });

            base.OnModelCreating(modelBuilder);
        }
    }

}
