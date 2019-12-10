using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeste.Classes
{
    class Animal
    {
        public string Nome { get; set; }
        public virtual void Comer()
        {
            Console.WriteLine("Animal Comendo");
        }
        public void Correr()
        {
            Console.WriteLine("Animal Correndo");
        }
        public void Beber()
        {
            Console.WriteLine("Animal Bebendo");
        }
    }
}
