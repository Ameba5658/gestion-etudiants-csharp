namespace projetgestionsEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_ClasseCours_ClasseMatiere : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClasseMatieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClasseId = c.Int(nullable: false),
                        MatiereId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClasseId, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.MatiereId, cascadeDelete: true)
                .Index(t => t.ClasseId)
                .Index(t => t.MatiereId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClasseMatieres", "MatiereId", "dbo.Matieres");
            DropForeignKey("dbo.ClasseMatieres", "ClasseId", "dbo.Classes");
            DropIndex("dbo.ClasseMatieres", new[] { "MatiereId" });
            DropIndex("dbo.ClasseMatieres", new[] { "ClasseId" });
            DropTable("dbo.ClasseMatieres");
        }
    }
}
