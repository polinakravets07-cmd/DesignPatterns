using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class EmailNotification : Notification
    {
        public void Send(string message)
        {
            Console.WriteLine("Відправлення Email-повідомлення:");
            Console.WriteLine(message);
        }
    }
}
