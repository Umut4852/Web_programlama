using Web_programlama.Models;

namespace Web_programlama.Models
{
    public class EfIhtiyaclarRepostory : IRepostory
    {
        private DataContext context;

        public EfIhtiyaclarRepostory(DataContext _context)
        {
            context = _context;
        }
        public IQueryable<Ihtiyaclar> ihtiyaclars => context.ihtiyaclars;
        public void CreateIhtitaclar(Ihtiyaclar newIhtiyaclar)
        {
            throw new NotImplementedException();
        }
        public void DeleteIhtiyaclar(int Ihtiyaclarid)
        {
            throw new NotImplementedException();
        }
        public Ihtiyaclar GetById(int i_id)
        {
            return context.ihtiyaclars.Where(i => i.i_id == i_id).FirstOrDefault();
        }

        public IEnumerable<Ihtiyaclar> GetIhtiyaclarByActive(bool var)
        {
            return context.ihtiyaclars.Where(p => p.var == var).ToList();
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

                context.SaveChanges();
            }
        }
    }
}
