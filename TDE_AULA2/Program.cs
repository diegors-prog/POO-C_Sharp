using System;

namespace TDE_AULA2
{
  class Program
  {
    static void Main(string[] args)
    {
      Autor autorLivro = new Autor("João do Caminhão", "032 902 034 03", "joao_caminhao@gmail.com");
      Livro nomeLivro = new Livro("Pelo Mundo", "Livro Aventura", 20.00, "01-0002-003", autorLivro);

      Console.WriteLine("Nome do livro: " + nomeLivro.getNome());
      Console.WriteLine("Nome do autor: " + nomeLivro.getAutorLivro().getNome());
    }

  }
}
