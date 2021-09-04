using System;
using System.Collections.Generic;

namespace Exerc_AgendaContatos
{
  public class ControleMenuAgenda
  {
    Agenda minhaAgenda = new Agenda();

    public void criarContato()
    {
      string numeroId = (minhaAgenda.tamanhoLista() + 1).ToString();
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

        foreach (Contato contato in minhaAgenda.obterTodosContatos())
        {
          if (contato.id.Equals(idContatoEditado))
          {
            Console.WriteLine("Digite o novo nome");
            string novoNome = Console.ReadLine();
            Console.WriteLine("Digite o novo número");
            string novoNumero = Console.ReadLine();

            string retorno = minhaAgenda.editarContato(idContatoEditado, novoNome, novoNumero);

            Console.WriteLine(retorno + "\n");
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

        string retorno = minhaAgenda.desativarContato(idContatoDesativado);
        Console.WriteLine(retorno + "\n");
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

        string retorno = minhaAgenda.reativarContato(idContatoReativado);
        Console.WriteLine(retorno + "\n");
      }
    }

    public void listContactsActivated()
    {
      List<Contato> contatos = minhaAgenda.obterContatosAtivos();

      if (contatos.Count == 0)
      {
        Console.WriteLine("Não existem contatos ativos\n");
      }
      else
      {
        foreach (var item in minhaAgenda.obterContatosAtivos())
        {
          Console.WriteLine(item.getDescriptionContacts());
        }
      }
    }

    public void listContactsDesactivated()
    {
      List<Contato> contatos = minhaAgenda.obterContatosInativos();

      if (contatos.Count == 0)
      {
        Console.WriteLine("Não existem contatos desativados\n");
      }
      else
      {
        foreach (var item in minhaAgenda.obterContatosInativos())
        {
          Console.WriteLine(item.getDescriptionContacts());
        }
      }
    }

    public void listFullContacts()
    {
      List<Contato> contatos = minhaAgenda.obterTodosContatos();

      if (contatos.Count == 0)
      {
        Console.WriteLine("Não exitem contatos na agenda!\n");
      }
      else
      {
        foreach (var item in minhaAgenda.obterTodosContatos())
        {
          Console.WriteLine(item.getDescriptionTodosContatos());
        }
      }
    }
  }
}