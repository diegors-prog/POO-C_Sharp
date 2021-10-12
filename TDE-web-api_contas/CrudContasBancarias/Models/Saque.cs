namespace CrudContasBancarias.Models
{
  public class Saque
  {
    public string Conta { get; set; }
    public double Valor { get; set; }
    public string Senha { get; set; }

    public Saque(string conta, double valor, string senha)
    {
      this.Conta = conta;
      this.Valor = valor;
      this.Senha = senha;
    }
  }
}