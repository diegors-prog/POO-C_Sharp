using System;

namespace Exerc_c_sharp
{
  public class ControleMenuAgenda
  {
    Agenda minhaAgenda = new Agenda();

    public void criarContato()
    {
      string numeroId = (minhaAgenda.getAllList().Count + 1).ToString();
      Console.WriteLine("Digite o nome do contato: ");
      string nome = Console.ReadLine();
      Console.WriteLine("Digite o número do contato: ");
      string numero = Console.ReadLine();

      minhaAgenda.addContato(new Contato(numeroId, nome, numero));

      Console.WriteLine("Contato adicionado com sucesso!\n");
    }

    public void escolherContatoEdit()
    {
      if (minhaAgenda.tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia, para poder editar é necessário possuir contatos cadastrados!");
        Console.WriteLine("Digite a opção 1 para começar a cadastrar seus contatos.\n");
      }
      else
      {
        Console.WriteLine("Digite o id do usuário a ser editado\n");
        listContactsActivated();
        string idContatoEditado = Console.ReadLine();

        foreach (Contato contato in minhaAgenda.getAllList())
        {
          if (contato.id.Equals(idContatoEditado))
          {
            Console.WriteLine("Digite o novo nome");
            string novoNome = Console.ReadLine();
            Console.WriteLine("Digite o novo número");
            string novoNumero = Console.ReadLine();

            minhaAgenda.editarContato(idContatoEditado, novoNome, novoNumero);

            Console.WriteLine("O nome e o número do contato foram editados com sucesso!\n");
            return;
          }
        }
        Console.WriteLine("Contato não encontrado, verifique corretamente o id dos contatos contidos na agenda!\n");
      }
    }

    public void escolherContatoDesativar()
    {
      if (minhaAgenda.tamanhoLista().Equals(0) || minhaAgenda.qtdContatosAtivos().Equals(0))
      {
        Console.WriteLine("Lista vazia ou sem contatos ativos, para poder desativar é necessário possuir contatos cadastrados e ativados!");
        Console.WriteLine("Digite a opção 1 para começar a cadastrar seus contatos.\n");
      }
      else
      {
        Console.WriteLine("Digite o id do usuário a ser desativado\n");
        listContactsActivated();
        string idContatoDesativado = Console.ReadLine();

        foreach (Contato contato in minhaAgenda.getAllList())
        {
          if (contato.id.Equals(idContatoDesativado))
          {
            minhaAgenda.desativarContato(idContatoDesativado);
            Console.WriteLine("Contato desativado com sucesso!\n");
            return;
          }
        }
        Console.WriteLine("Contato não encontrado, verifique corretamente o id dos contatos ativos contidos na agenda!\n");
      }
    }

    public void escolherContatoReativar()
    {
      if (minhaAgenda.tamanhoLista().Equals(0) || minhaAgenda.qtdContatosDesativados().Equals(0))
      {
        Console.WriteLine("Lista vazia ou sem contatos inativos, para poder reativar é necessário possuir contatos cadastrados e desativados!");
        Console.WriteLine("Digite a opção 1 para começar a cadastrar seus contatos.\n");
      }
      else
      {
        Console.WriteLine("Digite o id do usuário a ser reativado\n");
        listContactsDesactivated();
        string idContatoReativado = Console.ReadLine();

        foreach (Contato contato in minhaAgenda.getAllList())
        {
          if (contato.id.Equals(idContatoReativado))
          {
            minhaAgenda.reativarContato(idContatoReativado);
            Console.WriteLine("Contato reativado com sucesso!\n");
            return;
          }
        }
        Console.WriteLine("Contato não encontrado, verifique corretamente o id dos contatos ativos contidos na agenda!\n");
      }
    }

    public void listContactsActivated()
    {
      minhaAgenda.listarContatosAtivos();
    }

    public void listContactsDesactivated()
    {
      minhaAgenda.listarContatosInativos();
    }

    public void listFullContacts()
    {
      minhaAgenda.listarTodosContatos();
    }
  }
}