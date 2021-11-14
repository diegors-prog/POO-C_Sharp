using System;

namespace AP2_POO.Models
{
  public class Cliente
  {
    public int Id { get; set; }
    public string Email { get; set; }
    public string Nome { get; set; }
    public string Fone { get; set; }
    public DateTime DataNasc { get; set; }

    public Cliente()
    {

    }
  }

}