using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //PrintNumsBetween();
            //PrintNumsBetween(95);
            PrintNumsBetween(end:5);
        }

        static void PrintNumsBetween(int start = 0, int end = 100)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
