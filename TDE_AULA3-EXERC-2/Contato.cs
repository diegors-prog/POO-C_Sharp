namespace TDE_AULA3_EXERC_2
{
  public class Contato
  {
    public string id { get; set; }
    string nome;
    string numero;

    public Contato(string id, string nome, string numero)
    {
      this.id = id;
      this.nome = nome;
      this.numero = numero;
    }

    public string getNome()
    {
      return this.nome;
    }

    public void setNome(string nome)
    {
      this.nome = nome;
    }

    public string getNumero()
    {
      return this.numero;
    }

    public void setNumero(string numero)
    {
      this.numero = numero;
    }

    public string getDescription()
    {
      return "Id: " + id + " - " + nome + " -  Número: " + numero;
    }
  }
}