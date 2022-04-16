using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula06_camadasElistas.Services;


namespace Aula06_camadasElistas.Controllers
{
  public class ClientCobrancaController
  {
    ClientService clienteServico = new ClientService();
    CobrancaService novacobranca = new CobrancaService();

    public void menu()
    {
      string operador = string.Empty;

      while (operador != "0")
      {
        Console.WriteLine("Digite 0 para sair");
        Console.WriteLine("Digite 1 para adicionar um novo cliente");
        Console.WriteLine("Digite 2 para editar um cliente");
        Console.WriteLine("Digite 3 para listar todos clientes");
        Console.WriteLine("Digite 4 para remover um cliente");
        Console.WriteLine("Digite 5 criar uma cobrança");
        Console.WriteLine("Digite 6 para listar uma cobranças");
        Console.WriteLine("Digite 7 para efetuar o pagamento de uma cobrança");

        operador = Console.ReadLine();

        switch (operador)
        {
          case "0":
            Environment.Exit(0);
            break;
          case "1":
            Console.WriteLine("Digite o nome do cliente");
            string nome = Console.ReadLine().Trim();

            Console.WriteLine("Digite o telefone do cliente");
            string telefone = Console.ReadLine().Trim();

            var retorno = clienteServico.CriarCliente(nome, telefone);
            Console.WriteLine(retorno);
            Console.WriteLine("");
            break;
          case "2":
            Console.WriteLine("Escolha o id do usuário a ser editado");
            var contatos = clienteServico.ListarClientes();
            if (contatos.Contains("vazia"))
            {
              Console.WriteLine(contatos);
              menu();
            }
            else
            {
              Console.WriteLine(contatos);
            }
            string idContato = Console.ReadLine();
            int idContatoInt = Convert.ToInt32(idContato);

            Console.WriteLine("Digite o novo nome");
            string novoNome = Console.ReadLine().Trim();

            Console.WriteLine("Digite o novo telefone");
            string novoTelefone = Console.ReadLine().Trim();

            var retorno2 = clienteServico.EditCliente(idContatoInt, novoNome, novoTelefone);
            Console.WriteLine(retorno2);
            Console.WriteLine("");
            break;
          case "3":
            var retorno3 = clienteServico.ListarClientes();
            Console.WriteLine(retorno3);
            break;
          case "4":
            Console.WriteLine("Escolha o id do usuário a ser removido");
            var todosContatos = clienteServico.ListarClientes();
            if (todosContatos.Contains("vazia"))
            {
              Console.WriteLine(todosContatos);
              menu();
            }
            else
            {
              Console.WriteLine(todosContatos);
            }
            string idContatoRemover = Console.ReadLine();
            int idContatoRemoverInt = Convert.ToInt32(idContatoRemover);

            var retorno6 = clienteServico.RemoverCliente(idContatoRemoverInt);
            Console.WriteLine(retorno6);
            break;
          case "5":
            System.Console.WriteLine("digite a data de vencimento");
            var datevenc = Console.ReadLine();

            DateTime date = Convert.ToDateTime(datevenc);

            System.Console.WriteLine("Digite o valor da cobrança ");
            var valor = Console.ReadLine();

            double valor2 = Convert.ToDouble(valor);

            System.Console.WriteLine("Escolha o id do cliente");
            var lista = clienteServico.ListarClientes();
            Console.WriteLine(lista);

            var id_cliente = Console.ReadLine();
            var id2 = Convert.ToInt32(id_cliente);

            var retorno10 = novacobranca.CriarCobranca(date, valor2, id2);
            Console.WriteLine(retorno10);

            break;
          case "6":
            var lista_cobranca = novacobranca.ListarCobrancas();
            Console.WriteLine(lista_cobranca);
            break;
          case "7":
            Console.WriteLine("escolha o id da conta a ser paga");
            var lista3 = novacobranca.ListarCobrancas();
            Console.WriteLine(lista3);

            var id = Console.ReadLine();
            var id_cobranca = Convert.ToInt32(id);
            var retorno11 = novacobranca.EfetuarPagamento(id_cobranca);

            Console.WriteLine(retorno11);
            break;
          default:
            Console.WriteLine("Invalido");
            menu();
            break;

        }
      }
    }
  }
}