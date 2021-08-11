using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectoryApp.Core.Data.BaseRepository
{
    public interface IEntityRepository<T> where T : class
    {
        List<T> Get(Expression<Func<T, bool>> filter = null);

        T GetFirst(Expression<Func<T, bool>> filter = null);

        Task<List<T>> GetAsync(Expression<Func<T, bool>> filter = null);

        Task<T> GetFirstAsync(Expression<Func<T, bool>> filter = null);

        T Create(T entity);

        T Update(T entity);

        void Delete(T entity);

        void Delete(object id);
    }
}
