using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Univera.AppData;
using Univera.DataLayer;
using Univera.IServices;
using Univera.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Univera.BussinessLayer
{
    public class AddtionalGroupService
    {

        private GenericRepository<AdditionalProductGroup> _genericRepo;
        public AddtionalGroupService(GenericRepository<AdditionalProductGroup> AdditionalProductGroupDI) => _genericRepo = AdditionalProductGroupDI;
        

        public List<AdditionalProductGroup> GetAdditionalProductGroups()
        {
            return _genericRepo.GetAll();
        }
        public AdditionalProductGroup GetAdditionalProductGroup(int id)
        {
            return _genericRepo.Get(q => q.ID == id);
        }
        public bool RemoveAdditionalProductGroup(AdditionalProductGroup param)
        {
            _genericRepo.Delete(param);
            return true;
        }
        public AdditionalProductGroup InsertAdditionalProductGroup(AdditionalProductGroup param)
        {
            _genericRepo.Insert(param);
            return param;
        }

        public AdditionalProductGroup UpdateAdditionalProductGroup(AdditionalProductGroup param)
        {
            return _genericRepo.Update(param.ID, param);
        }
    }
}
