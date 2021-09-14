using System;
using System.Collections.Generic;

namespace Semi_controleCobrancas
{
    public class Cobranca
    {
        public string Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string DataPagamento { get; set; }
        public bool PagamentoRealizado { get; set; }
        public double Valor { get; set; }
        public Cliente Cliente_ { get; set; }
        
        public Cobranca(string id, DateTime dataEmissao, DateTime dataVencimento, double valor, Cliente cliente_)
        {
            this.Id = id;
            this.DataEmissao = dataEmissao;
            this.DataVencimento = dataVencimento;
            this.DataPagamento = "";
            this.PagamentoRealizado = false;
            this.Valor = valor;
            this.Cliente_ = cliente_;
        }

        public string getDescription()
        {
            return "Id cobrança: " + Id + " Valor: R$ " + Valor + "Pagamento efetuado pelo cliente " + Clinte.Nome + " ? " + PagamentoRealizado;
        }
    }
}