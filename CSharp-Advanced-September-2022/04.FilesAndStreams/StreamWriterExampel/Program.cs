using System;
using System.IO;

namespace StreamWriterExampel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            {
                writer.Write("Kak taka??");
            }
            Console.WriteLine("Kak taka syshtoto?");
            Console.ReadLine();
        }
    }
}
