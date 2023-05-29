using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class GonulluController : Controller
    {
        private readonly ILogger<GonulluController> _logger;

        private DataContext context;
        public GonulluController(DataContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GonulluBasvuru()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GonulluBasvuru(Gonullu model)
        {
            context.Gonullus.Add(model);
            context.SaveChanges();
            return View("Thanks", model);
        }
        public IActionResult Listg()
        {

            return View(context.Gonullus.OrderByDescending(p => p.g_id));
        }
        public Gonullu GetById(int id)
        {
            return context.Gonullus.Where(p => p.g_id == id).FirstOrDefault();
        }
        [HttpGet]
        public IActionResult Guncelleg(int id)
        {
            return View(GetById(id));
        }

        [HttpPost]
        public IActionResult Guncelleg(Gonullu entity, Gonullu? gizli = null)
        {
            if (gizli == null)
            {
                context.Gonullus.FirstOrDefault(p => p.g_id == entity.g_id);
            }
            else
            {
                context.Gonullus.Attach(gizli);
            }
            if (gizli != null)
            {
                gizli.g_id = entity.g_id;
                gizli.g_tc = entity.g_tc;
                gizli.isim = entity.isim;
                gizli.soyisim = entity.soyisim;
                gizli.meslegi = entity.meslegi;
                gizli.yasi = entity.yasi;
                gizli.mail = entity.mail;
                gizli.sifre = entity.sifre;

                context.Gonullus.ExecuteDeleteAsync();
                context.SaveChanges();

            }
            return RedirectToAction(nameof(Index));
        }

        public void DeleteGonullu(int g_id)
        {
            var entity = context.Gonullus.Where(p => p.g_id == g_id).FirstOrDefault();
            context.Gonullus.Remove(entity);
            context.SaveChanges();
        }


        [HttpPost]
        public IActionResult Delete(int g_id)
        {
            DeleteGonullu(g_id);
            return RedirectToAction(nameof(Index));
        }
    }
}
