using Web_programlama.Models;

namespace Web_programlama.Models
{
    public class EfIhtiyaclarRepository : IIhtiyaclarRepository
    {
        private DataContext context;
        public EfIhtiyaclarRepository(DataContext _context)
        {
            context = _context;
        }

        public IQueryable<Ihtiyaclar> Ihtiyaclars => context.ihtiyaclars;
        public void CreateIhtiyaclar(Ihtiyaclar newIhtiyaclar)
        {
            throw new NotImplementedException();
        }

        public void DeleteIhtiyaclar(int Ihtiyaclari_id)
        {
            throw new NotImplementedException();
        }

        public Ihtiyaclar GetById(int id)
        {
            return context.ihtiyaclars.Where(i => i.i_id == id).FirstOrDefault();
        }

        public IEnumerable<Ihtiyaclar> GetIhtiyaclarByIsNeed(bool isneed)
        {
            return context.ihtiyaclars.Where(p => p.IsNeed == isneed).ToList(); //ihtiyaç olanları çektiğim sorgu
        }

        public IEnumerable<Ihtiyaclar> GetIhtiyaclar()
        {
            throw new NotImplementedException();
        }



        public void UpdateIhtiyaclar(Ihtiyaclar updateIhtiyaclar)
        {
            var entity = context.ihtiyaclars.Find(updateIhtiyaclar.i_id);
            if (entity != null)
            {
                entity.i_adi = updateIhtiyaclar.i_adi;
                entity.i_miktari = updateIhtiyaclar.i_miktari;
                entity.istek_adresi = updateIhtiyaclar.istek_adresi;
                entity.ozel_istek = updateIhtiyaclar.ozel_istek;
                entity.IsNeed=updateIhtiyaclar.IsNeed;

                context.SaveChanges();
            }
        }
    }
}
