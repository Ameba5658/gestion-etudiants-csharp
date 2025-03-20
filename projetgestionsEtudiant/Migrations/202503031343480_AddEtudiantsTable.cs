namespace projetgestionsEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEtudiantsTable : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Etudiants", "ClasseId", "dbo.Classes");
            DropIndex("dbo.Etudiants", new[] { "ClasseId" });
            DropTable("dbo.Etudiants");
        }
    }
}
