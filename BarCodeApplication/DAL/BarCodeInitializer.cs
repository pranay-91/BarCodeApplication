using System;
using System.Data.Entity;
using BarCodeApplication.Models;

namespace BarCodeApplication.DAL
{
    public class BarCodeInitializer:DropCreateDatabaseAlways<BarCodeContext>
    {
        protected override void Seed(BarCodeContext context)
        {
            var j = new Job { Status = "Start", Start = new DateTime(1981, 12, 09), End = new DateTime(1983, 1, 20) };
            context.Job.Add(j);
            context.SaveChanges();
            base.Seed(context);
            
         
        }

    }
}