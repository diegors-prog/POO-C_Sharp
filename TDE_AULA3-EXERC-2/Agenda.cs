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

    void addContato()
    {
      string id = (listaDeContatos.Count + 1).ToString();
      escrever("Digite o nome do contato: ");
      string nome = resposta();
      escrever("Digite o número do contato: ");
      string numero = resposta();

      Contato novoContato = new Contato(id, nome, numero);
      listaDeContatos.Add(novoContato);
    }

    void editarContato()
    {
      escrever("Digite o id do usuário a ser editado");
      listarContatos();
      string contatoEditado = resposta();
      foreach (Contato contato in listaDeContatos)
      {
        if (contato.id == contatoEditado)
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
            escrever("O nome foi editado com sucesso!");
            return;
          }
          else if (oper == "2")
          {
            escrever("Digite o novo número");
            string novoNumero = resposta();
            contato.setNumero(novoNumero);
            escrever("O número foi editado com sucesso!");
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
            escrever("O nome e o número foram editados com sucesso!");
            return;
          }
          else
          {
            escrever("Operação inválida");
            return;
          }
        }
      }
    }

    void excluirContato()
    {
      escrever("Digite o id do usuário a ser excluído");
      listarContatos();
      string contatoExcluido = resposta();
      foreach (Contato contato in listaDeContatos)
      {
        if (contato.id == contatoExcluido)
        {
          listaDeContatos.Remove(contato);
          escrever("Usuário excluído com sucesso!");
          return;
        }
      }
    }

    void listarContatos()
    {
      foreach (Contato contato in listaDeContatos)
      {
        escrever(contato.getDescription());
      }
    }
    public void menu()
    {
      string sair = "0";

      do
      {
        escrever("Digite 1 para add um contato: ");
        escrever("Digite 2 para editar um contato: ");
        escrever("Digite 3 para excluir um contato: ");
        escrever("Digite 4 para listar os contatos: ");
        escrever("Digite Ctrl C para finalizar o programa");

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
          excluirContato();
        }
        else if (operador == "4")
        {
          listarContatos();
        }
        else
        {
          escrever("Opção invalida");
        }

      } while (sair != "99");

    }
  }
}