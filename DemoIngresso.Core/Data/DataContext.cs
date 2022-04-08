using DemoIngresso.Domain.Entidade;
using Microsoft.EntityFrameworkCore;

namespace DemoIngresso.Core.Data
{
    public class DataContext : DbContext, IDisposable
    {
        public DbSet<Usuario>? Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}