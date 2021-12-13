using System.Collections.Generic;
using System.Linq;
using AS.Data.DataContext;
using AS.Domain;
using Microsoft.EntityFrameworkCore;

namespace AS.Data
{
  public class ContaRepository : IContaRepository
  {
    private AppDbContext context;
    public ContaRepository(AppDbContext context)
    {
      this.context = context;
    }
    public void Delete(Conta conta)
    {
      context.Contas.Remove(conta);
      context.SaveChanges();
    }

    public List<Conta> GetAll()
    {
      return context.Contas.Include(x => x.Cliente).ToList();
    }

    public Conta GetById(int id)
    {
      return context.Contas.Include(x => x.Cliente).SingleOrDefault(x => x.Id == id);
    }

    public void Save(Conta conta)
    {
      conta.Cliente = context.Clientes.Find(conta.Cliente.Id);
      context.Contas.Add(conta);
      context.SaveChanges();
    }

    public void Update(Conta conta)
    {
      conta.Cliente = context.Clientes.Find(conta.Cliente.Id);
      context.Entry(conta).State = EntityState.Modified;
      context.SaveChanges();
    }
  }
}