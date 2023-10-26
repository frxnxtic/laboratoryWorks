using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Laba4
{
    internal class ArraySet<T> : ISet<T>
    {
        private T[] array;
        private int index;

        public ArraySet(int size)
        {
            array = new T[size];
            index = 0;
        }

        public int Count => array.Length;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (index == array.Length)
            {
                throw new InvalidOperationException("Set is full");
            }

            if (array.Contains(item))
            {
                throw new InvalidOperationException("Set already contains this item");
            }

            array[index] = item;
            index++;
        }

        public void Clear()
        {
            array = new T[array.Length];
            index = 0;
        }

        public bool Contains(T item)
        {
            return array.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            array.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return array.Take(index).GetEnumerator();
        }

        public bool Remove(T item)
        {
            if (!array.Contains(item))
            {
                return false;
            }

            var newArray = new T[array.Length];
            var newIndex = 0;
            for (int i = 0; i < index; i++)
            {
                if (!array[i].Equals(item))
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }

            array = newArray;
            index = newIndex;
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.Take(index).GetEnumerator();
        }
    }
}
