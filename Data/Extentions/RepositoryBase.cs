using Data.Extentions.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Extentions
{
    public abstract class RepositoryBase<TContext, TEntity> : IRepositoryBase<TEntity>
       where TContext : DbContext
       where TEntity : class
    {
        protected TContext Context { get; set; }

        public RepositoryBase(TContext context)
        {
            this.Context = context;
        }
        public IQueryable<TEntity> FindAll()
        {
            return this.Context.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return this.Context.Set<TEntity>()
                .Where(expression).AsNoTracking();
        }

        public void Create(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            this.Context.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            this.Context.Set<TEntity>().Remove(entity);
        }

    }
}
