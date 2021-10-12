namespace CrudContasBancarias.Models
{
  public class Saque
  {
    public double Valor { get; set; }
    public string Senha { get; set; }

    public Saque(double valor, string senha)
    {
      this.Valor = valor;
      this.Senha = senha;
    }
  }
}