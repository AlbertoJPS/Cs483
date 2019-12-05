using Cs483.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.Dados.Repositorio
{
    public class TipoRepositorio
    {
        public List<ClasseTipo> ListarTodos()
        {
            List<ClasseTipo> lista = new List<ClasseTipo>();
            using (DadosContexto contexto = new DadosContexto())
            {
                lista = contexto.ClasseTipos.ToList();
            }
            return lista;
        }
        public ClasseTipo BuscarPorId(int id)
        {
            ClasseTipo p = new ClasseTipo();
            using (DadosContexto contexto = new DadosContexto())
            {
                p = contexto.ClasseTipos.Find(id);
            }
            return p;
        }
        public void Inserir(ClasseTipo tipo)
        {
            using (DadosContexto contexto = new DadosContexto())
            {
                contexto.ClasseTipos.Add(tipo);
                contexto.SaveChanges();
            }
        }
        public void Editar(ClasseTipo tipo)
        {
            using (DadosContexto contexto = new DadosContexto())
            {
                ClasseTipo tipoDb = BuscarPorId(tipo.Id);
                if(tipoDb != null)
                {
                    contexto.Set<ClasseTipo>(tipoDb).State = ConsoleModifiers;
                    contexto.SaveChanges();
                }
            }
        }
    }
}
