using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba2.Facade
{
    internal interface IDatabase<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        T Get(int id);
        List<T> GetAll();

    }
}
