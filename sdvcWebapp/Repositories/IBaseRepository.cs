using sdvcWebapp.Models;
using System.Collections.Generic;

namespace sdvcWebapp.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity FindById(int id);
        int Add(TEntity entity);
        TEntity Update(TEntity entity);
        void RemoveById(int id);
    // void RemoveRange(IEnumerable<TEntity> entities);
    }
}