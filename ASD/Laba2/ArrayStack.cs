using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Laba2
{
    internal class ArrayStack<T> : IStack<T>, IEnumerable<T>
    {
        private int pos = -1;
        private T[] array;

        public ArrayStack(int size)
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = pos; i >= 0; i--)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
