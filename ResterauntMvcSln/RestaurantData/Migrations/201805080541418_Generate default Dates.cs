namespace RestaurantData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GeneratedefaultDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restaurants", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Restaurants", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Reviews", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Reviews", "Modified", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Modified", c => c.DateTime());
            AlterColumn("dbo.Reviews", "Created", c => c.DateTime());
            AlterColumn("dbo.Restaurants", "Modified", c => c.DateTime());
            AlterColumn("dbo.Restaurants", "Created", c => c.DateTime());
        }
    }
}
