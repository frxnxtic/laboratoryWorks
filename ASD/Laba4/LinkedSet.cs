using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Laba4
{
    internal class LinkedSet<T> : ISet<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public LinkedSet()
        {
            head = null;
            tail = null;
        }

        public int Count
        {
            get
            {
                int count = 0;
                Node<T> current = head;

                while (current != null)
                {
                    count++;
                    current = current.next;
                }

                return count;
                }
            }
        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item, null, null);
                tail = head;
            }
            else
            {
                tail.next = new Node<T>(item, null, tail);
                tail = tail.next;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
        }

        public bool Contains(T item)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.data.Equals(item))
                {
                    return true;
                }

                current = current.next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> current = head;

            while (current != null)
            {
                array[arrayIndex] = current.data;
                arrayIndex++;
                current = current.next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;

            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }

        public bool Remove(T item)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.data.Equals(item))
                {
                    if (current.prev != null)
                    {
                        current.prev.next = current.next;
                    }
                    else
                    {
                        head = current.next;
                    }

                    if (current.next != null)
                    {
                        current.next.prev = current.prev;
                    }
                    else
                    {
                        tail = current.prev;
                    }

                    return true;
                }

                current = current.next;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node<T> current = head;

            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }
    }
}
