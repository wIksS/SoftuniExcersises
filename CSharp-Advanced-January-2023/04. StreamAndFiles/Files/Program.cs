using System;
using System.IO;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("../../../input.txt");

            Console.WriteLine(input);

            string[] lines = new string[] { "1", "2", "3" };
            File.AppendAllText("../../../output.txt", "Na edin red!!!");
            File.WriteAllLines("../../../output2.txt", lines);
        }
    }
}
