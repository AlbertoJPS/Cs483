using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Tipos.TipoValor
{
    class Outros
    {
        public void Executar()
        {
            //bool validacao = true;
            //bool resultado = (10 % 2 == 1);
            //if(resultado)
            //{
            //    Console.WriteLine("número ímpar");
            //}
            //Console.WriteLine(resultado);

            //decimal = Convert.ToDecimal(("1000,00").Replace(',','.'));
            ////=======Var

            //var booleana = true;


            //Console.WriteLine(booleana.GetType());

            //const int Dom = 1;
            //const int Seg = 2;
            //const int Ter = 3;
            //const int Qua = 4;
            //const int Qui = 5;
            //const int Sex = 6;
            //const int Sab = 7;

            DiasDaSemana dias = (DiasDaSemana)3;
            Console.WriteLine(dias);

        }
        [Flags]
        enum DiasDaSemana
        {
            Dom=1,
            Seg=2,
            Ter=4,
            Qua=8,
            Qui=16,
            Sex=32,
            Sab=64
        }

    }
}
