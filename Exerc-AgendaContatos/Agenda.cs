using System.Collections.Generic;

namespace Exerc_AgendaContatos
{
  public class Agenda
  {
    List<Contato> listaDeContatos = new List<Contato>();

    public int tamanhoLista()
    {
      return listaDeContatos.Count;
    }

    public int qtdContatosAtivos()
    {
      return listaDeContatos.FindAll(c => c.ativo == true).Count;
    }

    public int qtdContatosDesativados()
    {
      return listaDeContatos.FindAll(c => c.ativo == false).Count;
    }

    public void addContato(Contato contato)
    {
      listaDeContatos.Add(contato);
    }

    public string editarContato(string idContato,
                string nomeEditado,
                string numeroEditado)
    {
      Contato contato = null;
      contato = listaDeContatos.Find(c => c.id.Equals(idContato));

      if (contato == null)
      {
        return "Esse contato não existe, liste todos os contatos e verifique!";
      }

      contato.nome = nomeEditado;
      contato.numero = numeroEditado;

      return "Contato editado com sucesso!";
    }

    public string desativarContato(string idContato)
    {
      Contato contato = null;
      contato = listaDeContatos.Find(c => c.id.Equals(idContato) && c.ativo.Equals(true));

      if (contato == null)
      {
        return "Este contato já está desativado ou não existe, por favor liste todos os contatos e verifique!";
      }

      contato.ativo = false;
      return "Contato desativado com sucesso!";
    }

    public string reativarContato(string idContato)
    {
      Contato contato = null;
      contato = listaDeContatos.Find(c => c.id.Equals(idContato) && c.ativo.Equals(false));

      if (contato == null)
      {
        return "Este contato já está ativado ou não existe, por favor liste todos os contatos e verifique!";
      }

      contato.ativo = true;
      return "Contato reativado com sucesso!";
    }

    public List<Contato> obterContatosAtivos()
    {
      return listaDeContatos.FindAll(c => c.ativo == true);
    }

    public List<Contato> obterContatosInativos()
    {
      return listaDeContatos.FindAll(c => c.ativo == false);
    }

    public List<Contato> obterTodosContatos()
    {
      return listaDeContatos;
    }
  }
}