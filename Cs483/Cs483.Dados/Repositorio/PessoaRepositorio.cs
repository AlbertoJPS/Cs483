using Cs483.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.Dados.Repositorio
{
    public class PessoaRepositorio
    {
        public List<Pessoa> ListarTodos()
        {
            List<Pessoa> lista = new List<Pessoa>();
            using(DadosContexto contexto = new DadosContexto())
            {
            lista = contexto.Pessoa.ToList();
            }
            return lista;
        }
        public Pessoa BsucarPorId(int id)
        {
            Pessoa p = new Pessoa();
            using (DadosContexto contexto = new DadosContexto())
            {
                p = contexto.Pessoa.Find(id);
            }
            return p;
        }
    }
}
