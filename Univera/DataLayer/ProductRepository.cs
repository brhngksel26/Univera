using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Univera.AppData;
using Univera.IServices;
using Univera.Models;

namespace Univera.DataLayer
{
    public class ProductRepository : IGenericService<Product> 
    {
        private UniveraContext Context = new UniveraContext();
        DbSet<Product> _context;

        public ProductRepository() => _context = Context.Set<Product>();
        public List<Product> GetAll()
        {
            return _context
                           .Include(p => p.GroupCode)
                           .Include(a => a.AdditionalProductGroupCode)
                           .Include(t => t.Type)
                           .Include(s => s.Status)
                           .Include(u => u.Unit)
                           .Include(x => x.AmountType)
                           .ToList();
        }

        public Product Get(Expression<Func<Product, bool>> Filter)
        {
            return _context
                          .Include(p => p.GroupCode)
                          .Include(a => a.AdditionalProductGroupCode)
                          .Include(t => t.Type)
                          .Include(s => s.Status)
                          .Include(u => u.Unit)
                          .Include(x => x.AmountType)
                          .Where(Filter)
                          .FirstOrDefault();
        }

        public Product Update(int id, Product item)
        {
            Context.Entry(id).CurrentValues.SetValues(item);
            Context.SaveChanges();
            return item;
        }

        public Product Insert(Product item)
        {
            _context.Add(item);
            Context.SaveChanges();
            return item;
        }

        public void Delete(Product param)
        {
            var res = _context.Remove(param);
            Context.SaveChanges();
        }
    }
}
