using System;

namespace TDE_AULA3_EXERC_2
{
  class Program
  {
    static void Main(string[] args)
    {
      ControleMenuAgenda controle = new ControleMenuAgenda();

      string sair = "0";

      do
      {
        Console.WriteLine("Digite 1 para add um contato: ");
        Console.WriteLine("Digite 2 para editar um contato: ");
        Console.WriteLine("Digite 3 para desativar um contato: ");
        Console.WriteLine("Digite 4 para listar os contatos ativos: ");
        Console.WriteLine("Digite 5 para listar todos os contatos: ");
        Console.WriteLine("Pressione Ctrl C para finalizar o programa");

        string operador = Console.ReadLine();

        if (operador == "1")
        {
          controle.criarContato();
        }
        else if (operador == "2")
        {
          controle.escolherContatoEdit();
        }
        else if (operador == "3")
        {
          controle.escolherContatoDesativar();
        }
        else if (operador == "4")
        {
          controle.listContactsActivated();
        }
        else if (operador == "5")
        {
          controle.listFullContacts();
        }
        else
        {
          Console.WriteLine("Opção inválida!");
        }

      } while (sair != "99");

    }
  }
}
