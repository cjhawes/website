using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLogic.Repositories.Interfaces
{
    public interface IGenericBaseRepository<TEntity> : IBaseRepository
    {
        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);
        TEntity SearchForSingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllWithIncludes(params Expression<Func<TEntity, object>>[] includes);
        TEntity GetByPrimaryKey(params object[] primaryKey);
        TEntity UpdateEntity(TEntity entityToUpdate);
        IEnumerable<string> GetChanges(TEntity entity);
    }
}
