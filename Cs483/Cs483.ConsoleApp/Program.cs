using Cs483.ConsoleApp.Tipos.TipoReferencia;
using Cs483.ConsoleApp.Tipos.TipoValor;
using Cs483.Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Inteiros inteiros = new Inteiros();
            //Flutuante flutuantes = new Flutuante();
            //Outros outros = new Outros();
            //Estruturas estruturas = new Estruturas();
            //Classes classes = new Classes();
            //Delegados delegados = new Delegados();
            //inteiros.Executar();
            //flutuantes.Executar();
            //outros.Executar();
            //estruturas.Executar();
            //classes.Executar();
            //delegados.Executar();


            PessoaRepositorio pRepos = new PessoaRepositorio();
            //var lista = pRepos.ListarTodos();
            //foreach (Dados.Pessoa p in lista)
            //{
            //    Console.WriteLine($"{p.Id}-{p.Nome}-{p.Sobrenome}-{p.Idade}");
            //}
            Console.Write("Digite o id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var p = pRepos.BsucarPorId(id);
            Console.WriteLine($"{p.Id}-{p.Nome}-{p.Sobrenome}-{p.Idade}");

            Console.Read();
        }
    }
}
