namespace VidyaCat.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Platforms", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetRoles", "UserDbID", c => c.Int());
            AddColumn("dbo.AspNetRoles", "UserID", c => c.Guid());
            AddColumn("dbo.AspNetRoles", "Role", c => c.String());
            AddColumn("dbo.AspNetRoles", "EmailAddress", c => c.String());
            AddColumn("dbo.AspNetRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Games", "ReleaseYear");
            DropColumn("dbo.Platforms", "ReleaseYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Platforms", "ReleaseYear", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "ReleaseYear", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetRoles", "Discriminator");
            DropColumn("dbo.AspNetRoles", "EmailAddress");
            DropColumn("dbo.AspNetRoles", "Role");
            DropColumn("dbo.AspNetRoles", "UserID");
            DropColumn("dbo.AspNetRoles", "UserDbID");
            DropColumn("dbo.Platforms", "ReleaseDate");
            DropColumn("dbo.Games", "ReleaseDate");
        }
    }
}
