using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using Revisao.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Repository.Repositories
{
    public class BaseRepository : IRepository
    {
        public void Insert(object obj)
        {
            using (RevisaoContext context = new RevisaoContext())
            {
                context.PessoaFisica.Add(obj as PessoaFisica);
            }
        }
        public void Update(object obj)
        {
            using (RevisaoContext context = new RevisaoContext())
            {
                context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void Delete()
        {
            using (RevisaoContext context = new RevisaoContext())
            {
                context.
            }
        }
        public List<object> ListAll()
        {
            List<object> lista;
            using (RevisaoContext context = new RevisaoContext())
            {
                lista = context.PessoaFisica.ToList() as List<object>;
            }
            return List;
        }
        public object GetById(int Id)
        {
            using (RevisaoContext context = new RevisaoContext())
            {
                context.
            }
        }
    }
}
