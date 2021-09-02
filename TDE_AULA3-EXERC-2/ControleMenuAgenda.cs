using System;
using System.Collections.Generic;

namespace TDE_AULA3_EXERC_2
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

      Console.WriteLine("Contato adicionado com sucesso!");
    }

    public void escolherContatoEdit()
    {
      if (minhaAgenda.tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia, para poder editar é necessário possuir contatos cadastrados!");
        Console.WriteLine("Digite a opção 1 para começar a cadastrar seus contatos.");
      }
      else
      {
        Console.WriteLine("Digite o id do usuário a ser editado");
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

            Console.WriteLine("O nome e o número do contato foram editados com sucesso!");
            return;
          }
        }
        Console.WriteLine("Contato não encontrado, verifique corretamente o id dos contatos contidos na agenda!");
      }
    }

    public void escolherContatoDesativar()
    {
      if (minhaAgenda.tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia, para poder desativar é necessário possuir contatos cadastrados!");
        Console.WriteLine("Digite a opção 1 para começar a cadastrar seus contatos.");
      }
      else
      {
        Console.WriteLine("Digite o id do usuário a ser desativado");
        listContactsActivated();
        string idContatoDesativado = Console.ReadLine();

        foreach (Contato contato in minhaAgenda.getAllList())
        {
          if (contato.id.Equals(idContatoDesativado))
          {
            minhaAgenda.desativarContato(idContatoDesativado);
            Console.WriteLine("Contato desativado com sucesso!");
            return;
          }
        }
        Console.WriteLine("Contato não encontrado, verifique corretamente o id dos contatos contidos na agenda!");
      }
    }

    public void listContactsActivated()
    {
      minhaAgenda.listarContatosAtivos();
    }

    public void listFullContacts()
    {
      minhaAgenda.listarTodosContatos();
    }
  }
}