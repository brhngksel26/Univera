using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Univera.AppData;
using Univera.IServices;

namespace Univera.DataLayer
{
    public class GenericRepository<T> : IGenericService<T> where T : class
    {
        private UniveraContext Context = new UniveraContext();
        DbSet<T> _context;

        public GenericRepository()
        {
            _context = Context.Set<T>();
        }
        public void Delete(T param)
        {
            var res = _context.Remove(param);
            Context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> Filter)
        {
            return _context.Where(Filter).FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return _context.ToList();
        }

        public T Insert(T item)
        {
            _context.Add(item);
            Context.SaveChanges();
            return item;
        }

        public T Update(int id, T item)
        {
            Context.Entry(id).CurrentValues.SetValues(item);
            Context.SaveChanges();
            return item;
        }
    }
}
