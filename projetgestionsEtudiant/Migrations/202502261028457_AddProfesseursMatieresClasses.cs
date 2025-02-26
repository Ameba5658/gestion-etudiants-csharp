namespace projetgestionsEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProfesseursMatieresClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProfesseurClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfesseurId = c.Int(nullable: false),
                        ClasseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClasseId, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.ProfesseurId, cascadeDelete: true)
                .Index(t => t.ProfesseurId)
                .Index(t => t.ClasseId);
            
            CreateTable(
                "dbo.ProfesseurMatieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfesseurId = c.Int(nullable: false),
                        MatiereId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matieres", t => t.MatiereId, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.ProfesseurId, cascadeDelete: true)
                .Index(t => t.ProfesseurId)
                .Index(t => t.MatiereId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfesseurMatieres", "ProfesseurId", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseurMatieres", "MatiereId", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseurClasses", "ProfesseurId", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseurClasses", "ClasseId", "dbo.Classes");
            DropIndex("dbo.ProfesseurMatieres", new[] { "MatiereId" });
            DropIndex("dbo.ProfesseurMatieres", new[] { "ProfesseurId" });
            DropIndex("dbo.ProfesseurClasses", new[] { "ClasseId" });
            DropIndex("dbo.ProfesseurClasses", new[] { "ProfesseurId" });
            DropTable("dbo.ProfesseurMatieres");
            DropTable("dbo.ProfesseurClasses");
        }
    }
}
