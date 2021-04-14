namespace VidyaCat.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestingMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        DeveloperID = c.Int(nullable: false, identity: true),
                        DeveloperName = c.String(nullable: false),
                        Region = c.Int(nullable: false),
                        IsMajor = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DeveloperID);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ReleaseYear = c.DateTime(nullable: false),
                        Genre = c.Int(nullable: false),
                        FirstSubgenre = c.Int(nullable: false),
                        SecondSubgenre = c.Int(nullable: false),
                        ThirdSubgenre = c.Int(nullable: false),
                        DeveloperID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameID)
                .ForeignKey("dbo.Developers", t => t.DeveloperID, cascadeDelete: true)
                .Index(t => t.DeveloperID);
            
            CreateTable(
                "dbo.Platforms",
                c => new
                    {
                        PlatformID = c.Int(nullable: false, identity: true),
                        Brand = c.Int(nullable: false),
                        PlatformName = c.String(nullable: false),
                        ReleaseYear = c.DateTime(nullable: false),
                        IsCurrent = c.Boolean(nullable: false),
                        Game_GameID = c.Int(),
                    })
                .PrimaryKey(t => t.PlatformID)
                .ForeignKey("dbo.Games", t => t.Game_GameID)
                .Index(t => t.Game_GameID);            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Games", "DeveloperID", "dbo.Developers");
            DropForeignKey("dbo.Platforms", "Game_GameID", "dbo.Games");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Platforms", new[] { "Game_GameID" });
            DropIndex("dbo.Games", new[] { "DeveloperID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Platforms");
            DropTable("dbo.Games");
            DropTable("dbo.Developers");
        }
    }
}
