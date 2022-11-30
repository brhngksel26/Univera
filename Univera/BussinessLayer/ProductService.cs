using Univera.DataLayer;
using Univera.Models;

namespace Univera.BussinessLayer
{
    public class ProductService
    {
        private ProductRepository _genericRepo;
        public ProductService(ProductRepository ProductDI) => _genericRepo = ProductDI;

      
        public List<Product> GetAllProducts()
        {
            
            return _genericRepo.GetAll();
        }
        public Product GetProduct(int id)
        {
            return _genericRepo.Get(q => q.ID == id);
        }
        public bool RemoveProduct(Product param)
        {
            _genericRepo.Delete(param);
            return true;
        }
        public Product InsertlProduct(Product param)
        {
            _genericRepo.Insert(param);
            return param;
        }

        public Product UpdatelProduct(Product param)
        {
            return _genericRepo.Update(param.ID, param);
        }
    }

}
