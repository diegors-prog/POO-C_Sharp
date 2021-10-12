namespace CrudContasBancarias.Models
{
  public class Deposito
  {
    public string Conta { get; set; }
    public string Senha { get; set; }
    public double Valor { get; set; }

    public Deposito(string conta, string senha, double valor)
    {
      this.Conta = conta;
      this.Senha = senha;
      this.Valor = valor;
    }
  }
}