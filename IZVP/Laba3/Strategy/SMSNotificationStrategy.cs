using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba3.Strategy
{
    internal class SMSNotificationStrategy<T> : INotificationStrategy<T>
    {
        public void Send(T notification)
        {
            Console.WriteLine("SMS notification: ");
        }
    }
}
