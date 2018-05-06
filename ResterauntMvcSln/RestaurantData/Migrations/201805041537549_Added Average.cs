namespace RestaurantData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAverage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restauraunts", "AvgRating", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restauraunts", "AvgRating");
        }
    }
}
