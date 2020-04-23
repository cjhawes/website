using BusinessLogic.Repositories.Interfaces;
using Context.Models;
using Context.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLogic.Repositories
{
    public class BaseRepository<TEntity> : IGenericBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext DbContext;

        public BaseRepository()
        {
            DbContext = (DbContext)new WebsiteContext();
        }

        protected DbSet<TEntity> DbSet => DbContext.Set<TEntity>();

        public void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void InsertRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public IQueryable<TEntity> GetAllWithIncludes(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = DbSet.AsQueryable();
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return query;
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public TEntity SearchForSingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Local.AsQueryable().SingleOrDefault(predicate) ?? DbSet.SingleOrDefault(predicate);
        }

        public TEntity SearchForFirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Local.AsQueryable().FirstOrDefault(predicate) ?? DbSet.FirstOrDefault(predicate);
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public TEntity GetByPrimaryKey(params object[] primaryKey)
        {
            return DbSet.Find(primaryKey);
        }

        public TEntity UpdateEntity(TEntity entityToUpdate)
        {
            if (entityToUpdate == null)
            {
                throw new ArgumentNullException($"{nameof(entityToUpdate)}");
            }

            if (DbContext.Entry(entityToUpdate).State != EntityState.Added)
            {
                DbContext.Entry(entityToUpdate).State = EntityState.Modified;
            }

            return entityToUpdate;
        }

        public int Count()
        {
            return DbSet.Count();
        }

        public IEnumerable<string> GetChanges(TEntity entity)
        {
            List<string> changes = new List<string>();

            var entry = DbContext.Entry(entity);

            foreach (var property in entry.CurrentValues.PropertyNames)
            {
                var currentVal = entry.CurrentValues.GetValue<object>(property);
                var prevVal = entry.OriginalValues.GetValue<object>(property);
                if (!Equals(currentVal, prevVal))
                {
                    if (currentVal is null || string.IsNullOrEmpty(currentVal.ToString()))
                    {
                        changes.Add($"{property} was unset.");
                    }
                    else if (prevVal is null || string.IsNullOrEmpty(prevVal.ToString()))
                    {
                        changes.Add($"{property} was set to {currentVal}.");
                    }
                    else
                    {
                        changes.Add($"{property} was changed from {prevVal} to {currentVal}.");
                    }
                }
            }

            return changes;
        }
    }
}
