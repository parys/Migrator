using System.Data.Entity;
using Common.Entities;

namespace DAL
{
    /// <summary>
    /// Qas context.
    /// </summary>
    public class QasContext : DbContext
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public QasContext()
            //: base("Data Source=ANDREW-PC;Initial Catalog=NewDbTest;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
        {
            //Database.SetInitializer<QasContext>(null);
            Database.SetInitializer(new DatabaseInitializer());
        }


        /// <summary>
        /// Represents a users set that is used to perform create, read, update, and delete operations.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Represents a qualifications set that is used to perform create, read, update, and delete operations.
        /// </summary>
        public DbSet<BlogItem> BlogItems { get; set; }

        /// <summary>
        /// Represents a roles set that is used to perform create, read, update, and delete operations.
        /// </summary>
        public DbSet<NewsItem> NewsItems { get; set; }
    }
}
