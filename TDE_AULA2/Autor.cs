namespace TDE_AULA2
{
    public class Autor
    {
        string nome;
        string cpf;
        string email;

        public Autor(string n, string cpf, string email)
        {
            this.nome = n;
            this.cpf = cpf;
            this.email = email;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        
        public string getCpf()
        {
            return this.cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        
        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
    }
}