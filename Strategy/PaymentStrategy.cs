using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal interface PaymentStrategy
    {
        void Pay(decimal amount);
    }
}
