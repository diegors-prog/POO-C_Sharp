using System;

namespace Semi_controleCobrancas
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleClienteCobranca controle = new ControleClienteCobranca();

            string  operador ;

            do{
                Console.WriteLine("\nDigite 1 para add um cliente: ");
                Console.WriteLine("Digite 2 para apresentar o numero de cliente cadastrados: ");
                Console.WriteLine("Digite 3 para listar os clientes: " );
                Console.WriteLine("Digite 4 para editar um cliente: ");
                Console.WriteLine("Digite 5 para excluir um cliente: ");
                Console.WriteLine("Digite 6 para add uma cobrança: ");
                Console.WriteLine("Digite 7 para editar uma cobrança: ");
                Console.WriteLine("Digite 8 para remover uma cobrança: ");
                Console.WriteLine("Digite 0 para encerrar: \n");

                string  resposta  =  Console.ReadLine ();

                operador = resposta;

                while(operador != "1" && operador != "2" && operador != "3" && operador != "4" && operador != "5" && operador != "6" && operador != "0")
                {   
                    Console.WriteLine("Operação invalida digite novamente");
                    resposta = Console.ReadLine();
                    operador = resposta;
                }
                switch (operador)
                {
                    case "1" :
                        controle.criarCliente();
                        break;
                    case "2" :
                        controle.printLista();
                        break;
                    case "3" :
                        controle.apresentarListaCliente();
                        break;
                    case "4" :
                        controle.apresentarClienteEditado();
                        break;
                    case "5" :
                        controle.apresentarClienteRemovido();
                    break;
                    case "6" :
                        controle.criarCobranca();
                    break;
                }

            }while(operador != "0");
            
            Console.WriteLine("Programa encerrado!");
        }
    }
}
