namespace Gestion_Etudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_de_la_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatiere = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valeur = c.Single(nullable: false),
                        EtudiantId = c.Int(nullable: false),
                        MatiereId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.EtudiantId, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.MatiereId, cascadeDelete: true)
                .Index(t => t.EtudiantId)
                .Index(t => t.MatiereId);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Sexe = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        ClasseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClasseId, cascadeDelete: true)
                .Index(t => t.ClasseId);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        DateExpiration = c.DateTime(nullable: false),
                        UtilisateurId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.UtilisateurId, cascadeDelete: true)
                .Index(t => t.UtilisateurId);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(),
                        MotDePasse = c.String(),
                        Role = c.String(),
                        Telephone = c.String(),
                        Active = c.Boolean(nullable: false),
                        OtpExpiration = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfesseursClasses",
                c => new
                    {
                        ProfesseurId = c.Int(nullable: false),
                        ClasseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProfesseurId, t.ClasseId })
                .ForeignKey("dbo.Professeurs", t => t.ProfesseurId, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.ClasseId, cascadeDelete: true)
                .Index(t => t.ProfesseurId)
                .Index(t => t.ClasseId);
            
            CreateTable(
                "dbo.ProfesseursMatieres",
                c => new
                    {
                        ProfesseurId = c.Int(nullable: false),
                        MatiereId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProfesseurId, t.MatiereId })
                .ForeignKey("dbo.Professeurs", t => t.ProfesseurId, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.MatiereId, cascadeDelete: true)
                .Index(t => t.ProfesseurId)
                .Index(t => t.MatiereId);
            
            CreateTable(
                "dbo.CoursMatieres",
                c => new
                    {
                        CoursId = c.Int(nullable: false),
                        MatiereId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CoursId, t.MatiereId })
                .ForeignKey("dbo.Cours", t => t.CoursId, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.MatiereId, cascadeDelete: true)
                .Index(t => t.CoursId)
                .Index(t => t.MatiereId);
            
            CreateTable(
                "dbo.ClassesCours",
                c => new
                    {
                        ClasseId = c.Int(nullable: false),
                        CoursId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClasseId, t.CoursId })
                .ForeignKey("dbo.Classes", t => t.ClasseId, cascadeDelete: true)
                .ForeignKey("dbo.Cours", t => t.CoursId, cascadeDelete: true)
                .Index(t => t.ClasseId)
                .Index(t => t.CoursId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OTPCodes", "UtilisateurId", "dbo.Utilisateurs");
            DropForeignKey("dbo.ClassesCours", "CoursId", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "ClasseId", "dbo.Classes");
            DropForeignKey("dbo.CoursMatieres", "MatiereId", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieres", "CoursId", "dbo.Cours");
            DropForeignKey("dbo.ProfesseursMatieres", "MatiereId", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseursMatieres", "ProfesseurId", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "ClasseId", "dbo.Classes");
            DropForeignKey("dbo.ProfesseursClasses", "ProfesseurId", "dbo.Professeurs");
            DropForeignKey("dbo.Notes", "MatiereId", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "EtudiantId", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "ClasseId", "dbo.Classes");
            DropIndex("dbo.ClassesCours", new[] { "CoursId" });
            DropIndex("dbo.ClassesCours", new[] { "ClasseId" });
            DropIndex("dbo.CoursMatieres", new[] { "MatiereId" });
            DropIndex("dbo.CoursMatieres", new[] { "CoursId" });
            DropIndex("dbo.ProfesseursMatieres", new[] { "MatiereId" });
            DropIndex("dbo.ProfesseursMatieres", new[] { "ProfesseurId" });
            DropIndex("dbo.ProfesseursClasses", new[] { "ClasseId" });
            DropIndex("dbo.ProfesseursClasses", new[] { "ProfesseurId" });
            DropIndex("dbo.OTPCodes", new[] { "UtilisateurId" });
            DropIndex("dbo.Etudiants", new[] { "ClasseId" });
            DropIndex("dbo.Notes", new[] { "MatiereId" });
            DropIndex("dbo.Notes", new[] { "EtudiantId" });
            DropTable("dbo.ClassesCours");
            DropTable("dbo.CoursMatieres");
            DropTable("dbo.ProfesseursMatieres");
            DropTable("dbo.ProfesseursClasses");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.Professeurs");
            DropTable("dbo.Etudiants");
            DropTable("dbo.Notes");
            DropTable("dbo.Matieres");
            DropTable("dbo.Cours");
            DropTable("dbo.Classes");
        }
    }
}
