using System.Collections.Generic;
using System.Linq;
using AS.Data.DataContext;
using AS.Domain;
using Microsoft.EntityFrameworkCore;

namespace AS.Data
{
  public class ClienteRepository : IClienteRepository
  {
    private AppDbContext context;
    public ClienteRepository(AppDbContext context)
    {
      this.context = context;
    }
    public void Delete(Cliente cliente)
    {
      context.Clientes.Remove(cliente);
      context.SaveChanges();
    }

    public List<Cliente> GetAll()
    {
      return context.Clientes.ToList();
    }

    public Cliente GetById(int id)
    {
      return context.Clientes.SingleOrDefault(x => x.Id == id);
    }

    public void Save(Cliente cliente)
    {
      context.Clientes.Add(cliente);
      context.SaveChanges();
    }

    public void Update(Cliente cliente)
    {
      context.Entry(cliente).State = EntityState.Modified;
      context.SaveChanges();
    }
  }
}