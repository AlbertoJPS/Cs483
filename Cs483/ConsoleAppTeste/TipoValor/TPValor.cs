using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeste.TipoValor
{
    class TPValor
    {
        public void Executar()
        {
            int numero1 = 710000000;
            short numero2 = (short)numero1;
            long numero3 = numero1;
            long numero4 = numero2;

            Console.WriteLine(numero4);
        } 
    }
}
