using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba2.Decorator
{
    internal class SignedEmailNotification : EmailNotification
    {
        private readonly EmailNotification emailNotification;

        public SignedEmailNotification(EmailNotification emailNotification)
        {
            this.emailNotification = emailNotification;
        }

        public override void Send(string message)
        {
            Console.WriteLine("Signing message...");
            emailNotification.Send(message);
        }
    }
}
