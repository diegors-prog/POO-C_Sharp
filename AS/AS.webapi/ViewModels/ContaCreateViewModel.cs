using AS.Domain;

namespace AS.webapi.ViewModels
{
  public class ContaCreateViewModel
  {
    public ContaCreateViewModel(int numLeitura,
    int kmgasto, double valorPagar, Cliente cliente)
    {

      this.NumLeitura = numLeitura;
      this.KwGasto = kmgasto;
      this.ValorPagar = valorPagar;
      this.Cliente = cliente;
    }
    public ContaCreateViewModel()
    {

    }

    public int NumLeitura { get; set; }
    public int KwGasto { get; set; }
    public double ValorPagar { get; set; }
    public Cliente Cliente { get; set; }
  }
}