using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class LoginController : Controller
    {
        private DataContext context;
        public LoginController(DataContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                HttpContext.Session.SetString("Username", username);
                return RedirectToAction("Welcome");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Welcome()
        {
            string username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Index");
            }

            ViewData["Username"] = username;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
