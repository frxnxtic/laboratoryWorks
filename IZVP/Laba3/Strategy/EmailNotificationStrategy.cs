using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba3.Strategy
{
    internal class EmailNotificationStrategy<T> : INotificationStrategy<T>
    {
        public void Send(T notification)
        {
            Console.WriteLine("Email notification: ");
        }
    }
}
