using Microsoft.AspNetCore.Mvc;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class IhtiyaclarController : Controller
    {
        private readonly ILogger<IhtiyaclarController> _logger;

        private DataContext ihtiyaclar1;
        public IhtiyaclarController(DataContext _ihtiyaclar)
        {
            ihtiyaclar1 = _ihtiyaclar;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddIhtiyaclar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddIhtiyaclar(Ihtiyaclar model)
        {
            ihtiyaclar1.ihtiyaclars.Add(model);
            ihtiyaclar1.SaveChanges();
            return View("Thanks", model);
        }
        public IActionResult Listi()
        {
            return View(ihtiyaclar1.ihtiyaclars.OrderByDescending(p => p.i_id));
        }
        public Ihtiyaclar GetById(int id)
        {
            return ihtiyaclar1.ihtiyaclars.Where(p => p.i_id == id).FirstOrDefault();
        }
        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            return View(GetById(id));
        }

        [HttpPost]
        public IActionResult Guncelle(Ihtiyaclar entity, Ihtiyaclar gizli = null)
        {
            if (gizli == null)
            {
                gizli = ihtiyaclar1.ihtiyaclars.Where(p => p.i_id == entity.i_id).FirstOrDefault();
            }
            else
            {
                ihtiyaclar1.ihtiyaclars.Attach(gizli);
            }
            if (gizli != null)
            {
                gizli.i_id = entity.i_id;
                gizli.i_miktari = entity.i_miktari;
                gizli.istek_adresi = entity.istek_adresi;
                gizli.ozel_istek = entity.ozel_istek;
                ihtiyaclar1.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public void DeleteI(int i_id)
        {
            var entity = ihtiyaclar1.ihtiyaclars.Where(p => p.i_id == i_id).FirstOrDefault();
            ihtiyaclar1.ihtiyaclars.Remove(entity);
            ihtiyaclar1.SaveChanges();
        }


        [HttpPost]
        public IActionResult Delete(int i_id)
        {
            DeleteI(i_id);
            return RedirectToAction(nameof(Index));
        }

    }
}
