using Microsoft.AspNetCore.Mvc;
using Web_programlama.Models;
using Microsoft.EntityFrameworkCore;

namespace Web_programlama.Controllers
{
    public class HaberlerController : Controller
    {
        public IRepository repository;
        private IhaberlerRepository repository1;
        public HaberlerController(IhaberlerRepository _repository)
        {
            repository1 = _repository;
        }
        public IActionResult Index()
        {
            var Haberlers = repository1.GetHaberlersActive(true);
            ViewBag.HaberlerCount=Haberlers.Count();

            return View(Haberlers);
        }

        public IActionResult Edit(int h_id)
        {
            return View(repository1.GetById(h_id));
        }

        [HttpPost]
        public IActionResult Edit(Haberler Entity)
        {
            repository1.UpdateHaberler(Entity);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int h_id)
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult AddHaberler()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddHaberler(Haberler model)
        //{

        //    repository1.Haberlers.Add(model);
        //    repository1.SaveChanges();
        //    return View("Thanks", model);
        //}

    }
}
