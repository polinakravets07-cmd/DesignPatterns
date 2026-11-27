using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class HomeTheaterFacade
    {
        private Television _television;
        private SoundSystem _soundSystem;
        private MediaPlayer _mediaPlayer;
        public HomeTheaterFacade()
        {
            _television = new Television();
            _soundSystem = new SoundSystem();
            _mediaPlayer = new MediaPlayer();
        }
        public void WatchMovie()
        {
            Console.WriteLine("Підготовка до перегляду фільму:");
            _television.TurnOn();
            _soundSystem.TurnOn();
            _mediaPlayer.Play();
        }
        public void EndMovie()
        {
            Console.WriteLine("Завершення перегляду фільму:");
            _mediaPlayer.Stop();
            _soundSystem.TurnOff();
            _television.TurnOff();
        }
    }
}
