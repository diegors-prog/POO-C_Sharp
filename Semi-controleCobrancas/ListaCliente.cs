using System.Collections.Generic;

namespace Semi_controleCobrancas
{
    public class ListaCliente
    {
        List<Cliente> listaDeCliente = new List<Cliente>();
        
        /*Add clientes*/

        public void addCliente(Cliente cliente)
        {
            listaDeCliente.Add(cliente);
        }
        /*Apresenta o tamanho da lista de clientes*/

        public int tamanhoLista()            
        {
            return listaDeCliente.Count;
        }
        /*Apresenta os clientes cadastrados */

        public List<Cliente> listarClientes()
        {
            return listaDeCliente;    
        }
        /*Editar clientes cadastrados*/
        
        public string editarCliente(string idCliente, string nomeEditado, string telefoneEditado, 
        string cpfEditado, string enderecoEditado)
        {
            Cliente clienteEditar = null;
            clienteEditar = listaDeCliente.Find(c => c.Id.Equals(idCliente));
            if(clienteEditar == null)
            {
                return "ERRO cliente enexistente!";
            }

            clienteEditar.Nome = nomeEditado;
            clienteEditar.Telefone = telefoneEditado;
            clienteEditar.Cpf = cpfEditado;
            clienteEditar.Endereco = enderecoEditado;

            return "Contato editado com sucesso!";
        }
        /*Remover cliente*/
        
        public string removerCliente(string idRemover)
        {
            int clienteRemovido = listaDeCliente.FindIndex(c => c.Id.Equals(idRemover));

            if (clienteRemovido.Equals(-1))
            {
                return "ERRO, cliente inexistente";
            }

            listaDeCliente.RemoveAt(clienteRemovido);

            return "Cliente removido com sucesso!";
        }
    }
}