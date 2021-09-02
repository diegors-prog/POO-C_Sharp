using System;
using System.Collections.Generic;

namespace TDE_AULA3_EXERC_2
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
        contato.ativo = false;
      }
    }

    public void listarContatosAtivos()
    {
      if (tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia!");
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
          Console.WriteLine("Você possui " + tamanhoLista() + " contatos cadastrados, mas somente " + qtdContatosAtivos() + " estão ativos");
        }
        else
        {
          Console.WriteLine("Você possui " + tamanhoLista() + " contato cadastrado!");
        }
      }
    }

    public void listarTodosContatos()
    {
      if (tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia!");
      }
      else
      {
        foreach (Contato contato in listaDeContatos)
        {
          Console.WriteLine(contato.getDescriptionTodosContatos());
        }
        if (tamanhoLista() != 1)
        {
          Console.WriteLine("Você possui " + tamanhoLista() + " contatos cadastrados!");
        }
        else
        {
          Console.WriteLine("Você possui " + tamanhoLista() + " contato cadastrado!");
        }
      }
    }

  }
}