using System;

namespace TDE_09_interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      GerenciadorDeContas controle = new GerenciadorDeContas();

      string operadorContas;

      do
      {
        Console.WriteLine("Menu Principal\n");
        Console.WriteLine("Digite 1 para acessar sua conta corrente ");
        Console.WriteLine("Digite 2 para acessar sua conta poupança ");
        Console.WriteLine("Digite 0 para sair: \n");
        string primeiraResposta = Console.ReadLine();

        operadorContas = primeiraResposta;

        while (operadorContas != "1" && operadorContas != "2" && operadorContas != "0")
        {
          Console.WriteLine("Operação invalida digite novamente");
          primeiraResposta = Console.ReadLine();
          operadorContas = primeiraResposta;
        }

        if (operadorContas == "1")
        {
          string operador;

          do
          {
            Console.WriteLine("\nDigite 1 para fazer deposito em conta corrente: ");
            Console.WriteLine("Digite 2 para sacar da conta corrente: ");
            Console.WriteLine("Digite 3 para ver o saldo da conta corrente: ");
            Console.WriteLine("Digite 4 para ver o extrato: ");
            Console.WriteLine("Digite 0 para voltar ao menu principal: \n");

            string resposta = Console.ReadLine();

            operador = resposta;


            while (operador != "1" && operador != "2" && operador != "3" && operador != "4"
            && operador != "0")
            {
              Console.WriteLine("Operação invalida digite novamente");
              resposta = Console.ReadLine();
              operador = resposta;
            }
            switch (operador)
            {
              case "1":
                controle.fazerDeposito();
                break;
              case "2":
                controle.fazerSaque();
                break;
              case "3":
                controle.saldo();
                break;
              case "4":

                break;
            }
          } while (operador != "0");
        }
        else if (operadorContas == "2")
        {
          string operador;

          do
          {
            Console.WriteLine("Digite 1 para fazer deposito em conta poupança: ");
            Console.WriteLine("Digite 2 para sacar da conta poupança: ");
            Console.WriteLine("Digite 3 para ver o saldo da conta poupança ");
            Console.WriteLine("Digite 4 para ver o extrato: ");
            Console.WriteLine("Digite 0 para voltar ao menu principal: \n");

            string resposta = Console.ReadLine();

            operador = resposta;


            while (operador != "1" && operador != "2" && operador != "3" && operador != "4"
            && operador != "0")
            {
              Console.WriteLine("Operação invalida digite novamente");
              resposta = Console.ReadLine();
              operador = resposta;
            }
            switch (operador)
            {
              case "1":
                controle.fazerDepositoPoupanca();
                break;
              case "2":
                controle.fazerSaquePoupanca();
                break;
              case "3":
                controle.saldoPoupanca();
                break;
              case "4":

                break;
            }
          } while (operador != "0");

        }
        else
        {
          Console.WriteLine("Programa encerrado");
        }
      } while (operadorContas != "0");
    }
  }
}
