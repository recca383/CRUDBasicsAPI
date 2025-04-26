using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDBasicsAPI.Controllers
{
    public class RecordsController : Controller
    {
        // GET: RecordsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RecordsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecordsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecordsController/Create
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

        // GET: RecordsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecordsController/Edit/5
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

        // GET: RecordsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecordsController/Delete/5
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
