using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    /// <summary>
    /// Provides data access layer to database using Entity Framework.
    /// Defines CRUD (create, read, update, delete) operations for given entity type.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public class EntityFrameworkGenericRepository<T> : IGenericRepository<T>
        where T : class 
    {
        private readonly DbSet<T> dbSet;

        /// <summary>
        ///  The class constructor.
        /// </summary>
        /// <param name="dbSet">Represents a typed entity set that is used to
        ///  perform create, read, update, and delete operations</param>
        public EntityFrameworkGenericRepository(DbSet<T> dbSet)
        {
            this.dbSet = dbSet;
        }

        /// <summary>
        /// Adds given entity to repository.
        /// </summary>f
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        /// <summary>
        /// Deletes given entity from repository.
        /// </summary>
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        /// <summary>
        /// Updates entity properties.
        /// </summary>
        /// <param name="entity">Entity which properties are to be updated.</param>
        public void Update(T entity)
        {
            dbSet.AddOrUpdate(entity);
        }

        /// <summary>
        /// Returns all entities of type T.
        /// </summary>
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            var query = dbSet.AsQueryable();
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }
            return query.ToList();
        }
    }
}
