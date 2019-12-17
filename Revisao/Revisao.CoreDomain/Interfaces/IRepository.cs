using Revisao.CoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao.CoreDomain.Interfaces
{
    interface IRepository<T> where T: Base
    {
        T Insert(T obj);
        T Update(T obj);
        T GetById(int id);
        List<T> ListAll();
        void Delete(int id);
    }
}
