using System;

namespace GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Print<int>(5);
            string text = Print<string>("text");
            Program program = Print<Program>(new Program());
        }

        static T Print<T>(T value)
        {
            T value2 = value;
            Console.WriteLine(value);
            return value;
        }
    }
}
