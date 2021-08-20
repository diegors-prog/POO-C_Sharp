namespace TDE_AULA3_EXERC_3
{
  public class Autor
  {
    public string nome { get; set; }
    public string email { get; set; }

    public Autor(string nome, string email)
    {
      this.nome = nome;
      this.email = email;
    }
  }
}