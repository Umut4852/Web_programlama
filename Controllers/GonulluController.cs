using Microsoft.AspNetCore.Mvc;

namespace Web_programlama.Controllers
{
    public class GonulluController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
