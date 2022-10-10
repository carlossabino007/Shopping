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
        // Mapeo la base de datos.
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name","CountryId").IsUnique();
            modelBuilder.Entity<City>().HasIndex("Name", "StateId").IsUnique();
            // Despues de mapear, hago Migracion enseguida, pues se ha afectado la base de datos
            // add-migtation Nombre
            // Y luego update-database
            // drop-database borro la base de datos para empezar de nuevo y luego si update-database

        }
    }
}
