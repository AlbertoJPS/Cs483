using Cs483.ConsoleApp.Tipos.TipoReferencia;
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
            Outros outros = new Outros();
            Estruturas estruturas = new Estruturas();
            Classes classes = new Classes();
            Delegados delegados = new Delegados();
            //inteiros.Executar();
            //flutuantes.Executar();
            //outros.Executar();
            //estruturas.Executar();
            //classes.Executar();
            delegados.Executar();

            Console.Read();
        }
    }
}
