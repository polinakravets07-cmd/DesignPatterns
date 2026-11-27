using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class SmsNotification : Notification
    {
        public void Send(string message)
        {
            Console.WriteLine("Відправлення SMS-повідомлення:");
            Console.WriteLine(message);
        }
    }
}
