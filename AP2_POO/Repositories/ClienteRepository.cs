using System.Collections.Generic;
using System.Linq;
using AP2_POO.Data;
using AP2_POO.Interfaces;
using AP2_POO.Models;
using Microsoft.EntityFrameworkCore;

namespace AP2_POO.Repositories
{
  public class ClienteRepository : IClienteRepository
  {
    private AppDbContext context;
    public ContaRepository(AppDbContext context)
    {
      this.context = context;
    }
    public Cliente GetById(int id)
    {
      return context.Clientes.SingleOrDefault(x => x.Id == id);
    }
    public List<Cliente> GetAll()
    {
      return context.Clientes.ToList();
    }
    public void Save(Cliente cliente)
    {
      context.Clientes.Add(cliente);
      context.SaveChanges();
    }
    public void Delete(Cliente cliente)
    {
      context.Clientes.Remove(cliente);
      context.SaveChanges();
    }
    public void Update(Cliente cliente)
    {
      context.Entry(cliente).State = EntityState.Modified;
      context.SaveChanges();
    }
  }
}