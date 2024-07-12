using Core.Consts;
using Core.Entities.Abstract;
using DataAccess.Context.ApplicationContext;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace DataAccess.Services.Concrete
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public async Task<bool> AddAsync(T entity)
        {
            await _table.AddAsync(entity);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = Status.Modified;
            _table.Update(entity);
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = Status.Passive;
            _table.Update(entity);
            return await SaveAsync();
        }

        public async Task<bool> SaveAsync()
        => await _context.SaveChangesAsync() > 0 ? true : false;

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        => await _table.AnyAsync(expression);

        public async Task<T> GetByIdAsync(Guid id)
        => await _table.FirstOrDefaultAsync(x => x.Status != Status.Passive && x.Id == id);

        public async Task<T> GetByDefaultAsync(Expression<Func<T, bool>> expression)
        => await _table.FirstOrDefaultAsync(expression);

        public async Task<ICollection<T>> GetByDefaultsAsync(Expression<Func<T, bool>> expression)
        => await _table.Where(expression).ToListAsync();

        public async Task<ICollection<TResult>> GetFilteredListAsync<TResult>
            (
                Expression<Func<T, TResult>> select, 
                Expression<Func<T, bool>> where = null, 
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
                Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null
            )
        {
            IQueryable<T> query = _table;

            if(join != null)
                query=join(query);
            if(where != null)
                query = query.Where(where);
            if(orderBy != null)
                return await orderBy(query).Select(select).ToListAsync();

            return await query.Select(select).ToListAsync();
        }
    }
}