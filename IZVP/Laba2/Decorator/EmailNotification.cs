using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba2.Decorator
{
    internal abstract class EmailNotification
    {
        public abstract void Send(string message);
    }
}
