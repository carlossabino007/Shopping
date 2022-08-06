using Microsoft.EntityFrameworkCore;
using Shopping.Data.Entities;

namespace Shopping.Data
{
    public class DataContext: DbContext
    {
        /* le paso el objeto creando options al constructor de la clase padre */
        /* ,al base,al DbContext */
        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {
        }

        public DbSet<Country> countries  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
