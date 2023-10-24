using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba2.Decorator
{
    internal class SimpleEmailNotification : EmailNotification
    {
        public override void Send(string message)
        {
            Console.WriteLine("Sending message...");
        }
    }
}
