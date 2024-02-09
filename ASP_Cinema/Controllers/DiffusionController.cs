using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Cinema.Controllers
{
    public class DiffusionController : Controller
    {
        // GET: DiffusionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DiffusionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DiffusionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiffusionController/Create
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

        // GET: DiffusionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiffusionController/Edit/5
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

        // GET: DiffusionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiffusionController/Delete/5
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
