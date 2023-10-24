using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Laba4
{
    internal class Node<T>
    {
        public Node<T> next;
        public Node<T> prev;
        public T data;

        public Node(T data, Node<T> next, Node<T> prev)
        {
            this.data = data;
            this.next = next;
            this.prev = prev;
        }
    }
}
