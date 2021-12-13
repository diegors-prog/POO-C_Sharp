using System;

namespace AS.Domain
{
  public class Cliente
  {
    public Cliente()
    {

    }
    public int Id { get; set; }
    public string Email { get; set; }
    public string Nome { get; set; }
    public string Fone { get; set; }
    public DateTime DataNasc { get; set; }
  }
}