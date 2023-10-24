﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Laba3
{
    internal interface IQueue<T>
    {
        public void Enqueue(T element);
        public T Dequeue();
        public T Peek();
    }
}
