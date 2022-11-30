using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Univera.AppData;
using Univera.BussinessLayer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Univera.DataLayer;
using Univera.Models;

namespace Univera.Controllers
{
    public class AdditionalGroupController : Controller
    {
        private AddtionalGroupService addtionalGroupService;

        public AdditionalGroupController(GenericRepository<AdditionalProductGroup> addtionalGroupGenerate)
        {
            addtionalGroupService = new AddtionalGroupService(addtionalGroupGenerate);
        }

        // GET: AdditionalGroup
        public ActionResult Index()
        {
            var addtionalGroups = addtionalGroupService.GetAdditionalProductGroups();
            ViewData["addtionalGroups"] = addtionalGroups;
            return View();
        }

        // GET: AdditionalGroup/Details/1
        public ActionResult Details(int id)
        {
            var addtionalGroupsDetails = addtionalGroupService.GetAdditionalProductGroup(id);
            var test = "";
            return View();
        }

        // GET: AdditionalGroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdditionalGroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdditionalGroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }


        // GET: AdditionalGroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdditionalGroupController/Delete/5

    }
}
