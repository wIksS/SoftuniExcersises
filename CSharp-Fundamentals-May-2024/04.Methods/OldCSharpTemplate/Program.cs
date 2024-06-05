using System;

namespace OldCSharpTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int name = 5;

            PrintName("Gosho");
        }
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, my name is {name}");
        }
    }
}
