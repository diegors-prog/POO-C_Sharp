using System;

namespace AP2_POO.Models
{
    public class Conta
    {
        /*public Conta(int id, DateTime dataLeitura, int numLeitura, 
        int kmgasto, double valorPagar, double mediaConsumo)
        {
            this.Id = id;
            this.DataLeitura = dataLeitura;
            this.NumLeitura = numLeitura;
            this.KwGasto = kmgasto;
            this.ValorPagar = valorPagar;
            this.MediaConsumo = mediaConsumo;
            this.PagamentoRealizado = false;
        }*/
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