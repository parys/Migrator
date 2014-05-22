using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MyLiverpoolSite.DataAccessLayer
{
    /// <summary>
    /// Generic repository.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly LiverpoolContext _context;
        private readonly DbSet<TEntity> _dbSet;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="context">Qas context.</param>
        public GenericRepository(LiverpoolContext context)
        {
            this._context = context;
            _dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Returns all objects of given type.
        /// </summary>
        /// <param name="filter">Filter for selecting desired data.</param>
        /// <param name="includeProperties">Included properties.</param>
        /// <returns>List with filtered data.</returns>
        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            string includeProperties = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.ToList();
        }

        /// <summary>
        /// Returns element by id.
        /// </summary>
        /// <param name="id">Entity id.</param>
        /// <returns>Entity.</returns>
        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Adds object to repository.
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// Deletes object from repository by id.
        /// </summary>
        /// <param name="id">Entity id.</param>
        public virtual void Delete(object id)
        {
            Delete(_dbSet.Find(id));
        }

        /// <summary>
        /// Deletes object from repository by entity.
        /// </summary>
        /// <param name="entityToDelete">Entity to delete.</param>
        public virtual void Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Updates object in repository.
        /// </summary>
        /// <param name="entityToUpdate">Entity to update.</param>
        public virtual void Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}