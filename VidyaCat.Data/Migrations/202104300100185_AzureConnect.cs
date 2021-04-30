namespace VidyaCat.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AzureConnect : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Platforms", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Games", "ReleaseYear");
            DropColumn("dbo.Platforms", "ReleaseYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Platforms", "ReleaseYear", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "ReleaseYear", c => c.DateTime(nullable: false));
            DropColumn("dbo.Platforms", "ReleaseDate");
            DropColumn("dbo.Games", "ReleaseDate");
        }
    }
}
