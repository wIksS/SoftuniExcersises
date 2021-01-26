using System;

namespace ActionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = Print;

            printer("Opaaa");
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
