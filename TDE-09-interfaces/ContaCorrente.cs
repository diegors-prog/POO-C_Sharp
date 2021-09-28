namespace TDE_09_interfaces
{
  public class ContaCorrente : Conta
  {
    public double Tarifa { get; set; }

    public ContaCorrente(double tarifa, double saldo) : base(saldo)
    {
      this.Tarifa = tarifa;
    }
    public override void depositar(double valor)
    {
      Saldo = Saldo + valor;
    }

    public override string sacar(double valor)
    {
      double saqueMaisTarifa = valor + Tarifa;

      if (Saldo < saqueMaisTarifa)
      {
        return "Saque Negado, saldo insuficiente!";
      }
      Saldo = Saldo - saqueMaisTarifa;

      return "Saque realizado com sucesso, você sacou: R$ " + valor + "\nSeu saldo atual agora é de: R$ " + Saldo;
    }
    public override string getSaldo()
    {
      return "Seu saldo atual é de R$ " + Saldo;
    }
  }
}