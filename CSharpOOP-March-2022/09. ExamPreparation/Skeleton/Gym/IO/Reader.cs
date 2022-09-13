namespace Gym.IO
{
    using Gym.IO.Contracts;
    using System;
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
