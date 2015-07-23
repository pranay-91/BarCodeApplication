using System.Data.Entity;
using BarCodeApplication.Models;

namespace BarCodeApplication.DAL
{
    public class BarCodeContext:DbContext
    {
        public BarCodeContext() : base("name=BarCodeDatabase")
        {

            //Database.SetInitializer<BarCodeContext>(new BarCodeInitializer());
            
            //Turn off DbInitilizer in code first for production environment
            Database.SetInitializer<BarCodeContext>(null);
        }

        public DbSet<Import> Import { get; set; }
        public DbSet<Job> Job { get; set; }
    }
}