using Microsoft.AspNetCore.Mvc;
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
        public IActionResult RaporGonullu()
        {
            return RedirectToAction("Listg", "Gonullu");
        }
        public IActionResult Lista()
        {

            return View(context.Admins.OrderByDescending(p => p.a_id));
        }
    }
}
