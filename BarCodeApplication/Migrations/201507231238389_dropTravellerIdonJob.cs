namespace BarCodeApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropTravellerIdonJob : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Jobs", "TravellerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jobs", "TravellerId", c=> c.String(maxLength:15));
        }
    }
}
