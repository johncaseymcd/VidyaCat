namespace VidyaCat.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDev : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Platforms", "Game_GameID", "dbo.Games");
            DropIndex("dbo.Platforms", new[] { "Game_GameID" });
            DropColumn("dbo.Platforms", "Game_GameID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Platforms", "Game_GameID", c => c.Int());
            CreateIndex("dbo.Platforms", "Game_GameID");
            AddForeignKey("dbo.Platforms", "Game_GameID", "dbo.Games", "GameID");
        }
    }
}
