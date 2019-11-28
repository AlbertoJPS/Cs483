using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Tipos.TipoValor
{
    class Inteiros
    {
        public void Executar()
        {






            byte idade = 25;
            byte numeroS = 222;
            long numeroGrande = 1_000_000;



            Console.WriteLine($"{idade} - Idade");
            Console.WriteLine($"{numeroS} - NumeroS");
            Console.WriteLine($"{numeroGrande} - NumeroGrande");
            Console.WriteLine("----------------");

            // valor / c# / .net
            Console.WriteLine($"{byte.MinValue} - byte.Min");
            Console.WriteLine($"{Byte.MaxValue} - Byte.Max");
            Console.WriteLine("----------------");

            // Sinal U/S
            Console.WriteLine($"{short.MinValue} - short.Min");
            Console.WriteLine($"{UInt16.MaxValue} - UInt16.Max");
            Console.WriteLine("----------------");

            Console.WriteLine($"{(short.MinValue)} - short.Min");
            Console.WriteLine($"{Int16.MaxValue} - Int16.Max");
            Console.WriteLine("----------------");

            Console.WriteLine($"{int.MinValue} - int.Min");
            Console.WriteLine($"{Int32.MaxValue} - Int32.Max");
            Console.WriteLine("----------------");

            Console.WriteLine($"{int.MinValue} - int.Min");
            Console.WriteLine($"{Int64.MaxValue} - Int64.Max");
            Console.WriteLine("----------------");

            Console.WriteLine(" ");

            char letra = 'A';
            Console.WriteLine($"A Letra '{letra}' em inteiro é: {(int)letra}");
            Console.WriteLine("----------------");




        }

    }
}
