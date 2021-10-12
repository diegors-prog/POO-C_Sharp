namespace CrudContasBancarias.Models
{
  public class ContaCorrenteRepository : Conta
  {
    public double Tarifa { get; set; }


    public ContaCorrenteRepository(double tarifa, double saldo,
                                string numeroDaConta,
                                string senha) : base(saldo, numeroDaConta, senha)
    {
      this.Tarifa = tarifa;
    }

    public double depositar(double valor)
    {
      Saldo = Saldo + valor;
      return Saldo;
    }

    public double sacar(double valor)
    {
      double saqueMaisTarifa = valor + Tarifa;
      Saldo = Saldo - saqueMaisTarifa;
      return Saldo;
    }
    public double getSaldo()
    {
      return Saldo;
    }
  }
}