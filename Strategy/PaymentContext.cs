using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class PaymentContext
    {
        private PaymentStrategy _paymentStrategy;
        public PaymentContext(PaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void SetPaymentStrategy(PaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void Pay(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
