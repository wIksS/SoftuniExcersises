using System;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(1, 10);
            PrintNumbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
        }

    }
}
