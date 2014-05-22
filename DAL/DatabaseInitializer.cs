using System.Data.Entity;
using MyLiverpoolSite.DataAccessLayer;

namespace DAL
{
    /// <summary>
    /// Database initializer.
    /// </summary>
    internal class DatabaseInitializer : CreateDatabaseIfNotExists<LiverpoolContext>
    {
        /// <summary>
        /// Filling context.
        /// </summary>
        /// <param name="context">Qas contex.</param>
        protected override void Seed(LiverpoolContext context)
        {
         }
    }
}
