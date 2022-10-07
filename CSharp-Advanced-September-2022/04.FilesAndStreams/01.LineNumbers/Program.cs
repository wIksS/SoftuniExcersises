using System;
using System.IO;

namespace _01.LineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../scoreboard.txt"))
            {
                int lineNumber = 1;
                while (!reader.EndOfStream)
                {
                    Console.WriteLine($"{lineNumber++}. {reader.ReadLine()}");
                }
            }
        }
    }
}
