namespace TDE_AULA3_EXERC_3
{
  public class Livro
  {
    public string id { get; private set; }
    public string nome { get; set; }
    public string genero { get; set; }
    public string descricao { get; set; }
    public string isbn { get; private set; }
    public Autor autorLivro { get; set; }

    public Livro(string id, string nome, string genero, string descricao, string isbn, Autor autor)
    {
      this.id = id;
      this.nome = nome;
      this.genero = genero;
      this.descricao = descricao;
      this.isbn = isbn;
      this.autorLivro = autor;
    }

    public string getDescription()
    {
      return "Nome do livro: " + nome + " Gênero: " + genero + " Código: " + id + "\nDescrição: " + descricao;
    }
  }
}