using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeste.Classes
{
    class Mamifero : Animal
    {
        //Para haver override é necessario q na classe mãe seja descrito como virtual, para que seja substituido
        public override void Comer()
        {
            Console.WriteLine("Mamífero está Comendo");
        }
        public void Mamar()
        {
            Console.WriteLine("Mamífero está Mamando");
        }

    }
}
