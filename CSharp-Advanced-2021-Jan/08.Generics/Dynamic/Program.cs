using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(5);
            Print("string");
        }

        public static dynamic Print(dynamic element)
        {
            Console.WriteLine(element);

            element = 55;

            Console.WriteLine(element);

            return 5;
        }
    }
}
