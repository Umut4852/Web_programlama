namespace Web_programlama.Models
{
    public interface IHaberRepository
    {
        List<Haber> TumHaberleriGetir();
        Haber HaberGetir(int haberId);
        void HaberEkle(Haber haber);
        void HaberGuncelle(Haber haber);
        void HaberSil(int haberId);
    }
}
