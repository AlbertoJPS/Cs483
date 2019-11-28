using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Tipos.TipoReferencia
{
    class Passaro : IAnimal
    {
        public void Comer(int quantidade)
        {
            Console.WriteLine($"O Pássaro está comendo {quantidade} de sementes de girassol");
        }

        public void Mover(int velocidade)
        {
            Console.WriteLine($"O Pássaro está voando a {velocidade} de m/s");
        }
    }
}
