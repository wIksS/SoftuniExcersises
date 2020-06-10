using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriteLine(5);
            ConsoleWriteLine("stringa");
            ConsoleWriteLine("stringa" , 6);

        }
        static string ConsoleWriteLine(string input, int times)
        {
            Console.WriteLine($"string:{input} times:{times}");
            return "5";
        }

        static void ConsoleWriteLine(string input)
        {
            Console.WriteLine($"string:{input}");
        }

        static void ConsoleWriteLine(int input)
        {
            Console.WriteLine($"int:{input}");
        }
    }
}
