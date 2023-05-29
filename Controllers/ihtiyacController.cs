using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class ihtiyacController : Controller
    {
        private readonly ILogger _logger;
        private DataContext context;

        public ihtiyacController(DataContext _context)
        {
            context= _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Addihtiyac()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Addihtiyac(ihtiyac model)
        {
            context.ihtiyaclars.Add(model);
            context.SaveChanges();
            return View(nameof(Index));
        }

        public IActionResult listn()
        {
            return View(context.ihtiyaclars.OrderByDescending(p => p.i_id));

        }
        public ihtiyac GetById(int id)
        {

            return context.ihtiyaclars.Where(p => p.i_id == id).FirstOrDefault();
        }
        [HttpGet]
        public IActionResult Guncellen(int id)
        {
            return View(GetById(id));
        }
        [HttpPost]
        public IActionResult Guncellen(ihtiyac entity, ihtiyac? gizli = null)
        {
            if (gizli == null)
            {
                context.ihtiyaclars.FirstOrDefault(p => p.i_id == entity.i_id);
            }
            else
            {
                context.ihtiyaclars.Attach(gizli);
            }
            if (gizli != null)
            {
                gizli.i_id = entity.i_id;
                gizli.i_adi = entity.i_adi;
                gizli.i_miktari = entity.i_miktari;
                gizli.istek_adresi = entity.istek_adresi;
                gizli.ozel_istek = entity.ozel_istek;

                context.ihtiyaclars.ExecuteDeleteAsync();
                context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public void Deleteihtiyac(int i_id)
        {
            var entity = context.ihtiyaclars.Where(p => p.i_id == i_id).FirstOrDefault();
            context.ihtiyaclars.Remove(entity);
            context.SaveChanges();
        }


        [HttpPost]
        public IActionResult Delete(int g_id)
        {
            Deleteihtiyac(g_id);
            return RedirectToAction(nameof(Index));
        }
    }
}

