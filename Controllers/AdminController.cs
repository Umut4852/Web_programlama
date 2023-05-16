using Microsoft.AspNetCore.Mvc;

namespace Web_programlama.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
