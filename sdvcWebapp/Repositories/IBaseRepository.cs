using sdvcWebapp.Models;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace sdvcWebapp.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity FindById(int id);
        IList<TEntity> GetAll();
        IList<TEntity> FindAny(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity Update(TEntity entity);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void RemoveById(int id);
        void PersistChanges();
    }
}