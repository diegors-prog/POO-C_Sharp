using System;

namespace TDE_09_interfaces
{
  public class GerenciadorDeContas
  {
    ContaCorrente minhaContaCorrente = new ContaCorrente(1, 50);
    public void fazerDeposito()
    {
      string resposta;
      Console.WriteLine("Digite o valor do deposito: ");
      resposta = Console.ReadLine();
      double respostaDouble = double.Parse(resposta);
      minhaContaCorrente.depositar(respostaDouble);
      Console.WriteLine("Valor adicionado com sucesso!\nSeu saldo é de: R$ " + minhaContaCorrente.Saldo);
    }
    public void fazerSaque()
    {
      string resposta;
      Console.WriteLine("Digite o valor do saque: ");
      resposta = Console.ReadLine();
      double respostaDouble = double.Parse(resposta);
      string retorno = minhaContaCorrente.sacar(respostaDouble);
      Console.WriteLine(retorno);
    }
    public void saldo()
    {
      Console.WriteLine(minhaContaCorrente.getSaldo());
    }

    ContaPoupanca minhaContaPoupanca = new ContaPoupanca(0);
    public void fazerDepositoPoupanca()
    {
      string resposta;
      Console.WriteLine("digite o valor do deposito: ");
      resposta = Console.ReadLine();
      double respostaDouble = double.Parse(resposta);
      minhaContaPoupanca.depositar(respostaDouble);
      Console.WriteLine("Valor adicionado com sucesso!\nSeu saldo é de: R$ " + minhaContaPoupanca.Saldo);
    }
    public void fazerSaquePoupanca()
    {
      string resposta;
      Console.WriteLine("Digite o valor do saque: ");
      resposta = Console.ReadLine();
      double respostaDouble = double.Parse(resposta);
      string retorno = minhaContaPoupanca.sacar(respostaDouble);
      Console.WriteLine(retorno);
    }
    public void saldoPoupanca()
    {
      Console.WriteLine(minhaContaPoupanca.getSaldo());
    }
  }
}