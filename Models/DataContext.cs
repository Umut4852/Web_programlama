using Microsoft.EntityFrameworkCore;

using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Web_programlama.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Depremzede> Depremzedes { get; set; }
        public DbSet<Gonullu> Gonullus { get; set; }
        public DbSet<Haberler> Haberlers { get; set; }
        public DbSet<Ihtiyaclar> ihtiyaclars { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<ToplanmaAlani> Toplanma_Alanis { get; set; }
        public DbSet<Yetkili> Yetkilis { get; set; }

    }
}
