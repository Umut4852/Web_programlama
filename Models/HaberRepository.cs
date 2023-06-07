namespace Web_programlama.Models
{
    public class HaberRepository
    {
        private List<Haber> haberListesi;

        public HaberRepository()
        {
            haberListesi = new List<Haber>();
        }

        public List<Haber> HaberleriGetir()
        {
            return haberListesi;
        }

        public Haber HaberGetir(int id)
        {
            return haberListesi.FirstOrDefault(h => h.Id == id);
        }

        public void HaberEkle(Haber haber)
        {
            haberListesi.Add(haber);
        }

        public void HaberGuncelle(Haber haber)
        {
            Haber eskiHaber = haberListesi.FirstOrDefault(h => h.Id == haber.Id);
            if (eskiHaber != null)
            {
                eskiHaber.Baslik = haber.Baslik;
                eskiHaber.Icerik = haber.Icerik;
                eskiHaber.Tarih = haber.Tarih;
            }
        }

        public void HaberSil(int id)
        {
            Haber haber = haberListesi.FirstOrDefault(h => h.Id == id);
            if (haber != null)
            {
                haberListesi.Remove(haber);
            }
        }
    }
}
