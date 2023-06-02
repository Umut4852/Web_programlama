namespace Web_programlama.Models
{
    public interface IhaberlerRepository
    {
        Haberler GetById(int id);
        IEnumerable<Haberler> GetHaberlers();
        IEnumerable<Haberler> GetHaberlersActive(bool isactive);
        void CreateHaberler(Haberler newhaberler);
        void UpdateHaberler(Haberler updatehaberler);
        void DeleteHaberler(int h_id);
    }
}
