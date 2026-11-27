namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade homeTheater = new HomeTheaterFacade();
            homeTheater.WatchMovie();
            Console.WriteLine();
            homeTheater.EndMovie();
        }
    }
}
