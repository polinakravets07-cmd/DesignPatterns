using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("Телевізор увімкнено.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Телевізор вимкнено.");
        }
    }
}
