using Microsoft.EntityFrameworkCore;
using AriFarmaSA.App.Dominio;

namespace AriFarmaSA.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Producto> Producto{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AriFarmaSADb");
            }
        }
    }
}