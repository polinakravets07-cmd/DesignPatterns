using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class MediaPlayer
    {
        public void Play()
        {
            Console.WriteLine("Відтворення фільму розпочато.");
        }
        public void Stop()
        {
            Console.WriteLine("Відтворення фільму зупинено.");
        }
    }
}
