namespace TDE_09_interfaces
{
  public abstract class Conta : IConta
  {
    public double Saldo { get; set; }

    public Conta(double saldo)
    {
      this.Saldo = saldo;
    }

    public virtual void depositar(double valor)
    {

    }
    public virtual string sacar(double valor)
    {
      return "";
    }
    public virtual string getSaldo()
    {
      return "";
    }
  }
}