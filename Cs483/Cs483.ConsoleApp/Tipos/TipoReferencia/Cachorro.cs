using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Tipos.TipoReferencia
{
    public class Cachorro : IAnimal
    {
        public void Comer(int quantidade)
        {
            Console.WriteLine($"O Cachorro está comendo {quantidade} de sapato");
        }

        public void Mover(int velocidade)
        {
            Console.WriteLine($"O Cachorro está correndo a {velocidade} de m/s");
        }
    }
}
