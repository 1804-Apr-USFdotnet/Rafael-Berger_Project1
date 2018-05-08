namespace RestaurantData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pleasework : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "Restaurant_Id" });
            AlterColumn("dbo.Reviews", "Restaurant_Id", c => c.Int());
            CreateIndex("dbo.Reviews", "Restaurant_Id");
            AddForeignKey("dbo.Reviews", "Restaurant_Id", "dbo.Restaurants", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "Restaurant_Id" });
            AlterColumn("dbo.Reviews", "Restaurant_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "Restaurant_Id");
            AddForeignKey("dbo.Reviews", "Restaurant_Id", "dbo.Restaurants", "Id", cascadeDelete: true);
        }
    }
}
