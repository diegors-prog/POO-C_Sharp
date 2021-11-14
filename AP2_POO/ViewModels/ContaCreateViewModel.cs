using System;

namespace AP2_POO.ViewModels
{
  public class ContaCreateViewModel
  {
    public ContaCreateViewModel(int numLeitura,
    int kmgasto, double valorPagar, int clienteId)
    {

      this.NumLeitura = numLeitura;
      this.KwGasto = kmgasto;
      this.ValorPagar = valorPagar;
      this.ClienteId = clienteId;
    }
    public ContaCreateViewModel()
    {

    }

    public int NumLeitura { get; set; }
    public int KwGasto { get; set; }
    public double ValorPagar { get; set; }
    public int ClienteId { get; set; }
  }
}