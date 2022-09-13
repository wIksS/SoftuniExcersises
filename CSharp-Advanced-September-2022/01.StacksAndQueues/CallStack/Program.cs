using System;

namespace CallStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running is the best");

            Run();

            Sleep();

            Console.WriteLine("Never running again");
        }

        private static void Sleep()
        {
            Console.WriteLine("Sleeping");
        }

        private static void Run()
        {
            Console.WriteLine("Starting run");

            DrinkWater();
            Faint();
        }

        private static void Faint()
        {
            Console.WriteLine("Running sux");
        }

        private static void DrinkWater()
        {
            Console.WriteLine("Piq vodi4ka");
        }
    }
}
