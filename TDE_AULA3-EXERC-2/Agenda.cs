using System;
using System.Collections.Generic;

namespace TDE_AULA3_EXERC_2
{
  public class Agenda
  {
    List<Contato> listaDeContatos = new List<Contato>();

    public void escrever(string valorDigitado)
    {
      Console.WriteLine(valorDigitado);
    }

    public string resposta() => Console.ReadLine();

    int tamanhoLista()
    {
      int tamanho;
      return tamanho = listaDeContatos.Count;
    }

    int qtdContatosAtivos()
    {
      int total = 0;
      foreach (Contato contato in listaDeContatos)
      {
        if (contato.getAtivo().Equals(true))
        {
          total = total + 1;
        }
      }
      return total;
    }

    void addContato()
    {
      string id = (listaDeContatos.Count + 1).ToString();
      escrever("Digite o nome do contato: ");
      string nome = resposta();
      escrever("Digite o número do contato: ");
      string numero = resposta();
      bool ativado = true;

      Contato novoContato = new Contato(id, nome, numero, ativado);
      listaDeContatos.Add(novoContato);
      escrever("O contato foi cadastrado com sucesso!");
    }

    void editarContato()
    {
      if (tamanhoLista().Equals(0))
      {
        escrever("Lista vazia, para poder editar é necessário possuir contatos cadastrados!");
        escrever("Digite a opção 1 para começar a cadastrar seus contatos.");
      }
      else
      {
        escrever("Digite o id do usuário a ser editado");
        listarContatosAtivos();
        string contatoEditado = resposta();

        foreach (Contato contato in listaDeContatos)
        {
          if (contato.id.Equals(contatoEditado))
          {
            escrever("Digite 1 para editar somente o nome");
            escrever("Digite 2 para editar somente o número");
            escrever("Digite 3 para editar o nome e o número");
            string oper = resposta();
            if (oper == "1")
            {
              escrever("Digite o novo nome");
              string novoNome = resposta();
              contato.setNome(novoNome);
              escrever("O nome do contato foi editado com sucesso!");
              return;
            }
            else if (oper == "2")
            {
              escrever("Digite o novo número");
              string novoNumero = resposta();
              contato.setNumero(novoNumero);
              escrever("O número do contato foi editado com sucesso!");
              return;
            }
            else if (oper == "3")
            {
              escrever("Digite o novo nome");
              string novoNome = resposta();
              contato.setNome(novoNome);
              escrever("Agora digite o novo número");
              string novoNumero = resposta();
              contato.setNumero(novoNumero);
              escrever("O nome e o número do contato foram editados com sucesso!");
              return;
            }
            else
            {
              escrever("Operação inválida");
              return;
            }
          }
        }
        escrever("Contato não encontrado, verifique corretamente o id dos contatos contidos na agenda!");
      }
    }

    void desativarContato()
    {
      if (tamanhoLista().Equals(0))
      {
        escrever("Lista vazia, para poder desativar é necessário possuir contatos cadastrados!");
        escrever("Digite a opção 1 para começar a cadastrar seus contatos.");
      }
      else
      {
        escrever("Digite o id do usuário a ser desativado");
        listarContatosAtivos();
        string contatoDesativado = resposta();

        foreach (Contato contato in listaDeContatos)
        {
          if (contato.id.Equals(contatoDesativado))
          {
            contato.setAtivo(false);
            escrever("Usuário desativado com sucesso!");
            return;
          }
        }
        escrever("Contato não encontrado, verifique corretamente o id dos contatos contidos na agenda!");
      }
    }

    void listarContatosAtivos()
    {
      if (tamanhoLista().Equals(0))
      {
        escrever("Lista vazia!");
      }
      else
      {
        foreach (Contato contato in listaDeContatos)
        {
          if (contato.getAtivo().Equals(true))
          {
            escrever(contato.getDescriptionContatosAtivos());
          }
        }
        if (tamanhoLista() != 1)
        {
          escrever("Você possui " + tamanhoLista() + " contatos cadastrados, mas somente " + qtdContatosAtivos() + " estão ativos");
        }
        else
        {
          escrever("Você possui " + tamanhoLista() + " contato cadastrado!");
        }
      }
    }

    void listarTodosContatos()
    {
      if (tamanhoLista().Equals(0))
      {
        escrever("Lista vazia!");
      }
      else
      {
        foreach (Contato contato in listaDeContatos)
        {
          escrever(contato.getDescriptionTodosContatos());
        }
        if (tamanhoLista() != 1)
        {
          escrever("Você possui " + tamanhoLista() + " contatos cadastrados!");
        }
        else
        {
          escrever("Você possui " + tamanhoLista() + " contato cadastrado!");
        }
      }
    }
    public void menu()
    {
      string sair = "0";

      do
      {
        escrever("Digite 1 para add um contato: ");
        escrever("Digite 2 para editar um contato: ");
        escrever("Digite 3 para desativar um contato: ");
        escrever("Digite 4 para listar os contatos ativos: ");
        escrever("Digite 5 para listar todos os contatos: ");
        escrever("Pressione Ctrl C para finalizar o programa");

        string operador = resposta();

        if (operador == "1")
        {
          addContato();
        }
        else if (operador == "2")
        {
          editarContato();
        }
        else if (operador == "3")
        {
          desativarContato();
        }
        else if (operador == "4")
        {
          listarContatosAtivos();
        }
        else if (operador == "5")
        {
          listarTodosContatos();
        }
        else
        {
          escrever("Opção invalida");
        }

      } while (sair != "99");

    }
  }
}