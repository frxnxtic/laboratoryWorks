using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba3.Observer
{
    internal interface ISubject
    {
        void addObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyObservers();
    }
}
