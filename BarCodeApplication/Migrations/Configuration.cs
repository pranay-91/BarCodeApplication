namespace BarCodeApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BarCodeApplication.Models;
    

    internal sealed class Configuration : DbMigrationsConfiguration<BarCodeApplication.DAL.BarCodeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BarCodeApplication.DAL.BarCodeContext";
        }

        protected override void Seed(BarCodeApplication.DAL.BarCodeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Job.AddOrUpdate(x => x.Id,
                new Job()
                {
                    Id = 1,

                    Status = "started",
                    Start = new DateTime(1988, 09, 09),
                    End = new DateTime(1988, 09, 29)
                },
                new Job()
                {
                    Id = 2,
                    Status = "started",
                    Start = new DateTime(1998, 09, 09),
                    End = new DateTime(1998, 09, 29)
                },
                new Job()
                {
                    Id = 3,
                    Status = "started",
                    Start = new DateTime(2008, 09, 09),
                    End = new DateTime(2008, 09, 29)
                }
                );

            context.Import.AddOrUpdate(x => x.Id,
                new Import()
                {
                    Ref = "BHHO-SME-D-PL-BWK-01/A",
                    Customer = "A.G.COOMBS",
                    CompanyName = "DuctMakers Pty Ltd",
                    JobNo = "G381-09",
                    ItemNo = "1",
                    LabourCode = "10",
                    Description = "Input Straight",
                    PieceNo = "G381-09-01",
                    Project = "AGC/(G381) Bendigo Hospital"
                },
                new Import()
                {
                    Ref = "BHHO-SME-D-PL-BWK-01/A",
                    Customer = "A.G.COOMBS",
                    CompanyName = "DuctMakers Pty Ltd",
                    JobNo = "G381-09",
                    ItemNo = "2",
                    LabourCode = "10",
                    Description = "Input Straight",
                    PieceNo = "G381-09-01",
                    Project = "AGC/(G381) Bendigo Hospital"

                });

        }
    }
}
