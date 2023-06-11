using Microsoft.AspNetCore.Mvc;
using Web_programlama.Models;

namespace Web_programlama.Controllers
{
    public class HaberController : Controller
    {
        private IHaberRepository haberRepository;

        private DataContext context;
        public HaberController(DataContext _context)
        {
            context = _context;
        }
        public HaberController(IHaberRepository repository)
        {
            haberRepository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public List<Haber> TumHaberleriGetir()
        {
            return haberRepository.TumHaberleriGetir();
        }

        public Haber HaberGetir(int haberId)
        {
            return haberRepository.HaberGetir(haberId);
        }

        public void HaberEkle(string baslik, string icerik, DateTime tarih)
        {
            var haber = new Haber
            {
                Id = GetNextId(),
                Baslik = baslik,
                Icerik = icerik,
                Tarih = tarih
            };

            haberRepository.HaberEkle(haber);
        }

        public void HaberGuncelle(int haberId, string baslik, string icerik, DateTime tarih)
        {
            var haber = new Haber
            {
                Id = haberId,
                Baslik = baslik,
                Icerik = icerik,
                Tarih = tarih
            };

            haberRepository.HaberGuncelle(haber);
        }

        public void HaberSil(int haberId)
        {
            haberRepository.HaberSil(haberId);
        }

        private int GetNextId()
        {
            return haberRepository.TumHaberleriGetir().Max(h => h.Id) + 1;
        }
    }
}
