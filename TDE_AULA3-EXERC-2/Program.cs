using System;

namespace TDE_AULA3_EXERC_2
{
  class Program
  {
    static void Main(string[] args)
    {
      Contato contato1 = new Contato("Diego", "51982360459");
      Contato contato2 = new Contato("Gean", "51993748978");
      Contato contato3 = new Contato("Eduarda", "51925683683");
      Contato contato4 = new Contato("Mariana", "51998743128");

      Agenda contatos = new Agenda();

      contatos.minhaAgenda.Add(contato1);
      contatos.minhaAgenda.Add(contato2);
      contatos.minhaAgenda.Add(contato3);
      contatos.minhaAgenda.Add(contato4);

      foreach (Contato contato in contatos.minhaAgenda)
      {
        Console.WriteLine(contato.nome);
        Console.WriteLine(contato.numero);
      }
    }
  }
}
