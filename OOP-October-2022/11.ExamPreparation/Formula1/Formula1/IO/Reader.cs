namespace Formula1.IO
{
    using System;
    using Formula1.IO.Contracts;
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
