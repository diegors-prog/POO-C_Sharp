using System.Runtime.CompilerServices;
using System.Transactions;
using System;
using System.Collections.Generic;

namespace Semi_controleCobrancas
{
    public class ListaCobranca
    {
        List<Cobranca> listaDeCobranca = new List<Cobranca>();

        /*Apresenta o tamanho da lista de cobranças*/

        public int tamanhoLista()            
        {
            return listaDeCobranca.Count;
        }
        /*Retorna as cobranças cadastradas */

        public List<Cobranca> listarCobrancas()
        {
            return listaDeCobranca;    
        }

        /*Add cobranças*/

        public void addCobranca(Cobranca cobranca)
        {
            listaDeCobranca.Add(cobranca);
        }

        /*Efetuar pagamento*/

        public string efetuarPagamento(string idCobranca)
        {
            Cobranca cobranca = null;
            cobranca = listaDeCobranca.Find(c => c.Id.Equals(idCobranca));


            if(cobranca == null)
            {
                return "ERRO, cobrança não encontrada, verifique o id correto na lista de cobranças";
            }
            
            if (cobranca.PagamentoRealizado == true)
            {
                return "Está cobrança já está paga!";
            }

            
            cobranca.DataPagamento = DateTime.Now.ToString("dd-MM-yyyy");
            cobranca.PagamentoRealizado = true;

            return "Pagamento realizado com sucesso na data de " + cobranca.DataPagamento + ", no valor de R$ " + cobranca.Valor;
            
        }
    }
}