using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using Revisao.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Repository.Repositories
{
    public class BaseRepository<T> : IRepository2<T> where T : Base
    {
        public void Insert(T obj)
        {
            using (RevisaoContext context = new RevisaoContext())
            {
                context.Set<T>().Add(obj);
                context.SaveChanges();
            }
        }
        public void Update(T obj)
        {
            using (RevisaoContext context = new RevisaoContext())
            {
                context.Entry(obj).State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void Delete(int id)
        {
            using (RevisaoContext context = new RevisaoContext())
            {
                T obj = GetById(id);
                context.Entry(obj).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<T> ListAll()
        {
            List<T> lista = new List<T>();
            using (RevisaoContext context = new RevisaoContext())
            {
                lista = context.Set<T>().ToList();
            }
            return lista;
        }
        public T GetById(int id)
        {
            T obj;
            using (RevisaoContext context = new RevisaoContext())
            {
                obj = context.Set<T>().Find(id);
            }
            return obj;
        }
    }
}
