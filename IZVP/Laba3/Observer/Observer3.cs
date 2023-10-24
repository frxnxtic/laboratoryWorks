using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba3.Observer
{
    internal class Observer3 : IObserver
    {
        public void update()
        {
            Console.WriteLine("Observer3: update");
        }
    }
}
