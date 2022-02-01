using System;

namespace ForCycleInFP
{
    class Program
    {
        static void Main(string[] args)
        {
            CallNTimes(PrintHello,5);
            PrintHello();
        }

        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        static void CallNTimes(Action function, int times)
        {
            if (times == 0)
            {
                return;
            }
            CallNTimes(function, times - 1);
            function();
        }
    }
}
