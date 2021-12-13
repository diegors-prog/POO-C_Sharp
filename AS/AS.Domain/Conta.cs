using System;

namespace AS.Domain
{
  public class Conta
  {
    public Conta()
    {

    }
    public int Id { get; set; }
    public DateTime DataLeitura { get; set; }
    public int NumLeitura { get; set; }
    public int KwGasto { get; set; }
    public double ValorPagar { get; set; }
    public DateTime DataPagamento { get; set; }
    public double MediaConsumo { get; set; }
    public bool PagamentoRealizado { get; set; }
    public Cliente Cliente { get; set; }
  }
}