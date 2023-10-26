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



        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        

        public bool MoveNext()
        {
            return true;
        }

        public void Reset()
        {

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
