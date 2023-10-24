using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba3.Strategy
{
    internal interface INotificationStrategy<T>
    {
        void Send(T notification);
    }
}
