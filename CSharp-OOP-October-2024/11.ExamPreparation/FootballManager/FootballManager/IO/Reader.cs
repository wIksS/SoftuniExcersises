using FootballManager.IO.Contracts;

namespace FootballManager.IO
{
    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
