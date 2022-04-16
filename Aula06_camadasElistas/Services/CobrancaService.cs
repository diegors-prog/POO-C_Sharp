using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula06_camadasElistas.Domain;
using Aula06_camadasElistas.Data;
using System.Text;


namespace Aula06_camadasElistas.Services
{
  public class CobrancaService
  {
    ClienteRepository repositorioCliente = new ClienteRepository();
    CobrancaRepository repositorioCobranca = new CobrancaRepository();

    public string CriarCobranca(DateTime datevenc, double valor, int idcliente)
    {
      var idCobranca = repositorioCobranca.GetAll().Count + 1;
      var cliente = repositorioCliente.GetById(idcliente);

      repositorioCobranca.Save(new Cobranca(idCobranca, DateTime.Now, datevenc, valor, cliente));

      return "cobranca adicionada com sucesso!";

    }
    public string ListarCobrancas()
    {

      var retorno = new StringBuilder();
      var lista = repositorioCobranca.GetAll();
      var qtdCobranca = lista.Count;

      if (qtdCobranca == 0)
      {
        return retorno.AppendLine("lista vazia").ToString();
      }
      else
      {
        foreach (Cobranca cobranca in lista)
        {
          retorno.AppendLine("id : " + cobranca.Id + " Pagamento efetuado: " + cobranca.Status + " Data pgto: " + cobranca.Payday);
        }
        return retorno.ToString();
      }
    }

    public string EfetuarPagamento(int id)
    {

      var pagamento = repositorioCobranca.Update(id);

      if (pagamento)
        return "Pagamento efetuado com sucesso";
      else
        return "Está cobrança ja foi paga";

    }

    public Cobranca BuscarCobranca(int idCobranca)
    {
      var cobranca = repositorioCobranca.GetById(idCobranca);
      if (cobranca == null)
      {
        return null;
      }
      else
      {
        return cobranca;
      }
    }

    public bool CobrancasSemPagar(int idCliente)
    {
      var cobrancas = repositorioCobranca.GetCobrancasToClient(idCliente);
      Cobranca cobrancaNaoPaga = null;

      if (cobrancas.Count != 0)
      {
        foreach (Cobranca cobranca in cobrancas)
        {
          if (cobranca.Status.Equals(false))
          {
            cobrancaNaoPaga = cobranca;
          }
        }

        if (cobrancaNaoPaga == null)
          return false;
        else
          return true;
      }
      else
      {
        return false;
      }
    }
  }
}