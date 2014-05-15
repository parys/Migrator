using System.Data.Entity.Migrations;

namespace DAL.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<QasContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QasContext context)
        {
        }
    }
}
