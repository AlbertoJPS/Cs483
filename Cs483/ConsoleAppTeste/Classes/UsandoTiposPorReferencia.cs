using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeste.Classes
{
    class UsandoTiposPorReferencia
    {
        public void Conversoes()
        {
            Animal animal = new Animal();
            var animal1 = new Animal();
            object animal2 = new Animal();
            dynamic animal3 = new Animal();
            //=== Acessando metodo inexistente
            animal3.Pulando();

            //=== Conversão explicita - Cast
            Animal a = (Animal)animal2;
            a.Correr();
            animal1.Comer();

            Mamifero cachorro = new Mamifero();
            cachorro.Mamar();

            //=== conversão implicita (como mamifero herda de animal ele n necessita de cast)
            Animal gato = new Mamifero();
            Console.WriteLine(gato.GetType());

            //=== conversão implicita (como mamifero herda de animal ele n necessita de cast)
            animal = cachorro;

            //=== Conversão explicita - Cast
            cachorro = (Mamifero)animal;

        }
        public void Copias()
        {
            Animal animal = new Animal();
            var animal1 = new Animal();

            animal1.Nome = "Tamanduá";
            animal = animal1;
            Console.WriteLine(animal.Nome);
            Console.WriteLine(animal1.Nome);

            animal.Nome = "Cachorro";

            Console.WriteLine(animal.Nome);
            Console.WriteLine(animal1.Nome);
        }
        public void PrintandoAnimal(object objeto)
        {
            // no As quando dá um erro de conversão (recebe null) ele ainda dá continuidade no codigo,
            // e com cast ele dá quebra de código assim que ele tentar fazer uma conversão com resultado null

            var animal1 = objeto as Animal;

            // if(objeto.GetType() == typeof(Animal)) pode ser substituído por:
            if (animal1 is null)
            {
               
                Console.WriteLine("Não é animal, animal");
            }

            if (objeto is Animal)
            {
                //Animal animal = (Animal)objeto; pode substituir o cast por:
                Animal animal2 = objeto as Animal;
                animal2.Beber();
                Console.WriteLine("Animal de teta");
            }

            if (objeto is Animal animal3)
            {
                animal3.Correr();
            }
        }
        public void IsEAS()
        {

            Animal animal1 = new Animal();
            Mamifero mamifero1 = new Mamifero();
            Animal animal2 = new Mamifero();

            animal1.Comer();
            mamifero1.Comer();
            animal2.Comer();

            var utr = new UsandoTiposPorReferencia();
            utr.PrintandoAnimal(animal1);
        }
    }
}
