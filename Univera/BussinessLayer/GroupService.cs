using Univera.DataLayer;
using Univera.Models;

namespace Univera.BussinessLayer
{
    public class GroupService
    {
        private GenericRepository<ProductGroup> _genericRepo;
        public GroupService(GenericRepository<ProductGroup> ProductGroupDI) => _genericRepo = ProductGroupDI;

        public List<ProductGroup> GetlProductGroups()
        {
            return _genericRepo.GetAll();
        }
        public ProductGroup GetlProductGroup(int id)
        {
            return _genericRepo.Get(q => q.ID == id);
        }
        public bool RemoveProductGroup(ProductGroup param)
        {
            _genericRepo.Delete(param);
            return true;
        }
        public ProductGroup InsertlProductGroup(ProductGroup param)
        {
            _genericRepo.Insert(param);
            return param;
        }

        public ProductGroup UpdatelProductGroup(ProductGroup param)
        {
            return _genericRepo.Update(param.ID, param);
        }
    }
}
