using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        private DataContext context;
        public AdminController(DataContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminOlustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminOlustur(Admin model)
        {
            context.Admins.Add(model);
            context.SaveChanges();
            return View("Thanks", model);
        }
        [HttpGet]
        public IActionResult AddHaberler()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddHaberler(Haberler model)
        {
            context.Haberlers.Add(model);
            context.SaveChanges();
            return View("Thanks", model);
        }
        public IActionResult RaporGonullu()
        {
            return RedirectToAction("Listg", "Gonullu");
        }
        public IActionResult Lista()
        {

            return View(context.Admins.OrderByDescending(p => p.a_id));
        }
        public Admin GetById(int id)
        {

            return context.Admins.Where(p => p.a_id == id).FirstOrDefault();
        }
        [HttpGet]
        public IActionResult Guncellea(int id)
        {
            return View(GetById(id));
        }

        [HttpPost]
        public IActionResult Guncellea(Admin entity, Admin? gizli = null)
        {
            if (gizli == null)
            {
                context.Admins.FirstOrDefault(p => p.a_id == entity.a_id);
            }
            else
            {
                context.Admins.Attach(gizli);
            }
            if (gizli != null)
            {
                gizli.a_id = entity.a_id;
                gizli.a_tc = entity.a_tc;
                gizli.sifre = entity.sifre;
                gizli.isim = entity.isim;
                gizli.a_soyisim = entity.a_soyisim;

                context.Admins.ExecuteDeleteAsync();
                context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public void DeleteAdmin(int a_id)
        {
            var entity = context.Admins.Where(p => p.a_id == a_id).FirstOrDefault();
            context.Admins.Remove(entity);
            context.SaveChanges();
        }


        [HttpPost]
        public IActionResult Delete(int g_id)
        {
            DeleteAdmin(g_id);
            return RedirectToAction(nameof(Index));
        }
    }
}
