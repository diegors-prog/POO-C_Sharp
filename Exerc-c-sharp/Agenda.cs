using System;
using System.Collections.Generic;

namespace Exerc_c_sharp
{
  public class Agenda
  {
    List<Contato> listaDeContatos = new List<Contato>();

    public List<Contato> getAllList()
    {
      return listaDeContatos;
    }

    public int tamanhoLista()
    {
      return listaDeContatos.Count;
    }

    public int qtdContatosAtivos()
    {
      int total = 0;
      foreach (Contato contato in listaDeContatos)
      {
        if (contato.ativo.Equals(true))
        {
          total = total + 1;
        }
      }
      return total;
    }

    public int qtdContatosDesativados()
    {
      int total = 0;
      foreach (Contato contato in listaDeContatos)
      {
        if (contato.ativo.Equals(false))
        {
          total = total + 1;
        }
      }
      return total;
    }

    public void addContato(Contato contato)
    {
      listaDeContatos.Add(contato);
    }

    public void editarContato(string idContato,
                string nomeEditado,
                string numeroEditado)
    {
      foreach (Contato contato in listaDeContatos)
      {
        if (contato.id.Equals(idContato))
        {
          contato.nome = nomeEditado;
          contato.numero = numeroEditado;
        }
      }
    }

    public void desativarContato(string idContato)
    {
      foreach (Contato contato in listaDeContatos)
      {
        if (contato.id.Equals(idContato) && contato.ativo.Equals(true))
        {
          contato.ativo = false;
          return;
        }
      }
      Console.WriteLine("Este contato já está desativado ou o id está incorreto, por favor liste todos os contatos e verifique!");
    }

    public void reativarContato(string idContato)
    {
      foreach (Contato contato in listaDeContatos)
      {
        if (contato.id.Equals(idContato) && contato.ativo.Equals(false))
        {
          contato.ativo = true;
          return;
        }
      }
    }

    public void listarContatosAtivos()
    {
      if (tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia!\n");
      }
      else
      {
        foreach (Contato contato in listaDeContatos)
        {
          if (contato.ativo.Equals(true))
          {
            Console.WriteLine(contato.getDescriptionContatosAtivos());
          }
        }
        if (tamanhoLista() != 1)
        {
          string resposta = qtdContatosAtivos() != 1 ? "Você possui " + tamanhoLista() + " contatos cadastrados, e destes " + qtdContatosAtivos() + " estão ativos.\n" : "Você possui " + tamanhoLista() + " contatos cadastrados, e destes " + qtdContatosAtivos() + " está ativo.\n";
          Console.WriteLine(resposta);
        }
        else
        {
          Console.WriteLine("Você possui " + tamanhoLista() + " contato cadastrado!\n");
        }
      }
    }

    public void listarContatosInativos()
    {
      if (tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia!\n");
      }
      else
      {
        foreach (Contato contato in listaDeContatos)
        {
          if (contato.ativo.Equals(false))
          {
            Console.WriteLine(contato.getDescriptionContatosInativos());
          }
        }
        if (tamanhoLista() != 1)
        {
          string resposta = qtdContatosDesativados() != 1 ? "Você possui " + tamanhoLista() + " contatos cadastrados, e destes " + qtdContatosDesativados() + " estão inativos.\n" : "Você possui " + tamanhoLista() + " contatos cadastrados, e destes " + qtdContatosDesativados() + " está inativo.\n";
          Console.WriteLine(resposta);
        }
        else
        {
          Console.WriteLine("Você possui " + tamanhoLista() + " contato cadastrado!\n");
        }
      }
    }

    public void listarTodosContatos()
    {
      if (tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia!\n");
      }
      else
      {
        foreach (Contato contato in listaDeContatos)
        {
          Console.WriteLine(contato.getDescriptionTodosContatos());
        }
        if (tamanhoLista() != 1)
        {
          Console.WriteLine("Você possui " + tamanhoLista() + " contatos cadastrados!\n");
        }
        else
        {
          Console.WriteLine("Você possui " + tamanhoLista() + " contato cadastrado!\n");
        }
      }
    }
  }
}