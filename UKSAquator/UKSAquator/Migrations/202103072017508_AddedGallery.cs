namespace UKSAquator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGallery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        GalleryFileName = c.String(),
                        NewsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryId)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .Index(t => t.NewsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Galleries", "NewsId", "dbo.News");
            DropIndex("dbo.Galleries", new[] { "NewsId" });
            DropTable("dbo.Galleries");
        }
    }
}
