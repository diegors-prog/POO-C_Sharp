using AP2_POO.Models;
using Microsoft.EntityFrameworkCore;

namespace AP2_POO.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Conta> Contas{ get; set; }
        public DbSet<Cliente> Clientes{ get; set; } 
    }
}