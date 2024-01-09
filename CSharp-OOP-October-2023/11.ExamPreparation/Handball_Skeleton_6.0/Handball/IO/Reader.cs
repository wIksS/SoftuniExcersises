namespace Handball.IO
{
    using Handball.IO.Contracts;
    using System;
    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
