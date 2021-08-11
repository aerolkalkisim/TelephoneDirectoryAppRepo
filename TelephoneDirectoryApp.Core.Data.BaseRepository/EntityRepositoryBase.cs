using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Data.DataContext;

namespace TelephoneDirectoryApp.Core.Data.BaseRepository
{
    public abstract class EntityRepositoryBase<T> : IEntityRepository<T> where T : class
    {
        protected DbSet<T> dbSet { get; set; }
        protected ProjectDbContext dataContext { get; private set; }

        protected EntityRepositoryBase(ProjectDbContext context)
        {
            this.dataContext = context;
            this.dbSet = dataContext.Set<T>();
        }

        public List<T> Get(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return dbSet.AsNoTracking().ToList();
            }
            else
            {
                return dbSet.Where(filter).AsNoTracking().ToList();
            }
        }

        public virtual T GetFirst(Expression<Func<T, bool>> filter = null)
        {
            return filter != null ? dbSet.FirstOrDefault(filter) : dbSet.FirstOrDefault();
        }

        #region Async   
        public Task<List<T>> GetAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return dbSet.ToListAsync();
            }
            else
            {
                return dbSet.Where(filter).ToListAsync();
            }
        }

        public virtual Task<T> GetFirstAsync(Expression<Func<T, bool>> filter = null)
        {
            return filter != null ? dbSet.FirstOrDefaultAsync(filter) : dbSet.FirstOrDefaultAsync();
        }
        #endregion

        public virtual T Create(T entity)
        {
            dbSet.Add(entity);
            dataContext.SaveChanges();
            return entity;
        }

        public virtual T Update(T entity)
        {
            dbSet.Update(entity);
            //dataContext.Entry(entity).State = EntityState.Modified;
            dataContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            dataContext.SaveChanges();
        }

        public void Delete(object id)
        {
            dbSet.Remove(dbSet.Find(id));
            dataContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dataContext.Dispose();

                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
