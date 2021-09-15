using System;
using System.Collections.Generic;
using System.Linq;

namespace Semi_controleCobrancas
{
    public class ControleClienteCobranca
    {
        ListaCliente minhaListaCliente = new ListaCliente();
        ListaCobranca minhaListaCobranca = new ListaCobranca();

        public void criarCliente()
        {
            string id_C = "";
            if (minhaListaCliente.tamanhoLista().Equals(0))
            {
                id_C = (minhaListaCliente.tamanhoLista() + 1).ToString();
            }
            else
            {
                id_C = criarIdCliente();
            }
            Console.WriteLine("Digite o nome do cliente: ");
            string nome_C = Console.ReadLine();
            Console.WriteLine("Digite o número do cliente: ");
            string numero_C = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            string cpf_C = Console.ReadLine();
            Console.WriteLine("Digite o endereço do cliente: ");
            string endereco_C = Console.ReadLine();

            minhaListaCliente.addCliente(new Cliente(id_C, nome_C, numero_C, cpf_C, endereco_C));

            Console.WriteLine("Cliente adicionado com sucesso!\n");

        }  

        public string criarIdCliente()
        {
            List<Cliente> clientes = minhaListaCliente.listarClientes();
            Cliente lastCliente = clientes.Last();
            string idLastCliente = lastCliente.Id;
            int idInt = int.Parse(idLastCliente);
            idInt = idInt + 1;
            
            string novoId = idInt.ToString();

            return novoId;           
        }
        public void printLista()
        {
            
            Console.WriteLine("Numero de clientes cadastrados: " + minhaListaCliente.tamanhoLista());
        }

        public void apresentarListaCliente()
        {
            List<Cliente> clientes = minhaListaCliente.listarClientes();
            if (clientes.Count == 0)
            {
                Console.WriteLine("Numero de clientes cadastrados é igual a 0! ");
            }
            else
            {
                foreach (var item in minhaListaCliente.listarClientes())
                { 
                    Console.WriteLine(item.getDescription());
                }
            }
        }

        public void apresentarClienteEditado()
        {
            if(minhaListaCliente.tamanhoLista().Equals(0))
            {
                Console.WriteLine("Lista vazia, para poder editar e necessario \n possuir clientes cadastrados");
            }
            else
            {
                Console.WriteLine("Digite o numero do id do cliente a ser editado: ");
                apresentarListaCliente();
                string idClienteEditar = Console.ReadLine();

                foreach (Cliente item in minhaListaCliente.listarClientes())
                {
                    if (item.Id.Equals(idClienteEditar))
                    {
                        Console.WriteLine("Digite o novo nome: ");
                        string novoNome = Console.ReadLine();
                        Console.WriteLine("Digite o novo telefone: ");
                        string novoTelefone = Console.ReadLine();
                        Console.WriteLine("Digite o novo CPF: ");
                        string novoCpf = Console.ReadLine();
                        Console.WriteLine("Digite o novo endereco: ");
                        string novoEndereco = Console.ReadLine();
                        
                        string retorno = minhaListaCliente.editarCliente(idClienteEditar, 
                        novoNome, novoTelefone, novoCpf, novoEndereco);
                        Console.WriteLine(retorno);
                        return;
                    }
                }
            }
        }

        public void apresentarClienteRemovido()
        {   
            if(minhaListaCliente.tamanhoLista().Equals(0))
            {
                Console.WriteLine("Lista vazia, para poder remover e necessario \n possuir clientes cadastrados");
            }
            else
            {
                Console.WriteLine("Digite o id do cliente a ser removido: ");
                apresentarListaCliente();
                string idClienteRemover = Console.ReadLine();

                List<Cobranca> cobrancas = minhaListaCobranca.listarCobrancas();
                Cobranca cobranca = null;
                cobranca = cobrancas.Find(c => c.Cliente_.Id.Equals(idClienteRemover));

                if(cobranca == null)
                {
                    string retorno = minhaListaCliente.removerCliente(idClienteRemover);
                    Console.WriteLine(retorno);
                }else
                {
                    Console.WriteLine("Cliente possui combranças em seu nome, impossível remover!");
                }
            }
        }

        public void criarCobranca()
        {
            Console.WriteLine("Escolha o id do cliente que recebera essa cobrança: ");
            apresentarListaCliente();
            string idCliente = Console.ReadLine();
            List<Cliente> clientes = minhaListaCliente.listarClientes();
            Cliente clienteDevedor = null;
            clienteDevedor = clientes.Find(c => c.Id.Equals(idCliente));
            if(clienteDevedor == null)
            {
                Console.WriteLine("ERRO, cliente inexistente, verifique o id correto na lista de clientes");
            }
             else
            {
                string id_Cobranca = (minhaListaCobranca.tamanhoLista() + 1).ToString();
                Console.WriteLine("Digite a data de emissão da cobrança ");
                string novaDataEmissao = Console.ReadLine();
                DateTime dataEmissao = Convert.ToDateTime(novaDataEmissao);
                Console.WriteLine("Digite a data de vencimento da cobrança ");
                string novaDataVencimento = Console.ReadLine();
                DateTime dataVencimento = Convert.ToDateTime(novaDataVencimento);
                Console.WriteLine("Digite o valor da cobrança ");
                string novoValor = Console.ReadLine();
                double valorCobrado = Convert.ToDouble(novoValor);

                minhaListaCobranca.addCobranca(new Cobranca(id_Cobranca, dataEmissao, dataVencimento, valorCobrado, clienteDevedor));

                Console.WriteLine("Cobrança cadastrada com sucesso!\n");
            }            

        }

        public void escolherCobrancaPagamento()
        {
            Console.WriteLine("Digite o id da cobrança em que será realizado o pagamento ");
            apresentarListaCobrancas();
            string idCobranca = Console.ReadLine();

            string retorno = minhaListaCobranca.efetuarPagamento(idCobranca);
            Console.WriteLine(retorno);
        }

        public void apresentarListaCobrancas()
        {
            List<Cobranca> cobrancas = minhaListaCobranca.listarCobrancas();
            if (cobrancas.Count == 0)
            {
                Console.WriteLine("Numero de cobranças cadastradas é igual a 0! ");
            }
            else
            {
                foreach (var item in minhaListaCobranca.listarCobrancas())
                { 
                    Console.WriteLine(item.getDescription());
                }
            }
        }
    }
}