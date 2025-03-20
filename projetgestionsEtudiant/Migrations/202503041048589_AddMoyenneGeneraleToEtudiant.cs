namespace projetgestionsEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoyenneGeneraleToEtudiant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Etudiants", "MoyenneGenerale", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Etudiants", "MoyenneGenerale");
        }
    }
}
