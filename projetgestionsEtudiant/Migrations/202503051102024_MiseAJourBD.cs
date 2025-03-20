namespace projetgestionsEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MiseAJourBD : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Etudiants", "MoyenneGenerale", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Etudiants", "MoyenneGenerale", c => c.Single(nullable: false));
        }
    }
}
