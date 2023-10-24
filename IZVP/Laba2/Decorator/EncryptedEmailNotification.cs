using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba2.Decorator
{
    internal class EncryptedEmailNotification : EmailNotification
    {
        private readonly EmailNotification emailNotification;

        public EncryptedEmailNotification(EmailNotification emailNotification)
        {
            this.emailNotification = emailNotification;
        }

        public override void Send(string message)
        {
            Console.WriteLine("Encrypting message...");
            emailNotification.Send(message);
        }
    }
}
