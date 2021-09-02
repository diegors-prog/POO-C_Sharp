namespace Exerc_c_sharp
{
  public class Contato
  {
    public string id { get; set; }
    public string nome { get; set; }
    public string numero { get; set; }

    public bool ativo { get; set; }

    public Contato(string id, string nome, string numero)
    {
      this.id = id;
      this.nome = nome;
      this.numero = numero;
      this.ativo = true;
    }

    public string getDescriptionContatosAtivos()
    {
      return "Id: " + id + " - " + nome + " -  Número: " + numero;
    }

    public string getDescriptionContatosInativos()
    {
      return "Id: " + id + " - " + nome + " -  Número: " + numero;
    }

    public string getDescriptionTodosContatos()
    {
      return "Id: " + id + " - " + nome + " -  Número: " + numero + " Ativado: " + ativo;
    }
  }
}