using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class IhtiyaclarController : Controller
    {
        private IRepositoriy ihtiyaclar;
        private IIhtiyaclarRepository ihtiyaclar1;
        public IhtiyaclarController(IIhtiyaclarRepository _ihtiyaclar)
        {
            ihtiyaclar1= _ihtiyaclar;
        }
        public IActionResult Index() 
        { 
            return View();
        }
        [HttpGet]
        public IActionResult Guncelle(int i_id)
        {
            return View(ihtiyaclar1.GetById(i_id));
        }

        [HttpPost]
        public IActionResult Guncelle(Ihtiyaclar Entity)
        {
            ihtiyaclar1.UpdateIhtiyaclar( Entity);
           return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int i_id)
        {
            return View();
        }
        public IActionResult View()
        {
            return View();
        }

    }
}
