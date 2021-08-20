using System;
using System.Collections.Generic;

namespace TDE_AULA3_EXERC_3
{
  public class Biblioteca
  {
    List<Cliente> minhaListaClientes = new List<Cliente>();
    List<Autor> listaAutores = new List<Autor>();
    List<Livro> listaLivros = new List<Livro>();
    List<Emprestimo> meusEmprestimos = new List<Emprestimo>();
    public void escrever(string opcoes)
    {
      Console.WriteLine(opcoes);
    }

    public string resposta() => Console.ReadLine();

    void cadastrarCliente()
    {
      string codigo = (minhaListaClientes.Count + 1).ToString();
      escrever("Digite o nome do cliente");
      string nome = resposta();
      escrever("Digite o telefone do cliente");
      string telefone = resposta();
      escrever("Digite o endereço do cliente");
      string endereco = resposta();

      Cliente novoCliente = new Cliente(codigo, nome, telefone, endereco);
      minhaListaClientes.Add(novoCliente);
    }

    void listarClientes()
    {
      foreach (Cliente cliente in minhaListaClientes)
      {
        escrever(cliente.getDescription());
      }
    }

    void cadastrarLivros()
    {
      escrever("Digite o nome do autor do livro");
      string nomeAutor = resposta();
      escrever("Digite o e-mail do autor do livro");
      string emailAutor = resposta();
      string codigo = (listaLivros.Count + 1).ToString();
      escrever("Digite o nome do livro");
      string nomeLivro = resposta();
      escrever("Digite o gênero do livro");
      string genero = resposta();
      escrever("Digite a descrição sobre o livro");
      string descricao = resposta();
      escrever("Digite o código isbn do livro");
      string codigoIsbn = resposta();

      Autor novoAutor = new Autor(nomeAutor, emailAutor);
      listaAutores.Add(novoAutor);

      Livro novoLivro = new Livro(codigo, nomeLivro, genero, descricao, codigoIsbn, novoAutor);
      listaLivros.Add(novoLivro);
    }

    void listarLivros()
    {
      foreach (Livro livro in listaLivros)
      {
        escrever(livro.getDescription());
      }
    }

    void emprestarLivros()
    {
      string codigo = (meusEmprestimos.Count + 1).ToString();
      escrever("Escolha o cliente pelo código");
      listarClientes();
      string clienteEscolhido = resposta();
      Cliente cliente = minhaListaClientes.Find((c => c.id == clienteEscolhido));
      if (cliente == null)
      {
        return;
      }
      escrever("Escolha um livro pelo código");
      listarLivros();
      string livroEscolhido = resposta();
      Livro livro = listaLivros.Find((l => l.id == livroEscolhido));
      if (livro == null)
      {
        return;
      }

      Emprestimo novoEmprestimo = new Emprestimo(codigo, cliente, livro);
      meusEmprestimos.Add(novoEmprestimo);
    }

    void listarEmprestimos()
    {
      foreach (Emprestimo emprestimo in meusEmprestimos)
      {
        escrever(emprestimo.getDescription());
      }
    }

    public void menu()
    {
      string sair = "0";
      do
      {
        escrever("Digite 1 para cadastrar um cliente");
        escrever("Digite 2 para listar os clientes cadastrados");
        escrever("Digite 3 para cadastrar um livro");
        escrever("Digite 4 para listar os livros cadastrados");
        escrever("Digite 5 para efetuar um empréstimo");
        escrever("Digite 6 para listar os empréstimos");
        escrever("Digite 99 para fechar o programa");

        string oper = resposta();

        if (oper == "1")
        {
          cadastrarCliente();
        }
        else if (oper == "2")
        {
          listarClientes();
        }
        else if (oper == "3")
        {
          cadastrarLivros();
        }
        else if (oper == "4")
        {
          listarLivros();
        }
        else if (oper == "5")
        {
          emprestarLivros();
        }
        else if (oper == "6")
        {
          listarEmprestimos();
        }
        else
        {
          escrever("Opção inválida!");
        }
      } while (sair != "99");
    }
  }
}