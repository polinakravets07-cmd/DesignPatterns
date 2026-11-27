using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class SmsNotificationCreator : NotificationCreator
    {
        public override Notification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}
