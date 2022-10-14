using System;
using System.IO;

namespace GenericMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(int));
            Print<string>("Hey");
            Print<int>(5);

            var result = Print<double>(5 / 2.5);
            var date = Print(DateTime.Now);
            //Print("Zdravei");
        }

        public static T Print<T>(T input)
        {
            Console.WriteLine(typeof(T));
            Console.WriteLine(input);

            return input;
        }
    }
}
