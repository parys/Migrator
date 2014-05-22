﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyLiverpoolSite.DataAccessLayer
{
    /// <summary>
    /// Mediator interface that acts as an abstraction layer between domain and data layer.
    /// Maintains a list of domain model objects of given type.
    /// Provides CRUD (create, read, update, delete) operations on given type of objects.
    /// </summary>
    public interface IGenericRepository<TEntity>
    {
        /// <summary>
        /// Returns all objects of given type.
        /// </summary>
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            string includeProperties = "");

        /// <summary>
        /// Returns element by id
        /// </summary>
        TEntity GetById(object id);

        /// <summary>
        /// Adds object to repository.
        /// </summary>
        void Add(TEntity entity);

        /// <summary>
        /// Deletes object from repository by id.
        /// </summary>
        void Delete(object id);

        /// <summary>
        /// Deletes object from repository by entity.
        /// </summary>
        void Delete(TEntity entity);

        /// <summary>
        /// Updates object in repository.
        /// </summary>
        void Update(TEntity entity);
    }
}

