using Microsoft.AspNetCore.Mvc;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class HaberController : Controller
    {
        private HaberRepository haberRepository;

        public HaberController()
        {
            haberRepository = new HaberRepository();
        }

        public ActionResult Index()
        {
            List<Haber> haberler = haberRepository.HaberleriGetir();
            return View(haberler);
        }

        public ActionResult Detay(int id)
        {
            Haber haber = haberRepository.HaberGetir(id);
            return View(haber);
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Haber haber)
        {
            haberRepository.HaberEkle(haber);
            return RedirectToAction("Index");
        }

        public ActionResult Guncelle(int id)
        {
            Haber haber = haberRepository.HaberGetir(id);
            return View(haber);
        }

        [HttpPost]
        public ActionResult Guncelle(Haber haber)
        {
            haberRepository.HaberGuncelle(haber);
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            haberRepository.HaberSil(id);
            return RedirectToAction("Index");
        }
    }
}
