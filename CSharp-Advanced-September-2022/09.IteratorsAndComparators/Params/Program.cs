using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pyrviqt {1} vtoriqt {0} ", "1","2");
            PrintElements(5, "first", "second", "third", "1","2");

            Print(5, "", DateTime.Now);
        }

        public static void PrintElements(int number, params string[] elements)
        {
            Console.WriteLine(string.Join(",", elements));
        }

        public static void Print(params object[] elements)
        {
            DateTime date = (DateTime)elements[2];
            Console.WriteLine(date.AddDays(5));
        }
    }
}
