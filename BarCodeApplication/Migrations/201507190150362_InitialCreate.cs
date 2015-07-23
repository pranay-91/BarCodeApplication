namespace BarCodeApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ref = c.String(maxLength: 15),
                        Customer = c.String(maxLength: 20),
                        JobNo = c.String(maxLength: 10),
                        ItemNo = c.String(maxLength: 10),
                        LabourCode = c.String(maxLength: 10),
                        Description = c.String(maxLength: 30),
                        TravellerId = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TravellerId = c.String(maxLength: 15),
                        Status = c.String(maxLength: 12),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jobs");
            DropTable("dbo.Imports");
        }
    }
}
