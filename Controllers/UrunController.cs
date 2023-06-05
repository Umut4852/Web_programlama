using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Urunekle()
        {
            var Urun = new Urun()
            {
                isim = "Umut can",
                adet = 15
            };
            return View();
        }

        [HttpPost]
        public IActionResult Urunekle(Urun urun)
        {
            return View("Urunekle");
        }

        [HttpPost]
        public IActionResult VeriAl(Urun model)
        {
            return View();
        }
        public IActionResult Qstring()
        {
            //url e controller + action + ?isim=umut&adet=15

            var queryString = Request.QueryString;
            var isim = Request.Query["isim"].ToString;
            var adet = Request.Query["adet"].ToString;
            return View();
        }

        public IActionResult RouteData(string id)
        {
            //  url e controller + action + /15

            var values = Request.RouteValues;
            return View();
        }
    }
}
