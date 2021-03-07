namespace UKSAquator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        NewsTitle = c.String(),
                        Description = c.String(),
                        CountryEvent = c.String(),
                        CityEvent = c.String(),
                        StartDateEvent = c.DateTime(nullable: false),
                        EndDateEvent = c.DateTime(nullable: false),
                        PublicationDate = c.DateTime(nullable: false),
                        CoverFileName = c.String(),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.NewsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
        }
    }
}
