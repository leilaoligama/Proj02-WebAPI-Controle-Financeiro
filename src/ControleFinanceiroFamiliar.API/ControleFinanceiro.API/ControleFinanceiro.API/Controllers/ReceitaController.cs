using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.API.Controllers
{
    public class ReceitaController : Controller
    {


        // GET: ReceitaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReceitaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReceitaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReceitaController/Create
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

        // GET: ReceitaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReceitaController/Edit/5
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

        // GET: ReceitaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReceitaController/Delete/5
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
