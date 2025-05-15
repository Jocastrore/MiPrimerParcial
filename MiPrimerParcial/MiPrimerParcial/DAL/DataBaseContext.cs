using Microsoft.EntityFrameworkCore;
using MiPrimerParcial.DAL.Entities;

namespace MiPrimerParcial.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }

        #region DbSet
        public DbSet<Country> Countries { get; set; }
        #endregion
    }
}
