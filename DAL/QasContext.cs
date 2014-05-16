using System.Data.Entity;
using Common.Entities;
using DAL.models;

namespace DAL
{

    public class QasContext : DbContext
    {

        public QasContext()
        //: base("Data Source=ANDREW-PC;Initial Catalog=NewDbTest;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
        {
            //Database.SetInitializer<QasContext>(null);
            Database.SetInitializer(new DatabaseInitializer());
        }


        public DbSet<User> Users { get; set; }

        public DbSet<BlogItem> BlogItems { get; set; }

        public DbSet<NewsItem> NewsItems { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }

        public DbSet<NewsCategory> NewsCategories { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
