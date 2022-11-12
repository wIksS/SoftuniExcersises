using System;

namespace Throwing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeoutException timeout = new TimeoutException();

            throw timeout;
        }
    }

    class BadException : Exception
    {

    }
}
