using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface IRepository2<T> where T : Base
    {

        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        List<T> ListAll();
        T GetById(int Id);

    }
}