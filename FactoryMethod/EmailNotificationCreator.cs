using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class EmailNotificationCreator : NotificationCreator
    {
        public override Notification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
