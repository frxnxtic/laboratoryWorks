using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class ArrayList<T> : IUser<T>, ICollection<T>, IEnumerator<T>, IEnumerable<T>
    {
        private T[] array;
        private int index;
        private int iterator;

        public ArrayList(int size)
        {
            array = new T[size];
            index = 0;
            iterator = 0;
        }

        public int Count => index;

        public bool IsReadOnly => false;

        public T Current => array[iterator];

        object IEnumerator.Current => Current;

        public void Add(T item)
        {
            if (index == array.Length)
            {
                T[] temp = new T[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];
                }
                array = temp;
            }
            array[index] = item;
            index++;
        }

        public void AddAfter(T search, T item)
        {
            int pos = IndexOf(search);
            if (pos == -1)
            {
                AddHead(item);
            }
            else
            {
                if (index == array.Length)
                {
                    T[] temp = new T[array.Length * 2];
                    for (int i = 0; i < array.Length; i++)
                    {
                        temp[i] = array[i];
                    }
                    array = temp;
                }
                for (int i = index; i > pos; i--)
                {
                    array[i] = array[i - 1];
                }
                array[pos + 1] = item;
                index++;    
            }

        }

        public int IndexOf(T? item)
        {
            for(int i = 0; i < index; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void AddHead(T item)
        {
            if (index == array.Length)
            {
                T[] temp = new T[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];
                }
                array = temp;
            }
            for (int i = index; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = item;
            index++;
        }

        public void Clear()
        {
            array = new T[array.Length];
            index = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < index; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for(int i = 0; i < index; i++)
            {
                array[arrayIndex + i] = this.array[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (iterator < index - 1)
            {
                iterator++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public bool Remove(T item)
        {
            int pos = IndexOf(item);
            if (pos == -1)
            {
                return false;
            }
            else
            {
                for (int i = pos; i < index - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                index--;
                return true;
            }
        }

        public void Reset()
        {
            iterator = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            //does not need to be implemented
        }


    }
}

