using System.Data.Entity.Migrations;
using MyLiverpoolSite.DataAccessLayer;

namespace DAL.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<LiverpoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LiverpoolContext context)
        {
        }
    }
}
