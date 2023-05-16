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
            if (ModelState.IsValid)
            {
                context.Kullanicis.Add(model);
                context.SaveChanges();
            }
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
        public Kullanici GetById(int k_id)
        {
            return context.Kullanicis.Where(p => p.k_id == k_id).FirstOrDefault();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}