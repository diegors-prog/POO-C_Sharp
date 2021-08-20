namespace TDE_AULA3_EXERC_3
{
  public class Cliente
  {
    public string id { get; private set; }
    public string nome { get; set; }
    public string telefone { get; set; }
    public string endereco { get; set; }

    public Cliente(string id, string nome, string telefone, string endereco)
    {
      this.id = id;
      this.nome = nome;
      this.telefone = telefone;
      this.endereco = endereco;
    }

    public string getDescription()
    {
      return "Código e nome do cliente: " + id + " - " + nome;
    }
  }
}