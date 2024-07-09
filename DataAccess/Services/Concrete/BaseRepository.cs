using Core.Entities.Abstract;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public BaseRepository()
        {
            
        }
        public Task<bool> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByDefaultAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> GetByDefaultsAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TResult>> GetFilteredListAsync<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            throw new NotImplementedException();
        }
    }
}