using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba3.Observer
{
    internal class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.update();
            }
        }
    }
}
