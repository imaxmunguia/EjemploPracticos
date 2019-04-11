namespace MvcMusicStore.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ArtistId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlbumId)
                .ForeignKey("dbo.Artists", t => t.ArtistId, cascadeDelete: true)
                .Index(t => t.ArtistId);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ArtistId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        AlbumId = c.Int(nullable: false),
                        Contents = c.String(),
                        ReviewerEmail = c.String(),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .Index(t => t.AlbumId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Albums", "ArtistId", "dbo.Artists");
            DropIndex("dbo.Reviews", new[] { "AlbumId" });
            DropIndex("dbo.Albums", new[] { "ArtistId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
