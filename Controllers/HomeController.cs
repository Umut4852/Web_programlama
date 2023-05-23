using Web_programlama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_programlama.Models;
using Microsoft.EntityFrameworkCore;


namespace Web_programlama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DataContext context;
        public HomeController(DataContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddKullanici()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddKullanici(Kullanici model)
        {

            context.Kullanicis.Add(model);
            context.SaveChanges();
            return View("Thanks", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(context.Kullanicis.OrderByDescending(p => p.k_id));
        }
        public Kullanici GetById(int id)
        {
            return context.Kullanicis.Where(p => p.k_id == id).FirstOrDefault();
        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            return View(GetById(id));
        }

        [HttpPost]
        public IActionResult Guncelle(Kullanici entity, Kullanici gizli = null)
        {
            if (gizli == null)
            {
                gizli = context.Kullanicis.Where(p => p.k_id == entity.k_id).FirstOrDefault();
            }
            else
            {
                context.Kullanicis.Attach(gizli);
            }
            if (gizli != null)
            {
                gizli.k_tc = entity.k_tc;
                gizli.k_yetki_turu = entity.k_yetki_turu;
                gizli.k_sifre = entity.k_sifre;
                context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public void DeleteKullanici(int k_id)
        {
            var entity = context.Kullanicis.Where(p => p.k_id == k_id).FirstOrDefault();
            context.Kullanicis.Remove(entity);
            context.SaveChanges();
        }


        [HttpPost]
        public IActionResult Delete(int k_id)
        {
            DeleteKullanici(k_id);
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}