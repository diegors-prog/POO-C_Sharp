using System;
using Aula06_camadasElistas.Domain;
using Aula06_camadasElistas.Controllers;

namespace Aula06_camadasElistas
{
    class Program
    {
        static void Main(string[] args)
        {
           ClientCobrancaController inicio = new ClientCobrancaController();
           inicio.menu();

        }
    }
}
