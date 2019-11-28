using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Tipos.TipoValor
{
    class Flutuante
    {


        public void Executar()
        {
            decimal salario = 1000.49m;
            decimal aumento = 100.51m;
            decimal salarioComAumento = 1101.00m;

            Console.WriteLine($" {salario} + {aumento} = {salarioComAumento}");
            Console.WriteLine($" {salarioComAumento}");
            Console.WriteLine( (salario = aumento) == salarioComAumento );



            ////float numeroComVirgula = 10.6f;
            //double numeroMaiorComVirgula = 1000.85;
            //decimal salarioRafael = 10000.00000m;


            //Console.WriteLine($"{numeroComVirgula} - NumeroComVirgula");
            //Console.WriteLine($"{numeroMaiorComVirgula} - NumeroMaiorComVirgula");
            //Console.WriteLine($"{salarioRafael} - SalarioRafael");
            //Console.WriteLine("----------------");

            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(Single.MaxValue);
            //Console.WriteLine("----------------");

            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(Double.MaxValue);
            //Console.WriteLine("----------------");

            //Console.WriteLine(decimal.MinValue);
            //Console.WriteLine(Decimal.MaxValue);
            //Console.WriteLine("----------------");


        }
    }
}
