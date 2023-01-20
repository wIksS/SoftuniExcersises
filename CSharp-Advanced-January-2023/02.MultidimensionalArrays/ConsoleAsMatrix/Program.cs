using System;

namespace ConsoleAsMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.WindowHeight);
            Console.WriteLine(Console.WindowWidth);

            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/2);
            Console.WriteLine("@");
        }
    }
}
