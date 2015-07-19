using System.Data.Entity;

namespace BarCodeApplication.DAL
{
    public class BarCodeInitializer:DropCreateDatabaseAlways<BarCodeContext>
    {
        protected override void Seed(BarCodeContext context)
        {
            base.Seed(context);
        }
    }
}