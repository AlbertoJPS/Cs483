using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Tipos.TipoReferencia
{
    internal class Classes
    {
        //private int idade = 10;
        //private string nome = "Alberto";

        //public int GetIdade()
        //{
        //    return idade;
        //}
        //public int SetIdade(int idade)
        //{
        //    this.idade = idade;
        //}

        #region Propriedades
        public int Idade { get; set; }
        public string Nome { get; set; }
        #endregion

        #region Metodos
        public void Executar()
        {
            Cerveja cerveja1 = new Cerveja()
            {
            //{ marca = "sdfsdf", volume=123};
                marca = "Brahma",
                volume = 300
            };

            Cerveja cerveja2 = cerveja1;

            Console.WriteLine(cerveja1.marca);
            Console.WriteLine(cerveja2.marca);
            cerveja2.marca = "Skol";
            Console.WriteLine(cerveja1.marca);
            Console.WriteLine(cerveja2.marca);

            cerveja1.NomeCompleto();
        }
        #endregion
    }
    class Cerveja
    {
        public string marca;
        public int volume;
        public Cerveja()
        {

        }

        public Cerveja(string marca, int volume)
        {
            this.marca = marca;
            this.volume = volume;
        }

        public void NomeCompleto()
        {
            Console.WriteLine($"{marca}+{volume}");
        }
    }
}
