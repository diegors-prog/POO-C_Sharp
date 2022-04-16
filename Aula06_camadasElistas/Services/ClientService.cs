using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula06_camadasElistas.Data;
using Aula06_camadasElistas.Domain;

namespace Aula06_camadasElistas.Services
{
  public class ClientService
  {
    ClienteRepository repositorioCliente = new ClienteRepository();
    CobrancaService serviceCobranca = new CobrancaService();

    public string CriarCliente(string name, string fone)
    {
      int id_client = repositorioCliente.TamanhoList() + 1;
      repositorioCliente.Save(new Client(id_client, name, fone));
      return "cliente foi adicionado";

    }

    public string ListarClientes()
    {
      var retorno = new StringBuilder();
      var lista_de_cliente = repositorioCliente.GetAll();
      var qtdClientes = lista_de_cliente.Count;

      if (qtdClientes == 0)
      {
        return retorno.AppendLine("lista vazia").ToString();
      }
      else
      {
        foreach (Client cliente in lista_de_cliente)
        {
          retorno.AppendLine("id : " + cliente.Id + " name: " + cliente.Name + " fone: " + cliente.PhoneNumber);
        }
        return retorno.ToString();
      }

    }

    public string RemoverCliente(int idCliente)
    {
      var retorno = string.Empty;
      if (repositorioCliente.TamanhoList() == 0)
      {
        retorno = "lista vazia";
        return retorno;
      }
      else
      {
        var contasPagas = serviceCobranca.CobrancasSemPagar(idCliente);
        if (contasPagas == false)
        {
          var deletou = repositorioCliente.Delete(idCliente);
          if (deletou == true)
          {
            retorno = "cliente deletado";
          }
          else
          {
            retorno = "cliente não encontrado na base de dados";
          }
        }
        else
        {
          retorno = "Existem cobranças não pagas no nome deste cliente, para poder deletar é necessário efetuar o pagemento das contas pendentes!";
        }

        return retorno;
      }

    }

    public string EditCliente(int id, string nome, string telefone)
    {
      string retorno = string.Empty;
      if (repositorioCliente.TamanhoList() == 0)
      {
        retorno = "lista vazia";
        return retorno;
      }
      else
      {
        var editado = repositorioCliente.Update(new Client(id, nome, telefone));
        if (editado == true)
        {
          retorno = "cliente editado com sucesso";
        }
        else
        {
          retorno = "deu pau";
        }
        return retorno;
      }
    }

    public Client BuscarCliente(int idCliente)
    {
      var cliente = repositorioCliente.GetById(idCliente);
      if (cliente == null)
      {
        return null;
      }
      else
      {
        return cliente;
      }
    }
  }
}