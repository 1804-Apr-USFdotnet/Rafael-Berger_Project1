namespace RestaurantData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Somethingshouldwork : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "Created", c => c.DateTime());
            AddColumn("dbo.Restaurants", "Modified", c => c.DateTime());
            AddColumn("dbo.Reviews", "Created", c => c.DateTime());
            AddColumn("dbo.Reviews", "Modified", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Modified");
            DropColumn("dbo.Reviews", "Created");
            DropColumn("dbo.Restaurants", "Modified");
            DropColumn("dbo.Restaurants", "Created");
        }
    }
}
