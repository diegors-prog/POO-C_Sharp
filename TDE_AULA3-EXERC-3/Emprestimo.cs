namespace TDE_AULA3_EXERC_3
{
  public class Emprestimo
  {
    public string id { get; private set; }
    public Cliente cliente { get; private set; }

    public Livro livro { get; private set; }

    public Emprestimo(string id, Cliente cliente, Livro livro)
    {
      this.id = id;
      this.cliente = cliente;
      this.livro = livro;
    }

    public string getDescription()
    {
      return "EMPRÉSTIMO " + id + "\n" + livro.getDescription() + "\n" + cliente.getDescription();
    }
  }
}