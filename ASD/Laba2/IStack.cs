using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Laba2
{
    internal interface IStack<T>
    {
        public void Push(T element);
        public T Pop();
        public T Peek();
    }
}
