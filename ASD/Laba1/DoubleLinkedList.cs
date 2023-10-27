using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class DoubleLinkedList<T> : IUser<T>, IEnumerator<T>, IEnumerable<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        public Node<T>? iterator;

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
            iterator = null;
        }

        public void AddAfter(T search, T item)
        {
            Node<T>? node = head;
            while (node != null)
            {
                if (node.info.Equals(search))
                {
                    Node<T> newNode = new Node<T>(item);
                    newNode.next = node.next;
                    newNode.prev = node;
                    node.next = newNode;
                    if (newNode.next != null)
                    {
                        newNode.next.prev = newNode;
                    }
                    else
                    {
                        tail = newNode;
                    }
                    return;
                }
                node = node.next;
            }

        }

        public void AddHead(T item)
        {
            Node<T> node = new Node<T>(item);

            if (head == null)
            {
                head = node;
                tail = node;
                iterator = node;
            }
            else
            {
                node.next = head;
                head.prev = node;
                head = node;
            }
        }



        public T Current => iterator!.info;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            iterator = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        

        public bool MoveNext()
        {
            if (iterator != null)
            {
                iterator = iterator.next;
                if (iterator == null)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public void Reset()
        {
            iterator = head;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
