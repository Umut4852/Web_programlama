using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class IhtiyaclarController : Controller
    {
        private IRepostory ihtiyaclar;
        private IIhtiyaclarRepostory ihtiyaclar1;
        public IhtiyaclarController(IIhtiyaclarRepostory _ihtiyaclar)
        {
            ihtiyaclar1= _ihtiyaclar;
        }
        public IActionResult AddIhtiyaclar()
        {
            var ihtiyaclars = ihtiyaclar1.GetIhtiyaclarByActive(true);
            ViewBag.IhtiyaclarCount = ihtiyaclars.Count();
            return View(ihtiyaclars);
        }
        [HttpGet]
        public IActionResult Guncelle(int i_id)
        {
            return View(ihtiyaclar1.GetById(i_id));
        }

        [HttpPost]
        public IActionResult AddIhtiyaclar(Ihtiyaclar Entity)
        {
            ihtiyaclar1.UpdateIhtiyaclar( Entity);
           return RedirectToAction(nameof(Ihtiyaclar_listesi));
        }

        private object Ihtiyaclar_listesi()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Delete(int i_id)
        {
            return View();
        }
    }
}
