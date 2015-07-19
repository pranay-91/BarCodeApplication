using System.Data.Entity;
using BarCodeApplication.Models;

namespace BarCodeApplication.DAL
{
    public class BarCodeContext:DbContext
    {
        public BarCodeContext() : base("name=BarCodeDatabase")
        {

            Database.SetInitializer<BarCodeContext>(new BarCodeInitializer());
        }

        public DbSet<Import> Import { get; set; }
        public DbSet<Job> Job { get; set; }
    }
}