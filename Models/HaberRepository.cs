namespace Web_programlama.Models
{
    public class HaberRepository : IHaberRepository
    {
        private List<Haber> haberler;

        public HaberRepository()
        {
            haberler = new List<Haber>();
        }

        public List<Haber> TumHaberleriGetir()
        {
            return haberler;
        }

        public Haber HaberGetir(int haberId)
        {
            return haberler.FirstOrDefault(h => h.Id == haberId);
        }

        public void HaberEkle(Haber haber)
        {
            haberler.Add(haber);
        }

        public void HaberGuncelle(Haber haber)
        {
            var eskiHaber = haberler.FirstOrDefault(h => h.Id == haber.Id);
            if (eskiHaber != null)
            {
                eskiHaber.Baslik = haber.Baslik;
                eskiHaber.Icerik = haber.Icerik;
                eskiHaber.Tarih = haber.Tarih;
            }
        }

        public void HaberSil(int haberId)
        {
            var haber = haberler.FirstOrDefault(h => h.Id == haberId);
            if (haber != null)
            {
                haberler.Remove(haber);
            }
        }
    }
}
