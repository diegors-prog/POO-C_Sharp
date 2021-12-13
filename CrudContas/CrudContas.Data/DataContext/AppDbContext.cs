using CrudContas.Domain;
using Microsoft.EntityFrameworkCore;

namespace CrudContas.Data.DataContext
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Conta> Contas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
  }
}