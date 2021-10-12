namespace CrudContasBancarias.Models
{
  public abstract class Conta
  {
    public double Saldo { get; set; }
    public string NumeroDaConta { get; set; }
    public string Senha { get; set; }

    public Conta() { }

    public Conta(double saldo, string numeroDaConta, string senha)
    {
      this.Saldo = saldo;
      this.NumeroDaConta = numeroDaConta;
      this.Senha = senha;
    }
  }
}