namespace VidyaCat.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seeding : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Platforms", "IsCurrent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Platforms", "IsCurrent", c => c.Boolean(nullable: false));
        }
    }
}
