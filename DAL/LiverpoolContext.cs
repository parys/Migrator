using System.Data.Entity;
using DAL;
using DAL.models;

namespace MyLiverpoolSite.DataAccessLayer
{

    public class LiverpoolContext : DbContext
    {

        public LiverpoolContext()
            //: base("Data Source=KAPITANCHIKA\\SQLEXPRESS;Initial Catalog=LiverpoolDatabase1;Integrated Security=False;")
            //: base(@"Data Source=KAPITANCHIKA\SQLEXPRESS;Initial Catalog=LiverpoolDatabase1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
          //  : base("Data Source=KAPITANCHIKA\\SQLEXPRESS;Initial Catalog=MyLiverpoolSite.DataAccessLayer.LiverpoolContext;Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
        {
            Database.SetInitializer<LiverpoolContext>(null);
           // Database.SetInitializer(new DatabaseInitializer());
        }


        public DbSet<User> Users { get; set; }

        public DbSet<BlogItem> BlogItems { get; set; }

        public DbSet<NewsItem> NewsItems { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }

        public DbSet<NewsCategory> NewsCategories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<ForumSection> ForumSections { get; set; }

        public DbSet<ForumSubsection> ForumSubsections { get; set; }

        public DbSet<ForumTheme> ForumThemes { get; set; }

        public DbSet<ForumMessage> ForumMessages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BlogCategory>().HasMany(blogCategory => blogCategory.BlogItems).WithRequired();

            //modelBuilder.Entity<BlogItem>().HasRequired(blogItem => blogItem.Category).WithRequiredPrincipal();

            //modelBuilder.Entity<NewsCategory>().HasMany(newsCategory => newsCategory.NewsItems).WithRequired();

            //modelBuilder.Entity<NewsItem>().HasRequired(newsItem => newsItem.Category).WithRequiredPrincipal();

         //   modelBuilder.Entity<BlogCategory>().HasMany(blogCategory => blogCategory.BlogItems).WithRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
