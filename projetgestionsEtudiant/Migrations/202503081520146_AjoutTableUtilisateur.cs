namespace projetgestionsEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutTableUtilisateur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        MotDePasse = c.String(nullable: false),
                        NumeroTelephone = c.String(nullable: false, maxLength: 20),
                        Role = c.String(nullable: false),
                        EstActive = c.Boolean(nullable: false),
                        CodeValidation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilisateurs");
        }
    }
}
