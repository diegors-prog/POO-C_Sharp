using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula06_camadasElistas.Domain;

namespace Aula06_camadasElistas.Data
{
  public class CobrancaRepository
  {
    private List<Cobranca> listaCobrancas = new List<Cobranca>();

    public void Save(Cobranca cobranca)
    {
      listaCobrancas.Add(cobranca);
    }

    public List<Cobranca> GetAll()
    {
      return listaCobrancas;
    }

    public bool Update(int id_cobranca)
    {
      Cobranca cobrancaAtual = listaCobrancas.Find(x => x.Id == id_cobranca);
      if (cobrancaAtual.Status)
        return false;
      else
      {
        cobrancaAtual.Payday = DateTime.Now;
        cobrancaAtual.Status = true;
        return true;
      }
    }

    public void Delete(int idCobranca)
    {
      var cobranca = listaCobrancas.Find(i => i.Id == idCobranca);
      listaCobrancas.Remove(cobranca);
    }
    public Cobranca GetById(int idCobranca)
    {
      var cobranca = listaCobrancas.Find(i => i.Id == idCobranca);
      return cobranca;
    }

    public List<Cobranca> GetCobrancasToClient(int idCLient)
    {
      var cobrancas = listaCobrancas.FindAll(i => i.Cliente.Id == idCLient);
      return cobrancas;
    }
  }
}