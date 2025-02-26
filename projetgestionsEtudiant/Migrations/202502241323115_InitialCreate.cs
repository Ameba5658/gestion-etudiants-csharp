namespace projetgestionsEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                        Professeur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id)
                .Index(t => t.Professeur_Id);
            
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
                        Professeur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id)
                .Index(t => t.Professeur_Id);
            
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
                "dbo.CoursClasses",
                c => new
                    {
                        Cours_Id = c.Int(nullable: false),
                        Classe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cours_Id, t.Classe_Id })
                .ForeignKey("dbo.Cours", t => t.Cours_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Classe_Id, cascadeDelete: true)
                .Index(t => t.Cours_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.MatiereClasses",
                c => new
                    {
                        Matiere_Id = c.Int(nullable: false),
                        Classe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Matiere_Id, t.Classe_Id })
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Classe_Id, cascadeDelete: true)
                .Index(t => t.Matiere_Id)
                .Index(t => t.Classe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matieres", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.Classes", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.MatiereClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.MatiereClasses", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.CoursClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.CoursClasses", "Cours_Id", "dbo.Cours");
            DropIndex("dbo.MatiereClasses", new[] { "Classe_Id" });
            DropIndex("dbo.MatiereClasses", new[] { "Matiere_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Classe_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Cours_Id" });
            DropIndex("dbo.Matieres", new[] { "Professeur_Id" });
            DropIndex("dbo.Classes", new[] { "Professeur_Id" });
            DropTable("dbo.MatiereClasses");
            DropTable("dbo.CoursClasses");
            DropTable("dbo.Professeurs");
            DropTable("dbo.Matieres");
            DropTable("dbo.Cours");
            DropTable("dbo.Classes");
        }
    }
}
