namespace Web_programlama.Models
{
    public interface IIhtiyaclarRepository
    {
        Ihtiyaclar GetById(int id);
        IEnumerable<Ihtiyaclar> GetIhtiyaclar();
        IEnumerable<Ihtiyaclar> GetIhtiyaclarByIsNeed(bool isneed);
        void CreateIhtiyaclar(Ihtiyaclar newIhtiyaclar);
        void UpdateIhtiyaclar(Ihtiyaclar updateIhtiyaclar);
        void DeleteIhtiyaclar(int Ihtiyaclari_id);
    }
}
