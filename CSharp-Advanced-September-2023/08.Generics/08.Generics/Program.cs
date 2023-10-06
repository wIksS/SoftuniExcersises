using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> dict;
            List<int> genericList = new List<int>();

            PrintSomething<int>(5);

            PrintSomething<string>("helo");

            PrintSomething<List<int>>(new List<int>() { 5 });
        }

        static void PrintSomething<T>(T input)
        {
            T value;
            Console.WriteLine(typeof(T).Name);
            Console.WriteLine($"Generic print something: {input}");
        }
    }
}
