using System.Linq.Expressions;

namespace Univera.IServices
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T Get(Expression<Func<T, bool>> Filter);
        T Update(int id, T item);
        T Insert(T item);
        void Delete(T param);
    }
}
