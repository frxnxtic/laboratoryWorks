using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class Node<T>
    {
        public T info;
        public Node<T>? next;
        public Node<T>? prev;

        public Node(T info, Node<T> next, Node<T> prev)
        {
            this.info = info;
            this.next = next;
            this.prev = prev;
        }

        public Node(T info)
        {
            this.info = info;
            next = null;
            prev = null;
        }
    }
}
