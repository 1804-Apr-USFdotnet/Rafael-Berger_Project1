namespace RestaurantData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deletigcreated : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restaurants", "Created");
            DropColumn("dbo.Restaurants", "Modified");
            DropColumn("dbo.Reviews", "Created");
            DropColumn("dbo.Reviews", "Modified");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Modified", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reviews", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Restaurants", "Modified", c => c.DateTime(nullable: false));
            AddColumn("dbo.Restaurants", "Created", c => c.DateTime(nullable: false));
        }
    }
}
