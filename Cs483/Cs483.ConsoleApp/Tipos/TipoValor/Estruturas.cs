using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Tipos.TipoValor
{
    class Estruturas
    {
        public void Executar()
        {
            Cerveja cerveja1; 
               // = new Cerveja();
            cerveja1.marca = "Brahma";
            cerveja1.volume = 300;
            Cerveja cerveja2 = cerveja1;

            Console.WriteLine(cerveja1.marca);
            Console.WriteLine(cerveja2.marca);
            cerveja2.marca = "Skol";
            Console.WriteLine(cerveja1.marca);
            Console.WriteLine(cerveja2.marca);

            cerveja1.NomeCompleto();
        }
    }
    struct Cerveja
    {
        public string marca;
        public int volume;

        public void NomeCompleto()
        {
            Console.WriteLine($"{marca}+{volume}");

        }

    }
}
