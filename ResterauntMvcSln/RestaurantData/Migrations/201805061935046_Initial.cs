namespace RestaurantData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Street1 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        phone = c.String(),
                        Zipcode = c.String(),
                        AvgRating = c.Int(),
                        Created = c.DateTime(),
                        Modified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Comments = c.String(maxLength: 200),
                        Created = c.DateTime(),
                        Modified = c.DateTime(),
                        Restaurant_Id = c.Int(),
                        Restaurant_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reviews", t => t.Restaurant_Id)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Id1)
                .Index(t => t.Restaurant_Id)
                .Index(t => t.Restaurant_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Restaurant_Id1", "dbo.Restaurants");
            DropForeignKey("dbo.Reviews", "Restaurant_Id", "dbo.Reviews");
            DropIndex("dbo.Reviews", new[] { "Restaurant_Id1" });
            DropIndex("dbo.Reviews", new[] { "Restaurant_Id" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Restaurants");
        }
    }
}
