namespace BarCodeApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeJobImportModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imports", "PieceNo", c => c.String(maxLength: 15));
            AddColumn("dbo.Imports", "Project", c => c.String(maxLength: 40));
            AddColumn("dbo.Imports", "CompanyName", c => c.String(maxLength: 40));
            AddColumn("dbo.Jobs", "PieceNo", c => c.String(maxLength: 30));
            AlterColumn("dbo.Imports", "Ref", c => c.String(maxLength: 30));
            AlterColumn("dbo.Imports", "Customer", c => c.String(maxLength: 30));
            AlterColumn("dbo.Imports", "JobNo", c => c.String(maxLength: 15));
            AlterColumn("dbo.Imports", "ItemNo", c => c.String(maxLength: 15));
            AlterColumn("dbo.Imports", "LabourCode", c => c.String(maxLength: 15));
            AlterColumn("dbo.Imports", "Description", c => c.String(maxLength: 40));
            DropColumn("dbo.Imports", "TravellerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imports", "TravellerId", c => c.String(maxLength: 10));
            AlterColumn("dbo.Imports", "Description", c => c.String(maxLength: 30));
            AlterColumn("dbo.Imports", "LabourCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.Imports", "ItemNo", c => c.String(maxLength: 10));
            AlterColumn("dbo.Imports", "JobNo", c => c.String(maxLength: 10));
            AlterColumn("dbo.Imports", "Customer", c => c.String(maxLength: 20));
            AlterColumn("dbo.Imports", "Ref", c => c.String(maxLength: 15));
            DropColumn("dbo.Jobs", "PieceNo");
            DropColumn("dbo.Imports", "CompanyName");
            DropColumn("dbo.Imports", "Project");
            DropColumn("dbo.Imports", "PieceNo");
        }
    }
}
