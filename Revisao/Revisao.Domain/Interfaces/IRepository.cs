using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface IRepository
    {
        
        void Insert(object obj);
        void Update();
        void Delete();
        List<object> ListAll();
        object GetById(int Id);

    }
}
