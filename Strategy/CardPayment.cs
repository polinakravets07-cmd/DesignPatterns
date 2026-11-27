using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class CardPayment : PaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата банківською карткою: {amount} грн");
        }
    }
}
