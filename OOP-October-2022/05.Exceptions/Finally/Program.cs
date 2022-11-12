using System;

namespace Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int.Parse(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.WriteLine("After finally");
        }
    }
}
