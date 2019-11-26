using Cs483.ConsoleApp.Tipos.TipoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Inteiros inteiros = new Inteiros();
            Flutuante flutuantes = new Flutuante();
            //inteiros.Executar();
            flutuantes.Executar();

            Console.Read();
        }
    }
}
