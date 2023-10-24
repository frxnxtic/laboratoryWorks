using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba2.Decorator
{
    internal class TrackedEmailNotification : EmailNotification
    {
        private readonly EmailNotification emailNotification;

        public TrackedEmailNotification(EmailNotification emailNotification)
        {
            this.emailNotification = emailNotification;
        }

        public override void Send(string message)
        {
            Console.WriteLine("Tracking message...");
            emailNotification.Send(message);
        }
    }
}
