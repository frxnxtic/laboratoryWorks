using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Laba2
{
    internal class ArraySet<T> : ISet<T>
    {
        private int pos = -1;
        private T[] array;

        public ArraySet(int size)
        {
            array = new T[size];
        }

        public void Push(T element)
        {
            pos++;
            array[pos] = element;
        }

        public T Pop()
        {
            if (pos == -1)
            {
                return default;
            }

            T element = array[pos];
            pos--;
            return element;
        }

        public T Peek()
        {
            if (pos == -1)
            {
                return default;
            }

            return array[pos];
        }
    }
}
