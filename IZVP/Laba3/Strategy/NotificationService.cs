using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZVP.Laba3.Strategy
{
    internal class NotificationService<T>
    {
        private INotificationStrategy<T> notificationStrategy;

        public NotificationService(INotificationStrategy<T> notificationStrategy)
        {
            this.notificationStrategy = notificationStrategy;
        }

        public void SendNotification(T notification)
        {
            notificationStrategy.Send(notification);
        }
    }
}
