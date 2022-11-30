using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Univera.AppData;

namespace Univera.Controllers
{
    public class GroupController : Controller
    {
        private UniveraContext _dbContext;
        public GroupController(UniveraContext dbContext) => _dbContext = dbContext;
        // GET: Group
        public ActionResult Index()
        {
            var test = _dbContext.ProductGroup.ToList();
            return View();
        }

        // GET: Group/Details/1
        public ActionResult Details(int id)
        {
            var test = _dbContext.ProductGroup.Find(id);
            return View();
        }

        // GET: GroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GroupController/Create
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

        // GET: GroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GroupController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: GroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GroupController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
