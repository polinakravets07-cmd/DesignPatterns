using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal abstract class NotificationCreator
    {
        public abstract Notification CreateNotification();
    }
}
