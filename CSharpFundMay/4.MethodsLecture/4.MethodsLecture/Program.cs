using System;

namespace _4.MethodsLecture
{
    class Program
    {
        static void Hello()
        {
            Console.WriteLine("In hello");
            PrintEvenNumbersTo100();
            Console.WriteLine("exiting hello");
        }

        static void Main(string[] args)
        {
            PrintEvenNumbersTo100();
            Hello();
            Console.WriteLine("exiting Main");

        }

        static void PrintEvenNumbersTo100()
        {
            Console.WriteLine("Print 1 to 100");
            return;

            Console.WriteLine("Exiting");
        }
    }
}
