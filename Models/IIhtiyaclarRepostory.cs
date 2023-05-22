namespace Web_programlama.Models
{
    public interface IIhtiyaclarRepostory
    {
        Ihtiyaclar GetById(int id);
        IEnumerable<Ihtiyaclar> GetIhtiyaclar();
        IEnumerable<Ihtiyaclar> GetIhtiyaclarByActive(bool isactive);
        void CreateIhtiyaclar(Ihtiyaclar newIhtiyaclar);
        void UpdateIhtiyaclar(Ihtiyaclar updateIhtiyaclar);
        void DeleteIhtiyaclar(int i_id);
    }
}
