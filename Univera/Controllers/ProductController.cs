using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Univera.AppData;
using Univera.BussinessLayer;
using Univera.DataLayer;
using Univera.Models;

namespace Univera.Controllers
{
    public class ProductController : Controller
    {


        private UniveraContext _dbContext;
        public ProductController(UniveraContext dbContext) => _dbContext = dbContext;

        // GET: Product
        public ActionResult Index()
        {

            var product = _dbContext.Product
                           .Include(p => p.GroupCode)
                           .Include(a => a.AdditionalProductGroupCode)
                           .Include(t => t.Type)
                           .Include(s => s.Status)
                           .Include(u => u.Unit)
                           .Include(x => x.AmountType)
                           .ToList();

            return View(product);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
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

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
