using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Laba3
{
    internal class ArrayQueue<T> : IQueue<T>
    {
        private int pos = -1;
        private T[] array;

        public ArrayQueue(int size)
        {
            array = new T[size];
        }

        public void Enqueue(T element)
        {
            pos++;
            array[pos] = element;
        }

        public T Dequeue()
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
