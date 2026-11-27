using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class SoundSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Аудіосистему увімкнено.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Аудіосистему вимкнено.");
        }
    }
}
