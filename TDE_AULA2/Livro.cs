namespace TDE_AULA2
{
    public class Livro
    {
        string nome;
        string descricao;
        double valor;
        string isbn;
        Autor autorlivro;

        public Livro(string n, string desc, double v, string isbn, Autor autor)
        {
            this.nome = n;
            this.descricao = desc;
            this.valor = v;
            this.isbn = isbn;
            this.autorlivro = autor; 
        }
        
        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        
        public string getDescricao()
        {
            return this.descricao;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        
        public double getValor()
        {
            return this.valor;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }
        
        public string getIsbn()
        {
            return this.isbn;
        }

        public void setIsbn(string isbn)
        {
            this.isbn = isbn;
        }
        
        public Autor getAutorLivro()
        {
            return this.autorlivro;
        }

        public void setAutorLivro(Autor autorlivro)
        {
            this.autorlivro = autorlivro;
        }
    }
}