using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using Common.Entities;

namespace DAL
{
    /// <summary>
    /// Database initializer.
    /// </summary>
    internal class DatabaseInitializer : CreateDatabaseIfNotExists<QasContext>
    {
        /// <summary>
        /// Filling context.
        /// </summary>
        /// <param name="context">Qas contex.</param>
        protected override void Seed(QasContext context)
        {
         }
    }
}
