using CRUDBasicsAPI.Data;
using CRUDBasicsAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDBasicsAPI.Controllers
{
    public class RecordsController : Controller
    {
        public DatabaseContext _context { get; }
        
        public RecordsController(DatabaseContext context)
        {
            _context = context;
        }
        #region CRUD Methods
        private IEnumerable<Patient> GetPatients()
        {
            return _context.Patients.AsEnumerable();
        }
        private Patient GetPatient(int id)
        {
            return _context.Patients.FirstOrDefault(p => p.ID == id)!;
        }
        #endregion

        // GET: RecordsController
        public IActionResult Index()
        {
            return View(GetPatients());
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
                Patient created = new Patient()
                {
                    Name = collection["Name"]!,
                    Address = collection["Address"]
                };
                _context.Patients.Add(created);
                _context.SaveChangesAsync();

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
            return View(GetPatient(id));
        }

        // POST: RecordsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Patient updated = new Patient()
                {
                    ID = id,
                    Name = collection["Name"]!,
                    Address = collection["Address"]
                };

                _context.Patients.Update(updated);
                _context.SaveChangesAsync();
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
            return View(GetPatient(id));
        }

        // POST: RecordsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Patient toremove = GetPatient(id);
                _context.Patients.Remove(toremove);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
