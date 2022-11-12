using System;

namespace TryCatchAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch
            {
                Console.WriteLine("Catching all!!");
            }
        }
    }
}
