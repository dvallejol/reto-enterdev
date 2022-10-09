using Microsoft.EntityFrameworkCore;
using Reto.Payment.Models;
using Reto.Payment.Models.Models;

namespace Reto.Payment.DAL.Context
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Products> Products { get; set; }

        public DbSet<Factura>Facturas { get; set; }
    }
}
