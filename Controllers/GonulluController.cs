using Microsoft.AspNetCore.Mvc;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class GonulluController : Controller
    {
        private DataContext context1;
        public GonulluController(DataContext _context1)
        {
           context1 = _context1;
        }
        public IActionResult AddGonullu()
        {
            return View();
        }
        public IActionResult AddGonullu(Gonullu model)
        {
            context1.Gonullus.Add(model);
            context1.SaveChanges();
            return View("Thanks",model);
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
