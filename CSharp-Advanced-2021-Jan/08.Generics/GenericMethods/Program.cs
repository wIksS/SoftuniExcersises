using System;

namespace GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string, int> x;
            PrintKeyValuePair(5, "Pesho");
        }

        static void PrintKeyValuePair<TKey, TValue>(TKey key, TValue value)
        {
            Console.WriteLine($"Key: {key} Value : {value}");
        }
    }
}
