namespace TDE_09_interfaces
{
  public class ContaPoupanca : Conta
  {
    public ContaPoupanca(double saldo) : base(saldo)
    {
    }

    public override void depositar(double valor)
    {
      Saldo = Saldo + valor;
    }
    public override string sacar(double valor)
    {
      if (Saldo < valor)
      {
        return "Saque Negado, saldo insuficiente!";
      }
      Saldo = Saldo - valor;
      return "Saque realizado com sucesso, você sacou: R$ " + valor + "\nSeu saldo atual agora é de: R$ " + Saldo;
    }
    public override string getSaldo()
    {
      return "Seu saldo atual é R$ " + Saldo;
    }
  }
}