using Microsoft.EntityFrameworkCore;
using SaleSystem2.Models;

namespace SaleSystem2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }

    }
}
