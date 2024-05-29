namespace NauticalCatchChallenge.IO
{
    using System;
    using NauticalCatchChallenge.IO.Contracts;
    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
