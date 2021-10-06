using System;

namespace OptionalParams
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(5, 20);
            Console.WriteLine("\n\nNew\n");
            PrintNumbers(5); 
            Console.WriteLine("\n\nNew\n");
            PrintNumbers();
            Console.WriteLine("\n\nNew\n");
            PrintNumbers(end: 50, start: 20);
        }

        static void PrintNumbers(int start = 0, int end = 100)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
        }

    }
}
