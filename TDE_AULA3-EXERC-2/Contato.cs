namespace TDE_AULA3_EXERC_2
{
  public class Contato
  {
    public string id { get; set; }
    string nome;
    string numero;

    bool ativo = false;

    public Contato(string id, string nome, string numero, bool ativo)
    {
      this.id = id;
      this.nome = nome;
      this.numero = numero;
      this.ativo = ativo;
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

    public bool getAtivo()
    {
      return this.ativo;
    }

    public void setAtivo(bool ativo)
    {
      this.ativo = ativo;
    }

    public string getDescriptionContatosAtivos()
    {
      return "Id: " + id + " - " + nome + " -  Número: " + numero;
    }

    public string getDescriptionTodosContatos()
    {
      return "Id: " + id + " - " + nome + " -  Número: " + numero + " Ativado: " + ativo;
    }
  }
}