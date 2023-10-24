using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Laba2
{
    internal class LinkedSet<T> : ISet<T>
    {
        private Node<T>? head;

        public LinkedSet()
        {
            head = null;
        }

        public void Push(T element)
        {
            Node<T> node = new Node<T>(element, head);
            head = node;
        }

        public T Pop()
        {
            if (head == null)
            {
                return default;
            }

            T element = head.data;
            head = head.next;
            return element;
        }

        public T Peek()
        {
            if (head == null)
            {
                return default;
            }

            return head.data;
        }
    }
}
