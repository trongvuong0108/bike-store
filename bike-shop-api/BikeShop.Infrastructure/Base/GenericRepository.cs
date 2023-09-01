
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BikeShop.Infrastructure.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContext _context;

        public GenericRepository(DbContext _context)
        {
            this._context = _context;
        }

        public IQueryable<T> FindAll() => _context.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            _context.Set<T>().Where(expression).AsNoTracking();

        public void Insert(T entity) => _context.Set<T>().Add(entity);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
        public void Save() => _context.SaveChanges();
    }
}
