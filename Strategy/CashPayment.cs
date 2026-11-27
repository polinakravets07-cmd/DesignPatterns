using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class CashPayment : PaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата готівкою: {amount} грн");
        }
    }
}
