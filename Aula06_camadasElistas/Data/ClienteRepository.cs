using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula06_camadasElistas.Domain;

namespace Aula06_camadasElistas.Data
{
  public class ClienteRepository
  {
    private List<Client> listaClientes = new List<Client>();

    public void Save(Client cliente)
    {

      listaClientes.Add(cliente);
    }

    public List<Client> GetAll()
    {
      return listaClientes;
    }

    public bool Update(Client client)
    {

      var clienteED = listaClientes.Find(x => x.Id == client.Id);
      if (clienteED == null)
      {
        return false;
      }
      else
      {
        clienteED.Name = client.Name;
        clienteED.PhoneNumber = client.PhoneNumber;
        return true;
      }
    }
    public bool Delete(int id_dell)
    {
      var clienteDEL = listaClientes.Find(i => i.Id == id_dell);
      if (clienteDEL == null)
      {
        return false;
      }
      else
      {
        listaClientes.Remove(clienteDEL);
        return true;
      }

    }

    public int TamanhoList()
    {
      return listaClientes.Count;
    }

    public Client GetById(int id)
    {
      var cliente = listaClientes.Find(i => i.Id == id);
      return cliente;
    }
  }
}