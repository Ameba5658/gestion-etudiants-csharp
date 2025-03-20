namespace projetgestionsEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EtudiantId = c.Int(nullable: false),
                        MatiereId = c.Int(nullable: false),
                        Valeur = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.EtudiantId, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.MatiereId, cascadeDelete: true)
                .Index(t => t.EtudiantId)
                .Index(t => t.MatiereId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "MatiereId", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "EtudiantId", "dbo.Etudiants");
            DropIndex("dbo.Notes", new[] { "MatiereId" });
            DropIndex("dbo.Notes", new[] { "EtudiantId" });
            DropTable("dbo.Notes");
        }
    }
}
