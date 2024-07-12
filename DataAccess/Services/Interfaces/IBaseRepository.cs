using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        //Creat Update Delete Operations
        Task<bool> AddAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<bool> SaveAsync();

        //Read Operations
        Task<T> GetByIdAsync(Guid id);

        Task<T> GetByDefaultAsync(Expression<Func<T, bool>> expression);

        Task<ICollection<T>> GetByDefaultsAsync(Expression<Func<T, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task<ICollection<TResult>> GetFilteredListAsync<TResult>
            (
                Expression<Func<T, TResult>> select,
                Expression<Func<T , bool>> where = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                Func<IQueryable<T> , IIncludableQueryable<T, object>> join = null 
            );
    }
}