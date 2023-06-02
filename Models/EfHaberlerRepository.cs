using NuGet.Protocol.Core.Types;

namespace Web_programlama.Models
{
    public class EfHaberlerRepository : IhaberlerRepository
    {
        public List<Haberler> Haberler { get; set; }
        private DataContext context;
        public EfHaberlerRepository(DataContext _context)
        {
            context = _context;
        }

        public IQueryable<Haberler> Haberlers => context.Haberlers;
        public void CreateHaberler(Haberler newhaberler)
        {
            throw new NotImplementedException();
        }

        public void DeleteHaberler(int h_id)
        {
            throw new NotImplementedException();
        }

        public Haberler GetById(int id)
        {
            return context.Haberlers.Where(i => i.h_id == id).FirstOrDefault();
        }

        public IEnumerable<Haberler> GetHaberlersActive(bool isactive)
        {
            return context.Haberlers.Where(p=> p.IsActive == isactive).ToList();
        }
        public IEnumerable<Haberler> GetHaberlers()
        {
            throw new NotImplementedException();
        }


        public void UpdateHaberler(Haberler updatehaberler)
        {
            var entity = context.Haberlers.Find(updatehaberler.h_id);
            if (entity != null)
            {
                entity.h_id = updatehaberler.h_id;
                entity.son_haberler = updatehaberler.son_haberler;
                entity.gida_dagitim_noktalari = updatehaberler.gida_dagitim_noktalari;
                entity.saglik_merkezleri = updatehaberler.saglik_merkezleri;
                entity.IsActive= updatehaberler.IsActive;

                context.SaveChanges();
            }
        }
    }
}
