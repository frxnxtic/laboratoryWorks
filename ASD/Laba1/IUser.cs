using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal interface IUser<T>
    {
        public void AddHead(T item);
        public void AddAfter(T search, T item);
    }
}
