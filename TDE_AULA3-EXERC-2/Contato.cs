namespace TDE_AULA3_EXERC_2
{
  public class Contato
  {
    public string nome { get; set; }
    public string numero { get; set; }

    public Contato(string nome, string num)
    {
      this.nome = nome;
      this.numero = num;
    }
  }
}