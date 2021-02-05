using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(int).GetType().Name);

            PrintElement(5);

            PrintElement("some string");

            PrintElement(new List<int>());
        }

        static void PrintElement<T>(T element)
        {
            T someElement = element;

            Console.WriteLine(typeof(T).GetType().Name);

            Console.WriteLine($"Generics are cuul: {element}");
        }

    }
}
